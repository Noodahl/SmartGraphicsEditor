using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGDFileConverter.FileConversion.SGD
{
    class SGDConverterHelpers
    {

    }

    public class SmartGraphic
    {
        /// A Smart Graphic consists of:
        /// - Object Name
        /// - Object Type
        /// - Smart Object ID
        /// - Number of Analog Signals
        /// - Number of Digital Signals
        /// - Number of Serial Signals
        /// - List of the Analog Signal Names
        /// - List of the Digital Signal Names
        /// - List of the Serial Signal Names
        /// 

        #region For Testing Purposes
        public bool isMetaData { get; set; }
        public int joinNumberTotalCount { get; set; }
        public int numberOfSignalStringToParse { get; set; }
        public string[] splitMetaDataSections;
        public string smartObjectData;
        public string joinInfo;
        DebugginEventArgs debugsing = new DebugginEventArgs();
        #endregion

        #region Properties
        string[] smartGraphicsSignalInfo;
        public string content { get; set; }
        public string smartObjectHeader { get; set; }
        public string smartObjectFooter { get; set; }
        public string newSGDMetaData { get; private set; }
        public static int numSmartGraphics { get; private set; }
        public string objectName { get; set; }
        public string objectType { get; set; }
        public uint iD { get; set; }
        public string metaData { get; set; }
        public int digitalStartIndex { get; set; }
        public int analogStartIndex { get; set; }
        public int serialStartIndex { get; set; }
        public int numAnalogInputSignals { get; private set; }
        public int numDigitalInputSignals { get; private set; }
        public int numSerialInputSignals { get; private set; }
        public int numAnalogOutputSignals { get; private set; }
        public int numDigitalOutputSignals { get; private set; }
        public int numSerialOutputSignals { get; private set; }
        public List<JoinInfo> analogInputSignalNames { get; set; }
        public List<JoinInfo> analogOutputSignalNames { get; set; }
        public List<JoinInfo> digitalInputSignalNames { get; set; }
        public List<JoinInfo> digitalOutputSignalNames { get; set; }
        public List<JoinInfo> serialInputSignalNames { get; set; }
        public List<JoinInfo> serialOutputSignalNames { get; set; }
        FileOperations localFileOps;
        #endregion

        eInputOrOutput signalConnectionType { get; set; }

        public SmartGraphic()
        {

        }

        public SmartGraphic(string MetaData, string[] SmartObjectHeader, string[] SmartObjectFooter)
        {
            smartObjectHeader += SmartObjectHeader[0] + ";" + SmartObjectHeader[1];
            smartObjectFooter += ";" + SmartObjectFooter[0] + ";" + SmartObjectFooter[1] + ";" + SmartObjectFooter[2] + ";" + SmartObjectFooter[3];
            analogInputSignalNames = new List<JoinInfo>();
            analogOutputSignalNames = new List<JoinInfo>();
            digitalInputSignalNames = new List<JoinInfo>();
            digitalOutputSignalNames = new List<JoinInfo>();
            serialInputSignalNames = new List<JoinInfo>();
            serialOutputSignalNames = new List<JoinInfo>();
            ParseSmartObjectJoins(MetaData);
            numSmartGraphics++;
        }
       
        private void ParseSmartObjectJoins(string SmartGraphicJoinInfo)
        {
            char delimitter = (char)13;
            string data = SmartGraphicJoinInfo;
            
            int start, end;
            bool parseJoins = true;     //Flag to control when joins should be parsed or not. Once the ParamCue1 string is found, this flag gets set high

            //Console.WriteLine("Data is: " + data);
            try
            {
                smartGraphicsSignalInfo = SmartGraphicJoinInfo.Split(delimitter);

                //Console.WriteLine("Length = " + smartGraphicsSignalInfo.Length);

                for (int i = 0; i < smartGraphicsSignalInfo.Length; i++)
                {
                    if (smartGraphicsSignalInfo[i].IndexOf((char)10) > 0)
                    {
                        smartGraphicsSignalInfo[i] = smartGraphicsSignalInfo[i].Remove(smartGraphicsSignalInfo[i].IndexOf((char)10), 1);
                    }
                    
                    if (smartGraphicsSignalInfo[i].Contains("ParamCue"))
                    {
                        Console.WriteLine("ParamCue found at index " + i);
                        parseJoins = false;
                    }
                    else if (smartGraphicsSignalInfo[i].Contains("Cue") && !smartGraphicsSignalInfo[i].Contains("UNUSED") && !smartGraphicsSignalInfo[i].Contains("ParamCue"))
                    {
                        Console.WriteLine("Parse Joins is " + parseJoins);
                        if (parseJoins)
                        {
                            string signalName = "";
                            string signalInfo = "";
                            eSignalType signalType = eSignalType.Unassigned;

                            Console.WriteLine("Text to parse = {0}", smartGraphicsSignalInfo[i]);

                            start = smartGraphicsSignalInfo[i].IndexOf('=') + 1;
                            end = smartGraphicsSignalInfo[i].Length;
                            //Console.WriteLine("Start Is: " + start + "& Finish Is " + end);
                            //Grab the Signal Name
                            //Console.WriteLine("trimmed = " + smartGraphicsSignalInfo[i].Trim());

                            signalName = smartGraphicsSignalInfo[i].Substring(start, end - start);


                            //Check the next signal for its type

                            signalInfo = smartGraphicsSignalInfo[i + 1];
                            if (signalInfo.Contains("Analog"))
                            {
                                if (analogStartIndex == 0)
                                {
                                    analogStartIndex = i;
                                }
                                if (signalInfo.Contains("Input"))
                                {
                                    signalType = eSignalType.AnalogInput;
                                }
                                else
                                {
                                    signalType = eSignalType.AnalogOutput;
                                }
                            }
                            else if (signalInfo.Contains("Digital"))
                            {
                                if (analogStartIndex == 0)
                                {
                                    digitalStartIndex = i;
                                }
                                if (signalInfo.Contains("Input"))
                                {
                                    signalType = eSignalType.DigitalInput;
                                }
                                else
                                {
                                    signalType = eSignalType.DigitalOutput;
                                }
                            }
                            else if (signalInfo.Contains("Serial"))
                            {
                                if (analogStartIndex == 0)
                                {
                                    serialStartIndex = i;
                                }
                                if (signalInfo.Contains("Input"))
                                {
                                    signalType = eSignalType.SerialInput;
                                }
                                else
                                {
                                    signalType = eSignalType.SerialOutput;
                                }
                            }
                            //Console.WriteLine(string.Format("{0} - {1}", signalName, signalType.ToString()));
                            AddSignal(signalName, signalType);
                        }                    
                    }
                    else if(smartGraphicsSignalInfo[i].Contains("SmartObjId"))
                    {
                        string smartObjectIDString;
                        start = smartGraphicsSignalInfo[i].IndexOf('=') +1;
                        end = smartGraphicsSignalInfo[i].Length - 1;
                        smartObjectIDString = smartGraphicsSignalInfo[i].Substring(start, end - start);
                        iD = Convert.ToUInt32(smartObjectIDString);
                        //Console.WriteLine(iD);
                    }
                }
                //CompleteBuild();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void AddSignal(string Name, eSignalType SignalType)
        {
            switch (SignalType)
            {
                case eSignalType.AnalogInput:
                    analogInputSignalNames.Add(new JoinInfo() {currentJoin = Name, oldJoin = "~"});
                    break;
                case eSignalType.AnalogOutput:
                    analogOutputSignalNames.Add(new JoinInfo() { currentJoin = Name, oldJoin = "~" });
                    break;
                case eSignalType.DigitalInput:
                    digitalInputSignalNames.Add(new JoinInfo() { currentJoin = Name, oldJoin = "~" });
                    break;
                case eSignalType.DigitalOutput:
                    digitalOutputSignalNames.Add(new JoinInfo() { currentJoin = Name, oldJoin = "~" });
                    break;
                case eSignalType.SerialInput:
                    serialInputSignalNames.Add(new JoinInfo() { currentJoin = Name, oldJoin = "~" });
                    break;
                case eSignalType.SerialOutput:
                    serialOutputSignalNames.Add(new JoinInfo() { currentJoin = Name, oldJoin = "~" });
                    break;
                default:
                    break;
            }
        }

        public string SetObjectName(string MetaData)
        {
            string[] splitMetaData;
            char delimitter = (char)13;
            int start, end;

            splitMetaData = MetaData.Split(delimitter);
            Console.WriteLine(splitMetaData.Length);

            
            foreach (var line in splitMetaData)
            {
                if (line.Contains("Hint"))
                {
                    start = line.IndexOf('=') + 1;
                    end = line.IndexOf('(');

                    objectName = line.Substring(start, end - start);
                    Console.WriteLine(objectName);
                    return objectName;
                }
            }
            
            return null;
        }

        public string BuildNewMetaData()
        {
            UpdateJoinSection(analogInputSignalNames);
            UpdateJoinSection(analogOutputSignalNames);
            UpdateJoinSection(digitalInputSignalNames);
            UpdateJoinSection(digitalOutputSignalNames);
            UpdateJoinSection(serialInputSignalNames);
            UpdateJoinSection(serialOutputSignalNames);

            CompleteBuild();

            return null;
        }

        private void CompleteBuild()
        {
            
            content = smartObjectHeader;
                      
            if (RebuildSmartObjectMetaData(smartGraphicsSignalInfo))
            {                
                if (File.Exists(string.Format(@"{0}\{1}.txt", Directory.GetCurrentDirectory(), objectName)))
                {
                    File.Delete((string.Format(@"{0}\{1}.txt", Directory.GetCurrentDirectory(), objectName)));
                }
                localFileOps = new FileOperations(string.Format(@"{0}\{1}.txt", Directory.GetCurrentDirectory(), objectName));
                content += ";" + metaData + smartObjectFooter;
                localFileOps.fileContents = content;
                localFileOps.WriteToFile();
            }
        }

        private void UpdateJoinSection(List<JoinInfo> SignalList)
        {
            //PublishDebug(string.Format("Creating new MetaData File for {0}", this.objectName));
            foreach (var ji in SignalList)
            {
                //PublishDebug(string.Format("Checking signal {0}", ji.currentJoin));
                if (ji.oldJoin != "~")
                {
                    //PublishDebug(string.Format("{0} Contains a ~", ji.oldJoin));
                    for (int i = 0; i < smartGraphicsSignalInfo.Length; i++)
                    {
                        if (smartGraphicsSignalInfo[i].Contains(ji.oldJoin))
                        {
                            //PublishDebug(string.Format("Found a Match! Signal {0} ", smartGraphicsSignalInfo[i]));
                            smartGraphicsSignalInfo[i] = smartGraphicsSignalInfo[i].Replace(ji.oldJoin, ji.currentJoin);
                            
                            //PublishDebug(string.Format(" Signal Updated to {0}", smartGraphicsSignalInfo[i]));
                            break;
                        }
                    }
                }
            }
        }

        private bool RebuildSmartObjectMetaData(string[] StringToBuild)
        {
            string newMetaData = "";
            for (int i = 0; i < StringToBuild.Length; i++)
            {
                newMetaData += string.Format("{0}{1}", StringToBuild[i], (char)0x0D);                               
            }           
            metaData = newMetaData;
            return true;
        }
       
        private void PublishDebug(string Message)
        {
            if (onDebugMessageGenerated != null)
            {
                debugsing.message = Message;
                onDebugMessageGenerated(this, debugsing);
            }
        }

        public event EventHandler<DebugginEventArgs> onDebugMessageGenerated;
    }

    public enum eSignalType
    {
        AnalogInput,
        AnalogOutput,
        DigitalInput,
        DigitalOutput,
        SerialInput,
        SerialOutput,
        Unassigned
    }

    enum eInputOrOutput
    {
        Input,
        Output
    }

    public class JoinInfo
    {
        public string currentJoin { get; set; }
        public string oldJoin { get; set; }
    }
    
    public class DebugginEventArgs:EventArgs
    {
        public string message { get; set; }
    }
}
