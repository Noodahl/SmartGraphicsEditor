using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseSGD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGDFileConverter.FileConversion.SGD;

namespace ParseSGD.Tests
{
    [TestClass()]
    public class ParseTests
    {
        #region Data
        #region Data Set 1
        string data = @"[
ObjTp=FSgntr
Sgntr=SGD
RelVrs=3
VTProeVer=6.2.00
Schema=1
CRCGUID=AFD6FB33-7763-4C7F-9D97-0CF512C0E210
]
;================================================================================
[
ObjTp=Hd
ProjectFile=CTI-P101 Student 1542_rev1.1.vtp
VtpGuid=C83FF4EF-A96F-4E28-A5C5-4311E560AB33
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03. Main_Select Activity.ced
Hint=Select Activity(Smart Object ID = 25)
Code=1
SGControlType=Vertical Tab Button
SGControlName=Select Activity
GUID=A7BB5BD1-61CF-4567-AF1E-B2C48C160BD2
SmplCName=CTI-P101 Student 1542_rev1.1_03. Main_Select Activity.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10074
;Define the number of inputs, outputs and parameters
MinVariableInputs=14
MaxVariableInputs=14
MinVariableOutputs=14
MaxVariableOutputs=14
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Tab Button 3 Press
  OutputSigType5 = Digital
InputCue6=Tab Button 3 Select
InputSigType6 = Digital
OutputCue6=[~UNUSED3~]
OutputSigType6=Digital
InputCue7 =[~UNUSED3~]
InputSigType7=Digital
OutputCue7 = Tab Button 4 Press
  OutputSigType7 = Digital
InputCue8=Tab Button 4 Select
InputSigType8 = Digital
OutputCue8=[~UNUSED3~]
OutputSigType8=Digital
InputCue9 =[~UNUSED3~]
InputSigType9=Digital
OutputCue9 = Tab Button 5 Press
  OutputSigType9 = Digital
InputCue10=Tab Button 5 Select
InputSigType10 = Digital
OutputCue10=[~UNUSED3~]
OutputSigType10=Digital
InputCue11 =[~UNUSED3~]
InputSigType11=Digital
OutputCue11 = Tab Button 6 Press
  OutputSigType11 = Digital
InputCue12=Tab Button 6 Select
InputSigType12 = Digital
OutputCue12=[~UNUSED3~]
OutputSigType12=Digital
InputCue13 =[~UNUSED3~]
InputSigType13=Digital
OutputCue13 = Tab Button 7 Press
  OutputSigType13 = Digital
InputCue14=Tab Button 7 Select
InputSigType14 = Digital
OutputCue14=[~UNUSED3~]
OutputSigType14=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=1
CedH=1
SmartObjId=25d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 1
Tp = 1
HD = TRUE
DV = 25d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 1
Name = CTI - P101 Student 1542_rev1.1_03.Main_Select Activity.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03. Main_Screen Control.ced
Hint=Screen Control(Smart Object ID = 26)
Code=2
SGControlType=Vertical Tab Button
SGControlName=Screen Control
GUID=F9FE1AED-4978-4B75-A62B-0CE8AFF88125
SmplCName=CTI-P101 Student 1542_rev1.1_03. Main_Screen Control.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10074
;Define the number of inputs, outputs and parameters
MinVariableInputs=4
MaxVariableInputs=4
MinVariableOutputs=4
MaxVariableOutputs=4
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=2
CedH=2
SmartObjId=26d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 2
Tp = 1
HD = TRUE
DV = 26d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 2
Name = CTI - P101 Student 1542_rev1.1_03.Main_Screen Control.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03. Main_Lights Btns.ced
Hint=Lights Btns(Smart Object ID = 27)
Code=3
SGControlType=Vertical Tab Button
SGControlName=Lights Btns
GUID=B6C265A1-4158-4D18-A637-CFEE175908DA
SmplCName=CTI-P101 Student 1542_rev1.1_03. Main_Lights Btns.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10074
;Define the number of inputs, outputs and parameters
MinVariableInputs=12
MaxVariableInputs=12
MinVariableOutputs=12
MaxVariableOutputs=12
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Tab Button 3 Press
  OutputSigType5 = Digital
InputCue6=Tab Button 3 Select
InputSigType6 = Digital
OutputCue6=[~UNUSED3~]
OutputSigType6=Digital
InputCue7 =[~UNUSED3~]
InputSigType7=Digital
OutputCue7 = Tab Button 4 Press
  OutputSigType7 = Digital
InputCue8=Tab Button 4 Select
InputSigType8 = Digital
OutputCue8=[~UNUSED3~]
OutputSigType8=Digital
InputCue9 =[~UNUSED3~]
InputSigType9=Digital
OutputCue9 = Tab Button 5 Press
  OutputSigType9 = Digital
InputCue10=Tab Button 5 Select
InputSigType10 = Digital
OutputCue10=[~UNUSED3~]
OutputSigType10=Digital
InputCue11 =[~UNUSED3~]
InputSigType11=Digital
OutputCue11 = Tab Button 6 Press
  OutputSigType11 = Digital
InputCue12=Tab Button 6 Select
InputSigType12 = Digital
OutputCue12=[~UNUSED3~]
OutputSigType12=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=3
CedH=3
SmartObjId=27d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 3
Tp = 1
HD = TRUE
DV = 27d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 3
Name = CTI - P101 Student 1542_rev1.1_03.Main_Lights Btns.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03. Main_Volume Btns.ced
Hint=Volume Btns(Smart Object ID = 28)
Code=4
SGControlType=Vertical Tab Button
SGControlName=Volume Btns
GUID=A62777BD-AB12-4D90-9A02-2CFD3A776CC5
SmplCName=CTI-P101 Student 1542_rev1.1_03. Main_Volume Btns.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10074
;Define the number of inputs, outputs and parameters
MinVariableInputs=6
MaxVariableInputs=6
MinVariableOutputs=6
MaxVariableOutputs=6
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Tab Button 3 Press
  OutputSigType5 = Digital
InputCue6=Tab Button 3 Select
InputSigType6 = Digital
OutputCue6=[~UNUSED3~]
OutputSigType6=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=4
CedH=4
SmartObjId=28d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 4
Tp = 1
HD = TRUE
DV = 28d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 4
Name = CTI - P101 Student 1542_rev1.1_03.Main_Volume Btns.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03. Main_Volume Presets.ced
Hint=Volume Presets(Smart Object ID = 29)
Code=5
SGControlType=Vertical Tab Button
SGControlName=Volume Presets
GUID=6CDA48E9-3346-4A8D-92FB-72524BC897AA
SmplCName=CTI-P101 Student 1542_rev1.1_03. Main_Volume Presets.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10074
;Define the number of inputs, outputs and parameters
MinVariableInputs=6
MaxVariableInputs=6
MinVariableOutputs=6
MaxVariableOutputs=6
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Tab Button 3 Press
  OutputSigType5 = Digital
InputCue6=Tab Button 3 Select
InputSigType6 = Digital
OutputCue6=[~UNUSED3~]
OutputSigType6=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=5
CedH=5
SmartObjId=29d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 5
Tp = 1
HD = TRUE
DV = 29d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 5
Name = CTI - P101 Student 1542_rev1.1_03.Main_Volume Presets.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.6 Shades_Shades Control.ced
Hint=Shades Control(Smart Object ID = 60)
Code=6
SGControlType=Vertical Tab Button
SGControlName=Shades Control
GUID=993A669D-C305-4E5C-BC89-9ACE67DF2383
SmplCName=CTI-P101 Student 1542_rev1.1_03.6 Shades_Shades Control.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10074
;Define the number of inputs, outputs and parameters
MinVariableInputs=10
MaxVariableInputs=10
MinVariableOutputs=10
MaxVariableOutputs=10
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Tab Button 3 Press
  OutputSigType5 = Digital
InputCue6=Tab Button 3 Select
InputSigType6 = Digital
OutputCue6=[~UNUSED3~]
OutputSigType6=Digital
InputCue7 =[~UNUSED3~]
InputSigType7=Digital
OutputCue7 = Tab Button 4 Press
  OutputSigType7 = Digital
InputCue8=Tab Button 4 Select
InputSigType8 = Digital
OutputCue8=[~UNUSED3~]
OutputSigType8=Digital
InputCue9 =[~UNUSED3~]
InputSigType9=Digital
OutputCue9 = Tab Button 5 Press
  OutputSigType9 = Digital
InputCue10=Tab Button 5 Select
InputSigType10 = Digital
OutputCue10=[~UNUSED3~]
OutputSigType10=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=6
CedH=6
SmartObjId=60d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 6
Tp = 1
HD = TRUE
DV = 60d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 6
Name = CTI - P101 Student 1542_rev1.1_03.6 Shades_Shades Control.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Nav btns.ced
Hint=Doc Cam Nav btns(Smart Object ID = 30)
Code=7
SGControlType=DPad
SGControlName=Doc Cam Nav btns
GUID=D082DAC0-9A35-4E66-8BEA-BBBBBFAD7A24
SmplCName=CTI-P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Nav btns.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10015
;Define the number of inputs, outputs and parameters
MinVariableInputs=5
MaxVariableInputs=5
MinVariableOutputs=5
MaxVariableOutputs=5
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Up
OutputSigType1=Digital
InputCue2 =[~UNUSED3~]
InputSigType2=Digital
OutputCue2 = Down
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Left
OutputSigType3=Digital
InputCue4 =[~UNUSED3~]
InputSigType4=Digital
OutputCue4 = Right
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Center
OutputSigType5=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=7
CedH=7
SmartObjId=30d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 7
Tp = 1
HD = TRUE
DV = 30d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 7
Name = CTI - P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Nav btns.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Zoom Btns.ced
Hint=Doc Cam Zoom Btns(Smart Object ID = 32)
Code=8
SGControlType=Vertical Tab Button
SGControlName=Doc Cam Zoom Btns
GUID=C899E62E-E7FF-475A-B2F7-6EBB4D41396A
SmplCName=CTI-P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Zoom Btns.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10074
;Define the number of inputs, outputs and parameters
MinVariableInputs=10
MaxVariableInputs=10
MinVariableOutputs=10
MaxVariableOutputs=10
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Tab Button 3 Press
  OutputSigType5 = Digital
InputCue6=Tab Button 3 Select
InputSigType6 = Digital
OutputCue6=[~UNUSED3~]
OutputSigType6=Digital
InputCue7 =[~UNUSED3~]
InputSigType7=Digital
OutputCue7 = Tab Button 4 Press
  OutputSigType7 = Digital
InputCue8=Tab Button 4 Select
InputSigType8 = Digital
OutputCue8=[~UNUSED3~]
OutputSigType8=Digital
InputCue9 =[~UNUSED3~]
InputSigType9=Digital
OutputCue9 = Tab Button 5 Press
  OutputSigType9 = Digital
InputCue10=Tab Button 5 Select
InputSigType10 = Digital
OutputCue10=[~UNUSED3~]
OutputSigType10=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=8
CedH=8
SmartObjId=32d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 8
Tp = 1
HD = TRUE
DV = 32d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 8
Name = CTI - P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Zoom Btns.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Preset Btns.ced
Hint=Doc Cam Preset Btns(Smart Object ID = 35)
Code=9
SGControlType=Vertical Tab Button
SGControlName=Doc Cam Preset Btns
GUID=B980F444-6543-4413-804B-DC1E70D8E0B9
SmplCName=CTI-P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Preset Btns.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10074
;Define the number of inputs, outputs and parameters
MinVariableInputs=6
MaxVariableInputs=6
MinVariableOutputs=6
MaxVariableOutputs=6
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Tab Button 3 Press
  OutputSigType5 = Digital
InputCue6=Tab Button 3 Select
InputSigType6 = Digital
OutputCue6=[~UNUSED3~]
OutputSigType6=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=9
CedH=9
SmartObjId=35d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 9
Tp = 1
HD = TRUE
DV = 35d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 9
Name = CTI - P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Preset Btns.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Light Btns.ced
Hint=Doc Cam Light Btns(Smart Object ID = 34)
Code=10
SGControlType=Horizontal Tab Button
SGControlName=Doc Cam Light Btns
GUID=A430D7FB-D8EB-4744-9761-FCC1E0384EBE
SmplCName=CTI-P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Light Btns.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10031
;Define the number of inputs, outputs and parameters
MinVariableInputs=4
MaxVariableInputs=4
MinVariableOutputs=4
MaxVariableOutputs=4
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=10
CedH=10
SmartObjId=34d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 10
Tp = 1
HD = TRUE
DV = 34d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 10
Name = CTI - P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Light Btns.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Focus btns.ced
Hint=Doc Cam Focus btns(Smart Object ID = 33)
Code=11
SGControlType=Horizontal Tab Button
SGControlName=Doc Cam Focus btns
GUID=F07C1083-D7C8-473B-9EAD-B871B4458253
SmplCName=CTI-P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Focus btns.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10031
;Define the number of inputs, outputs and parameters
MinVariableInputs=6
MaxVariableInputs=6
MinVariableOutputs=6
MaxVariableOutputs=6
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Tab Button 3 Press
  OutputSigType5 = Digital
InputCue6=Tab Button 3 Select
InputSigType6 = Digital
OutputCue6=[~UNUSED3~]
OutputSigType6=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=11
CedH=11
SmartObjId=33d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 11
Tp = 1
HD = TRUE
DV = 33d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 11
Name = CTI - P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Focus btns.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Menu Btns.ced
Hint=Doc Cam Menu Btns(Smart Object ID = 31)
Code=12
SGControlType=Horizontal Tab Button
SGControlName=Doc Cam Menu Btns
GUID=F74901A4-36D4-4E90-9A17-338AC9C7286D
SmplCName=CTI-P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Menu Btns.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10031
;Define the number of inputs, outputs and parameters
MinVariableInputs=4
MaxVariableInputs=4
MinVariableOutputs=4
MaxVariableOutputs=4
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=12
CedH=12
SmartObjId=31d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 12
Tp = 1
HD = TRUE
DV = 31d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 12
Name = CTI - P101 Student 1542_rev1.1_03.1 Doc Camera_Doc Cam Menu Btns.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.3 Satellite_Sat DPad.ced
Hint=Sat DPad(Smart Object ID = 40)
Code=13
SGControlType=DPad
SGControlName=Sat DPad
GUID=29E878C4-E9A8-475F-8853-D1D3C41CF039
SmplCName=CTI-P101 Student 1542_rev1.1_03.3 Satellite_Sat DPad.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10015
;Define the number of inputs, outputs and parameters
MinVariableInputs=5
MaxVariableInputs=5
MinVariableOutputs=5
MaxVariableOutputs=5
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Up
OutputSigType1=Digital
InputCue2 =[~UNUSED3~]
InputSigType2=Digital
OutputCue2 = Down
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Left
OutputSigType3=Digital
InputCue4 =[~UNUSED3~]
InputSigType4=Digital
OutputCue4 = Right
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Center
OutputSigType5=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=13
CedH=13
SmartObjId=40d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 13
Tp = 1
HD = TRUE
DV = 40d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 13
Name = CTI - P101 Student 1542_rev1.1_03.3 Satellite_Sat DPad.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.3 Satellite_Sat Keypad.ced
Hint=Sat Keypad(Smart Object ID = 42)
Code=14
SGControlType=Simple Keypad
SGControlName=Sat Keypad
GUID=4FCA034F-4126-4C1D-B3C5-DE8FE98793F2
SmplCName=CTI-P101 Student 1542_rev1.1_03.3 Satellite_Sat Keypad.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10061
;Define the number of inputs, outputs and parameters
MinVariableInputs=12
MaxVariableInputs=12
MinVariableOutputs=12
MaxVariableOutputs=12
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = 1
OutputSigType1=Digital
InputCue2 =[~UNUSED3~]
InputSigType2=Digital
OutputCue2 = 2
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = 3
OutputSigType3=Digital
InputCue4 =[~UNUSED3~]
InputSigType4=Digital
OutputCue4 = 4
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = 5
OutputSigType5=Digital
InputCue6 =[~UNUSED3~]
InputSigType6=Digital
OutputCue6 = 6
OutputSigType6=Digital
InputCue7 =[~UNUSED3~]
InputSigType7=Digital
OutputCue7 = 7
OutputSigType7=Digital
InputCue8 =[~UNUSED3~]
InputSigType8=Digital
OutputCue8 = 8
OutputSigType8=Digital
InputCue9 =[~UNUSED3~]
InputSigType9=Digital
OutputCue9 = 9
OutputSigType9=Digital
InputCue10 =[~UNUSED3~]
InputSigType10=Digital
OutputCue10 = 0
OutputSigType10=Digital
InputCue11 =[~UNUSED3~]
InputSigType11=Digital
OutputCue11 = Misc_1
OutputSigType11=Digital
InputCue12 =[~UNUSED3~]
InputSigType12=Digital
OutputCue12 = Misc_2
OutputSigType12=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=14
CedH=14
SmartObjId=42d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 14
Tp = 1
HD = TRUE
DV = 42d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 14
Name = CTI - P101 Student 1542_rev1.1_03.3 Satellite_Sat Keypad.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.3 Satellite_Sat Presets.ced
Hint=Sat Presets(Smart Object ID = 41)
Code=15
SGControlType=Icon List Vertical
SGControlName=Sat Presets
GUID=78D89396-9667-4F36-A877-0775D13C774F
SmplCName=CTI-P101 Student 1542_rev1.1_03.3 Satellite_Sat Presets.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10033
;Define the number of inputs, outputs and parameters
MinVariableInputs=10
MaxVariableInputs=10
MinVariableOutputs=10
MaxVariableOutputs=10
NumFixedParams=1
MinVariableInputsList2=6
MaxVariableInputsList2=6
MinVariableOutputsList2=6
MaxVariableOutputsList2=6
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Item 1 Pressed
  OutputSigType1 = Digital
InputCue2=[~UNUSED3~]
InputSigType2=Digital
OutputCue2 = Item 2 Pressed
  OutputSigType2 = Digital
InputCue3=[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Item 3 Pressed
  OutputSigType3 = Digital
InputCue4=[~UNUSED3~]
InputSigType4=Digital
OutputCue4 = Item 4 Pressed
  OutputSigType4 = Digital
InputCue5=[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Item 5 Pressed
  OutputSigType5 = Digital
InputCue6=[~UNUSED3~]
InputSigType6=Digital
OutputCue6 = Item 6 Pressed
  OutputSigType6 = Digital
InputCue7=[~UNUSED3~]
InputSigType7=Digital
OutputCue7 = Item 7 Pressed
  OutputSigType7 = Digital
InputCue8=[~UNUSED3~]
InputSigType8=Digital
OutputCue8 = Item 8 Pressed
  OutputSigType8 = Digital
InputCue9=[~UNUSED3~]
InputSigType9=Digital
OutputCue9 = Item 9 Pressed
  OutputSigType9 = Digital
InputCue10=[~UNUSED3~]
InputSigType10=Digital
OutputCue10 = Item 10 Pressed
  OutputSigType10 = Digital
InputList2Cue1=Select Item
InputList2SigType1=Analog
OutputList2Cue1 =[~UNUSED3~]
OutputList2SigType1=Analog
InputList2Cue2 = Deselect Item
  InputList2SigType2 = Analog
OutputList2Cue2=[~UNUSED3~]
OutputList2SigType2=Analog
InputList2Cue3 = Scroll Item
  InputList2SigType3 = Analog
OutputList2Cue3=[~UNUSED3~]
OutputList2SigType3=Analog
InputList2Cue4 =[~UNUSED3~]
InputList2SigType4=Analog
OutputList2Cue4 = Item Clicked
  OutputList2SigType4 = Analog
InputList2Cue5=[~UNUSED3~]
InputList2SigType5=Analog
OutputList2Cue5 = Item Held
  OutputList2SigType5 = Analog
InputList2Cue6=Set Num of Items
InputList2SigType6=Analog
OutputList2Cue6 =[~UNUSED3~]
OutputList2SigType6=Analog
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=15
CedH=15
SmartObjId=41d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 15
Tp = 1
HD = TRUE
DV = 41d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 15
Name = CTI - P101 Student 1542_rev1.1_03.3 Satellite_Sat Presets.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.4 Blu Ray_BluRay DPad.ced
Hint=BluRay DPad(Smart Object ID = 50)
Code=16
SGControlType=DPad
SGControlName=BluRay DPad
GUID=8DA37C37-8E2D-4AA5-91C1-FD66FE6301FD
SmplCName=CTI-P101 Student 1542_rev1.1_03.4 Blu Ray_BluRay DPad.ced
SMWRev=4.02.19
Expand=expand_random
HelpID=10015
;Define the number of inputs, outputs and parameters
MinVariableInputs=5
MaxVariableInputs=5
MinVariableOutputs=5
MaxVariableOutputs=5
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types  each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Up
OutputSigType1=Digital
InputCue2 =[~UNUSED3~]
InputSigType2=Digital
OutputCue2 = Down
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Left
OutputSigType3=Digital
InputCue4 =[~UNUSED3~]
InputSigType4=Digital
OutputCue4 = Right
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Center
OutputSigType5=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=16
CedH=16
SmartObjId=50d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 16
Tp = 1
HD = TRUE
DV = 50d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 16
Name = CTI - P101 Student 1542_rev1.1_03.4 Blu Ray_BluRay DPad.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.4 Blu Ray_Blu Ray Transports 1.ced
Hint=Blu Ray Transports 1 (Smart Object ID = 51)
Code=17
SGControlType=Horizontal Tab Button
SGControlName = Blu Ray Transports 1
GUID=7036CEE2-BAC3-41E5-B7FC-0FD3E08B0E07
SmplCName = CTI - P101 Student 1542_rev1.1_03.4 Blu Ray_Blu Ray Transports 1.ced
    SMWRev = 4.02.19
Expand=expand_random
HelpID = 10031
; Define the number of inputs, outputs and parameters
 MinVariableInputs = 8
MaxVariableInputs=8
MinVariableOutputs=8
MaxVariableOutputs=8
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Tab Button 3 Press
  OutputSigType5 = Digital
InputCue6=Tab Button 3 Select
InputSigType6 = Digital
OutputCue6=[~UNUSED3~]
OutputSigType6=Digital
InputCue7 =[~UNUSED3~]
InputSigType7=Digital
OutputCue7 = Tab Button 4 Press
  OutputSigType7 = Digital
InputCue8=Tab Button 4 Select
InputSigType8 = Digital
OutputCue8=[~UNUSED3~]
OutputSigType8=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=17
CedH=17
SmartObjId=51d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 17
Tp = 1
HD = TRUE
DV = 51d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 17
Name = CTI - P101 Student 1542_rev1.1_03.4 Blu Ray_Blu Ray Transports 1.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
;================================================================================
[
ObjTp=Symbol
Name=CTI-P101 Student 1542_rev1.1_03.4 Blu Ray_Blu Ray Transports 2.ced
Hint=Blu Ray Transports 2 (Smart Object ID = 52)
Code=18
SGControlType=Horizontal Tab Button
SGControlName = Blu Ray Transports 2
GUID=A3AF77A2-6134-4A1C-9A49-884BCBAB67E3
SmplCName = CTI - P101 Student 1542_rev1.1_03.4 Blu Ray_Blu Ray Transports 2.ced
    SMWRev = 4.02.19
Expand=expand_random
HelpID = 10031
; Define the number of inputs, outputs and parameters
 MinVariableInputs = 8
MaxVariableInputs=8
MinVariableOutputs=8
MaxVariableOutputs=8
NumFixedParams=1
MinVariableInputsList2=0
MaxVariableInputsList2=0
MinVariableOutputsList2=0
MaxVariableOutputsList2=0
MinVariableInputsList3=0
MaxVariableInputsList3=0
MinVariableOutputsList3=0
MaxVariableOutputsList3=0
;Define the cues, and signal types each input, output and parameter.
InputCue1=[~UNUSED3~]
InputSigType1=Digital
OutputCue1 = Tab Button 1 Press
  OutputSigType1 = Digital
InputCue2=Tab Button 1 Select
InputSigType2 = Digital
OutputCue2=[~UNUSED3~]
OutputSigType2=Digital
InputCue3 =[~UNUSED3~]
InputSigType3=Digital
OutputCue3 = Tab Button 2 Press
  OutputSigType3 = Digital
InputCue4=Tab Button 2 Select
InputSigType4 = Digital
OutputCue4=[~UNUSED3~]
OutputSigType4=Digital
InputCue5 =[~UNUSED3~]
InputSigType5=Digital
OutputCue5 = Tab Button 3 Press
  OutputSigType5 = Digital
InputCue6=Tab Button 3 Select
InputSigType6 = Digital
OutputCue6=[~UNUSED3~]
OutputSigType6=Digital
InputCue7 =[~UNUSED3~]
InputSigType7=Digital
OutputCue7 = Tab Button 4 Press
  OutputSigType7 = Digital
InputCue8=Tab Button 4 Select
InputSigType8 = Digital
OutputCue8=[~UNUSED3~]
OutputSigType8=Digital
ParamCue1 = SmartObjectId
ParamSigType1=Constant
MPp = 1
Pp1=18
CedH=18
SmartObjId=52d
]
; Parameter Properties for Smart Object ID
[
ObjTp = Dp
H = 18
Tp = 1
HD = TRUE
DV = 52d
NF = 1
DNF = 1
EncFmt = 0
DVLF = 1
Sgn = 0
]
; Smart Objects Definition section
[
ObjTp = CED
H = 18
Name = CTI - P101 Student 1542_rev1.1_03.4 Blu Ray_Blu Ray Transports 2.ced
; Cedver is the version of the Smart Graphics control, not the CED file format.
;If the control definition changes, increment this.
CedVer= 1
]
        ";
        #endregion

        #region Data Set 2
        string data2 = @"[
        ObjTp=FSgntr
        Sgntr=SGD
        RelVrs=3
        VTProeVer=6.2.00
        Schema=1
        CRCGUID=B6C05863-EACE-43ED-8D23-32CE1562284F
        ]
        ;================================================================================
        [
        ObjTp=Hd
        ProjectFile=P301 TS 20170530.vtp
        VtpGuid=5F459488-6EB2-4633-9D92-173F6278A067
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_[21]Matrix Switcher_[Switcher]Select Sources.ced
        Hint=[Switcher]Select Sources (Smart Object ID=31)
        Code=1
        SGControlType=Vertical Tab Button
        SGControlName=[Switcher]Select Sources
        GUID=9333C859-5F0A-4549-9A9F-D6071A3B9083
        SmplCName=P301 TS 20170530_[21]Matrix Switcher_[Switcher]Select Sources.ced
        SMWRev=4.02.19
        Expand=expand_random
        HelpID=10074
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=10
        MaxVariableInputs=10
        MinVariableOutputs=10
        MaxVariableOutputs=10
        NumFixedParams=1
        MinVariableInputsList2=0
        MaxVariableInputsList2=0
        MinVariableOutputsList2=0
        MaxVariableOutputsList2=0
        MinVariableInputsList3=0
        MaxVariableInputsList3=0
        MinVariableOutputsList3=0
        MaxVariableOutputsList3=0
        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        OutputCue1=Tab Button 1 Press
        OutputSigType1=Digital
        InputCue2=Tab Button 1 Select
        InputSigType2=Digital
        OutputCue2=[~UNUSED3~]
        OutputSigType2=Digital
        InputCue3=[~UNUSED3~]
        InputSigType3=Digital
        OutputCue3=Tab Button 2 Press
        OutputSigType3=Digital
        InputCue4=Tab Button 2 Select
        InputSigType4=Digital
        OutputCue4=[~UNUSED3~]
        OutputSigType4=Digital
        InputCue5=[~UNUSED3~]
        InputSigType5=Digital
        OutputCue5=Tab Button 3 Press
        OutputSigType5=Digital
        InputCue6=Tab Button 3 Select
        InputSigType6=Digital
        OutputCue6=[~UNUSED3~]
        OutputSigType6=Digital
        InputCue7=[~UNUSED3~]
        InputSigType7=Digital
        OutputCue7=Tab Button 4 Press
        OutputSigType7=Digital
        InputCue8=Tab Button 4 Select
        InputSigType8=Digital
        OutputCue8=[~UNUSED3~]
        OutputSigType8=Digital
        InputCue9=[~UNUSED3~]
        InputSigType9=Digital
        OutputCue9=Tab Button 5 Press
        OutputSigType9=Digital
        InputCue10=Tab Button 5 Select
        InputSigType10=Digital
        OutputCue10=[~UNUSED3~]
        OutputSigType10=Digital
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=1
        CedH=1
        SmartObjId=31d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=1
        Tp=1
        HD=TRUE
        DV=31d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=1
        Name=P301 TS 20170530_[21]Matrix Switcher_[Switcher]Select Sources.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_[21]Matrix Switcher_[Switcher]Select Type.ced
        Hint=[Switcher]Select Type (Smart Object ID=32)
        Code=2
        SGControlType=Vertical Tab Button
        SGControlName=[Switcher]Select Type
        GUID=B2373F47-D288-4795-9F67-DFB165E4858D
        SmplCName=P301 TS 20170530_[21]Matrix Switcher_[Switcher]Select Type.ced
        SMWRev=4.02.19
        Expand=expand_random
        HelpID=10074
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=6
        MaxVariableInputs=6
        MinVariableOutputs=6
        MaxVariableOutputs=6
        NumFixedParams=1
        MinVariableInputsList2=0
        MaxVariableInputsList2=0
        MinVariableOutputsList2=0
        MaxVariableOutputsList2=0
        MinVariableInputsList3=0
        MaxVariableInputsList3=0
        MinVariableOutputsList3=0
        MaxVariableOutputsList3=0
        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        OutputCue1=Tab Button 1 Press
        OutputSigType1=Digital
        InputCue2=Tab Button 1 Select
        InputSigType2=Digital
        OutputCue2=[~UNUSED3~]
        OutputSigType2=Digital
        InputCue3=[~UNUSED3~]
        InputSigType3=Digital
        OutputCue3=Tab Button 2 Press
        OutputSigType3=Digital
        InputCue4=Tab Button 2 Select
        InputSigType4=Digital
        OutputCue4=[~UNUSED3~]
        OutputSigType4=Digital
        InputCue5=[~UNUSED3~]
        InputSigType5=Digital
        OutputCue5=Tab Button 3 Press
        OutputSigType5=Digital
        InputCue6=Tab Button 3 Select
        InputSigType6=Digital
        OutputCue6=[~UNUSED3~]
        OutputSigType6=Digital
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=2
        CedH=2
        SmartObjId=32d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=2
        Tp=1
        HD=TRUE
        DV=32d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=2
        Name=P301 TS 20170530_[21]Matrix Switcher_[Switcher]Select Type.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_[21]Matrix Switcher_[Switcher]Select Destination.ced
        Hint=[Switcher]Select Destination (Smart Object ID=33)
        Code=3
        SGControlType=Vertical Tab Button
        SGControlName=[Switcher]Select Destination
        GUID=CD8BAE39-5F48-48E0-87AD-B6DFC9865483
        SmplCName=P301 TS 20170530_[21]Matrix Switcher_[Switcher]Select Destination.ced
        SMWRev=4.02.19
        Expand=expand_random
        HelpID=10074
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=8
        MaxVariableInputs=8
        MinVariableOutputs=8
        MaxVariableOutputs=8
        NumFixedParams=1
        MinVariableInputsList2=0
        MaxVariableInputsList2=0
        MinVariableOutputsList2=0
        MaxVariableOutputsList2=0
        MinVariableInputsList3=0
        MaxVariableInputsList3=0
        MinVariableOutputsList3=0
        MaxVariableOutputsList3=0
        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        OutputCue1=Tab Button 1 Press
        OutputSigType1=Digital
        InputCue2=Tab Button 1 Select
        InputSigType2=Digital
        OutputCue2=[~UNUSED3~]
        OutputSigType2=Digital
        InputCue3=[~UNUSED3~]
        InputSigType3=Digital
        OutputCue3=Tab Button 2 Press
        OutputSigType3=Digital
        InputCue4=Tab Button 2 Select
        InputSigType4=Digital
        OutputCue4=[~UNUSED3~]
        OutputSigType4=Digital
        InputCue5=[~UNUSED3~]
        InputSigType5=Digital
        OutputCue5=Tab Button 3 Press
        OutputSigType5=Digital
        InputCue6=Tab Button 3 Select
        InputSigType6=Digital
        OutputCue6=[~UNUSED3~]
        OutputSigType6=Digital
        InputCue7=[~UNUSED3~]
        InputSigType7=Digital
        OutputCue7=Tab Button 4 Press
        OutputSigType7=Digital
        InputCue8=Tab Button 4 Select
        InputSigType8=Digital
        OutputCue8=[~UNUSED3~]
        OutputSigType8=Digital
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=3
        CedH=3
        SmartObjId=33d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=3
        Tp=1
        HD=TRUE
        DV=33d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=3
        Name=P301 TS 20170530_[21]Matrix Switcher_[Switcher]Select Destination.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_[21]Matrix Switcher_[Switcher]Routed Source Text.ced
        Hint=[Switcher]Routed Source Text (Smart Object ID=34)
        Code=4
        SGControlType=Vertical Tab Button
        SGControlName=[Switcher]Routed Source Text
        GUID=4AB5FFDE-B294-4DD9-BDD3-12C5E8BFB50C
        SmplCName=P301 TS 20170530_[21]Matrix Switcher_[Switcher]Routed Source Text.ced
        SMWRev=4.02.19
        Expand=expand_random
        HelpID=10074
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=8
        MaxVariableInputs=8
        MinVariableOutputs=8
        MaxVariableOutputs=8
        NumFixedParams=1
        MinVariableInputsList2=0
        MaxVariableInputsList2=0
        MinVariableOutputsList2=0
        MaxVariableOutputsList2=0
        MinVariableInputsList3=0
        MaxVariableInputsList3=0
        MinVariableOutputsList3=0
        MaxVariableOutputsList3=0
        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        OutputCue1=Tab Button 1 Press
        OutputSigType1=Digital
        InputCue2=Tab Button 1 Select
        InputSigType2=Digital
        OutputCue2=[~UNUSED3~]
        OutputSigType2=Digital
        InputCue3=[~UNUSED3~]
        InputSigType3=Digital
        OutputCue3=Tab Button 2 Press
        OutputSigType3=Digital
        InputCue4=Tab Button 2 Select
        InputSigType4=Digital
        OutputCue4=[~UNUSED3~]
        OutputSigType4=Digital
        InputCue5=[~UNUSED3~]
        InputSigType5=Digital
        OutputCue5=Tab Button 3 Press
        OutputSigType5=Digital
        InputCue6=Tab Button 3 Select
        InputSigType6=Digital
        OutputCue6=[~UNUSED3~]
        OutputSigType6=Digital
        InputCue7=[~UNUSED3~]
        InputSigType7=Digital
        OutputCue7=Tab Button 4 Press
        OutputSigType7=Digital
        InputCue8=Tab Button 4 Select
        InputSigType8=Digital
        OutputCue8=[~UNUSED3~]
        OutputSigType8=Digital
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=4
        CedH=4
        SmartObjId=34d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=4
        Tp=1
        HD=TRUE
        DV=34d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=4
        Name=P301 TS 20170530_[21]Matrix Switcher_[Switcher]Routed Source Text.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_NAV Left Bar_[Main]Activity Selection.ced
        Hint=[Main]Activity Selection (Smart Object ID=1)
        Code=5
        SGControlType=Icon List Vertical
        SGControlName=[Main]Activity Selection
        GUID=C90B4843-721A-4E11-933E-34935AEB3DA1
        SmplCName=P301 TS 20170530_NAV Left Bar_[Main]Activity Selection.ced
        SMWRev=4.02.19
        Expand=expand_random
        HelpID=10033
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=7
        MaxVariableInputs=7
        MinVariableOutputs=7
        MaxVariableOutputs=7
        NumFixedParams=1
        MinVariableInputsList2=6
        MaxVariableInputsList2=6
        MinVariableOutputsList2=6
        MaxVariableOutputsList2=6
        MinVariableInputsList3=0
        MaxVariableInputsList3=0
        MinVariableOutputsList3=0
        MaxVariableOutputsList3=0
        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        OutputCue1=Item 1 Pressed
        OutputSigType1=Digital
        InputCue2=[~UNUSED3~]
        InputSigType2=Digital
        OutputCue2=Item 2 Pressed
        OutputSigType2=Digital
        InputCue3=[~UNUSED3~]
        InputSigType3=Digital
        OutputCue3=Item 3 Pressed
        OutputSigType3=Digital
        InputCue4=[~UNUSED3~]
        InputSigType4=Digital
        OutputCue4=Item 4 Pressed
        OutputSigType4=Digital
        InputCue5=[~UNUSED3~]
        InputSigType5=Digital
        OutputCue5=Item 5 Pressed
        OutputSigType5=Digital
        InputCue6=[~UNUSED3~]
        InputSigType6=Digital
        OutputCue6=Item 6 Pressed
        OutputSigType6=Digital
        InputCue7=[~UNUSED3~]
        InputSigType7=Digital
        OutputCue7=Item 7 Pressed
        OutputSigType7=Digital
        InputList2Cue1=Select Item
        InputList2SigType1=Analog
        OutputList2Cue1=[~UNUSED3~]
        OutputList2SigType1=Analog
        InputList2Cue2=Deselect Item
        InputList2SigType2=Analog
        OutputList2Cue2=[~UNUSED3~]
        OutputList2SigType2=Analog
        InputList2Cue3=Scroll Item
        InputList2SigType3=Analog
        OutputList2Cue3=[~UNUSED3~]
        OutputList2SigType3=Analog
        InputList2Cue4=[~UNUSED3~]
        InputList2SigType4=Analog
        OutputList2Cue4=Item Clicked
        OutputList2SigType4=Analog
        InputList2Cue5=[~UNUSED3~]
        InputList2SigType5=Analog
        OutputList2Cue5=Item Held
        OutputList2SigType5=Analog
        InputList2Cue6=Set Num of Items
        InputList2SigType6=Analog
        OutputList2Cue6=[~UNUSED3~]
        OutputList2SigType6=Analog
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=5
        CedH=5
        SmartObjId=1d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=5
        Tp=1
        HD=TRUE
        DV=1d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=5
        Name=P301 TS 20170530_NAV Left Bar_[Main]Activity Selection.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_[26]Ratings_[Ratings]Received Ratings.ced
        Hint=[Ratings]Received Ratings (Smart Object ID=81)
        Code=6
        SGControlType=Subpage Reference List Horizontal
        SGControlName=[Ratings]Received Ratings
        GUID=7017A5DC-8933-4F31-AE5C-300A53923219
        SmplCName=P301 TS 20170530_[26]Ratings_[Ratings]Received Ratings.ced
        SMWRev=4.02.20
        Expand=expand_random
        HelpID=10124
        Render=8
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=4032
        MaxVariableInputs=4032
        MinVariableOutputs=4032
        MaxVariableOutputs=4032
        NumFixedParams=1
        MinVariableInputsList2=44
        MaxVariableInputsList2=44
        MinVariableOutputsList2=44
        MaxVariableOutputsList2=44
        MinVariableInputsList3=28
        MaxVariableInputsList3=28
        MinVariableOutputsList3=28
        MaxVariableOutputsList3=28
        InputSigType1=Digital
        OutputSigType1=Digital
        InputList2SigType1=Analog
        OutputList2SigType1=Analog
        InputList3SigType1=Serial
        OutputList3SigType1=Serial

        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        InputCue2=[~UNUSED2~]
        InputSigType2=Digital
        InputCue3=[~UNUSED2~]
        InputSigType3=Digital
        InputCue4=[~UNUSED2~]
        InputSigType4=Digital
        InputCue5=[~UNUSED2~]
        InputSigType5=Digital
        InputCue6=[~UNUSED2~]
        InputSigType6=Digital
        InputCue7=[~UNUSED2~]
        InputSigType7=Digital
        InputCue8=[~UNUSED2~]
        InputSigType8=Digital
        InputCue9=[~UNUSED2~]
        InputSigType9=Digital
        InputCue10=[~UNUSED2~]
        InputSigType10=Digital
        InputCue11=[~BeginGroup~]Enable
        InputSigType11=Digital
        InputCue12=Item 1 Enable
        InputSigType12=Digital
        InputCue13=Item 2 Enable
        InputSigType13=Digital
        InputCue14=Item 3 Enable
        InputSigType14=Digital
        InputCue15=Item 4 Enable
        InputSigType15=Digital
        InputCue16=Item 5 Enable
        InputSigType16=Digital
        InputCue17=Item 6 Enable
        InputSigType17=Digital
        InputCue18=Item 7 Enable
        InputSigType18=Digital
        InputCue19=Item 8 Enable
        InputSigType19=Digital
        InputCue20=Item 9 Enable
        InputSigType20=Digital
        InputCue21=Item 10 Enable
        InputSigType21=Digital
        InputCue22=Item 11 Enable
        InputSigType22=Digital
        InputCue23=Item 12 Enable
        InputSigType23=Digital
        InputCue24=Item 13 Enable
        InputSigType24=Digital
        InputCue25=Item 14 Enable
        InputSigType25=Digital
        InputCue26=Item 15 Enable
        InputSigType26=Digital
        InputCue27=Item 16 Enable
        InputSigType27=Digital
        InputCue28=[~UNUSED2~]
        InputSigType28=Digital|Analog|Serial|String
        InputCue2012=[~EndGroup~]Enable
        InputSigType2012=Digital
        InputCue2013=[~BeginGroup~]Visible
        InputSigType2013=Digital
        InputCue2014=Item 1 Visible
        InputSigType2014=Digital
        InputCue2015=Item 2 Visible
        InputSigType2015=Digital
        InputCue2016=Item 3 Visible
        InputSigType2016=Digital
        InputCue2017=Item 4 Visible
        InputSigType2017=Digital
        InputCue2018=Item 5 Visible
        InputSigType2018=Digital
        InputCue2019=Item 6 Visible
        InputSigType2019=Digital
        InputCue2020=Item 7 Visible
        InputSigType2020=Digital
        InputCue2021=Item 8 Visible
        InputSigType2021=Digital
        InputCue2022=Item 9 Visible
        InputSigType2022=Digital
        InputCue2023=Item 10 Visible
        InputSigType2023=Digital
        InputCue2024=Item 11 Visible
        InputSigType2024=Digital
        InputCue2025=Item 12 Visible
        InputSigType2025=Digital
        InputCue2026=Item 13 Visible
        InputSigType2026=Digital
        InputCue2027=Item 14 Visible
        InputSigType2027=Digital
        InputCue2028=Item 15 Visible
        InputSigType2028=Digital
        InputCue2029=Item 16 Visible
        InputSigType2029=Digital
        InputCue2030=[~UNUSED2~]
        InputSigType2030=Digital|Analog|Serial|String
        InputCue4014=[~EndGroup~]Visible
        InputSigType4014=Digital
        InputCue4015=[~BeginGroup~]fb
        InputSigType4015=Digital
        InputCue4016=fb1
        InputSigType4016=Digital
        InputCue4017=fb2
        InputSigType4017=Digital
        InputCue4018=fb3
        InputSigType4018=Digital
        InputCue4019=fb4
        InputSigType4019=Digital
        InputCue4020=fb5
        InputSigType4020=Digital
        InputCue4021=fb6
        InputSigType4021=Digital
        InputCue4022=fb7
        InputSigType4022=Digital
        InputCue4023=fb8
        InputSigType4023=Digital
        InputCue4024=fb9
        InputSigType4024=Digital
        InputCue4025=fb10
        InputSigType4025=Digital
        InputCue4026=fb11
        InputSigType4026=Digital
        InputCue4027=fb12
        InputSigType4027=Digital
        InputCue4028=fb13
        InputSigType4028=Digital
        InputCue4029=fb14
        InputSigType4029=Digital
        InputCue4030=fb15
        InputSigType4030=Digital
        InputCue4031=fb16
        InputSigType4031=Digital
        InputCue4032=[~EndGroup~]fb
        InputSigType4032=Digital
        OutputCue1=Is Moving
        OutputSigType1=Digital
        OutputCue2=[~UNUSED2~]
        OutputSigType2=Digital
        OutputCue3=[~UNUSED2~]
        OutputSigType3=Digital
        OutputCue4=[~UNUSED2~]
        OutputSigType4=Digital
        OutputCue5=[~UNUSED2~]
        OutputSigType5=Digital
        OutputCue6=[~UNUSED2~]
        OutputSigType6=Digital
        OutputCue7=[~UNUSED2~]
        OutputSigType7=Digital
        OutputCue8=[~UNUSED2~]
        OutputSigType8=Digital
        OutputCue9=[~UNUSED2~]
        OutputSigType9=Digital
        OutputCue10=[~UNUSED2~]
        OutputSigType10=Digital
        OutputCue11=[~BeginGroup~]Enable
        OutputSigType11=Digital
        OutputCue12=[~UNUSED3~]
        OutputSigType12=Digital
        OutputCue13=[~UNUSED3~]
        OutputSigType13=Digital
        OutputCue14=[~UNUSED3~]
        OutputSigType14=Digital
        OutputCue15=[~UNUSED3~]
        OutputSigType15=Digital
        OutputCue16=[~UNUSED3~]
        OutputSigType16=Digital
        OutputCue17=[~UNUSED3~]
        OutputSigType17=Digital
        OutputCue18=[~UNUSED3~]
        OutputSigType18=Digital
        OutputCue19=[~UNUSED3~]
        OutputSigType19=Digital
        OutputCue20=[~UNUSED3~]
        OutputSigType20=Digital
        OutputCue21=[~UNUSED3~]
        OutputSigType21=Digital
        OutputCue22=[~UNUSED3~]
        OutputSigType22=Digital
        OutputCue23=[~UNUSED3~]
        OutputSigType23=Digital
        OutputCue24=[~UNUSED3~]
        OutputSigType24=Digital
        OutputCue25=[~UNUSED3~]
        OutputSigType25=Digital
        OutputCue26=[~UNUSED3~]
        OutputSigType26=Digital
        OutputCue27=[~UNUSED3~]
        OutputSigType27=Digital
        OutputCue28=[~UNUSED2~]
        OutputSigType28=Digital|Analog|Serial|String
        OutputCue2012=[~EndGroup~]Enable
        OutputSigType2012=Digital
        OutputCue2013=[~BeginGroup~]Visible
        OutputSigType2013=Digital
        OutputCue2014=[~UNUSED3~]
        OutputSigType2014=Digital
        OutputCue2015=[~UNUSED3~]
        OutputSigType2015=Digital
        OutputCue2016=[~UNUSED3~]
        OutputSigType2016=Digital
        OutputCue2017=[~UNUSED3~]
        OutputSigType2017=Digital
        OutputCue2018=[~UNUSED3~]
        OutputSigType2018=Digital
        OutputCue2019=[~UNUSED3~]
        OutputSigType2019=Digital
        OutputCue2020=[~UNUSED3~]
        OutputSigType2020=Digital
        OutputCue2021=[~UNUSED3~]
        OutputSigType2021=Digital
        OutputCue2022=[~UNUSED3~]
        OutputSigType2022=Digital
        OutputCue2023=[~UNUSED3~]
        OutputSigType2023=Digital
        OutputCue2024=[~UNUSED3~]
        OutputSigType2024=Digital
        OutputCue2025=[~UNUSED3~]
        OutputSigType2025=Digital
        OutputCue2026=[~UNUSED3~]
        OutputSigType2026=Digital
        OutputCue2027=[~UNUSED3~]
        OutputSigType2027=Digital
        OutputCue2028=[~UNUSED3~]
        OutputSigType2028=Digital
        OutputCue2029=[~UNUSED3~]
        OutputSigType2029=Digital
        OutputCue2030=[~UNUSED2~]
        OutputSigType2030=Digital|Analog|Serial|String
        OutputCue4014=[~EndGroup~]Visible
        OutputSigType4014=Digital
        OutputCue4015=[~BeginGroup~]Press
        OutputSigType4015=Digital
        OutputCue4016=press1
        OutputSigType4016=Digital
        OutputCue4017=press2
        OutputSigType4017=Digital
        OutputCue4018=press3
        OutputSigType4018=Digital
        OutputCue4019=press4
        OutputSigType4019=Digital
        OutputCue4020=press5
        OutputSigType4020=Digital
        OutputCue4021=press6
        OutputSigType4021=Digital
        OutputCue4022=press7
        OutputSigType4022=Digital
        OutputCue4023=press8
        OutputSigType4023=Digital
        OutputCue4024=press9
        OutputSigType4024=Digital
        OutputCue4025=press10
        OutputSigType4025=Digital
        OutputCue4026=press11
        OutputSigType4026=Digital
        OutputCue4027=press12
        OutputSigType4027=Digital
        OutputCue4028=press13
        OutputSigType4028=Digital
        OutputCue4029=press14
        OutputSigType4029=Digital
        OutputCue4030=press15
        OutputSigType4030=Digital
        OutputCue4031=press16
        OutputSigType4031=Digital
        OutputCue4032=[~EndGroup~]Press
        OutputSigType4032=Digital
        InputList2Cue1=[~UNUSED3~]
        InputList2SigType1=Analog
        InputList2Cue2=Scroll To Item
        InputList2SigType2=Analog
        InputList2Cue3=Set Number of Items
        InputList2SigType3=Analog
        InputList2Cue4=[~UNUSED2~]
        InputList2SigType4=Analog
        InputList2Cue5=[~UNUSED2~]
        InputList2SigType5=Analog
        InputList2Cue6=[~UNUSED2~]
        InputList2SigType6=Analog
        InputList2Cue7=[~UNUSED2~]
        InputList2SigType7=Analog
        InputList2Cue8=[~UNUSED2~]
        InputList2SigType8=Analog
        InputList2Cue9=[~UNUSED2~]
        InputList2SigType9=Analog
        InputList2Cue10=[~UNUSED2~]
        InputList2SigType10=Analog
        InputList2Cue11=[~BeginGroup~]an_fb
        InputList2SigType11=Analog
        InputList2Cue12=an_fb1
        InputList2SigType12=Analog
        InputList2Cue13=an_fb2
        InputList2SigType13=Analog
        InputList2Cue14=an_fb3
        InputList2SigType14=Analog
        InputList2Cue15=an_fb4
        InputList2SigType15=Analog
        InputList2Cue16=an_fb5
        InputList2SigType16=Analog
        InputList2Cue17=an_fb6
        InputList2SigType17=Analog
        InputList2Cue18=an_fb7
        InputList2SigType18=Analog
        InputList2Cue19=an_fb8
        InputList2SigType19=Analog
        InputList2Cue20=an_fb9
        InputList2SigType20=Analog
        InputList2Cue21=an_fb10
        InputList2SigType21=Analog
        InputList2Cue22=an_fb11
        InputList2SigType22=Analog
        InputList2Cue23=an_fb12
        InputList2SigType23=Analog
        InputList2Cue24=an_fb13
        InputList2SigType24=Analog
        InputList2Cue25=an_fb14
        InputList2SigType25=Analog
        InputList2Cue26=an_fb15
        InputList2SigType26=Analog
        InputList2Cue27=an_fb16
        InputList2SigType27=Analog
        InputList2Cue28=an_fb17
        InputList2SigType28=Analog
        InputList2Cue29=an_fb18
        InputList2SigType29=Analog
        InputList2Cue30=an_fb19
        InputList2SigType30=Analog
        InputList2Cue31=an_fb20
        InputList2SigType31=Analog
        InputList2Cue32=an_fb21
        InputList2SigType32=Analog
        InputList2Cue33=an_fb22
        InputList2SigType33=Analog
        InputList2Cue34=an_fb23
        InputList2SigType34=Analog
        InputList2Cue35=an_fb24
        InputList2SigType35=Analog
        InputList2Cue36=an_fb25
        InputList2SigType36=Analog
        InputList2Cue37=an_fb26
        InputList2SigType37=Analog
        InputList2Cue38=an_fb27
        InputList2SigType38=Analog
        InputList2Cue39=an_fb28
        InputList2SigType39=Analog
        InputList2Cue40=an_fb29
        InputList2SigType40=Analog
        InputList2Cue41=an_fb30
        InputList2SigType41=Analog
        InputList2Cue42=an_fb31
        InputList2SigType42=Analog
        InputList2Cue43=an_fb32
        InputList2SigType43=Analog
        InputList2Cue44=[~EndGroup~]an_fb
        InputList2SigType44=Analog
        OutputList2Cue1=Item Clicked
        OutputList2SigType1=Analog
        OutputList2Cue2=[~UNUSED3~]
        OutputList2SigType2=Analog
        OutputList2Cue3=[~UNUSED3~]
        OutputList2SigType3=Analog
        OutputList2Cue4=[~UNUSED2~]
        OutputList2SigType4=Analog
        OutputList2Cue5=[~UNUSED2~]
        OutputList2SigType5=Analog
        OutputList2Cue6=[~UNUSED2~]
        OutputList2SigType6=Analog
        OutputList2Cue7=[~UNUSED2~]
        OutputList2SigType7=Analog
        OutputList2Cue8=[~UNUSED2~]
        OutputList2SigType8=Analog
        OutputList2Cue9=[~UNUSED2~]
        OutputList2SigType9=Analog
        OutputList2Cue10=[~UNUSED2~]
        OutputList2SigType10=Analog
        OutputList2Cue11=[~BeginGroup~]an_act
        OutputList2SigType11=Analog
        OutputList2Cue12=an_act1
        OutputList2SigType12=Analog
        OutputList2Cue13=an_act2
        OutputList2SigType13=Analog
        OutputList2Cue14=an_act3
        OutputList2SigType14=Analog
        OutputList2Cue15=an_act4
        OutputList2SigType15=Analog
        OutputList2Cue16=an_act5
        OutputList2SigType16=Analog
        OutputList2Cue17=an_act6
        OutputList2SigType17=Analog
        OutputList2Cue18=an_act7
        OutputList2SigType18=Analog
        OutputList2Cue19=an_act8
        OutputList2SigType19=Analog
        OutputList2Cue20=an_act9
        OutputList2SigType20=Analog
        OutputList2Cue21=an_act10
        OutputList2SigType21=Analog
        OutputList2Cue22=an_act11
        OutputList2SigType22=Analog
        OutputList2Cue23=an_act12
        OutputList2SigType23=Analog
        OutputList2Cue24=an_act13
        OutputList2SigType24=Analog
        OutputList2Cue25=an_act14
        OutputList2SigType25=Analog
        OutputList2Cue26=an_act15
        OutputList2SigType26=Analog
        OutputList2Cue27=an_act16
        OutputList2SigType27=Analog
        OutputList2Cue28=an_act17
        OutputList2SigType28=Analog
        OutputList2Cue29=an_act18
        OutputList2SigType29=Analog
        OutputList2Cue30=an_act19
        OutputList2SigType30=Analog
        OutputList2Cue31=an_act20
        OutputList2SigType31=Analog
        OutputList2Cue32=an_act21
        OutputList2SigType32=Analog
        OutputList2Cue33=an_act22
        OutputList2SigType33=Analog
        OutputList2Cue34=an_act23
        OutputList2SigType34=Analog
        OutputList2Cue35=an_act24
        OutputList2SigType35=Analog
        OutputList2Cue36=an_act25
        OutputList2SigType36=Analog
        OutputList2Cue37=an_act26
        OutputList2SigType37=Analog
        OutputList2Cue38=an_act27
        OutputList2SigType38=Analog
        OutputList2Cue39=an_act28
        OutputList2SigType39=Analog
        OutputList2Cue40=an_act29
        OutputList2SigType40=Analog
        OutputList2Cue41=an_act30
        OutputList2SigType41=Analog
        OutputList2Cue42=an_act31
        OutputList2SigType42=Analog
        OutputList2Cue43=an_act32
        OutputList2SigType43=Analog
        OutputList2Cue44=[~EndGroup~]an_act
        OutputList2SigType44=Analog
        InputList3Cue1=[~UNUSED2~]
        InputList3SigType1=Serial
        InputList3Cue2=[~UNUSED2~]
        InputList3SigType2=Serial
        InputList3Cue3=[~UNUSED2~]
        InputList3SigType3=Serial
        InputList3Cue4=[~UNUSED2~]
        InputList3SigType4=Serial
        InputList3Cue5=[~UNUSED2~]
        InputList3SigType5=Serial
        InputList3Cue6=[~UNUSED2~]
        InputList3SigType6=Serial
        InputList3Cue7=[~UNUSED2~]
        InputList3SigType7=Serial
        InputList3Cue8=[~UNUSED2~]
        InputList3SigType8=Serial
        InputList3Cue9=[~UNUSED2~]
        InputList3SigType9=Serial
        InputList3Cue10=[~UNUSED2~]
        InputList3SigType10=Serial
        InputList3Cue11=[~BeginGroup~]text-o
        InputList3SigType11=Serial
        InputList3Cue12=text-o1
        InputList3SigType12=Serial
        InputList3Cue13=text-o2
        InputList3SigType13=Serial
        InputList3Cue14=text-o3
        InputList3SigType14=Serial
        InputList3Cue15=text-o4
        InputList3SigType15=Serial
        InputList3Cue16=text-o5
        InputList3SigType16=Serial
        InputList3Cue17=text-o6
        InputList3SigType17=Serial
        InputList3Cue18=text-o7
        InputList3SigType18=Serial
        InputList3Cue19=text-o8
        InputList3SigType19=Serial
        InputList3Cue20=text-o9
        InputList3SigType20=Serial
        InputList3Cue21=text-o10
        InputList3SigType21=Serial
        InputList3Cue22=text-o11
        InputList3SigType22=Serial
        InputList3Cue23=text-o12
        InputList3SigType23=Serial
        InputList3Cue24=text-o13
        InputList3SigType24=Serial
        InputList3Cue25=text-o14
        InputList3SigType25=Serial
        InputList3Cue26=text-o15
        InputList3SigType26=Serial
        InputList3Cue27=text-o16
        InputList3SigType27=Serial
        InputList3Cue28=[~EndGroup~]text-o
        InputList3SigType28=Serial
        OutputList3Cue1=[~UNUSED2~]
        OutputList3SigType1=Serial
        OutputList3Cue2=[~UNUSED2~]
        OutputList3SigType2=Serial
        OutputList3Cue3=[~UNUSED2~]
        OutputList3SigType3=Serial
        OutputList3Cue4=[~UNUSED2~]
        OutputList3SigType4=Serial
        OutputList3Cue5=[~UNUSED2~]
        OutputList3SigType5=Serial
        OutputList3Cue6=[~UNUSED2~]
        OutputList3SigType6=Serial
        OutputList3Cue7=[~UNUSED2~]
        OutputList3SigType7=Serial
        OutputList3Cue8=[~UNUSED2~]
        OutputList3SigType8=Serial
        OutputList3Cue9=[~UNUSED2~]
        OutputList3SigType9=Serial
        OutputList3Cue10=[~UNUSED2~]
        OutputList3SigType10=Serial
        OutputList3Cue11=[~BeginGroup~]text-i
        OutputList3SigType11=Serial
        OutputList3Cue12=text-i1
        OutputList3SigType12=Serial
        OutputList3Cue13=text-i2
        OutputList3SigType13=Serial
        OutputList3Cue14=text-i3
        OutputList3SigType14=Serial
        OutputList3Cue15=text-i4
        OutputList3SigType15=Serial
        OutputList3Cue16=text-i5
        OutputList3SigType16=Serial
        OutputList3Cue17=text-i6
        OutputList3SigType17=Serial
        OutputList3Cue18=text-i7
        OutputList3SigType18=Serial
        OutputList3Cue19=text-i8
        OutputList3SigType19=Serial
        OutputList3Cue20=text-i9
        OutputList3SigType20=Serial
        OutputList3Cue21=text-i10
        OutputList3SigType21=Serial
        OutputList3Cue22=text-i11
        OutputList3SigType22=Serial
        OutputList3Cue23=text-i12
        OutputList3SigType23=Serial
        OutputList3Cue24=text-i13
        OutputList3SigType24=Serial
        OutputList3Cue25=text-i14
        OutputList3SigType25=Serial
        OutputList3Cue26=text-i15
        OutputList3SigType26=Serial
        OutputList3Cue27=text-i16
        OutputList3SigType27=Serial
        OutputList3Cue28=[~EndGroup~]text-i
        OutputList3SigType28=Serial
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=6
        CedH=6
        SmartObjId=81d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=6
        Tp=1
        HD=TRUE
        DV=81d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=6
        Name=P301 TS 20170530_[26]Ratings_[Ratings]Received Ratings.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_[22]Temperature_[Temperature]Sample Data.ced
        Hint=[Temperature]Sample Data (Smart Object ID=40)
        Code=7
        SGControlType=Vertical Tab Button
        SGControlName=[Temperature]Sample Data
        GUID=FE409DFB-8C72-4048-92F8-C65192B019D7
        SmplCName=P301 TS 20170530_[22]Temperature_[Temperature]Sample Data.ced
        SMWRev=4.02.19
        Expand=expand_random
        HelpID=10074
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=10
        MaxVariableInputs=10
        MinVariableOutputs=10
        MaxVariableOutputs=10
        NumFixedParams=1
        MinVariableInputsList2=0
        MaxVariableInputsList2=0
        MinVariableOutputsList2=0
        MaxVariableOutputsList2=0
        MinVariableInputsList3=0
        MaxVariableInputsList3=0
        MinVariableOutputsList3=0
        MaxVariableOutputsList3=0
        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        OutputCue1=Tab Button 1 Press
        OutputSigType1=Digital
        InputCue2=Tab Button 1 Select
        InputSigType2=Digital
        OutputCue2=[~UNUSED3~]
        OutputSigType2=Digital
        InputCue3=[~UNUSED3~]
        InputSigType3=Digital
        OutputCue3=Tab Button 2 Press
        OutputSigType3=Digital
        InputCue4=Tab Button 2 Select
        InputSigType4=Digital
        OutputCue4=[~UNUSED3~]
        OutputSigType4=Digital
        InputCue5=[~UNUSED3~]
        InputSigType5=Digital
        OutputCue5=Tab Button 3 Press
        OutputSigType5=Digital
        InputCue6=Tab Button 3 Select
        InputSigType6=Digital
        OutputCue6=[~UNUSED3~]
        OutputSigType6=Digital
        InputCue7=[~UNUSED3~]
        InputSigType7=Digital
        OutputCue7=Tab Button 4 Press
        OutputSigType7=Digital
        InputCue8=Tab Button 4 Select
        InputSigType8=Digital
        OutputCue8=[~UNUSED3~]
        OutputSigType8=Digital
        InputCue9=[~UNUSED3~]
        InputSigType9=Digital
        OutputCue9=Tab Button 5 Press
        OutputSigType9=Digital
        InputCue10=Tab Button 5 Select
        InputSigType10=Digital
        OutputCue10=[~UNUSED3~]
        OutputSigType10=Digital
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=7
        CedH=7
        SmartObjId=40d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=7
        Tp=1
        HD=TRUE
        DV=40d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=7
        Name=P301 TS 20170530_[22]Temperature_[Temperature]Sample Data.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_[23]CD Jukebox_[Jukebox]Transport.ced
        Hint=[Jukebox]Transport (Smart Object ID=50)
        Code=8
        SGControlType=Horizontal Tab Button
        SGControlName=[Jukebox]Transport
        GUID=8819A2EF-6664-4310-B9C1-858AFF7AF585
        SmplCName=P301 TS 20170530_[23]CD Jukebox_[Jukebox]Transport.ced
        SMWRev=4.02.19
        Expand=expand_random
        HelpID=10031
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=8
        MaxVariableInputs=8
        MinVariableOutputs=8
        MaxVariableOutputs=8
        NumFixedParams=1
        MinVariableInputsList2=0
        MaxVariableInputsList2=0
        MinVariableOutputsList2=0
        MaxVariableOutputsList2=0
        MinVariableInputsList3=0
        MaxVariableInputsList3=0
        MinVariableOutputsList3=0
        MaxVariableOutputsList3=0
        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        OutputCue1=Tab Button 1 Press
        OutputSigType1=Digital
        InputCue2=Tab Button 1 Select
        InputSigType2=Digital
        OutputCue2=[~UNUSED3~]
        OutputSigType2=Digital
        InputCue3=[~UNUSED3~]
        InputSigType3=Digital
        OutputCue3=Tab Button 2 Press
        OutputSigType3=Digital
        InputCue4=Tab Button 2 Select
        InputSigType4=Digital
        OutputCue4=[~UNUSED3~]
        OutputSigType4=Digital
        InputCue5=[~UNUSED3~]
        InputSigType5=Digital
        OutputCue5=Tab Button 3 Press
        OutputSigType5=Digital
        InputCue6=Tab Button 3 Select
        InputSigType6=Digital
        OutputCue6=[~UNUSED3~]
        OutputSigType6=Digital
        InputCue7=[~UNUSED3~]
        InputSigType7=Digital
        OutputCue7=Tab Button 4 Press
        OutputSigType7=Digital
        InputCue8=Tab Button 4 Select
        InputSigType8=Digital
        OutputCue8=[~UNUSED3~]
        OutputSigType8=Digital
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=8
        CedH=8
        SmartObjId=50d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=8
        Tp=1
        HD=TRUE
        DV=50d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=8
        Name=P301 TS 20170530_[23]CD Jukebox_[Jukebox]Transport.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_[24]Projector Lamp Hours_[Projector]Lamp Hours Log.ced
        Hint=[Projector]Lamp Hours Log (Smart Object ID=60)
        Code=9
        SGControlType=Button List Vertical
        SGControlName=[Projector]Lamp Hours Log
        GUID=EFA62101-9472-4DE5-80D7-014E9368CA81
        SmplCName=P301 TS 20170530_[24]Projector Lamp Hours_[Projector]Lamp Hours Log.ced
        SMWRev=4.02.19
        Expand=expand_random
        HelpID=10009
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=10
        MaxVariableInputs=10
        MinVariableOutputs=10
        MaxVariableOutputs=10
        NumFixedParams=1
        MinVariableInputsList2=6
        MaxVariableInputsList2=6
        MinVariableOutputsList2=6
        MaxVariableOutputsList2=6
        MinVariableInputsList3=10
        MaxVariableInputsList3=10
        MinVariableOutputsList3=10
        MaxVariableOutputsList3=10
        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        OutputCue1=Item 1 Pressed
        OutputSigType1=Digital
        InputCue2=[~UNUSED3~]
        InputSigType2=Digital
        OutputCue2=Item 2 Pressed
        OutputSigType2=Digital
        InputCue3=[~UNUSED3~]
        InputSigType3=Digital
        OutputCue3=Item 3 Pressed
        OutputSigType3=Digital
        InputCue4=[~UNUSED3~]
        InputSigType4=Digital
        OutputCue4=Item 4 Pressed
        OutputSigType4=Digital
        InputCue5=[~UNUSED3~]
        InputSigType5=Digital
        OutputCue5=Item 5 Pressed
        OutputSigType5=Digital
        InputCue6=[~UNUSED3~]
        InputSigType6=Digital
        OutputCue6=Item 6 Pressed
        OutputSigType6=Digital
        InputCue7=[~UNUSED3~]
        InputSigType7=Digital
        OutputCue7=Item 7 Pressed
        OutputSigType7=Digital
        InputCue8=[~UNUSED3~]
        InputSigType8=Digital
        OutputCue8=Item 8 Pressed
        OutputSigType8=Digital
        InputCue9=[~UNUSED3~]
        InputSigType9=Digital
        OutputCue9=Item 9 Pressed
        OutputSigType9=Digital
        InputCue10=[~UNUSED3~]
        InputSigType10=Digital
        OutputCue10=Item 10 Pressed
        OutputSigType10=Digital
        InputList2Cue1=Select Item
        InputList2SigType1=Analog
        OutputList2Cue1=[~UNUSED3~]
        OutputList2SigType1=Analog
        InputList2Cue2=Deselect Item
        InputList2SigType2=Analog
        OutputList2Cue2=[~UNUSED3~]
        OutputList2SigType2=Analog
        InputList2Cue3=Scroll Item
        InputList2SigType3=Analog
        OutputList2Cue3=[~UNUSED3~]
        OutputList2SigType3=Analog
        InputList2Cue4=[~UNUSED3~]
        InputList2SigType4=Analog
        OutputList2Cue4=Item Clicked
        OutputList2SigType4=Analog
        InputList2Cue5=[~UNUSED3~]
        InputList2SigType5=Analog
        OutputList2Cue5=Item Held
        OutputList2SigType5=Analog
        InputList2Cue6=Set Num of Items
        InputList2SigType6=Analog
        OutputList2Cue6=[~UNUSED3~]
        OutputList2SigType6=Analog
        InputList3Cue1=Item 1 Text
        InputList3SigType1=Serial
        OutputList3Cue1=[~UNUSED3~]
        OutputList3SigType1=Serial
        InputList3Cue2=Item 2 Text
        InputList3SigType2=Serial
        OutputList3Cue2=[~UNUSED3~]
        OutputList3SigType2=Serial
        InputList3Cue3=Item 3 Text
        InputList3SigType3=Serial
        OutputList3Cue3=[~UNUSED3~]
        OutputList3SigType3=Serial
        InputList3Cue4=Item 4 Text
        InputList3SigType4=Serial
        OutputList3Cue4=[~UNUSED3~]
        OutputList3SigType4=Serial
        InputList3Cue5=Item 5 Text
        InputList3SigType5=Serial
        OutputList3Cue5=[~UNUSED3~]
        OutputList3SigType5=Serial
        InputList3Cue6=Item 6 Text
        InputList3SigType6=Serial
        OutputList3Cue6=[~UNUSED3~]
        OutputList3SigType6=Serial
        InputList3Cue7=Item 7 Text
        InputList3SigType7=Serial
        OutputList3Cue7=[~UNUSED3~]
        OutputList3SigType7=Serial
        InputList3Cue8=Item 8 Text
        InputList3SigType8=Serial
        OutputList3Cue8=[~UNUSED3~]
        OutputList3SigType8=Serial
        InputList3Cue9=Item 9 Text
        InputList3SigType9=Serial
        OutputList3Cue9=[~UNUSED3~]
        OutputList3SigType9=Serial
        InputList3Cue10=Item 10 Text
        InputList3SigType10=Serial
        OutputList3Cue10=[~UNUSED3~]
        OutputList3SigType10=Serial
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=9
        CedH=9
        SmartObjId=60d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=9
        Tp=1
        HD=TRUE
        DV=60d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=9
        Name=P301 TS 20170530_[24]Projector Lamp Hours_[Projector]Lamp Hours Log.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_[25]Sorting_[Sorting]Disordered List.ced
        Hint=[Sorting]Disordered List (Smart Object ID=70)
        Code=10
        SGControlType=Button List Vertical
        SGControlName=[Sorting]Disordered List
        GUID=B3CF0F4D-BB78-433A-8154-9CB150026F58
        SmplCName=P301 TS 20170530_[25]Sorting_[Sorting]Disordered List.ced
        SMWRev=4.02.19
        Expand=expand_random
        HelpID=10009
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=10
        MaxVariableInputs=10
        MinVariableOutputs=10
        MaxVariableOutputs=10
        NumFixedParams=1
        MinVariableInputsList2=6
        MaxVariableInputsList2=6
        MinVariableOutputsList2=6
        MaxVariableOutputsList2=6
        MinVariableInputsList3=10
        MaxVariableInputsList3=10
        MinVariableOutputsList3=10
        MaxVariableOutputsList3=10
        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        OutputCue1=Item 1 Pressed
        OutputSigType1=Digital
        InputCue2=[~UNUSED3~]
        InputSigType2=Digital
        OutputCue2=Item 2 Pressed
        OutputSigType2=Digital
        InputCue3=[~UNUSED3~]
        InputSigType3=Digital
        OutputCue3=Item 3 Pressed
        OutputSigType3=Digital
        InputCue4=[~UNUSED3~]
        InputSigType4=Digital
        OutputCue4=Item 4 Pressed
        OutputSigType4=Digital
        InputCue5=[~UNUSED3~]
        InputSigType5=Digital
        OutputCue5=Item 5 Pressed
        OutputSigType5=Digital
        InputCue6=[~UNUSED3~]
        InputSigType6=Digital
        OutputCue6=Item 6 Pressed
        OutputSigType6=Digital
        InputCue7=[~UNUSED3~]
        InputSigType7=Digital
        OutputCue7=Item 7 Pressed
        OutputSigType7=Digital
        InputCue8=[~UNUSED3~]
        InputSigType8=Digital
        OutputCue8=Item 8 Pressed
        OutputSigType8=Digital
        InputCue9=[~UNUSED3~]
        InputSigType9=Digital
        OutputCue9=Item 9 Pressed
        OutputSigType9=Digital
        InputCue10=[~UNUSED3~]
        InputSigType10=Digital
        OutputCue10=Item 10 Pressed
        OutputSigType10=Digital
        InputList2Cue1=Select Item
        InputList2SigType1=Analog
        OutputList2Cue1=[~UNUSED3~]
        OutputList2SigType1=Analog
        InputList2Cue2=Deselect Item
        InputList2SigType2=Analog
        OutputList2Cue2=[~UNUSED3~]
        OutputList2SigType2=Analog
        InputList2Cue3=Scroll Item
        InputList2SigType3=Analog
        OutputList2Cue3=[~UNUSED3~]
        OutputList2SigType3=Analog
        InputList2Cue4=[~UNUSED3~]
        InputList2SigType4=Analog
        OutputList2Cue4=Item Clicked
        OutputList2SigType4=Analog
        InputList2Cue5=[~UNUSED3~]
        InputList2SigType5=Analog
        OutputList2Cue5=Item Held
        OutputList2SigType5=Analog
        InputList2Cue6=Set Num of Items
        InputList2SigType6=Analog
        OutputList2Cue6=[~UNUSED3~]
        OutputList2SigType6=Analog
        InputList3Cue1=Item 1 Text
        InputList3SigType1=Serial
        OutputList3Cue1=[~UNUSED3~]
        OutputList3SigType1=Serial
        InputList3Cue2=Item 2 Text
        InputList3SigType2=Serial
        OutputList3Cue2=[~UNUSED3~]
        OutputList3SigType2=Serial
        InputList3Cue3=Item 3 Text
        InputList3SigType3=Serial
        OutputList3Cue3=[~UNUSED3~]
        OutputList3SigType3=Serial
        InputList3Cue4=Item 4 Text
        InputList3SigType4=Serial
        OutputList3Cue4=[~UNUSED3~]
        OutputList3SigType4=Serial
        InputList3Cue5=Item 5 Text
        InputList3SigType5=Serial
        OutputList3Cue5=[~UNUSED3~]
        OutputList3SigType5=Serial
        InputList3Cue6=Item 6 Text
        InputList3SigType6=Serial
        OutputList3Cue6=[~UNUSED3~]
        OutputList3SigType6=Serial
        InputList3Cue7=Item 7 Text
        InputList3SigType7=Serial
        OutputList3Cue7=[~UNUSED3~]
        OutputList3SigType7=Serial
        InputList3Cue8=Item 8 Text
        InputList3SigType8=Serial
        OutputList3Cue8=[~UNUSED3~]
        OutputList3SigType8=Serial
        InputList3Cue9=Item 9 Text
        InputList3SigType9=Serial
        OutputList3Cue9=[~UNUSED3~]
        OutputList3SigType9=Serial
        InputList3Cue10=Item 10 Text
        InputList3SigType10=Serial
        OutputList3Cue10=[~UNUSED3~]
        OutputList3SigType10=Serial
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=10
        CedH=10
        SmartObjId=70d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=10
        Tp=1
        HD=TRUE
        DV=70d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=10
        Name=P301 TS 20170530_[25]Sorting_[Sorting]Disordered List.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_[25]Sorting_[Sorting]Sorted List.ced
        Hint=[Sorting]Sorted List (Smart Object ID=71)
        Code=11
        SGControlType=Button List Vertical
        SGControlName=[Sorting]Sorted List
        GUID=673C70C8-6D0A-4864-8FA3-11DE432FD20B
        SmplCName=P301 TS 20170530_[25]Sorting_[Sorting]Sorted List.ced
        SMWRev=4.02.19
        Expand=expand_random
        HelpID=10009
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=10
        MaxVariableInputs=10
        MinVariableOutputs=10
        MaxVariableOutputs=10
        NumFixedParams=1
        MinVariableInputsList2=6
        MaxVariableInputsList2=6
        MinVariableOutputsList2=6
        MaxVariableOutputsList2=6
        MinVariableInputsList3=10
        MaxVariableInputsList3=10
        MinVariableOutputsList3=10
        MaxVariableOutputsList3=10
        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        OutputCue1=Item 1 Pressed
        OutputSigType1=Digital
        InputCue2=[~UNUSED3~]
        InputSigType2=Digital
        OutputCue2=Item 2 Pressed
        OutputSigType2=Digital
        InputCue3=[~UNUSED3~]
        InputSigType3=Digital
        OutputCue3=Item 3 Pressed
        OutputSigType3=Digital
        InputCue4=[~UNUSED3~]
        InputSigType4=Digital
        OutputCue4=Item 4 Pressed
        OutputSigType4=Digital
        InputCue5=[~UNUSED3~]
        InputSigType5=Digital
        OutputCue5=Item 5 Pressed
        OutputSigType5=Digital
        InputCue6=[~UNUSED3~]
        InputSigType6=Digital
        OutputCue6=Item 6 Pressed
        OutputSigType6=Digital
        InputCue7=[~UNUSED3~]
        InputSigType7=Digital
        OutputCue7=Item 7 Pressed
        OutputSigType7=Digital
        InputCue8=[~UNUSED3~]
        InputSigType8=Digital
        OutputCue8=Item 8 Pressed
        OutputSigType8=Digital
        InputCue9=[~UNUSED3~]
        InputSigType9=Digital
        OutputCue9=Item 9 Pressed
        OutputSigType9=Digital
        InputCue10=[~UNUSED3~]
        InputSigType10=Digital
        OutputCue10=Item 10 Pressed
        OutputSigType10=Digital
        InputList2Cue1=Select Item
        InputList2SigType1=Analog
        OutputList2Cue1=[~UNUSED3~]
        OutputList2SigType1=Analog
        InputList2Cue2=Deselect Item
        InputList2SigType2=Analog
        OutputList2Cue2=[~UNUSED3~]
        OutputList2SigType2=Analog
        InputList2Cue3=Scroll Item
        InputList2SigType3=Analog
        OutputList2Cue3=[~UNUSED3~]
        OutputList2SigType3=Analog
        InputList2Cue4=[~UNUSED3~]
        InputList2SigType4=Analog
        OutputList2Cue4=Item Clicked
        OutputList2SigType4=Analog
        InputList2Cue5=[~UNUSED3~]
        InputList2SigType5=Analog
        OutputList2Cue5=Item Held
        OutputList2SigType5=Analog
        InputList2Cue6=Set Num of Items
        InputList2SigType6=Analog
        OutputList2Cue6=[~UNUSED3~]
        OutputList2SigType6=Analog
        InputList3Cue1=Item 1 Text
        InputList3SigType1=Serial
        OutputList3Cue1=[~UNUSED3~]
        OutputList3SigType1=Serial
        InputList3Cue2=Item 2 Text
        InputList3SigType2=Serial
        OutputList3Cue2=[~UNUSED3~]
        OutputList3SigType2=Serial
        InputList3Cue3=Item 3 Text
        InputList3SigType3=Serial
        OutputList3Cue3=[~UNUSED3~]
        OutputList3SigType3=Serial
        InputList3Cue4=Item 4 Text
        InputList3SigType4=Serial
        OutputList3Cue4=[~UNUSED3~]
        OutputList3SigType4=Serial
        InputList3Cue5=Item 5 Text
        InputList3SigType5=Serial
        OutputList3Cue5=[~UNUSED3~]
        OutputList3SigType5=Serial
        InputList3Cue6=Item 6 Text
        InputList3SigType6=Serial
        OutputList3Cue6=[~UNUSED3~]
        OutputList3SigType6=Serial
        InputList3Cue7=Item 7 Text
        InputList3SigType7=Serial
        OutputList3Cue7=[~UNUSED3~]
        OutputList3SigType7=Serial
        InputList3Cue8=Item 8 Text
        InputList3SigType8=Serial
        OutputList3Cue8=[~UNUSED3~]
        OutputList3SigType8=Serial
        InputList3Cue9=Item 9 Text
        InputList3SigType9=Serial
        OutputList3Cue9=[~UNUSED3~]
        OutputList3SigType9=Serial
        InputList3Cue10=Item 10 Text
        InputList3SigType10=Serial
        OutputList3Cue10=[~UNUSED3~]
        OutputList3SigType10=Serial
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=11
        CedH=11
        SmartObjId=71d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=11
        Tp=1
        HD=TRUE
        DV=71d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=11
        Name=P301 TS 20170530_[25]Sorting_[Sorting]Sorted List.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_[27]SIMPLSharp_[SIMPL#]Sample Data.ced
        Hint=[SIMPL#]Sample Data (Smart Object ID=92)
        Code=12
        SGControlType=Vertical Tab Button
        SGControlName=[SIMPL#]Sample Data
        GUID=5421739E-2B1C-47A0-B308-B70D25CC6FF6
        SmplCName=P301 TS 20170530_[27]SIMPLSharp_[SIMPL#]Sample Data.ced
        SMWRev=4.02.19
        Expand=expand_random
        HelpID=10074
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=6
        MaxVariableInputs=6
        MinVariableOutputs=6
        MaxVariableOutputs=6
        NumFixedParams=1
        MinVariableInputsList2=0
        MaxVariableInputsList2=0
        MinVariableOutputsList2=0
        MaxVariableOutputsList2=0
        MinVariableInputsList3=0
        MaxVariableInputsList3=0
        MinVariableOutputsList3=0
        MaxVariableOutputsList3=0
        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        OutputCue1=Tab Button 1 Press
        OutputSigType1=Digital
        InputCue2=Tab Button 1 Select
        InputSigType2=Digital
        OutputCue2=[~UNUSED3~]
        OutputSigType2=Digital
        InputCue3=[~UNUSED3~]
        InputSigType3=Digital
        OutputCue3=Tab Button 2 Press
        OutputSigType3=Digital
        InputCue4=Tab Button 2 Select
        InputSigType4=Digital
        OutputCue4=[~UNUSED3~]
        OutputSigType4=Digital
        InputCue5=[~UNUSED3~]
        InputSigType5=Digital
        OutputCue5=Tab Button 3 Press
        OutputSigType5=Digital
        InputCue6=Tab Button 3 Select
        InputSigType6=Digital
        OutputCue6=[~UNUSED3~]
        OutputSigType6=Digital
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=12
        CedH=12
        SmartObjId=92d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=12
        Tp=1
        HD=TRUE
        DV=92d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=12
        Name=P301 TS 20170530_[27]SIMPLSharp_[SIMPL#]Sample Data.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ;================================================================================
        [
        ObjTp=Symbol
        Name=P301 TS 20170530_[27]SIMPLSharp_[SIMPL#]Connect_Disconnect.ced
        Hint=[SIMPL#]Connect/Disconnect (Smart Object ID=91)
        Code=13
        SGControlType=Vertical Tab Button
        SGControlName=[SIMPL#]Connect/Disconnect
        GUID=F760133F-DE34-41DD-A1FB-F9B0E4E06663
        SmplCName=P301 TS 20170530_[27]SIMPLSharp_[SIMPL#]Connect_Disconnect.ced
        SMWRev=4.02.19
        Expand=expand_random
        HelpID=10074
        ;Define the number of inputs, outputs and parameters
        MinVariableInputs=4
        MaxVariableInputs=4
        MinVariableOutputs=4
        MaxVariableOutputs=4
        NumFixedParams=1
        MinVariableInputsList2=0
        MaxVariableInputsList2=0
        MinVariableOutputsList2=0
        MaxVariableOutputsList2=0
        MinVariableInputsList3=0
        MaxVariableInputsList3=0
        MinVariableOutputsList3=0
        MaxVariableOutputsList3=0
        ;Define the cues, and signal types  each input, output and parameter.
        InputCue1=[~UNUSED3~]
        InputSigType1=Digital
        OutputCue1=Tab Button 1 Press
        OutputSigType1=Digital
        InputCue2=Tab Button 1 Select
        InputSigType2=Digital
        OutputCue2=[~UNUSED3~]
        OutputSigType2=Digital
        InputCue3=[~UNUSED3~]
        InputSigType3=Digital
        OutputCue3=Tab Button 2 Press
        OutputSigType3=Digital
        InputCue4=Tab Button 2 Select
        InputSigType4=Digital
        OutputCue4=[~UNUSED3~]
        OutputSigType4=Digital
        ParamCue1=SmartObjectId
        ParamSigType1=Constant
        MPp=1
        Pp1=13
        CedH=13
        SmartObjId=91d
        ]
        ; Parameter Properties for Smart Object ID
        [
        ObjTp=Dp
        H=13
        Tp=1
        HD=TRUE
        DV=91d
        NF=1
        DNF=1
        EncFmt=0
        DVLF=1
        Sgn=0
        ]
        ; Smart Objects Definition section
        [
        ObjTp=CED
        H=13
        Name=P301 TS 20170530_[27]SIMPLSharp_[SIMPL#]Connect_Disconnect.ced
        ;Cedver is the version of the Smart Graphics control, not the CED file format.
        ;If the control definition changes, increment this.
        CedVer=1
        ]
        ";
        #endregion

        #region Data Set 3
        string data3 = @"[
            ObjTp=FSgntr
            Sgntr=SGD
            RelVrs=3
            VTProeVer=6.2.00
            Schema=1
            CRCGUID=FF4BAAA8-A34F-421C-9ED5-66657FC68DA0
            ]
            ;================================================================================
            [
            ObjTp=Hd
            ProjectFile=CTI-P201 2014-10-07.vtp
            VtpGuid=82263589-D8C6-40E8-9F8D-EDDE1D039ED9
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_0 Header_Device Select.ced
            Hint=Device Select (Smart Object ID=1)
            Code=1
            SGControlType=Icon List Horizontal
            SGControlName=Device Select
            GUID=F3EEEE39-3576-4F1C-8211-29B79B1DBE36
            SmplCName=CTI-P201 2014-10-07_0 Header_Device Select.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10032
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=10
            MaxVariableInputs=10
            MinVariableOutputs=10
            MaxVariableOutputs=10
            NumFixedParams=1
            MinVariableInputsList2=6
            MaxVariableInputsList2=6
            MinVariableOutputsList2=6
            MaxVariableOutputsList2=6
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Item 1 Pressed
            OutputSigType1=Digital
            InputCue2=[~UNUSED3~]
            InputSigType2=Digital
            OutputCue2=Item 2 Pressed
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Item 3 Pressed
            OutputSigType3=Digital
            InputCue4=[~UNUSED3~]
            InputSigType4=Digital
            OutputCue4=Item 4 Pressed
            OutputSigType4=Digital
            InputCue5=[~UNUSED3~]
            InputSigType5=Digital
            OutputCue5=Item 5 Pressed
            OutputSigType5=Digital
            InputCue6=[~UNUSED3~]
            InputSigType6=Digital
            OutputCue6=Item 6 Pressed
            OutputSigType6=Digital
            InputCue7=[~UNUSED3~]
            InputSigType7=Digital
            OutputCue7=Item 7 Pressed
            OutputSigType7=Digital
            InputCue8=[~UNUSED3~]
            InputSigType8=Digital
            OutputCue8=Item 8 Pressed
            OutputSigType8=Digital
            InputCue9=[~UNUSED3~]
            InputSigType9=Digital
            OutputCue9=Item 9 Pressed
            OutputSigType9=Digital
            InputCue10=[~UNUSED3~]
            InputSigType10=Digital
            OutputCue10=Item 10 Pressed
            OutputSigType10=Digital
            InputList2Cue1=Select Item
            InputList2SigType1=Analog
            OutputList2Cue1=[~UNUSED3~]
            OutputList2SigType1=Analog
            InputList2Cue2=Deselect Item
            InputList2SigType2=Analog
            OutputList2Cue2=[~UNUSED3~]
            OutputList2SigType2=Analog
            InputList2Cue3=Scroll Item
            InputList2SigType3=Analog
            OutputList2Cue3=[~UNUSED3~]
            OutputList2SigType3=Analog
            InputList2Cue4=[~UNUSED3~]
            InputList2SigType4=Analog
            OutputList2Cue4=Item Clicked
            OutputList2SigType4=Analog
            InputList2Cue5=[~UNUSED3~]
            InputList2SigType5=Analog
            OutputList2Cue5=Item Held
            OutputList2SigType5=Analog
            InputList2Cue6=Set Num of Items
            InputList2SigType6=Analog
            OutputList2Cue6=[~UNUSED3~]
            OutputList2SigType6=Analog
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=1
            CedH=1
            SmartObjId=1d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=1
            Tp=1
            HD=TRUE
            DV=1d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=1
            Name=CTI-P201 2014-10-07_0 Header_Device Select.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_002 Switcher_Switcher Destination.ced
            Hint=Switcher Destination (Smart Object ID=4)
            Code=2
            SGControlType=Vertical Tab Button
            SGControlName=Switcher Destination
            GUID=4333BE18-4553-4AC0-B1C0-B3AE4405F4F7
            SmplCName=CTI-P201 2014-10-07_002 Switcher_Switcher Destination.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=8
            MaxVariableInputs=8
            MinVariableOutputs=8
            MaxVariableOutputs=8
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            InputCue5=[~UNUSED3~]
            InputSigType5=Digital
            OutputCue5=Tab Button 3 Press
            OutputSigType5=Digital
            InputCue6=Tab Button 3 Select
            InputSigType6=Digital
            OutputCue6=[~UNUSED3~]
            OutputSigType6=Digital
            InputCue7=[~UNUSED3~]
            InputSigType7=Digital
            OutputCue7=Tab Button 4 Press
            OutputSigType7=Digital
            InputCue8=Tab Button 4 Select
            InputSigType8=Digital
            OutputCue8=[~UNUSED3~]
            OutputSigType8=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=2
            CedH=2
            SmartObjId=4d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=2
            Tp=1
            HD=TRUE
            DV=4d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=2
            Name=CTI-P201 2014-10-07_002 Switcher_Switcher Destination.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_002 Switcher_Switcher Sources.ced
            Hint=Switcher Sources (Smart Object ID=2)
            Code=3
            SGControlType=Vertical Tab Button
            SGControlName=Switcher Sources
            GUID=5FF3931E-B830-40B1-9F04-503A32A3F197
            SmplCName=CTI-P201 2014-10-07_002 Switcher_Switcher Sources.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=10
            MaxVariableInputs=10
            MinVariableOutputs=10
            MaxVariableOutputs=10
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            InputCue5=[~UNUSED3~]
            InputSigType5=Digital
            OutputCue5=Tab Button 3 Press
            OutputSigType5=Digital
            InputCue6=Tab Button 3 Select
            InputSigType6=Digital
            OutputCue6=[~UNUSED3~]
            OutputSigType6=Digital
            InputCue7=[~UNUSED3~]
            InputSigType7=Digital
            OutputCue7=Tab Button 4 Press
            OutputSigType7=Digital
            InputCue8=Tab Button 4 Select
            InputSigType8=Digital
            OutputCue8=[~UNUSED3~]
            OutputSigType8=Digital
            InputCue9=[~UNUSED3~]
            InputSigType9=Digital
            OutputCue9=Tab Button 5 Press
            OutputSigType9=Digital
            InputCue10=Tab Button 5 Select
            InputSigType10=Digital
            OutputCue10=[~UNUSED3~]
            OutputSigType10=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=3
            CedH=3
            SmartObjId=2d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=3
            Tp=1
            HD=TRUE
            DV=2d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=3
            Name=CTI-P201 2014-10-07_002 Switcher_Switcher Sources.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_002 Switcher_Switcher Type.ced
            Hint=Switcher Type (Smart Object ID=3)
            Code=4
            SGControlType=Vertical Tab Button
            SGControlName=Switcher Type
            GUID=267DB3A8-D373-44DD-BDC3-A8FC4204ABCD
            SmplCName=CTI-P201 2014-10-07_002 Switcher_Switcher Type.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=6
            MaxVariableInputs=6
            MinVariableOutputs=6
            MaxVariableOutputs=6
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            InputCue5=[~UNUSED3~]
            InputSigType5=Digital
            OutputCue5=Tab Button 3 Press
            OutputSigType5=Digital
            InputCue6=Tab Button 3 Select
            InputSigType6=Digital
            OutputCue6=[~UNUSED3~]
            OutputSigType6=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=4
            CedH=4
            SmartObjId=3d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=4
            Tp=1
            HD=TRUE
            DV=3d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=4
            Name=CTI-P201 2014-10-07_002 Switcher_Switcher Type.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_003 Satellite_Simple Keypad.ced
            Hint=Simple Keypad (Smart Object ID=5)
            Code=5
            SGControlType=Simple Keypad
            SGControlName=Simple Keypad
            GUID=535C6BB1-5C4A-4968-B043-891B485C1FD1
            SmplCName=CTI-P201 2014-10-07_003 Satellite_Simple Keypad.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10061
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=12
            MaxVariableInputs=12
            MinVariableOutputs=12
            MaxVariableOutputs=12
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=1
            OutputSigType1=Digital
            InputCue2=[~UNUSED3~]
            InputSigType2=Digital
            OutputCue2=2
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=3
            OutputSigType3=Digital
            InputCue4=[~UNUSED3~]
            InputSigType4=Digital
            OutputCue4=4
            OutputSigType4=Digital
            InputCue5=[~UNUSED3~]
            InputSigType5=Digital
            OutputCue5=5
            OutputSigType5=Digital
            InputCue6=[~UNUSED3~]
            InputSigType6=Digital
            OutputCue6=6
            OutputSigType6=Digital
            InputCue7=[~UNUSED3~]
            InputSigType7=Digital
            OutputCue7=7
            OutputSigType7=Digital
            InputCue8=[~UNUSED3~]
            InputSigType8=Digital
            OutputCue8=8
            OutputSigType8=Digital
            InputCue9=[~UNUSED3~]
            InputSigType9=Digital
            OutputCue9=9
            OutputSigType9=Digital
            InputCue10=[~UNUSED3~]
            InputSigType10=Digital
            OutputCue10=0
            OutputSigType10=Digital
            InputCue11=[~UNUSED3~]
            InputSigType11=Digital
            OutputCue11=Clear
            OutputSigType11=Digital
            InputCue12=[~UNUSED3~]
            InputSigType12=Digital
            OutputCue12=Enter
            OutputSigType12=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=5
            CedH=5
            SmartObjId=5d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=5
            Tp=1
            HD=TRUE
            DV=5d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=5
            Name=CTI-P201 2014-10-07_003 Satellite_Simple Keypad.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_003 Satellite_Volume Controls.ced
            Hint=Volume Controls (Smart Object ID=7)
            Code=6
            SGControlType=Vertical Tab Button
            SGControlName=Volume Controls
            GUID=BFCA9102-4CEA-46C5-AF74-0BA7AEC692AD
            SmplCName=CTI-P201 2014-10-07_003 Satellite_Volume Controls.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=6
            MaxVariableInputs=6
            MinVariableOutputs=6
            MaxVariableOutputs=6
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            InputCue5=[~UNUSED3~]
            InputSigType5=Digital
            OutputCue5=Tab Button 3 Press
            OutputSigType5=Digital
            InputCue6=Tab Button 3 Select
            InputSigType6=Digital
            OutputCue6=[~UNUSED3~]
            OutputSigType6=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=6
            CedH=6
            SmartObjId=7d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=6
            Tp=1
            HD=TRUE
            DV=7d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=6
            Name=CTI-P201 2014-10-07_003 Satellite_Volume Controls.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_003 Satellite_Satellite Presets.ced
            Hint=Satellite Presets (Smart Object ID=6)
            Code=7
            SGControlType=Button List Horizontal
            SGControlName=Satellite Presets
            GUID=03E5E956-F0B4-4D0F-B5E8-7BD0164CCFD3
            SmplCName=CTI-P201 2014-10-07_003 Satellite_Satellite Presets.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10008
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=6
            MaxVariableInputs=6
            MinVariableOutputs=6
            MaxVariableOutputs=6
            NumFixedParams=1
            MinVariableInputsList2=6
            MaxVariableInputsList2=6
            MinVariableOutputsList2=6
            MaxVariableOutputsList2=6
            MinVariableInputsList3=6
            MaxVariableInputsList3=6
            MinVariableOutputsList3=6
            MaxVariableOutputsList3=6
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Item 1 Pressed
            OutputSigType1=Digital
            InputCue2=[~UNUSED3~]
            InputSigType2=Digital
            OutputCue2=Item 2 Pressed
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Item 3 Pressed
            OutputSigType3=Digital
            InputCue4=[~UNUSED3~]
            InputSigType4=Digital
            OutputCue4=Item 4 Pressed
            OutputSigType4=Digital
            InputCue5=[~UNUSED3~]
            InputSigType5=Digital
            OutputCue5=Item 5 Pressed
            OutputSigType5=Digital
            InputCue6=[~UNUSED3~]
            InputSigType6=Digital
            OutputCue6=Item 6 Pressed
            OutputSigType6=Digital
            InputList2Cue1=Select Item
            InputList2SigType1=Analog
            OutputList2Cue1=[~UNUSED3~]
            OutputList2SigType1=Analog
            InputList2Cue2=Deselect Item
            InputList2SigType2=Analog
            OutputList2Cue2=[~UNUSED3~]
            OutputList2SigType2=Analog
            InputList2Cue3=Scroll Item
            InputList2SigType3=Analog
            OutputList2Cue3=[~UNUSED3~]
            OutputList2SigType3=Analog
            InputList2Cue4=[~UNUSED3~]
            InputList2SigType4=Analog
            OutputList2Cue4=Item Clicked
            OutputList2SigType4=Analog
            InputList2Cue5=[~UNUSED3~]
            InputList2SigType5=Analog
            OutputList2Cue5=Item Held
            OutputList2SigType5=Analog
            InputList2Cue6=Set Num of Items
            InputList2SigType6=Analog
            OutputList2Cue6=[~UNUSED3~]
            OutputList2SigType6=Analog
            InputList3Cue1=Item 1 Text
            InputList3SigType1=Serial
            OutputList3Cue1=[~UNUSED3~]
            OutputList3SigType1=Serial
            InputList3Cue2=Item 2 Text
            InputList3SigType2=Serial
            OutputList3Cue2=[~UNUSED3~]
            OutputList3SigType2=Serial
            InputList3Cue3=Item 3 Text
            InputList3SigType3=Serial
            OutputList3Cue3=[~UNUSED3~]
            OutputList3SigType3=Serial
            InputList3Cue4=Item 4 Text
            InputList3SigType4=Serial
            OutputList3Cue4=[~UNUSED3~]
            OutputList3SigType4=Serial
            InputList3Cue5=Item 5 Text
            InputList3SigType5=Serial
            OutputList3Cue5=[~UNUSED3~]
            OutputList3SigType5=Serial
            InputList3Cue6=Item 6 Text
            InputList3SigType6=Serial
            OutputList3Cue6=[~UNUSED3~]
            OutputList3SigType6=Serial
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=7
            CedH=7
            SmartObjId=6d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=7
            Tp=1
            HD=TRUE
            DV=6d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=7
            Name=CTI-P201 2014-10-07_003 Satellite_Satellite Presets.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_004 CD Jukebox_CD Transports.ced
            Hint=CD Transports (Smart Object ID=8)
            Code=8
            SGControlType=Horizontal Tab Button
            SGControlName=CD Transports
            GUID=91EC65E8-D1F8-41F7-AF49-0CCDBFD0613A
            SmplCName=CTI-P201 2014-10-07_004 CD Jukebox_CD Transports.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10031
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=14
            MaxVariableInputs=14
            MinVariableOutputs=14
            MaxVariableOutputs=14
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            InputCue5=[~UNUSED3~]
            InputSigType5=Digital
            OutputCue5=Tab Button 3 Press
            OutputSigType5=Digital
            InputCue6=Tab Button 3 Select
            InputSigType6=Digital
            OutputCue6=[~UNUSED3~]
            OutputSigType6=Digital
            InputCue7=[~UNUSED3~]
            InputSigType7=Digital
            OutputCue7=Tab Button 4 Press
            OutputSigType7=Digital
            InputCue8=Tab Button 4 Select
            InputSigType8=Digital
            OutputCue8=[~UNUSED3~]
            OutputSigType8=Digital
            InputCue9=[~UNUSED3~]
            InputSigType9=Digital
            OutputCue9=Tab Button 5 Press
            OutputSigType9=Digital
            InputCue10=Tab Button 5 Select
            InputSigType10=Digital
            OutputCue10=[~UNUSED3~]
            OutputSigType10=Digital
            InputCue11=[~UNUSED3~]
            InputSigType11=Digital
            OutputCue11=Tab Button 6 Press
            OutputSigType11=Digital
            InputCue12=Tab Button 6 Select
            InputSigType12=Digital
            OutputCue12=[~UNUSED3~]
            OutputSigType12=Digital
            InputCue13=[~UNUSED3~]
            InputSigType13=Digital
            OutputCue13=Tab Button 7 Press
            OutputSigType13=Digital
            InputCue14=Tab Button 7 Select
            InputSigType14=Digital
            OutputCue14=[~UNUSED3~]
            OutputSigType14=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=8
            CedH=8
            SmartObjId=8d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=8
            Tp=1
            HD=TRUE
            DV=8d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=8
            Name=CTI-P201 2014-10-07_004 CD Jukebox_CD Transports.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zones 1 - 4.ced
            Hint=Local Zones 1 - 4 (Smart Object ID=24)
            Code=9
            SGControlType=Horizontal Tab Button
            SGControlName=Local Zones 1 - 4
            GUID=580BF39F-120F-4A4E-BD31-0CB93BBFD020
            SmplCName=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zones 1 - 4.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10031
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=4
            MaxVariableInputs=4
            MinVariableOutputs=4
            MaxVariableOutputs=4
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=9
            CedH=9
            SmartObjId=24d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=9
            Tp=1
            HD=TRUE
            DV=24d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=9
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zones 1 - 4.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zone 1.ced
            Hint=Local Zone 1 (Smart Object ID=9)
            Code=10
            SGControlType=Vertical Tab Button
            SGControlName=Local Zone 1
            GUID=624140A8-C060-4606-BE98-F5E67DEC0035
            SmplCName=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zone 1.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=4
            MaxVariableInputs=4
            MinVariableOutputs=4
            MaxVariableOutputs=4
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=10
            CedH=10
            SmartObjId=9d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=10
            Tp=1
            HD=TRUE
            DV=9d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=10
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zone 1.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zone 2.ced
            Hint=Local Zone 2 (Smart Object ID=10)
            Code=11
            SGControlType=Vertical Tab Button
            SGControlName=Local Zone 2
            GUID=DF96E866-4F34-4416-B256-AF2851536083
            SmplCName=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zone 2.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=4
            MaxVariableInputs=4
            MinVariableOutputs=4
            MaxVariableOutputs=4
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=11
            CedH=11
            SmartObjId=10d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=11
            Tp=1
            HD=TRUE
            DV=10d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=11
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zone 2.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zone 3.ced
            Hint=Local Zone 3 (Smart Object ID=11)
            Code=12
            SGControlType=Vertical Tab Button
            SGControlName=Local Zone 3
            GUID=3DA9AEB6-923D-4BD8-A503-7E281F3CDC24
            SmplCName=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zone 3.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=4
            MaxVariableInputs=4
            MinVariableOutputs=4
            MaxVariableOutputs=4
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=12
            CedH=12
            SmartObjId=11d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=12
            Tp=1
            HD=TRUE
            DV=11d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=12
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zone 3.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zone 4.ced
            Hint=Local Zone 4 (Smart Object ID=12)
            Code=13
            SGControlType=Vertical Tab Button
            SGControlName=Local Zone 4
            GUID=4E4E73F2-57AB-4ADE-8E1E-B5DAC3E53215
            SmplCName=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zone 4.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=4
            MaxVariableInputs=4
            MinVariableOutputs=4
            MaxVariableOutputs=4
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=13
            CedH=13
            SmartObjId=12d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=13
            Tp=1
            HD=TRUE
            DV=12d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=13
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Local Zone 4.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zones 1 - 4.ced
            Hint=Remote Zones 1 - 4 (Smart Object ID=17)
            Code=14
            SGControlType=Horizontal Tab Button
            SGControlName=Remote Zones 1 - 4
            GUID=D9B7C644-F2FC-4EA8-B927-1ACCC2BD13AC
            SmplCName=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zones 1 - 4.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10031
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=4
            MaxVariableInputs=4
            MinVariableOutputs=4
            MaxVariableOutputs=4
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=14
            CedH=14
            SmartObjId=17d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=14
            Tp=1
            HD=TRUE
            DV=17d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=14
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zones 1 - 4.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zone 2.ced
            Hint=Remote Zone 2 (Smart Object ID=14)
            Code=15
            SGControlType=Vertical Tab Button
            SGControlName=Remote Zone 2
            GUID=919607B6-5A85-46D9-A787-59DFBB1651DF
            SmplCName=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zone 2.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=4
            MaxVariableInputs=4
            MinVariableOutputs=4
            MaxVariableOutputs=4
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=15
            CedH=15
            SmartObjId=14d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=15
            Tp=1
            HD=TRUE
            DV=14d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=15
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zone 2.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zone 3.ced
            Hint=Remote Zone 3 (Smart Object ID=15)
            Code=16
            SGControlType=Vertical Tab Button
            SGControlName=Remote Zone 3
            GUID=7527DDD8-B643-49F8-ACCF-6D8C399A6CE9
            SmplCName=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zone 3.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=4
            MaxVariableInputs=4
            MinVariableOutputs=4
            MaxVariableOutputs=4
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=16
            CedH=16
            SmartObjId=15d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=16
            Tp=1
            HD=TRUE
            DV=15d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=16
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zone 3.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zone 4.ced
            Hint=Remote Zone 4 (Smart Object ID=16)
            Code=17
            SGControlType=Vertical Tab Button
            SGControlName=Remote Zone 4
            GUID=6FDB89E6-3D4F-46CC-BCA7-4A4324C3F496
            SmplCName=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zone 4.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=4
            MaxVariableInputs=4
            MinVariableOutputs=4
            MaxVariableOutputs=4
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=17
            CedH=17
            SmartObjId=16d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=17
            Tp=1
            HD=TRUE
            DV=16d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=17
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zone 4.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zone 1.ced
            Hint=Remote Zone 1 (Smart Object ID=13)
            Code=18
            SGControlType=Vertical Tab Button
            SGControlName=Remote Zone 1
            GUID=25BDDD15-B4BE-4629-A6A2-FD4B6A0D5323
            SmplCName=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zone 1.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=4
            MaxVariableInputs=4
            MinVariableOutputs=4
            MaxVariableOutputs=4
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=18
            CedH=18
            SmartObjId=13d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=18
            Tp=1
            HD=TRUE
            DV=13d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=18
            Name=CTI-P201 2014-10-07_007 Intersystem Communication_Remote Zone 1.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_010 SIMPL+_SIMPL+ SR.ced
            Hint=SIMPL+ SR (Smart Object ID=18)
            Code=19
            SGControlType=Vertical Tab Button
            SGControlName=SIMPL+ SR
            GUID=3E108986-D734-41B9-9CC9-CC5C93CD4517
            SmplCName=CTI-P201 2014-10-07_010 SIMPL+_SIMPL+ SR.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=4
            MaxVariableInputs=4
            MinVariableOutputs=4
            MaxVariableOutputs=4
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=19
            CedH=19
            SmartObjId=18d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=19
            Tp=1
            HD=TRUE
            DV=18d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=19
            Name=CTI-P201 2014-10-07_010 SIMPL+_SIMPL+ SR.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ;================================================================================
            [
            ObjTp=Symbol
            Name=CTI-P201 2014-10-07_010 SIMPL+_SIMPL+ IL.ced
            Hint=SIMPL+ IL (Smart Object ID=19)
            Code=20
            SGControlType=Vertical Tab Button
            SGControlName=SIMPL+ IL
            GUID=7E173FA9-64A4-484C-817A-79EBFB0D9F39
            SmplCName=CTI-P201 2014-10-07_010 SIMPL+_SIMPL+ IL.ced
            SMWRev=4.02.19
            Expand=expand_random
            HelpID=10074
            ;Define the number of inputs, outputs and parameters
            MinVariableInputs=6
            MaxVariableInputs=6
            MinVariableOutputs=6
            MaxVariableOutputs=6
            NumFixedParams=1
            MinVariableInputsList2=0
            MaxVariableInputsList2=0
            MinVariableOutputsList2=0
            MaxVariableOutputsList2=0
            MinVariableInputsList3=0
            MaxVariableInputsList3=0
            MinVariableOutputsList3=0
            MaxVariableOutputsList3=0
            ;Define the cues, and signal types  each input, output and parameter.
            InputCue1=[~UNUSED3~]
            InputSigType1=Digital
            OutputCue1=Tab Button 1 Press
            OutputSigType1=Digital
            InputCue2=Tab Button 1 Select
            InputSigType2=Digital
            OutputCue2=[~UNUSED3~]
            OutputSigType2=Digital
            InputCue3=[~UNUSED3~]
            InputSigType3=Digital
            OutputCue3=Tab Button 2 Press
            OutputSigType3=Digital
            InputCue4=Tab Button 2 Select
            InputSigType4=Digital
            OutputCue4=[~UNUSED3~]
            OutputSigType4=Digital
            InputCue5=[~UNUSED3~]
            InputSigType5=Digital
            OutputCue5=Tab Button 3 Press
            OutputSigType5=Digital
            InputCue6=Tab Button 3 Select
            InputSigType6=Digital
            OutputCue6=[~UNUSED3~]
            OutputSigType6=Digital
            ParamCue1=SmartObjectId
            ParamSigType1=Constant
            MPp=1
            Pp1=20
            CedH=20
            SmartObjId=19d
            ]
            ; Parameter Properties for Smart Object ID
            [
            ObjTp=Dp
            H=20
            Tp=1
            HD=TRUE
            DV=19d
            NF=1
            DNF=1
            EncFmt=0
            DVLF=1
            Sgn=0
            ]
            ; Smart Objects Definition section
            [
            ObjTp=CED
            H=20
            Name=CTI-P201 2014-10-07_010 SIMPL+_SIMPL+ IL.ced
            ;Cedver is the version of the Smart Graphics control, not the CED file format.
            ;If the control definition changes, increment this.
            CedVer=1
            ]
            ";
        #endregion
        #endregion

        Parse sgdParser;

        [TestMethod()]
        public void DataSet1()
        {
            sgdParser = new Parse();
            sgdParser.ProcessMetaData(data);

            Assert.IsTrue(sgdParser.metaData.Length > 0);
            Assert.IsTrue(sgdParser.splitMetaDataSections.Length > 0);
            Assert.IsTrue(SmartGraphic.numSmartGraphics > 0);
            Assert.IsTrue(sgdParser.smartObjectList.Count > 0);

            foreach (var sg in sgdParser.GetSmartObjectList)
            {
                Assert.IsTrue(sg.objectName.Length > 0);
                Console.WriteLine(sg.objectName);
             }
        }

        [TestMethod()]
        public void DataSet2()
        {
            sgdParser = new Parse();
            sgdParser.ProcessMetaData(data2);


            Assert.IsTrue(sgdParser.metaData.Length > 0);
            Assert.IsTrue(sgdParser.splitMetaDataSections.Length > 0);
            Assert.IsTrue(SmartGraphic.numSmartGraphics > 0);
            Assert.IsTrue(sgdParser.smartObjectList.Count > 0);


            foreach (var sg in sgdParser.GetSmartObjectList)
            {
                Assert.IsTrue(sg.objectName.Length > 0);
                Console.WriteLine(sg.objectName);
            }
        }

        [TestMethod()]
        public void DataSet3()
        {
            sgdParser = new Parse();
            sgdParser.ProcessMetaData(data3);


            Assert.IsTrue(sgdParser.metaData.Length > 0);
            Assert.IsTrue(sgdParser.splitMetaDataSections.Length > 0);
            Assert.IsTrue(SmartGraphic.numSmartGraphics > 0);
            Assert.IsTrue(sgdParser.smartObjectList.Count > 0);

            foreach (var sg in sgdParser.GetSmartObjectList)
            {
                Assert.IsTrue(sg.objectName.Length > 0);
                Console.WriteLine(sg.objectName);
            }
        }

        [TestMethod()]
        public void CheckFileContents()
        {

        }
    }
}