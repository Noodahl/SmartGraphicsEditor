using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParseSGD;
using SGDFileConverter.FileConversion.SGD;

namespace SGDFileConverter
{
    public partial class SmartGraphicEditor : Form
    {
        Parse fileParser = new Parse();
        public string dataToParse { get; set; }
        SmartGraphic selectedSmartGraphic = new SmartGraphic();
        eSignalType selectedSignalType = new eSignalType();
        SaveFileDialog saveSGDFile = new SaveFileDialog();

        #region New Signal Name Textbox
        FileOperations fileOps = new FileOperations(string.Format(@"{0}\stringdB.sdb", Directory.GetCurrentDirectory()));
        AutoCompleteStringCollection signalNameAutoComplete;
        List<string> splitSignalDB = new List<string>();
        #endregion

        public SmartGraphicEditor()
        {
            InitializeComponent();
            fileParser.onSmartObjectProcess += FileParser_onSmartObjectProcess;
            smartObjectList_ListView.SelectedIndexChanged += SmartObjectList_ListView_SelectedIndexChanged;
            SOID_Lbl.TextChanged += SOID_Lbl_TextChanged;
            SOName_Label.TextChanged += SOName_Label_TextChanged;
            smartObjectJoin_ListBox.SelectedIndexChanged += SmartObjectJoin_ListBox_SelectedIndexChanged;
            currentName_TextBox.TextChanged += JoinName_TextChanged;
            newSignalName_ComboBox.TextChanged += JoinName_TextChanged;
            saveJoinName_Btn.Click += SaveJoinName_Btn_Click;
            smartObjectList_ListView.MultiSelect = false;
            SetupAutoComplete();
        }

        private void SetupAutoComplete()
        {
            string content = "";
            string[] splitDB;
            newSignalName_ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            newSignalName_ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //Read File
            if (File.Exists(fileOps.fileLocation))
            {                
                if (fileOps.ReadFile())
                {
                    content = fileOps.fileContents;
                    splitDB = content.Split('~');
                    signalNameAutoComplete = new AutoCompleteStringCollection();
                    foreach (var str in splitDB)
                    {
                        splitSignalDB.Add(str);
                        signalNameAutoComplete.Add(str);
                    }
                    splitSignalDB.Sort();
                    newSignalName_ComboBox.AutoCompleteCustomSource = signalNameAutoComplete;
                }
            }
            //If the file does not exists create the file

        }
        private void UpdateJoinEditEnables()
        {
            if (SOID_Lbl.Text.Length > 0 && SOName_Label.Text.Length > 0)
            {
                Analog_Btn.Enabled = true;
                Digital_btn.Enabled = true;
                Serial_Btn.Enabled = true;
            }
        }

        public void UpdateSelectedSmartGraphic(SmartGraphic SelectedSmartGraphic)
        {
            selectedSmartGraphic = new SmartGraphic();
            selectedSmartGraphic.analogInputSignalNames = new List<JoinInfo>();
            selectedSmartGraphic.analogOutputSignalNames = new List<JoinInfo>();
            selectedSmartGraphic.digitalInputSignalNames = new List<JoinInfo>();
            selectedSmartGraphic.digitalOutputSignalNames = new List<JoinInfo>();
            selectedSmartGraphic.serialInputSignalNames = new List<JoinInfo>();
            selectedSmartGraphic.serialOutputSignalNames = new List<JoinInfo>();
            selectedSmartGraphic.onDebugMessageGenerated += SelectedSmartGraphic_onDebugMessageGenerated;

            selectedSmartGraphic = SelectedSmartGraphic;
            selectedSmartGraphic.analogInputSignalNames = SelectedSmartGraphic.analogInputSignalNames;
            selectedSmartGraphic.analogOutputSignalNames = SelectedSmartGraphic.analogOutputSignalNames;
            selectedSmartGraphic.digitalInputSignalNames = SelectedSmartGraphic.digitalInputSignalNames;
            selectedSmartGraphic.digitalOutputSignalNames = SelectedSmartGraphic.digitalOutputSignalNames;
            selectedSmartGraphic.serialInputSignalNames = SelectedSmartGraphic.serialInputSignalNames;
            selectedSmartGraphic.serialOutputSignalNames = SelectedSmartGraphic.serialOutputSignalNames;
        }

        private void SelectedSmartGraphic_onDebugMessageGenerated(object sender, DebugginEventArgs e)
        {
            debugger_listBox.Items.Add(e.message);
        }

        public SmartGraphic FindSmartGraphic(string SmartGraphicName, int SmartGraphicID)
        {
            foreach (var so in fileParser.smartObjectList)
            {
                if (so.objectName == SmartGraphicName && so.iD == SmartGraphicID)
                {
                    //Digital_btn.Text += so.digitalInputSignalNames.Count;
                    //Analog_Btn.Text += so.analogInputSignalNames.Count;
                    //Serial_Btn.Text += so.serialInputSignalNames.Count;
                    return so;
                }
            }
            return null;
        }

