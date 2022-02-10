
namespace NTPClock
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
            this.SystemTime = new System.Windows.Forms.Label();
            this.NTPTime = new System.Windows.Forms.Label();
            this.DifferenceText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SystemTime
            // 
            this.SystemTime.AutoSize = true;
            this.SystemTime.Location = new System.Drawing.Point(49, 29);
            this.SystemTime.Name = "SystemTime";
            this.SystemTime.Size = new System.Drawing.Size(84, 17);
            this.SystemTime.TabIndex = 0;
            this.SystemTime.Text = "Getting time";
            // 
            // NTPTime
            // 
            this.NTPTime.AutoSize = true;
            this.NTPTime.Location = new System.Drawing.Point(358, 217);
            this.NTPTime.Name = "NTPTime";
            this.NTPTime.Size = new System.Drawing.Size(84, 17);
            this.NTPTime.TabIndex = 1;
            this.NTPTime.Text = "Getting time";
            // 
            // DifferenceText
            // 
            this.DifferenceText.AutoSize = true;
            this.DifferenceText.Location = new System.Drawing.Point(610, 29);
            this.DifferenceText.Name = "DifferenceText";
            this.DifferenceText.Size = new System.Drawing.Size(121, 17);
            this.DifferenceText.TabIndex = 2;
            this.DifferenceText.Text = "Getting difference";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DifferenceText);
            this.Controls.Add(this.NTPTime);
            this.Controls.Add(this.SystemTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SystemTime;
        private System.Windows.Forms.Label NTPTime;
        private System.Windows.Forms.Label DifferenceText;
    }
}

