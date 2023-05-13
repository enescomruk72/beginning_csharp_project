namespace WindowsFormsApp1
{
    partial class Product
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.category_comboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.date_input_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.productId_input_textBox = new System.Windows.Forms.TextBox();
            this.CommentLabel = new System.Windows.Forms.Label();
            this.comment_textBox = new System.Windows.Forms.TextBox();
            this.StockLabel = new System.Windows.Forms.Label();
            this.stock_input_textBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.price_input_textBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.name_input_textBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.Button();
            this.UpdateProduct = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(998, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exit_button);
            this.groupBox1.Controls.Add(this.search_textBox);
            this.groupBox1.Controls.Add(this.category_comboBox);
            this.groupBox1.Controls.Add(this.CategoryLabel);
            this.groupBox1.Controls.Add(this.date_input_dateTimePicker);
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.productId_input_textBox);
            this.groupBox1.Controls.Add(this.CommentLabel);
            this.groupBox1.Controls.Add(this.comment_textBox);
            this.groupBox1.Controls.Add(this.StockLabel);
            this.groupBox1.Controls.Add(this.stock_input_textBox);
            this.groupBox1.Controls.Add(this.PriceLabel);
            this.groupBox1.Controls.Add(this.price_input_textBox);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.name_input_textBox);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.List);
            this.groupBox1.Controls.Add(this.UpdateProduct);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Insert);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Operations";
            // 
            // search_textBox
            // 
            this.search_textBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.search_textBox.Location = new System.Drawing.Point(300, 196);
            this.search_textBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(190, 28);
            this.search_textBox.TabIndex = 13;
            // 
            // category_comboBox
            // 
            this.category_comboBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.category_comboBox.FormattingEnabled = true;
            this.category_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.category_comboBox.Location = new System.Drawing.Point(95, 235);
            this.category_comboBox.Name = "category_comboBox";
            this.category_comboBox.Size = new System.Drawing.Size(150, 29);
            this.category_comboBox.TabIndex = 7;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CategoryLabel.Location = new System.Drawing.Point(12, 240);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(80, 21);
            this.CategoryLabel.TabIndex = 38;
            this.CategoryLabel.Text = "Category:";
            // 
            // date_input_dateTimePicker
            // 
            this.date_input_dateTimePicker.Location = new System.Drawing.Point(95, 95);
            this.date_input_dateTimePicker.MinimumSize = new System.Drawing.Size(4, 30);
            this.date_input_dateTimePicker.Name = "date_input_dateTimePicker";
            this.date_input_dateTimePicker.Size = new System.Drawing.Size(150, 30);
            this.date_input_dateTimePicker.TabIndex = 3;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DateLabel.Location = new System.Drawing.Point(12, 100);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(51, 21);
            this.DateLabel.TabIndex = 35;
            this.DateLabel.Text = "Date:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idLabel.Location = new System.Drawing.Point(12, 30);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(36, 21);
            this.idLabel.TabIndex = 34;
            this.idLabel.Text = "ID:";
            // 
            // productId_input_textBox
            // 
            this.productId_input_textBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productId_input_textBox.Location = new System.Drawing.Point(95, 25);
            this.productId_input_textBox.MaximumSize = new System.Drawing.Size(200, 200);
            this.productId_input_textBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.productId_input_textBox.Name = "productId_input_textBox";
            this.productId_input_textBox.Size = new System.Drawing.Size(150, 28);
            this.productId_input_textBox.TabIndex = 1;
            // 
            // CommentLabel
            // 
            this.CommentLabel.AutoSize = true;
            this.CommentLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CommentLabel.Location = new System.Drawing.Point(12, 205);
            this.CommentLabel.Name = "CommentLabel";
            this.CommentLabel.Size = new System.Drawing.Size(81, 21);
            this.CommentLabel.TabIndex = 33;
            this.CommentLabel.Text = "Comment:";
            // 
            // comment_textBox
            // 
            this.comment_textBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comment_textBox.Location = new System.Drawing.Point(95, 200);
            this.comment_textBox.MaximumSize = new System.Drawing.Size(200, 200);
            this.comment_textBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.comment_textBox.Name = "comment_textBox";
            this.comment_textBox.Size = new System.Drawing.Size(150, 28);
            this.comment_textBox.TabIndex = 6;
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StockLabel.Location = new System.Drawing.Point(12, 170);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(58, 21);
            this.StockLabel.TabIndex = 32;
            this.StockLabel.Text = "Stock:";
            // 
            // stock_input_textBox
            // 
            this.stock_input_textBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stock_input_textBox.Location = new System.Drawing.Point(95, 165);
            this.stock_input_textBox.MaximumSize = new System.Drawing.Size(200, 200);
            this.stock_input_textBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.stock_input_textBox.Name = "stock_input_textBox";
            this.stock_input_textBox.Size = new System.Drawing.Size(150, 28);
            this.stock_input_textBox.TabIndex = 5;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PriceLabel.Location = new System.Drawing.Point(12, 135);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(52, 21);
            this.PriceLabel.TabIndex = 28;
            this.PriceLabel.Text = "Price:";
            // 
            // price_input_textBox
            // 
            this.price_input_textBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.price_input_textBox.Location = new System.Drawing.Point(95, 130);
            this.price_input_textBox.MaximumSize = new System.Drawing.Size(200, 200);
            this.price_input_textBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.price_input_textBox.Name = "price_input_textBox";
            this.price_input_textBox.Size = new System.Drawing.Size(150, 28);
            this.price_input_textBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLabel.Location = new System.Drawing.Point(12, 65);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 21);
            this.NameLabel.TabIndex = 26;
            this.NameLabel.Text = "Name:";
            // 
            // name_input_textBox
            // 
            this.name_input_textBox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name_input_textBox.Location = new System.Drawing.Point(95, 60);
            this.name_input_textBox.MaximumSize = new System.Drawing.Size(200, 200);
            this.name_input_textBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.name_input_textBox.Name = "name_input_textBox";
            this.name_input_textBox.Size = new System.Drawing.Size(150, 28);
            this.name_input_textBox.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Search.Location = new System.Drawing.Point(300, 166);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(190, 30);
            this.Search.TabIndex = 12;
            this.Search.Text = "Search by Name";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // List
            // 
            this.List.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.List.Location = new System.Drawing.Point(300, 130);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(190, 30);
            this.List.TabIndex = 11;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateProduct.Location = new System.Drawing.Point(300, 95);
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(190, 30);
            this.UpdateProduct.TabIndex = 10;
            this.UpdateProduct.Text = "Update";
            this.UpdateProduct.UseVisualStyleBackColor = true;
            this.UpdateProduct.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Delete.Location = new System.Drawing.Point(300, 60);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(190, 30);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Insert.Location = new System.Drawing.Point(300, 25);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(190, 30);
            this.Insert.TabIndex = 8;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Red;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit_button.ForeColor = System.Drawing.Color.Transparent;
            this.exit_button.Location = new System.Drawing.Point(923, 9);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 40);
            this.exit_button.TabIndex = 14;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.Button UpdateProduct;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox productId_input_textBox;
        private System.Windows.Forms.Label CommentLabel;
        private System.Windows.Forms.TextBox comment_textBox;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.TextBox stock_input_textBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox price_input_textBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox name_input_textBox;
        private System.Windows.Forms.ComboBox category_comboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.DateTimePicker date_input_dateTimePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button exit_button;
    }
}