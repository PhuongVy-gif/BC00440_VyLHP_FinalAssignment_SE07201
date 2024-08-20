namespace ams
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cboTypeOfCustomer = new ComboBox();
            btShowBill = new Button();
            btnCalculateWater = new Button();
            txtThisMonthWaterMeter = new TextBox();
            txtLastMonthWaterMeter = new TextBox();
            txtNumberOfPeople = new TextBox();
            txtTypeOfCustomer = new TextBox();
            txtCustomerName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtSearch = new TextBox();
            lvWaterBill = new ListView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboTypeOfCustomer);
            groupBox1.Controls.Add(btShowBill);
            groupBox1.Controls.Add(btnCalculateWater);
            groupBox1.Controls.Add(txtThisMonthWaterMeter);
            groupBox1.Controls.Add(txtLastMonthWaterMeter);
            groupBox1.Controls.Add(txtNumberOfPeople);
            groupBox1.Controls.Add(txtTypeOfCustomer);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 531);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cboTypeOfCustomer
            // 
            cboTypeOfCustomer.FormattingEnabled = true;
            cboTypeOfCustomer.Location = new Point(227, 117);
            cboTypeOfCustomer.Name = "cboTypeOfCustomer";
            cboTypeOfCustomer.Size = new Size(213, 28);
            cboTypeOfCustomer.TabIndex = 14;
            cboTypeOfCustomer.SelectedIndexChanged += cboTypeOfCustomer_SelectedIndexChanged;
            // 
            // btShowBill
            // 
            btShowBill.Location = new Point(41, 439);
            btShowBill.Name = "btShowBill";
            btShowBill.Size = new Size(94, 29);
            btShowBill.TabIndex = 13;
            btShowBill.Text = "SHOW BILL";
            btShowBill.UseVisualStyleBackColor = true;
            btShowBill.Click += btShowBill_Click;
            // 
            // btnCalculateWater
            // 
            btnCalculateWater.Location = new Point(346, 439);
            btnCalculateWater.Name = "btnCalculateWater";
            btnCalculateWater.Size = new Size(107, 29);
            btnCalculateWater.TabIndex = 12;
            btnCalculateWater.Text = "Calculate";
            btnCalculateWater.UseVisualStyleBackColor = true;
            btnCalculateWater.Click += btnCalculateWater_Click;
            // 
            // txtThisMonthWaterMeter
            // 
            txtThisMonthWaterMeter.Location = new Point(227, 329);
            txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            txtThisMonthWaterMeter.PlaceholderText = "Enter This Month's Water Meter";
            txtThisMonthWaterMeter.Size = new Size(213, 27);
            txtThisMonthWaterMeter.TabIndex = 10;
            // 
            // txtLastMonthWaterMeter
            // 
            txtLastMonthWaterMeter.Location = new Point(227, 249);
            txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            txtLastMonthWaterMeter.PlaceholderText = "Enter Last Month's Water Meter";
            txtLastMonthWaterMeter.Size = new Size(213, 27);
            txtLastMonthWaterMeter.TabIndex = 9;
            // 
            // txtNumberOfPeople
            // 
            txtNumberOfPeople.Location = new Point(227, 172);
            txtNumberOfPeople.Name = "txtNumberOfPeople";
            txtNumberOfPeople.PlaceholderText = "Enter Customer Of People";
            txtNumberOfPeople.Size = new Size(213, 27);
            txtNumberOfPeople.TabIndex = 8;
            txtNumberOfPeople.TextChanged += txtNumberOfPeople_TextChanged;
            // 
            // txtTypeOfCustomer
            // 
            txtTypeOfCustomer.Enabled = false;
            txtTypeOfCustomer.Location = new Point(227, 117);
            txtTypeOfCustomer.Name = "txtTypeOfCustomer";
            txtTypeOfCustomer.Size = new Size(213, 27);
            txtTypeOfCustomer.TabIndex = 7;
            txtTypeOfCustomer.TextChanged += txtTypeOfCustomer_TextChanged;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(227, 45);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Enter Customer Name";
            txtCustomerName.Size = new Size(213, 27);
            txtCustomerName.TabIndex = 5;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 336);
            label5.Name = "label5";
            label5.Size = new Size(177, 20);
            label5.TabIndex = 4;
            label5.Text = "This Month's Water Meter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 249);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 3;
            label4.Text = "Last Month's Water Meter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 179);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 2;
            label3.Text = "Customer Of People";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 107);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 1;
            label2.Text = "Type Of Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 45);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(605, 24);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 5;
            label6.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(677, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(226, 27);
            txtSearch.TabIndex = 11;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lvWaterBill
            // 
            lvWaterBill.Location = new Point(605, 69);
            lvWaterBill.Name = "lvWaterBill";
            lvWaterBill.Size = new Size(358, 486);
            lvWaterBill.TabIndex = 11;
            lvWaterBill.UseCompatibleStateImageBehavior = false;
            lvWaterBill.SelectedIndexChanged += lvWaterBill_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 656);
            Controls.Add(lvWaterBill);
            Controls.Add(txtSearch);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox txtThisMonthWaterMeter;
        private TextBox txtLastMonthWaterMeter;
        private TextBox txtNumberOfPeople;
        private TextBox txtTypeOfCustomer;
        private TextBox txtCustomerName;
        private TextBox txtSearch;
        private ListView lvWaterBill;
        private Button btShowBill;
        private Button btnCalculateWater;
        private ComboBox cboTypeOfCustomer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
