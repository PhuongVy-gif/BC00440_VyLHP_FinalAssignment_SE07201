using static ams.Form1;

namespace ams
{
    public partial class Form1 : Form
    {
        // Declare VAT constant
        public const double VAT = 0.1;
        // Declare list of invoices
        private List<Invoice> invoices = new List<Invoice>();


        public Form1()
        {

            InitializeComponent();


            // Initialize invoice list
            invoices = new List<Invoice>();
            cboTypeOfCustomer.SelectedIndexChanged += new EventHandler(cboTypeOfCustomer_SelectedIndexChanged);
            lvWaterBill.SelectedIndexChanged += new EventHandler(lvWaterBill_SelectedIndexChanged);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // Event when changing customer type
        private void txtTypeOfCustomer_TextChanged(object sender, EventArgs e)
        {
            string typeOfCustomer = txtTypeOfCustomer.Text;
            // If the customer is type A, then allow to enter the number of people
            if (typeOfCustomer == "A")
            {
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                txtNumberOfPeople.Enabled = false;
            }
        }
        // Handle event when pressing water bill button
        private void CalculatorWater_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string typeOfCustomer = txtTypeOfCustomer.Text;
            int numberOfPeople = int.Parse(txtNumberOfPeople.Text);
            double lastMonthWaterMeter = double.Parse(txtLastMonthWaterMeter.Text);
            double thisMonthWaterMeter = double.Parse(txtThisMonthWaterMeter.Text);


        }
        // Water bill calculation event
        private void btnCalculateWater_Click(object sender, EventArgs e)
        {
            // Get information from the user interface
            string customerName = txtCustomerName.Text.Trim();
            string typeOfCustomer = cboTypeOfCustomer.Text;
            int numberOfPeople = 0;
            double lastMonthWaterMeter = 0;
            double thisMonthWaterMeter = 0;

            // Check the validity of input information
            if (customerName == "" || customerName == null)
            {
                MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;

            }
            if (string.IsNullOrEmpty(typeOfCustomer))
            {
                MessageBox.Show("Please select type of customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (typeOfCustomer.Equals("Household customer"))
            {
                if (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople <= 0)
                {
                    MessageBox.Show("Number of people must be a positive integer for for Household customer", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            if (!double.TryParse(txtLastMonthWaterMeter.Text, out lastMonthWaterMeter) || lastMonthWaterMeter < 0)
            {
                MessageBox.Show("Last month water meter should be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            if (!double.TryParse(txtThisMonthWaterMeter.Text, out thisMonthWaterMeter) || thisMonthWaterMeter < 0)
            {
                MessageBox.Show("This month water meter should be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            // Call the water bill calculation function
            var WaterBill = Calculator(typeOfCustomer, numberOfPeople, lastMonthWaterMeter, thisMonthWaterMeter);

            //Show results on ListView
            ListViewItem item = new ListViewItem(customerName);
            item.SubItems.Add(lastMonthWaterMeter.ToString());
            item.SubItems.Add(thisMonthWaterMeter.ToString());
            item.SubItems.Add(WaterBill.Item1.ToString());
            item.SubItems.Add(WaterBill.Item2.ToString());
            lvWaterBill.Items.Add(item);


            // Create Invoice object and add to invoice list
            Invoice invoice = new Invoice
            {
                customerName = customerName,
                lastMonthWaterMeter = lastMonthWaterMeter,
                thisMonthWaterMeter = thisMonthWaterMeter,
                Consumption = WaterBill.Item1,
                WaterMoney = WaterBill.Item2
            };
            invoices.Add(invoice);
        }

        // Event when selecting customer type from ComboBox
        private void cboTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If it is a household, then the number of people is allowed, otherwise not.
            string TypeOfNumber = cboTypeOfCustomer.Text;
            if (TypeOfNumber.Equals("Household customer"))
            {
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                txtNumberOfPeople.Enabled = false;
                txtNumberOfPeople.Text = "";
            }
        }

        // Event when form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            // Add customer types to combobox
            cboTypeOfCustomer.Items.Add("Household customer");
            cboTypeOfCustomer.Items.Add("Administration agency, public services");
            cboTypeOfCustomer.Items.Add("Production units");
            cboTypeOfCustomer.Items.Add("Business services");

            // Set columns for ListView
            lvWaterBill.View = View.Details;
            lvWaterBill.Columns.Add("Customer Name", 200);
            lvWaterBill.Columns.Add("Last Month's Water Meter", 200);
            lvWaterBill.Columns.Add("This Month's Water Meter", 200);
            lvWaterBill.Columns.Add("Anount Of Consumption ", 200);
            lvWaterBill.Columns.Add("Total Water Bill", 200);
        }

        // Event when searching for invoice
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            lvWaterBill.Items.Clear();
            bool foundResult = false;

            if (search == "")
            {
                // Display all invoices when there is no search keyword
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.customerName);
                    item.SubItems.Add(txtLastMonthWaterMeter.ToString());
                    item.SubItems.Add(txtThisMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());
                    lvWaterBill.Items.Add(item);


                }
                foundResult = true;

            }
            else
            {
                // Display invoices by search keyword
                foreach (Invoice invoice in invoices)
                {
                    if (invoice.customerName == search)
                    {
                        ListViewItem item = new ListViewItem(invoice.customerName);
                        item.SubItems.Add(txtLastMonthWaterMeter.ToString());
                        item.SubItems.Add(txtThisMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        lvWaterBill.Items.Add(item);
                        foundResult = true;
                    }

                }
            }
            // If no result found, display message
            if (!foundResult)
            {
                ListViewItem item = new ListViewItem("No result found");
                lvWaterBill.Items.Add(item);
            }
        }

        
     
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        // Function to calculate water bill based on customer type
        private (double, double) Calculator(string typeOfCustomer, int NumberOfPeople, double lastMothWaterMeter, double ThisMothWaterMeter)
        {
            double VAT = 0.1;
            // Calculate water consumption
            double consumption = ThisMothWaterMeter - lastMothWaterMeter;
            double WaterMoney = 0;

            // Calculate water bill based on customer type
            if (typeOfCustomer == "Household customer")
            {
                double averagePerson = consumption / NumberOfPeople;

                if (averagePerson < 10)
                {
                    WaterMoney = consumption * 5973;
                }
                else if (averagePerson >= 10 && averagePerson < 20)
                {
                    WaterMoney = consumption * 7052;
                }
                else if (averagePerson >= 20 && averagePerson < 30)
                {
                    WaterMoney = consumption * 8699;
                }
                else if (averagePerson >= 30)
                {
                    WaterMoney = consumption * 15929;
                }

            }
            else if (typeOfCustomer == "Administration agency, public services")
            {
                WaterMoney = consumption * 9955;
            }
            else if (typeOfCustomer == "Production units")
            {
                WaterMoney = (consumption * 11615);

            }
            else if (typeOfCustomer == "Business services")
            {
                WaterMoney = (consumption * 22086);
            }
            // Water bill includes VAT
            WaterMoney += WaterMoney * VAT;
            return (consumption, WaterMoney);

        }

        // Event when selecting item in ListView
        private void lvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lvWaterBill.SelectedItems[0].Index;
            Invoice invoice = invoices[index];
            Form2 form2 = new Form2(invoice);
            form2.Show();
        }

        // Event when pressing the button to open a new form
        private void btShowBill_Click(object sender, EventArgs e)
        {
            {
                Form2 hub = new Form2();
                hub.Show();
                if (lvWaterBill.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = lvWaterBill.SelectedItems[0];
                    string customerName = selectedItem.SubItems[0].Text;
                    Invoice selectedInvoice = invoices.FirstOrDefault(invoice => invoice.customerName == customerName);
                    if (selectedInvoice != null)
                    {
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                    }
                }
            }
        }

        // Invoice Class
        public class Invoice
        {
            public string customerName { get; set; }
            public double lastMonthWaterMeter { get; set; }
            public double thisMonthWaterMeter { get; set; }
            public double Consumption { get; set; }
            public double WaterMoney { get; set; }

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumberOfPeople_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