        public void StartParsing()
        {
            ProcessSGDFile();
        }

        public bool ProcessSGDFile()
        {
            fileParser.ProcessMetaData(dataToParse);
            return true;
        }

        private void SetJoinList(eSignalType SelectedSignalType)
        {
            smartObjectJoin_ListBox.Items.Clear();
            switch (SelectedSignalType)
            {
                case eSignalType.AnalogInput:
                    foreach (var join in selectedSmartGraphic.analogInputSignalNames)
                    {
                        smartObjectJoin_ListBox.Items.Add(join.currentJoin);
                    }
                    break;
                case eSignalType.AnalogOutput:
                    foreach (var join in selectedSmartGraphic.analogOutputSignalNames)
                    {
                        smartObjectJoin_ListBox.Items.Add(join.currentJoin);
                    }
                    break;
                case eSignalType.DigitalInput:
                    foreach (var join in selectedSmartGraphic.digitalInputSignalNames)
                    {
                        smartObjectJoin_ListBox.Items.Add(join.currentJoin);
                    }
                    break;
                case eSignalType.DigitalOutput:
                    foreach (var join in selectedSmartGraphic.digitalOutputSignalNames)
                    {
                        smartObjectJoin_ListBox.Items.Add(join.currentJoin);
                    }
                    break;
                case eSignalType.SerialInput:
                    foreach (var join in selectedSmartGraphic.serialInputSignalNames)
                    {
                        smartObjectJoin_ListBox.Items.Add(join.currentJoin);
                    }
                    break;
                case eSignalType.SerialOutput:
                    foreach (var join in selectedSmartGraphic.serialOutputSignalNames)
                    {
                        smartObjectJoin_ListBox.Items.Add(join.currentJoin);
                    }
                    break;
                default:
                    break;
            }
        }

        #region UI Updates

        private void SetSaveButtons()
        {
            if (currentName_TextBox.TextLength > 0 && newSignalName_ComboBox.Text.Length > 0 && currentName_TextBox.Text != newSignalName_ComboBox.Text)
            {
                saveJoinName_Btn.Enabled = true;
            }
        }

        private void ClearJoinSelection()
        {
            DeselectJoinType();
            SetAvailableJoinTypesByJoinList();
            UpdateJoinSelection();
        }

        private void SetAvailableJoinTypesByJoinList()
        {
            if (selectedSmartGraphic.analogInputSignalNames.Count > 0 || selectedSmartGraphic.analogOutputSignalNames.Count > 0)
            {
                Analog_Btn.Enabled = true;
            }
            else
            {
                Analog_Btn.Enabled = false;
            }
            if (selectedSmartGraphic.digitalInputSignalNames.Count > 0 || selectedSmartGraphic.digitalOutputSignalNames.Count > 0)
            {
                Digital_btn.Enabled = true;
            }
            else
            {
                Digital_btn.Enabled = false;
            }
            if (selectedSmartGraphic.serialInputSignalNames.Count > 0 || selectedSmartGraphic.serialOutputSignalNames.Count > 0)
            {
                Serial_Btn.Enabled = true;
            }
            else
            {
                Serial_Btn.Enabled = false;
            }
        }

        private void DeselectJoinType()
        {
            Analog_Btn.BackColor = Color.DarkRed;
            Digital_btn.BackColor = Color.RoyalBlue;
            Serial_Btn.BackColor = Color.Black;
        }

        private void DeselectJoinIO()
        {
            inputJoin_Btn.BackColor = Color.White;
            outputJoin_Btn.BackColor = Color.White;
        }

        private void ClearCurrentJoinName()
        {
            currentName_TextBox.Clear();
        }

        private void ClearNewJoinName()
        {
            newSignalName_ComboBox.Text = "";
        }

