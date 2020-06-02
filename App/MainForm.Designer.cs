namespace ConsoleApplication2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teamsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statisticsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coachesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(723, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 508);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // teamsComboBox
            // 
            this.teamsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamsComboBox.FormattingEnabled = true;
            this.teamsComboBox.Location = new System.Drawing.Point(84, 11);
            this.teamsComboBox.Name = "teamsComboBox";
            this.teamsComboBox.Size = new System.Drawing.Size(336, 24);
            this.teamsComboBox.TabIndex = 10;
            this.teamsComboBox.SelectedIndexChanged += new System.EventHandler(this.teamsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Команда";
            // 
            // statisticsRichTextBox
            // 
            this.statisticsRichTextBox.Location = new System.Drawing.Point(266, 97);
            this.statisticsRichTextBox.Name = "statisticsRichTextBox";
            this.statisticsRichTextBox.ReadOnly = true;
            this.statisticsRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.statisticsRichTextBox.Size = new System.Drawing.Size(255, 403);
            this.statisticsRichTextBox.TabIndex = 12;
            this.statisticsRichTextBox.Text = "";
            // 
            // playersListBox
            // 
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.ItemHeight = 16;
            this.playersListBox.Location = new System.Drawing.Point(16, 96);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(230, 404);
            this.playersListBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Склад";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(263, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Чемпіонство";
            // 
            // coachesLabel
            // 
            this.coachesLabel.AutoSize = true;
            this.coachesLabel.BackColor = System.Drawing.Color.Transparent;
            this.coachesLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.coachesLabel.Location = new System.Drawing.Point(12, 49);
            this.coachesLabel.Name = "coachesLabel";
            this.coachesLabel.Size = new System.Drawing.Size(63, 16);
            this.coachesLabel.TabIndex = 11;
            this.coachesLabel.Text = "Тренер: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.playersListBox);
            this.Controls.Add(this.statisticsRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coachesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamsComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1010, 560);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Футбол";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox teamsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox statisticsRichTextBox;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label coachesLabel;
    }
}