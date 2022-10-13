using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_Biblioteca
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void ola()
        {
           
        }
        string message = ("Madisson Pequeno");
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(message);
        }
    }
}
