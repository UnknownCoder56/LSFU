namespace LSFU
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.creditsButton = new LSFU.RoundedButton();
            this.startButton = new LSFU.RoundedButton();
            this.settingsButton = new LSFU.RoundedButton();
            this.buttonExit = new LSFU.RoundedButton();
            this.contactButton = new LSFU.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Learn Space PC (Version 2.0)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tableLayoutPanel1.Controls.Add(this.creditsButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonExit, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.contactButton, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 165);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 185);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // creditsButton
            // 
            this.creditsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.creditsButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.creditsButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.creditsButton.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.creditsButton.BorderRadius = 11;
            this.creditsButton.BorderSize = 3;
            this.creditsButton.FlatAppearance.BorderSize = 0;
            this.creditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditsButton.ForeColor = System.Drawing.Color.White;
            this.creditsButton.Location = new System.Drawing.Point(130, 77);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Size = new System.Drawing.Size(300, 31);
            this.creditsButton.TabIndex = 6;
            this.creditsButton.Text = "Credits";
            this.creditsButton.TextColor = System.Drawing.Color.White;
            this.creditsButton.UseVisualStyleBackColor = false;
            this.creditsButton.Click += new System.EventHandler(this.creditsButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.startButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.startButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.startButton.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.startButton.BorderRadius = 11;
            this.startButton.BorderSize = 3;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(130, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(300, 31);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start Learning";
            this.startButton.TextColor = System.Drawing.Color.White;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.settingsButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.settingsButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.settingsButton.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.settingsButton.BorderRadius = 11;
            this.settingsButton.BorderSize = 3;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(130, 40);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(300, 31);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextColor = System.Drawing.Color.White;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonExit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonExit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonExit.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonExit.BorderRadius = 11;
            this.buttonExit.BorderSize = 3;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(130, 151);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(300, 31);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit Application";
            this.buttonExit.TextColor = System.Drawing.Color.White;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // contactButton
            // 
            this.contactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.contactButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.contactButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.contactButton.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.contactButton.BorderRadius = 10;
            this.contactButton.BorderSize = 2;
            this.contactButton.FlatAppearance.BorderSize = 0;
            this.contactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactButton.ForeColor = System.Drawing.Color.White;
            this.contactButton.Location = new System.Drawing.Point(130, 114);
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(300, 31);
            this.contactButton.TabIndex = 8;
            this.contactButton.Text = "Contact Us";
            this.contactButton.TextColor = System.Drawing.Color.White;
            this.contactButton.UseVisualStyleBackColor = false;
            this.contactButton.Click += new System.EventHandler(this.contactButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LSFU.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(422, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::LSFU.Properties.Resources.image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learn Space PC";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedButton startButton;
        private RoundedButton settingsButton;
        private RoundedButton creditsButton;
        private RoundedButton buttonExit;
        private RoundedButton contactButton;
    }
}

