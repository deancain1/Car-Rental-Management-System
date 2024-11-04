using Carl_Rental_System.Modal_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carl_Rental_System.Modal
{
    public class AddCarModal
    {
        public string ShowModal()
        {
            using (var modal = new AddCarModalFormcs())
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    
                
                }
            }
      
            return null;
        }
    }
}