        private void UpdateJoinSelection()
        {
            if (Serial_Btn.BackColor == Color.White || Analog_Btn.BackColor == Color.White || Digital_btn.BackColor == Color.White)
            {
                switch (selectedSignalType)
                {
                    case eSignalType.AnalogInput:
                    case eSignalType.AnalogOutput:
                        if (selectedSmartGraphic.analogInputSignalNames.Count > 0)
                        {
                            inputJoin_Btn.Enabled = true;
                        }
                        else
                        {
                            inputJoin_Btn.Enabled = false;
                        }
                    
                        if (selectedSmartGraphic.analogOutputSignalNames.Count > 0)
                        {
                            outputJoin_Btn.Enabled = true;
                        }
                        else
                        {
                            outputJoin_Btn.Enabled = false;
                        }
                        break;
                    case eSignalType.DigitalInput:
                    case eSignalType.DigitalOutput:
                        if (selectedSmartGraphic.digitalInputSignalNames.Count > 0)
                        {
                            inputJoin_Btn.Enabled = true;
                        }
                        else
                        {
                            inputJoin_Btn.Enabled = false;
                        }
                    
                        if (selectedSmartGraphic.digitalOutputSignalNames.Count > 0)
                        {
                            outputJoin_Btn.Enabled = true;
                        }
                        else
                        {
                            outputJoin_Btn.Enabled = false;
                        }
                        break;
                    case eSignalType.SerialInput:
                    case eSignalType.SerialOutput:
                        if (selectedSmartGraphic.serialInputSignalNames.Count > 0)
                        {
                            inputJoin_Btn.Enabled = true;
                        }
                        else
                        {
                            inputJoin_Btn.Enabled = false;
                        }
                    
                        if (selectedSmartGraphic.serialOutputSignalNames.Count > 0)
                        {
                            outputJoin_Btn.Enabled = true;
                        }
                        else
                        {
                            outputJoin_Btn.Enabled = false;
                        }
                        break;
                    default:
                        break;
                }
                
                outputJoin_Btn.Enabled = true;
            }
            else
            {
                inputJoin_Btn.Enabled = false;
                outputJoin_Btn.Enabled = false;
            }

        }

        private void DeselectAll()
        {
            DeselectJoinIO();
            DeselectJoinType();
            smartObjectJoin_ListBox.Items.Clear();
        }
        #endregion

        #region Helpers
        private void ReplaceSignalName(string JoinToFind, List<JoinInfo> ListToSearch, string NewJoinName)
        {
            JoinInfo key = new JoinInfo();
            int index = -1;

            for (int i = 0; i < ListToSearch.Count; i++)
            {
                if (ListToSearch[i].currentJoin == JoinToFind)
                {
                    ListToSearch[i].currentJoin = NewJoinName;
                    ListToSearch[i].oldJoin = JoinToFind;
                    break;
                }
            }
           
            //debugger_listBox.Items.Add("New Join Information is: " + key.newJoin,);
            //debugger_listBox.Items.Add("");

            SetJoinList(selectedSignalType);
            ClearNewJoinName();
            ClearCurrentJoinName();
        }

        private int FindSignalIndex(string JoinToFind, IEnumerable<KeyValuePair<string, string>> ListToSearch)
        {
            int counter = 0;
            foreach (var str in ListToSearch)
            {
                if (str.Key == JoinToFind)
                {
                    return counter;
                }
                counter++;
            }
            return -1;
        }
        #endregion

        #region Event Handlers
        private void FileParser_onSmartObjectProcess(object sender, ParsedSmartObjectEventArgs e)
        {
            if (e.isDebug)
            {
                debugger_listBox.Items.Add(e.debugInfo);
            }
            else
            {
                foreach (var so in e.parsedSmartGraphicList)
                {
                    ListViewItem entry = new ListViewItem(so.objectName);
                    entry.SubItems.Add(so.iD.ToString());
                    smartObjectList_ListView.Items.Add(entry);
                }
            }
        }

        private void SmartObjectList_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selectedItem = smartObjectList_ListView.SelectedItems[0];

            UpdateSelectedSmartGraphic(FindSmartGraphic(selectedItem.SubItems[0].Text, Convert.ToInt32(selectedItem.SubItems[1].Text)));
            //Update UI with Smart Relevant Smart Object Info

            SOID_Lbl.Text = selectedItem.SubItems[1].Text;
            SOName_Label.Text = selectedItem.SubItems[0].Text;
            ClearJoinSelection();
            DeselectAll();
        }

        private void SOName_Label_TextChanged(object sender, EventArgs e)
        {
            UpdateJoinEditEnables();
        }

        private void SOID_Lbl_TextChanged(object sender, EventArgs e)
        {
            UpdateJoinEditEnables();
        }

        private void inputJoin_Btn_Click(object sender, EventArgs e)
        {
            outputJoin_Btn.BackColor = Color.White;
            inputJoin_Btn.BackColor = Color.Black;
            if (Analog_Btn.BackColor == Color.White)
            {
                selectedSignalType = eSignalType.AnalogInput;
            }
            else if(Digital_btn.BackColor == Color.White)
            {
                selectedSignalType = eSignalType.DigitalInput;
            }
            else if(Serial_Btn.BackColor == Color.White)
            {
                selectedSignalType = eSignalType.SerialInput;
            }
            SetJoinList(selectedSignalType);
        }

