namespace WindowsFormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.iban_text_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Family_text_in = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tell_text_in = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_text_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_text_in = new System.Windows.Forms.TextBox();
            this.List = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Comment_text_pay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cust_id_text_in_payment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Payment_id_text_in = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Pay_amount_text_in = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.iban_text_in);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Family_text_in);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Tell_text_in);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.id_text_in);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Name_text_in);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Operations";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(76, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(236, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "iban:";
            // 
            // iban_text_in
            // 
            this.iban_text_in.Location = new System.Drawing.Point(76, 129);
            this.iban_text_in.Name = "iban_text_in";
            this.iban_text_in.Size = new System.Drawing.Size(236, 22);
            this.iban_text_in.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Familly:";
            // 
            // Family_text_in
            // 
            this.Family_text_in.Location = new System.Drawing.Point(76, 75);
            this.Family_text_in.Name = "Family_text_in";
            this.Family_text_in.Size = new System.Drawing.Size(236, 22);
            this.Family_text_in.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tell:";
            // 
            // Tell_text_in
            // 
            this.Tell_text_in.Location = new System.Drawing.Point(76, 101);
            this.Tell_text_in.Name = "Tell_text_in";
            this.Tell_text_in.Size = new System.Drawing.Size(236, 22);
            this.Tell_text_in.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID:";
            // 
            // id_text_in
            // 
            this.id_text_in.Location = new System.Drawing.Point(76, 21);
            this.id_text_in.Name = "id_text_in";
            this.id_text_in.Size = new System.Drawing.Size(236, 22);
            this.id_text_in.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // Name_text_in
            // 
            this.Name_text_in.Location = new System.Drawing.Point(76, 47);
            this.Name_text_in.Name = "Name_text_in";
            this.Name_text_in.Size = new System.Drawing.Size(236, 22);
            this.Name_text_in.TabIndex = 2;
            // 
            // List
            // 
            this.List.Controls.Add(this.dataGridView2);
            this.List.Location = new System.Drawing.Point(13, 305);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(694, 330);
            this.List.TabIndex = 1;
            this.List.TabStop = false;
            this.List.Text = "List";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(682, 302);
            this.dataGridView2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Comment_text_pay);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cust_id_text_in_payment);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Payment_id_text_in);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Pay_amount_text_in);
            this.groupBox3.Location = new System.Drawing.Point(354, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 286);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Operations:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(102, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "LIst";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Comment:";
            // 
            // Comment_text_pay
            // 
            this.Comment_text_pay.Location = new System.Drawing.Point(102, 128);
            this.Comment_text_pay.Name = "Comment_text_pay";
            this.Comment_text_pay.Size = new System.Drawing.Size(236, 22);
            this.Comment_text_pay.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Customer-id";
            // 
            // cust_id_text_in_payment
            // 
            this.cust_id_text_in_payment.Location = new System.Drawing.Point(102, 100);
            this.cust_id_text_in_payment.Name = "cust_id_text_in_payment";
            this.cust_id_text_in_payment.Size = new System.Drawing.Size(236, 22);
            this.cust_id_text_in_payment.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID:";
            // 
            // Payment_id_text_in
            // 
            this.Payment_id_text_in.Location = new System.Drawing.Point(102, 20);
            this.Payment_id_text_in.Name = "Payment_id_text_in";
            this.Payment_id_text_in.Size = new System.Drawing.Size(236, 22);
            this.Payment_id_text_in.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Payment:";
            // 
            // Pay_amount_text_in
            // 
            this.Pay_amount_text_in.Location = new System.Drawing.Point(102, 46);
            this.Pay_amount_text_in.Name = "Pay_amount_text_in";
            this.Pay_amount_text_in.Size = new System.Drawing.Size(236, 22);
            this.Pay_amount_text_in.TabIndex = 13;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(76, 245);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(236, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Search (HTTP)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 647);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.List);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iban_text_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Family_text_in;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tell_text_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_text_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_text_in;
        private System.Windows.Forms.GroupBox List;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Comment_text_pay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cust_id_text_in_payment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Payment_id_text_in;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Pay_amount_text_in;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

