using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ams.Form1;

namespace ams
{

    public partial class Form2 : Form
    {



        public Form2(Invoice invoice)
        {
            InitializeComponent();
            // Assign information from the invoice to the corresponding TextBox on the form
            txtCustomerName.Text = invoice.customerName;
            txtLastMonthWaterMeter.Text = invoice.lastMonthWaterMeter.ToString();
            txtThisMonthWaterMeter.Text = invoice.thisMonthWaterMeter.ToString();
            txtConsumption.Text = invoice.Consumption.ToString();
            txtWaterMoney.Text = invoice.WaterMoney.ToString();



        }

        public Form2()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Display successful payment confirmation message
            MessageBox.Show("Payment Successful!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
