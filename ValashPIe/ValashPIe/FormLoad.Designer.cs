namespace ValashPIe
{
    partial class FormLoad
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
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.FontWeight = MetroFramework.MetroProgressBarWeight.Bold;
            this.metroProgressBar1.Location = new System.Drawing.Point(37, 358);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(451, 12);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroProgressBar1.TabIndex = 0;
            // 
            // FormLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ValashPIe.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 391);
            this.Controls.Add(this.metroProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoad";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}