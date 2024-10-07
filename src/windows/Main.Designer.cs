namespace hokan_S3
{
    partial class Main
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
            this.addS3Source = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addS3Source
            // 
            this.addS3Source.Location = new System.Drawing.Point(308, 68);
            this.addS3Source.Name = "addS3Source";
            this.addS3Source.Size = new System.Drawing.Size(186, 39);
            this.addS3Source.TabIndex = 0;
            this.addS3Source.Text = "Add S3 Source";
            this.addS3Source.UseVisualStyleBackColor = true;
            this.addS3Source.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 448);
            this.Controls.Add(this.addS3Source);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addS3Source;
    }
}

