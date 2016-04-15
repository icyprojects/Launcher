using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form
{
    public class FormWorker
    {
        public void OpenForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog(); 
        }
    }
}
