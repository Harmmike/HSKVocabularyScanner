namespace WindowsFormsApp1.ViewModels
{
    partial class HSKVocabScanner
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
            this.myRtb = new System.Windows.Forms.RichTextBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myRtb
            // 
            this.myRtb.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myRtb.Location = new System.Drawing.Point(12, 12);
            this.myRtb.Name = "myRtb";
            this.myRtb.Size = new System.Drawing.Size(1023, 499);
            this.myRtb.TabIndex = 0;
            this.myRtb.Text = "";
            // 
            // scanButton
            // 
            this.scanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanButton.Location = new System.Drawing.Point(399, 517);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(336, 71);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.OnClick_ScanDocument);
            // 
            // HSKVocabScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.myRtb);
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.Name = "HSKVocabScanner";
            this.Text = "HSKVocabScanner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox myRtb;
        private System.Windows.Forms.Button scanButton;
    }
}