namespace ams
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtLastMonthWaterMeter = new TextBox();
            txtThisMonthWaterMeter = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtConsumption = new TextBox();
            label8 = new Label();
            txtWaterMoney = new TextBox();
            button2 = new Button();
            txtCustomerName = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(415, 513);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 87);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 1;
            label1.Text = "Customer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 205);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 4;
            label4.Text = "Last Month's Water Meter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(602, 87);
            label5.Name = "label5";
            label5.Size = new Size(177, 20);
            label5.TabIndex = 5;
            label5.Text = "This Month's Water Meter";
            // 
            // txtLastMonthWaterMeter
            // 
            txtLastMonthWaterMeter.Location = new Point(64, 243);
            txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            txtLastMonthWaterMeter.Size = new Size(184, 27);
            txtLastMonthWaterMeter.TabIndex = 9;
            // 
            // txtThisMonthWaterMeter
            // 
            txtThisMonthWaterMeter.Location = new Point(612, 133);
            txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            txtThisMonthWaterMeter.Size = new Size(175, 27);
            txtThisMonthWaterMeter.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(345, 9);
            label6.Name = "label6";
            label6.Size = new Size(195, 46);
            label6.TabIndex = 11;
            label6.Text = "WATER BILL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 87);
            label7.Name = "label7";
            label7.Size = new Size(169, 20);
            label7.TabIndex = 12;
            label7.Text = "Anount Of Consumption";
            // 
            // txtConsumption
            // 
            txtConsumption.Location = new Point(345, 133);
            txtConsumption.Name = "txtConsumption";
            txtConsumption.Size = new Size(178, 27);
            txtConsumption.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(345, 205);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 14;
            label8.Text = "Total Water Bill";
            // 
            // txtWaterMoney
            // 
            txtWaterMoney.Location = new Point(345, 243);
            txtWaterMoney.Name = "txtWaterMoney";
            txtWaterMoney.Size = new Size(178, 27);
            txtWaterMoney.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(384, 373);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 16;
            button2.Text = "PAY";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(64, 133);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(184, 27);
            txtCustomerName.TabIndex = 17;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 469);
            Controls.Add(txtCustomerName);
            Controls.Add(button2);
            Controls.Add(txtWaterMoney);
            Controls.Add(label8);
            Controls.Add(txtConsumption);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtThisMonthWaterMeter);
            Controls.Add(txtLastMonthWaterMeter);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtLastMonthWaterMeter;
        private TextBox txtThisMonthWaterMeter;
        private Label label6;
        private Label label7;
        private TextBox txtConsumption;
        private Label label8;
        private TextBox txtWaterMoney;
        private Button button2;
        private TextBox txtCustomerName;
    }
}