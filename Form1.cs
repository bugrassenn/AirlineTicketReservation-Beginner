using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section1_FlightTicketReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label1.Text + " " +  comboBox1.Text +  " " 
                + label2.Text + "  " + comboBox2.Text + " "
                + label3.Text + " : " + dateTimePicker1.Text + " " 
                + label4.Text + " " + maskedTextBox1.Text + " " 
                + label5.Text + " " + maskedTextBox2.Text + " " 
                + label6.Text + " " + maskedTextBox3.Text + " "
                + label7.Text + " " + maskedTextBox4.Text);
            MessageBox.Show("Passenger Registered");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
