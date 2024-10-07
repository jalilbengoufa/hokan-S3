using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hokan_S3
{
    public partial class CreateSource : Form
    {
        public CreateSource()
        {
            InitializeComponent();
        }

        private void saveSource_Click(object sender, EventArgs e)
        {
            string bucketNameValue = this.bucketName.Text;
            string accessKey = this.accessKey.Text;
            string secretKey = this.secretKey.Text;

            //TODO: Save the source to the database sqlite

        }

        private void bucketName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void secretKey_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
