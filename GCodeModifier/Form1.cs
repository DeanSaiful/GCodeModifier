namespace GCodeModifier
{
    public partial class Form1 : Form
    {
        private string loadedFilePath = "";
        private GCodeParser? parser;
        private bool isValidated = false;
        private bool isTransformed = false;

        public Form1()
        {
            InitializeComponent();
            btnApplyTransform.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnLoadGCode_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "G-code files (*.gcode;*.nc;*.txt)|*.gcode;*.nc;*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                loadedFilePath = ofd.FileName;

                // Display the lines in lstPreview
                lstPreview.Items.Clear();
                var lines = System.IO.File.ReadAllLines(loadedFilePath);
                foreach (var line in lines)
                {
                    lstPreview.Items.Add(line);
                }

                lblFilePath.Text = ": " + loadedFilePath;

                MessageBox.Show("G-code loaded: " + loadedFilePath, "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnValidatePoints_Click(object sender, EventArgs e)
        {
            try
            {
                var top = new[] {
                    (double.Parse(txtTopX1.Text), double.Parse(txtTopY1.Text)),
                    (double.Parse(txtTopX2.Text), double.Parse(txtTopY2.Text)),
                    (double.Parse(txtTopX3.Text), double.Parse(txtTopY3.Text)),
                    (double.Parse(txtTopX4.Text), double.Parse(txtTopY4.Text))
                };

                var bottom = new[] {
                    (double.Parse(txtBotX1.Text), double.Parse(txtBotY1.Text)),
                    (double.Parse(txtBotX2.Text), double.Parse(txtBotY2.Text)),
                    (double.Parse(txtBotX3.Text), double.Parse(txtBotY3.Text)),
                    (double.Parse(txtBotX4.Text), double.Parse(txtBotY4.Text))
                };

                if (PointValidator.ValidateRigidTransformation(top, bottom, out string message))
                {
                    isValidated = true;
                    btnApplyTransform.Enabled = true;
                    MessageBox.Show(message, "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    isValidated = false;
                    btnApplyTransform.Enabled = false;
                    btnSave.Enabled = false;
                    MessageBox.Show(message, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Validation Error: " + ex.Message);
            }
        }

        private void btnApplyTransform_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isValidated)
                {
                    MessageBox.Show("Please validate the points first.");
                    return;
                }

                if (string.IsNullOrEmpty(loadedFilePath))
                {
                    MessageBox.Show("Please load a G-code file first.");
                    return;
                }

                var top = new[] {
            (double.Parse(txtTopX1.Text), double.Parse(txtTopY1.Text)),
            (double.Parse(txtTopX2.Text), double.Parse(txtTopY2.Text)),
            (double.Parse(txtTopX3.Text), double.Parse(txtTopY3.Text)),
            (double.Parse(txtTopX4.Text), double.Parse(txtTopY4.Text))
        };

                var bottom = new[] {
            (double.Parse(txtBotX1.Text), double.Parse(txtBotY1.Text)),
            (double.Parse(txtBotX2.Text), double.Parse(txtBotY2.Text)),
            (double.Parse(txtBotX3.Text), double.Parse(txtBotY3.Text)),
            (double.Parse(txtBotX4.Text), double.Parse(txtBotY4.Text))
        };

                var affine = new AffineTransform();
                affine.SolveTransformation(top, bottom);

                parser = new GCodeParser(affine);
                parser.Load(loadedFilePath);
                parser.ApplyTransformation();

                // ? Update the list box with transformed G-code
                lstPreview.Items.Clear();
                foreach (var line in parser.TransformedLines)
                {
                    lstPreview.Items.Add(line);
                }

                isTransformed = true;
                btnSave.Enabled = true;

                MessageBox.Show("Transform applied successfully. You can now save the file.", "Transform Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transformation Error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isTransformed || parser == null)
                {
                    MessageBox.Show("No transformation applied yet.");
                    return;
                }

                var sfd = new SaveFileDialog();
                sfd.FileName = "modified.gcode";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    parser.Save(sfd.FileName);
                    MessageBox.Show("G-code saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Error: " + ex.Message);
            }
        }

        private void lstPreview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPreview.SelectedItem != null)
            {
                string selectedLine = lstPreview.SelectedItem.ToString()!;
                // Optional: Show selectedLine in a label, textbox, or dialog
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear text boxes
            txtTopX1.Text = txtTopX2.Text = txtTopX3.Text = txtTopX4.Text = "";
            txtTopY1.Text = txtTopY2.Text = txtTopY3.Text = txtTopY4.Text = "";
            txtBotX1.Text = txtBotX2.Text = txtBotX3.Text = txtBotX4.Text = "";
            txtBotY1.Text = txtBotY2.Text = txtBotY3.Text = txtBotY4.Text = "";

            // Clear G-code preview
            lstPreview.Items.Clear();

            // Reset state
            loadedFilePath = "";
            parser = null;
            isValidated = false;
            isTransformed = false;

            // Disable buttons
            btnApplyTransform.Enabled = false;
            btnSave.Enabled = false;

            lblFilePath.Text = ": No file loaded";

            // Optional: Show message
            // MessageBox.Show("Form reset successfully.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pahtFile_Click(object sender, EventArgs e)
        {
            lblFilePath.Text = "Loaded file: " + loadedFilePath;
        }

    }
}
