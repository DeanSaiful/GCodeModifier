GCode Affine Modifier
A Windows desktop application that allows users to load, transform, preview, and save G-code files using affine transformation based on alignment points. Designed especially for PCBA or CNC users who need to adjust bottom layer coordinates after flipping boards.

Features
- Load G-code files (.gcode, .nc, .txt)
- Input and validate 4 top and 4 bottom alignment points
- Apply affine transformation (translation + rotation)
- Live preview of modified G-code in a list box
- Save the transformed G-code to a new file
- Reset form to default state
- Display loaded file path for clarity

Interface Overview
TextBoxes: For entering 8 alignment coordinates (4 top + 4 bottom).
Buttons:
- Load G-code
- Validate Points
- Apply Transform
- Save G-code
- Reset
List Box: Displays loaded or transformed G-code lines.
Label: Shows full path of the loaded file.

How It Works
Load G-code: Loads all G-code lines into memory and displays in the list box.
Input Points: Enter the top and bottom reference points (used for alignment).
Validate Points: Ensures the transformation between top and bottom layers is valid.
Apply Transformation: Applies affine transformation to every G-code line with X and Y coordinates.
Save: Saves the transformed result to a new .gcode file.

Technologies Used
C# (.NET Framework / WinForms)
Regex for G-code parsing
Basic linear algebra for affine transformation

Folder StructureGCodeAffineModifier/
├── AffineTransform.cs
├── GCodeParser.cs
├── PointValidator.cs
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
└── README.md

Getting Started
Clone the repo:

Use Case
This tool is especially useful for:
- PCB board alignment after flipping during the testing or manufacturing process
- Adjusting coordinate files for CNC operations
