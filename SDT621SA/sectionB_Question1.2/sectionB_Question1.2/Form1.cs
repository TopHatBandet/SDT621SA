using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sectionB_Question1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length != 0)
            {
                string name = txtName.Text;
                MessageBox.Show($"Greetings {name}!");

            }
            else
            {
                MessageBox.Show("A name must be entered");
            }
            
        }
    }
}
