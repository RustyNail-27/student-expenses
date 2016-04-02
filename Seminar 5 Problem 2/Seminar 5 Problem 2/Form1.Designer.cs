namespace Seminar_5_Problem_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.dayListBox = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.allInfoButton = new System.Windows.Forms.Button();
            this.dayInfoButton = new System.Windows.Forms.Button();
            this.studentInfoButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(9, 9);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(44, 13);
            this.studentLabel.TabIndex = 0;
            this.studentLabel.Text = "Student";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(118, 9);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(26, 13);
            this.dayLabel.TabIndex = 1;
            this.dayLabel.Text = "Day";
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(12, 28);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(92, 56);
            this.studentListBox.TabIndex = 2;
            // 
            // dayListBox
            // 
            this.dayListBox.FormattingEnabled = true;
            this.dayListBox.Location = new System.Drawing.Point(121, 28);
            this.dayListBox.Name = "dayListBox";
            this.dayListBox.Size = new System.Drawing.Size(88, 56);
            this.dayListBox.TabIndex = 3;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(12, 114);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(491, 108);
            this.outputListBox.TabIndex = 4;
            // 
            // allInfoButton
            // 
            this.allInfoButton.Location = new System.Drawing.Point(214, 239);
            this.allInfoButton.Name = "allInfoButton";
            this.allInfoButton.Size = new System.Drawing.Size(75, 61);
            this.allInfoButton.TabIndex = 5;
            this.allInfoButton.Text = "Display All Data";
            this.allInfoButton.UseVisualStyleBackColor = true;
            this.allInfoButton.Click += new System.EventHandler(this.allInfoButton_Click);
            // 
            // dayInfoButton
            // 
            this.dayInfoButton.Location = new System.Drawing.Point(111, 239);
            this.dayInfoButton.Name = "dayInfoButton";
            this.dayInfoButton.Size = new System.Drawing.Size(75, 61);
            this.dayInfoButton.TabIndex = 6;
            this.dayInfoButton.Text = "Display Day Data";
            this.dayInfoButton.UseVisualStyleBackColor = true;
            this.dayInfoButton.Click += new System.EventHandler(this.dayInfoButton_Click);
            // 
            // studentInfoButton
            // 
            this.studentInfoButton.Location = new System.Drawing.Point(12, 239);
            this.studentInfoButton.Name = "studentInfoButton";
            this.studentInfoButton.Size = new System.Drawing.Size(75, 61);
            this.studentInfoButton.TabIndex = 7;
            this.studentInfoButton.Text = "Display Student Data";
            this.studentInfoButton.UseVisualStyleBackColor = true;
            this.studentInfoButton.Click += new System.EventHandler(this.studentInfoButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 98);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(65, 13);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.Text = "Output Data";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(428, 239);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 61);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(320, 239);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 61);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 312);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.studentInfoButton);
            this.Controls.Add(this.dayInfoButton);
            this.Controls.Add(this.allInfoButton);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.dayListBox);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.studentLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.ListBox dayListBox;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button allInfoButton;
        private System.Windows.Forms.Button dayInfoButton;
        private System.Windows.Forms.Button studentInfoButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

