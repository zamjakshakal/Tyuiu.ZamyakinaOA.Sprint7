using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ZamyakinaOA.Sprint7.V1
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void ButtonLeaveAbout_ZOA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
