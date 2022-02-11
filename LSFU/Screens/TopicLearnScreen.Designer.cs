
namespace LSFU.Screens
{
    partial class TopicLearnScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopicLearnScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.headingLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.TextBox();
            this.roundedButton1 = new LSFU.RoundedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Learn Space PC (Version 2.0)";
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Location = new System.Drawing.Point(12, 56);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(37, 13);
            this.headingLabel.TabIndex = 1;
            this.headingLabel.Text = "Topic:";
            // 
            // dataLabel
            // 
            this.dataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLabel.Location = new System.Drawing.Point(12, 91);
            this.dataLabel.Multiline = true;
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.ReadOnly = true;
            this.dataLabel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataLabel.Size = new System.Drawing.Size(560, 213);
            this.dataLabel.TabIndex = 2;
            // 
            // roundedButton1
            // 
            this.roundedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton1.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.roundedButton1.BorderRadius = 10;
            this.roundedButton1.BorderSize = 2;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(422, 310);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(150, 40);
            this.roundedButton1.TabIndex = 3;
            this.roundedButton1.Text = "Back";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // TopicLearnScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LSFU.Properties.Resources.image1;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.TopicName = "TopicLearnScreen";
            this.Text = "Learn Space";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopicLearnScreen_FormClosing);
            this.Shown += new System.EventHandler(this.TopicLearnScreen_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headingLabel;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.TextBox dataLabel;
    }
}