using Carl_Rental_System.Database;
using Carl_Rental_System.Modal;
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
     
       
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn != null && byteArrayIn.Length > 0)
            {
                using (var ms = new MemoryStream(byteArrayIn))
                {
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

       

        private void UploadCarBtn_Click_1(object sender, EventArgs e)
        {
            AddCarModal modalHandler = new AddCarModal();
            string result = modalHandler.ShowModal();
        }
    }
}
