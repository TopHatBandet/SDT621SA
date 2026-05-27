using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobileStockCapture_SectionC_Question1
{
    public partial class Form1 : Form
    {
        List<List<string>> tblMobilePhones = new List<List<string>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (txtCode.Text.Length != 0 || txtMake.Text.Length != 0 || txtQuantity.Text.Length != 0)
            {
                string code = txtCode.Text;
                string make = txtMake.Text;
                string quantity = txtQuantity.Text;
                List<string> newRecord = new List<string>();
                newRecord.Add(code);
                newRecord.Add(make);
                newRecord.Add(quantity);
                tblMobilePhones.Add(newRecord);

                lblOutput.Text = "Record Added";
            }
            else
            {
                    MessageBox.Show("All fields must be entered.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            for (int i = 0; i < tblMobilePhones.Count; i++)
            {
                if (tblMobilePhones[i].Contains(code))
                {
                    tblMobilePhones.Remove(tblMobilePhones[i]);
                    lblOutput.Text = "Record Found";
                }
                if(i == tblMobilePhones.Count)
                {
                    lblOutput.Text = "Record Not Found";
                }
            }
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            for (int i = 0; i < tblMobilePhones.Count; i++)
            {
                if (tblMobilePhones[i].Contains(code))
                {
                    lblOutput.Text = "Record Deleted";
                }
                if (i == tblMobilePhones.Count)
                {
                    lblOutput.Text = "Record Not Found";
                }
            }

        }
    }
}
