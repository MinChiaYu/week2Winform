namespace week2Winform
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SumPrice = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SumNumber = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.Way = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(41, 270);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "開始計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 29);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 146);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 29);
            this.textBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(274, 571);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "重新設定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SumPrice
            // 
            this.SumPrice.AutoSize = true;
            this.SumPrice.Location = new System.Drawing.Point(119, 585);
            this.SumPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SumPrice.Name = "SumPrice";
            this.SumPrice.Size = new System.Drawing.Size(18, 20);
            this.SumPrice.TabIndex = 6;
            this.SumPrice.Text = "0";
            this.SumPrice.Click += new System.EventHandler(this.SumPrice_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(42, 358);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(383, 184);
            this.listBox1.TabIndex = 9;
            // 
            // SumNumber
            // 
            this.SumNumber.AutoSize = true;
            this.SumNumber.Location = new System.Drawing.Point(44, 585);
            this.SumNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SumNumber.Name = "SumNumber";
            this.SumNumber.Size = new System.Drawing.Size(41, 20);
            this.SumNumber.TabIndex = 11;
            this.SumNumber.Text = "總計";
            this.SumNumber.Click += new System.EventHandler(this.SumNumber_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Price.Location = new System.Drawing.Point(44, 100);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(41, 20);
            this.Price.TabIndex = 12;
            this.Price.Text = "價錢";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Amount.Location = new System.Drawing.Point(45, 155);
            this.Amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(41, 20);
            this.Amount.TabIndex = 13;
            this.Amount.Text = "數量";
            // 
            // Way
            // 
            this.Way.AutoSize = true;
            this.Way.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Way.Location = new System.Drawing.Point(45, 211);
            this.Way.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Way.Name = "Way";
            this.Way.Size = new System.Drawing.Size(73, 20);
            this.Way.TabIndex = 14;
            this.Way.Text = "折扣方式";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(187, 208);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label1.Location = new System.Drawing.Point(185, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "總價計算";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Way);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.SumNumber);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SumPrice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label SumPrice;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label SumNumber;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label Way;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

