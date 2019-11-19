SGDFileConverter

This application was made to address one of the challenges I came across when using Smart Graphics in a SIMPLSharp Pro Program.

While many Smart Graphics do contain methods of tracking which button has been pressed, fairly efficiently (e.g. Item Clicked), I found that handling Subpage Reference List
always seemed to be a challenge.

Through further research, I identified that within SIMPLSharp the signal Name is sometimes utilized and that that signal Name is an editable property.

I then turned my attention to the .SGD file to see how it was formatted, and found that it could be parsed and that the Signal Names can be changed.

I tested this, by manually changing the names and found this to be true.

This application, is the result of those investigations. Its intention is to allow for an SGD file to be edited and make the signal names reflect their operation in SIMPLSharp Pro.

At that point a standard could be defined, allowing for Smart Objects within VT Pro Projects to be standardizable and hopefully, allowing for a program to be more dynamic.

The application, allows the user to do the following:
1) Open a .SGD file to edit
2) Parses the SGD file for all the Smart Graphics and creates a List
3) The user to select any of the Smart Graphics, Signal Type and Input / Output (as applicable) and edit its name
4) Save the file as a new .SGD file

Additionally, all user defined signals are stored in a plain text file. The application filters that database as a Signal name is being enterred, reducing edit times.

The application works in the following way:

When the .sgd file is read, it is broken down and all the Smart Graphics are stored in a SmartGraphic Type.

This type, contains a list of Digital, Analog and Serial Inputs/Outputs. As the user edits the signal name, this is what they are interacting with.

When the edited version is saved, the .SGD is rebuilt using the predefined .SGD header and footer information AND the individual Smart Graphics header and footer information