        private void outputJoin_Btn_Click(object sender, EventArgs e)
        {
            inputJoin_Btn.BackColor = Color.White;
            outputJoin_Btn.BackColor = Color.Black;

            if (Analog_Btn.BackColor == Color.White)
            {
                selectedSignalType = eSignalType.AnalogOutput;
            }
            else if (Digital_btn.BackColor == Color.White)
            {
                selectedSignalType = eSignalType.DigitalOutput;
            }
            else if (Serial_Btn.BackColor == Color.White)
            {
                selectedSignalType = eSignalType.SerialOutput;
            }

            SetJoinList(selectedSignalType);
        }

        private void Analog_Btn_Click(object sender, EventArgs e)
        {
            Analog_Btn.BackColor = Color.White;
            Digital_btn.BackColor = Color.RoyalBlue;
            Serial_Btn.BackColor = Color.Black;
            UpdateJoinSelection();
        }

        private void Digital_btn_Click(object sender, EventArgs e)
        {
            Digital_btn.BackColor = Color.White;
            Analog_Btn.BackColor = Color.DarkRed;
            Serial_Btn.BackColor = Color.Black;
            UpdateJoinSelection();
        }

        private void Serial_Btn_Click(object sender, EventArgs e)
        {
            Serial_Btn.BackColor = Color.White;
            Analog_Btn.BackColor = Color.DarkRed;
            Digital_btn.BackColor = Color.RoyalBlue;
            UpdateJoinSelection();
        }

        private void SaveJoinName_Btn_Click(object sender, EventArgs e)
        {
            bool saveToFile = true;
            //Save Join
            saveToFile = WriteSignalToDB(saveToFile);
            
            // 1.Change Text in Active Smart Object
            switch (selectedSignalType)
            {
                case eSignalType.AnalogInput:
                    ReplaceSignalName(currentName_TextBox.Text, selectedSmartGraphic.analogInputSignalNames, newSignalName_ComboBox.Text);
                    break;
                case eSignalType.AnalogOutput:
                    ReplaceSignalName(currentName_TextBox.Text, selectedSmartGraphic.analogOutputSignalNames, newSignalName_ComboBox.Text);
                    break;
                case eSignalType.DigitalInput:
                    ReplaceSignalName(currentName_TextBox.Text, selectedSmartGraphic.digitalInputSignalNames, newSignalName_ComboBox.Text);
                    break;
                case eSignalType.DigitalOutput:
                    ReplaceSignalName(currentName_TextBox.Text, selectedSmartGraphic.digitalOutputSignalNames, newSignalName_ComboBox.Text);
                    break;
                case eSignalType.SerialInput:
                    ReplaceSignalName(currentName_TextBox.Text, selectedSmartGraphic.serialInputSignalNames, newSignalName_ComboBox.Text);
                    break;
                case eSignalType.SerialOutput:
                    ReplaceSignalName(currentName_TextBox.Text, selectedSmartGraphic.serialOutputSignalNames, newSignalName_ComboBox.Text);
                    break;
                default:
                    break;
            }
            // Save the signal name to the db if it does not exist
           
            // 3. Update the Name in the currentName text box
        }

        private bool WriteSignalToDB(bool saveToFile)
        {

            //Check the database to make sure it does not exist
            foreach (var str in splitSignalDB)
            {
                if (str == currentName_TextBox.Text)
                {
                    saveToFile = false;
                    break;
                }
            }

            if (saveToFile)
            {
                signalNameAutoComplete.Add(newSignalName_ComboBox.Text);
                splitSignalDB.Add(newSignalName_ComboBox.Text);
                fileOps.WriteToFile(FileMode.Append, newSignalName_ComboBox.Text + "~");                
                newSignalName_ComboBox.AutoCompleteCustomSource = null;
                newSignalName_ComboBox.AutoCompleteCustomSource = signalNameAutoComplete;
            }
                        
            return saveToFile;
        }

        private void JoinName_TextChanged(object sender, EventArgs e)
        {
            SetSaveButtons();
        }

        private void SmartObjectJoin_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentName_TextBox.Text = smartObjectJoin_ListBox.GetItemText(smartObjectJoin_ListBox.SelectedItem);
        }
        #endregion

        private void saveToFile_Btn_Click(object sender, EventArgs e)
        {
            //iterate through all SmartGraphics and replace the New Smart Graphics names, with the old ones
            //This will be broken into Analogs / Digital / Serial Inputs and Outputs
            saveSGDFile.DefaultExt = ".sgd";
            saveSGDFile.FileOk += SaveSGDFile_FileOk;
            saveSGDFile.ShowDialog();
           
        }

        private void SaveSGDFile_FileOk(object sender, CancelEventArgs e)
        {
            string fileLocation = saveSGDFile.InitialDirectory + saveSGDFile.FileName;
            foreach (var sg in fileParser.smartObjectList)
            {
                sg.BuildNewMetaData();
            }
            debugger_listBox.Items.Add(fileLocation);
            fileParser.BuildSGDFile(fileLocation);
        }

        private void appClose_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
