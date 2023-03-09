namespace Ch8Demo2WinFormsApp
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
            sampleButton = new Button();
            btnShow = new Button();
            lblDescription = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            bthForm3 = new RadioButton();
            bthForm2 = new RadioButton();
            bthForm1 = new RadioButton();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // sampleButton
            // 
            sampleButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sampleButton.Location = new Point(115, 87);
            sampleButton.Name = "sampleButton";
            sampleButton.Size = new Size(94, 29);
            sampleButton.TabIndex = 0;
            sampleButton.Text = "Welcome";
            sampleButton.UseVisualStyleBackColor = true;
            sampleButton.Click += button1_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(516, 125);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 1;
            btnShow.Text = "&Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(383, 73);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(342, 19);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Click on the show button to display Form2\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 177);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveToolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(145, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(145, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(145, 26);
            saveToolStripMenuItem.Text = "Save";
            // 
            // saveToolStripMenuItem1
            // 
            saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            saveToolStripMenuItem1.Size = new Size(145, 26);
            saveToolStripMenuItem1.Text = "Save as";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(145, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(51, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(131, 26);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(131, 26);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(131, 26);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bthForm3);
            groupBox1.Controls.Add(bthForm2);
            groupBox1.Controls.Add(bthForm1);
            groupBox1.Location = new Point(80, 254);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 139);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form";
            // 
            // bthForm3
            // 
            bthForm3.AutoSize = true;
            bthForm3.Location = new Point(71, 109);
            bthForm3.Name = "bthForm3";
            bthForm3.Size = new Size(77, 24);
            bthForm3.TabIndex = 2;
            bthForm3.TabStop = true;
            bthForm3.Text = "Form3";
            bthForm3.UseVisualStyleBackColor = true;
            bthForm3.CheckedChanged += bthForm3_CheckedChanged;
            // 
            // bthForm2
            // 
            bthForm2.AutoSize = true;
            bthForm2.Location = new Point(71, 64);
            bthForm2.Name = "bthForm2";
            bthForm2.Size = new Size(77, 24);
            bthForm2.TabIndex = 1;
            bthForm2.TabStop = true;
            bthForm2.Text = "Form2";
            bthForm2.UseVisualStyleBackColor = true;
            bthForm2.CheckedChanged += bthForm2_CheckedChanged;
            // 
            // bthForm1
            // 
            bthForm1.AutoSize = true;
            bthForm1.Location = new Point(71, 23);
            bthForm1.Name = "bthForm1";
            bthForm1.Size = new Size(77, 24);
            bthForm1.TabIndex = 0;
            bthForm1.TabStop = true;
            bthForm1.Text = "Form1";
            bthForm1.UseVisualStyleBackColor = true;
            bthForm1.CheckedChanged += bthForm1_CheckedChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "option1", "option2", "option3", "option4", "option5" });
            listBox1.Location = new Point(491, 254);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 44);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblDescription);
            Controls.Add(btnShow);
            Controls.Add(sampleButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sampleButton;
        private Button btnShow;
        private Label lblDescription;
        private Label label1;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private GroupBox groupBox1;
        private RadioButton bthForm3;
        private RadioButton bthForm2;
        private RadioButton bthForm1;
        private ListBox listBox1;
    }
}