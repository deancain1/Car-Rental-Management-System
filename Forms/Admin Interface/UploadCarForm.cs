using Carl_Rental_System.Database;
using Carl_Rental_System.Modal_Form;
using Carl_Rental_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carl_Rental_System.Forms.Admin_Interface
{
    public partial class UploadCarForm : Form
    {
        public UploadCarForm()
        {
            InitializeComponent();
        }
     
        private void UploadCarBtn_Click(object sender, EventArgs e)
        {
            UploadCarModalForm modalHandler = new UploadCarModalForm();
            modalHandler.ShowDialog();
        }
    }
}
