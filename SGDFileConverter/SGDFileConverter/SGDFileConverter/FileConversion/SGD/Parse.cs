using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SGDFileConverter.FileConversion.SGD;
using SGDFileConverter;

namespace ParseSGD
{
    public class Parse
    {        

        #region Properties
        public string[] splitMetaDataSections { get; private set; }
        public string[] sgdMetaDataHeader { get; set; }
        public string[] sgdMetaDataFooter { get; set; }
        public string[] sgdFileSections { get; set; }
        public string metaData { get; private set; }
        public KeyValuePair<string, string> smartObjectData { get; private set; }
        public List<SmartGraphic> smartObjectList = new List<SmartGraphic>();
        public SmartGraphic smartGraphicToAdd { get; set; }        
        public List<SmartGraphic> GetSmartObjectList { get { return smartObjectList; } }

        FileOperations debbugsing;
        FileOperations writeSGDToFile;

        ParsedSmartObjectEventArgs parsedSmartObjects = new ParsedSmartObjectEventArgs();
        #endregion

        public void ProcessMetaData(string SGDFileContent)
        {
            metaData = SGDFileContent;
            if (metaData.Length > 0)
            {
                ///Takes SGD file and breaks it into sections - this will include both Smart graphic and non- Smart Graphic information sections
                splitMetaDataSections = SplitMetaDataIntoSections(metaData);    //Works
                //Console.WriteLine(splitMetaDataSections[1]);
                foreach (var section in splitMetaDataSections)
                {
                    //Console.WriteLine(section);
                    smartObjectData = SplitSectionsIntoSmartObjects(section);
                    Console.WriteLine(smartObjectData); //Works returns the section containing all the join information for the Smart Object
                    
                    if (smartObjectData.Key != null && smartObjectData.Value != null)
                    {
                        smartGraphicToAdd = new SmartGraphic(smartObjectData.Value, sgdMetaDataHeader, sgdMetaDataFooter);
                        //Console.WriteLine(smartObjectData.Key);
                        smartGraphicToAdd.SetObjectName(smartObjectData.Key);
                        debbugsing = new FileOperations(string.Format(@"{0}\{1}", Directory.GetCurrentDirectory(),smartGraphicToAdd.objectName));
                        debbugsing.fileContents = smartObjectData.Value;
                        debbugsing.WriteToFile();
                        //Console.WriteLine(smartGraphicToAdd.objectName);
                        smartObjectList.Add(smartGraphicToAdd);
                        //Console.WriteLine("Number of Smart Objects in list is: {0}", smartObjectList.Count);
                        smartGraphicToAdd.onDebugMessageGenerated += SmartGraphicToAdd_onDebugMessageGenerated;
                    }

                    
                }
                parsedSmartObjects.parsedSmartGraphicList = smartObjectList;
                parsedSmartObjects.isDebug = false;
                if (parsedSmartObjects != null)
                {
                    UpdateSmartObjects();
                }                
            }
        }

        private void SmartGraphicToAdd_onDebugMessageGenerated(object sender, DebugginEventArgs e)
        {
            parsedSmartObjects.debugInfo = e.message;
            parsedSmartObjects.isDebug = true;
            UpdateSmartObjects();
        }

        private string[] SplitMetaDataIntoSections(string Data)
        {
            try
            {
                //Console.WriteLine(Data);
                
                string[] delimitter = { ";================================================================================" };

                sgdFileSections = Data.Split(delimitter, StringSplitOptions.None);
                //Console.WriteLine(sgdFileSections.Length);
                return sgdFileSections;
            }
            catch (Exception)
            {
                Console.WriteLine("Error Converting MetaData into .SGD file Sections");
                return null;
            }
        }

        private KeyValuePair<string, string> SplitSectionsIntoSmartObjects(string SmartGraphicMetaData)
        {
            try
            {
                char delimitter = ';';
                string[] sgdMetaDataSections;
                string objectName = "";
                //First thing to do is check if the Section contains "ObjTp=Symbol", which distinguishes the section as Smart Object Info
                if (SmartGraphicMetaData.Contains("ObjTp=Symbol"))
                {
                    //int counter = 1;
                    //Console.WriteLine("Section is Smart Object Info,{0}{1} Data = {2}", 0x0D, 0x0A, SmartGraphicMetaData);
                    sgdMetaDataSections = SmartGraphicMetaData.Split(delimitter);
                    sgdMetaDataHeader = new string[] { sgdMetaDataSections[0], sgdMetaDataSections[1]};
                    sgdMetaDataFooter = new string[] { sgdMetaDataSections[sgdMetaDataSections.Length - 4], sgdMetaDataSections[sgdMetaDataSections.Length - 3], sgdMetaDataSections[sgdMetaDataSections.Length - 2], sgdMetaDataSections[sgdMetaDataSections.Length - 1] };
                    return new KeyValuePair<string, string>(sgdMetaDataSections[0], sgdMetaDataSections[2]);
                }
                else
                {
                    return new KeyValuePair<string, string>(null, null);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateSmartObjects()
        {
            if (onSmartObjectProcess != null)
            {
                onSmartObjectProcess(this, parsedSmartObjects);
            }
        }

        public event EventHandler<ParsedSmartObjectEventArgs> onSmartObjectProcess;

        public void BuildSGDFile(string FileToSave)
        {
            string delimitter = ";================================================================================";
            string sgd = "";

            sgd = sgdFileSections[0] + delimitter + sgdFileSections[1];
            for (int i = 0; i < smartObjectList.Count; i++)
            {
                if (i != smartObjectList.Count - 1)
                {
                    sgd += smartObjectList[i].content + delimitter;
                }
                else
                {
                    sgd += smartObjectList[i].content;
                }
            }

            writeSGDToFile = new FileOperations(FileToSave);
            writeSGDToFile.fileContents = sgd;
            writeSGDToFile.WriteToFile();
        }
       
    }

    public class ParsedSmartObjectEventArgs : EventArgs
    {
        public List<SmartGraphic> parsedSmartGraphicList { get; set; }
        public string debugInfo;
        public bool isDebug { get; set; }
    }

}
