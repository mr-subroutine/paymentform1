using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentForm1
{
    public partial class Form1_Cust : Form
    {
        public Form1_Cust()
        {
            InitializeComponent();
            comboBoxName.Items.Add("Cloud Strife");
            comboBoxName.Items.Add("Tifa Lockhart");
            comboBoxName.Items.Add("Barret Wallace");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxName.Text))
            {
                Form2_Bill fm2 = new Form2_Bill();
                fm2.ShowDialog();
            }

            else
            {
                MessageBox.Show("Please select a first name and last name.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userInput = Microsoft.VisualBasic.Interaction.InputBox("Please enter first and last name",
                "Name Entry", "", 0, 0);
            if (comboBoxName.Text != "")
            {
                comboBoxName.Items.Add(userInput);
                MessageBox.Show("Customer Added!");
            }

            else
            {
                MessageBox.Show("Please enter the correct name.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
