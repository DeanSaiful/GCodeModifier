namespace GCodeModifier
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLoadGCode = new Button();
            btnReset = new Button();
            btnValidatePoints = new Button();
            btnApplyTransform = new Button();
            btnSave = new Button();
            lstPreview = new ListBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTopY4 = new TextBox();
            txtTopX4 = new TextBox();
            txtTopY3 = new TextBox();
            txtTopX3 = new TextBox();
            txtTopY2 = new TextBox();
            txtTopX2 = new TextBox();
            txtTopY1 = new TextBox();
            txtTopX1 = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            txtBotY4 = new TextBox();
            label7 = new Label();
            txtBotX4 = new TextBox();
            label8 = new Label();
            txtBotY3 = new TextBox();
            txtBotX3 = new TextBox();
            txtBotY2 = new TextBox();
            txtBotX2 = new TextBox();
            txtBotY1 = new TextBox();
            txtBotX1 = new TextBox();
            lblFilePath = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoadGCode
            // 
            btnLoadGCode.Location = new Point(51, 46);
            btnLoadGCode.Name = "btnLoadGCode";
            btnLoadGCode.Size = new Size(144, 48);
            btnLoadGCode.TabIndex = 0;
            btnLoadGCode.Text = "Load G-Code";
            btnLoadGCode.UseVisualStyleBackColor = true;
            btnLoadGCode.Click += btnLoadGCode_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(211, 46);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 48);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnValidatePoints
            // 
            btnValidatePoints.Location = new Point(303, 46);
            btnValidatePoints.Name = "btnValidatePoints";
            btnValidatePoints.Size = new Size(75, 48);
            btnValidatePoints.TabIndex = 2;
            btnValidatePoints.Text = "Validate";
            btnValidatePoints.UseVisualStyleBackColor = true;
            btnValidatePoints.Click += btnValidatePoints_Click;
            // 
            // btnApplyTransform
            // 
            btnApplyTransform.Location = new Point(384, 46);
            btnApplyTransform.Name = "btnApplyTransform";
            btnApplyTransform.Size = new Size(122, 23);
            btnApplyTransform.TabIndex = 3;
            btnApplyTransform.Text = "Apply Transform";
            btnApplyTransform.UseVisualStyleBackColor = true;
            btnApplyTransform.Click += btnApplyTransform_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(384, 71);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lstPreview
            // 
            lstPreview.FormattingEnabled = true;
            lstPreview.ItemHeight = 15;
            lstPreview.Location = new Point(51, 148);
            lstPreview.Name = "lstPreview";
            lstPreview.Size = new Size(235, 304);
            lstPreview.TabIndex = 5;
            lstPreview.SelectedIndexChanged += lstPreview_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTopY4);
            groupBox1.Controls.Add(txtTopX4);
            groupBox1.Controls.Add(txtTopY3);
            groupBox1.Controls.Add(txtTopX3);
            groupBox1.Controls.Add(txtTopY2);
            groupBox1.Controls.Add(txtTopX2);
            groupBox1.Controls.Add(txtTopY1);
            groupBox1.Controls.Add(txtTopX1);
            groupBox1.Location = new Point(303, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(209, 147);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Top Points (X,Y)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 112);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 12;
            label4.Text = "Point D :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 83);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 11;
            label3.Text = "Point C :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 54);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Point B :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 25);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 9;
            label1.Text = "Point A :";
            // 
            // txtTopY4
            // 
            txtTopY4.Location = new Point(138, 109);
            txtTopY4.Name = "txtTopY4";
            txtTopY4.Size = new Size(65, 23);
            txtTopY4.TabIndex = 7;
            // 
            // txtTopX4
            // 
            txtTopX4.Location = new Point(67, 109);
            txtTopX4.Name = "txtTopX4";
            txtTopX4.Size = new Size(65, 23);
            txtTopX4.TabIndex = 6;
            // 
            // txtTopY3
            // 
            txtTopY3.Location = new Point(138, 80);
            txtTopY3.Name = "txtTopY3";
            txtTopY3.Size = new Size(65, 23);
            txtTopY3.TabIndex = 5;
            // 
            // txtTopX3
            // 
            txtTopX3.Location = new Point(67, 80);
            txtTopX3.Name = "txtTopX3";
            txtTopX3.Size = new Size(65, 23);
            txtTopX3.TabIndex = 4;
            // 
            // txtTopY2
            // 
            txtTopY2.Location = new Point(138, 51);
            txtTopY2.Name = "txtTopY2";
            txtTopY2.Size = new Size(65, 23);
            txtTopY2.TabIndex = 3;
            // 
            // txtTopX2
            // 
            txtTopX2.Location = new Point(67, 51);
            txtTopX2.Name = "txtTopX2";
            txtTopX2.Size = new Size(65, 23);
            txtTopX2.TabIndex = 2;
            // 
            // txtTopY1
            // 
            txtTopY1.Location = new Point(138, 22);
            txtTopY1.Name = "txtTopY1";
            txtTopY1.Size = new Size(65, 23);
            txtTopY1.TabIndex = 1;
            // 
            // txtTopX1
            // 
            txtTopX1.Location = new Point(67, 22);
            txtTopX1.Name = "txtTopX1";
            txtTopX1.Size = new Size(65, 23);
            txtTopX1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtBotY4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtBotX4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtBotY3);
            groupBox2.Controls.Add(txtBotX3);
            groupBox2.Controls.Add(txtBotY2);
            groupBox2.Controls.Add(txtBotX2);
            groupBox2.Controls.Add(txtBotY1);
            groupBox2.Controls.Add(txtBotX1);
            groupBox2.Location = new Point(303, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(209, 147);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bottom Points (X,Y)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 112);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 16;
            label5.Text = "Point D :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 83);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 15;
            label6.Text = "Point C :";
            // 
            // txtBotY4
            // 
            txtBotY4.Location = new Point(138, 109);
            txtBotY4.Name = "txtBotY4";
            txtBotY4.Size = new Size(65, 23);
            txtBotY4.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 54);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 14;
            label7.Text = "Point B :";
            // 
            // txtBotX4
            // 
            txtBotX4.Location = new Point(67, 109);
            txtBotX4.Name = "txtBotX4";
            txtBotX4.Size = new Size(65, 23);
            txtBotX4.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 25);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 13;
            label8.Text = "Point A :";
            // 
            // txtBotY3
            // 
            txtBotY3.Location = new Point(138, 80);
            txtBotY3.Name = "txtBotY3";
            txtBotY3.Size = new Size(65, 23);
            txtBotY3.TabIndex = 5;
            // 
            // txtBotX3
            // 
            txtBotX3.Location = new Point(67, 80);
            txtBotX3.Name = "txtBotX3";
            txtBotX3.Size = new Size(65, 23);
            txtBotX3.TabIndex = 4;
            // 
            // txtBotY2
            // 
            txtBotY2.Location = new Point(138, 51);
            txtBotY2.Name = "txtBotY2";
            txtBotY2.Size = new Size(65, 23);
            txtBotY2.TabIndex = 3;
            // 
            // txtBotX2
            // 
            txtBotX2.Location = new Point(67, 51);
            txtBotX2.Name = "txtBotX2";
            txtBotX2.Size = new Size(65, 23);
            txtBotX2.TabIndex = 2;
            // 
            // txtBotY1
            // 
            txtBotY1.Location = new Point(138, 22);
            txtBotY1.Name = "txtBotY1";
            txtBotY1.Size = new Size(65, 23);
            txtBotY1.TabIndex = 1;
            // 
            // txtBotX1
            // 
            txtBotX1.Location = new Point(67, 22);
            txtBotX1.Name = "txtBotX1";
            txtBotX1.Size = new Size(65, 23);
            txtBotX1.TabIndex = 0;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Font = new Font("Segoe UI", 9F);
            lblFilePath.Location = new Point(125, 112);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(10, 15);
            lblFilePath.TabIndex = 9;
            lblFilePath.Text = ":";
            lblFilePath.Click += pahtFile_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 112);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 10;
            label9.Text = "G-Code File";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 483);
            Controls.Add(label9);
            Controls.Add(lblFilePath);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lstPreview);
            Controls.Add(btnSave);
            Controls.Add(btnApplyTransform);
            Controls.Add(btnValidatePoints);
            Controls.Add(btnReset);
            Controls.Add(btnLoadGCode);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "G-Code Modifier";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadGCode;
        private Button btnReset;
        private Button btnValidatePoints;
        private Button btnApplyTransform;
        private Button btnSave;
        private ListBox lstPreview;
        private GroupBox groupBox1;
        private TextBox txtTopY4;
        private TextBox txtTopX4;
        private TextBox txtTopY3;
        private TextBox txtTopX3;
        private TextBox txtTopY2;
        private TextBox txtTopX2;
        private TextBox txtTopY1;
        private TextBox txtTopX1;
        private GroupBox groupBox2;
        private TextBox txtBotY4;
        private TextBox txtBotX4;
        private TextBox txtBotY3;
        private TextBox txtBotX3;
        private TextBox txtBotY2;
        private TextBox txtBotX2;
        private TextBox txtBotY1;
        private TextBox txtBotX1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblFilePath;
        private Label label9;
    }
}
