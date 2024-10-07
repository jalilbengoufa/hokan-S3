namespace hokan_S3
{
    partial class CreateSource
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
            this.bucketName = new System.Windows.Forms.TextBox();
            this.bucketNameLabel = new System.Windows.Forms.Label();
            this.accessKey = new System.Windows.Forms.TextBox();
            this.accessKeyLabel = new System.Windows.Forms.Label();
            this.secretKey = new System.Windows.Forms.TextBox();
            this.secretKeyLabel = new System.Windows.Forms.Label();
            this.saveSource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bucketName
            // 
            this.bucketName.Location = new System.Drawing.Point(547, 188);
            this.bucketName.Name = "bucketName";
            this.bucketName.Size = new System.Drawing.Size(315, 26);
            this.bucketName.TabIndex = 0;
            this.bucketName.TextChanged += new System.EventHandler(this.bucketName_TextChanged);
            // 
            // bucketNameLabel
            // 
            this.bucketNameLabel.AutoSize = true;
            this.bucketNameLabel.Location = new System.Drawing.Point(379, 188);
            this.bucketNameLabel.Name = "bucketNameLabel";
            this.bucketNameLabel.Size = new System.Drawing.Size(105, 20);
            this.bucketNameLabel.TabIndex = 1;
            this.bucketNameLabel.Text = "Bucket Name";
            // 
            // accessKey
            // 
            this.accessKey.Location = new System.Drawing.Point(547, 273);
            this.accessKey.Name = "accessKey";
            this.accessKey.PasswordChar = '*';
            this.accessKey.Size = new System.Drawing.Size(315, 26);
            this.accessKey.TabIndex = 2;
            // 
            // accessKeyLabel
            // 
            this.accessKeyLabel.AutoSize = true;
            this.accessKeyLabel.Location = new System.Drawing.Point(379, 273);
            this.accessKeyLabel.Name = "accessKeyLabel";
            this.accessKeyLabel.Size = new System.Drawing.Size(95, 20);
            this.accessKeyLabel.TabIndex = 3;
            this.accessKeyLabel.Text = "Access Key ";
            // 
            // secretKey
            // 
            this.secretKey.Location = new System.Drawing.Point(547, 344);
            this.secretKey.Name = "secretKey";
            this.secretKey.PasswordChar = '*';
            this.secretKey.Size = new System.Drawing.Size(315, 26);
            this.secretKey.TabIndex = 4;
            this.secretKey.TextChanged += new System.EventHandler(this.secretKey_TextChanged);
            // 
            // secretKeyLabel
            // 
            this.secretKeyLabel.AutoSize = true;
            this.secretKeyLabel.Location = new System.Drawing.Point(379, 350);
            this.secretKeyLabel.Name = "secretKeyLabel";
            this.secretKeyLabel.Size = new System.Drawing.Size(90, 20);
            this.secretKeyLabel.TabIndex = 5;
            this.secretKeyLabel.Text = "Secret Key ";
            // 
            // saveSource
            // 
            this.saveSource.Location = new System.Drawing.Point(588, 492);
            this.saveSource.Name = "saveSource";
            this.saveSource.Size = new System.Drawing.Size(223, 51);
            this.saveSource.TabIndex = 6;
            this.saveSource.Text = "Save";
            this.saveSource.UseVisualStyleBackColor = true;
            this.saveSource.Click += new System.EventHandler(this.saveSource_Click);
            // 
            // CreateSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 753);
            this.Controls.Add(this.saveSource);
            this.Controls.Add(this.secretKeyLabel);
            this.Controls.Add(this.secretKey);
            this.Controls.Add(this.accessKeyLabel);
            this.Controls.Add(this.accessKey);
            this.Controls.Add(this.bucketNameLabel);
            this.Controls.Add(this.bucketName);
            this.Name = "CreateSource";
            this.Text = "CreateSource";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bucketName;
        private System.Windows.Forms.Label bucketNameLabel;
        private System.Windows.Forms.TextBox accessKey;
        private System.Windows.Forms.Label accessKeyLabel;
        private System.Windows.Forms.TextBox secretKey;
        private System.Windows.Forms.Label secretKeyLabel;
        private System.Windows.Forms.Button saveSource;
    }
}