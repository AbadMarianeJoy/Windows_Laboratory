namespace Windows_Laboratory
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
            this.label_item = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label_Discount = new System.Windows.Forms.Label();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.label_TOTAL = new System.Windows.Forms.Label();
            this.label_payment_received = new System.Windows.Forms.Label();
            this.label_CHANGE = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.button_COMPUTE = new System.Windows.Forms.Button();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textDiscount = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.textPayment = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_item
            // 
            this.label_item.AutoSize = true;
            this.label_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item.Location = new System.Drawing.Point(23, 18);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(50, 20);
            this.label_item.TabIndex = 0;
            this.label_item.Text = "Item:";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(23, 103);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(47, 16);
            this.label_Price.TabIndex = 1;
            this.label_Price.Text = "Price:";
            // 
            // label_Discount
            // 
            this.label_Discount.AutoSize = true;
            this.label_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Discount.Location = new System.Drawing.Point(266, 18);
            this.label_Discount.Name = "label_Discount";
            this.label_Discount.Size = new System.Drawing.Size(117, 20);
            this.label_Discount.TabIndex = 2;
            this.label_Discount.Text = "Discount (%):";
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Quantity.Location = new System.Drawing.Point(267, 101);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(67, 16);
            this.label_Quantity.TabIndex = 3;
            this.label_Quantity.Text = "Quantity:";
            // 
            // label_TOTAL
            // 
            this.label_TOTAL.AutoSize = true;
            this.label_TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TOTAL.Location = new System.Drawing.Point(57, 255);
            this.label_TOTAL.Name = "label_TOTAL";
            this.label_TOTAL.Size = new System.Drawing.Size(101, 16);
            this.label_TOTAL.TabIndex = 4;
            this.label_TOTAL.Text = "Total amount:";
            // 
            // label_payment_received
            // 
            this.label_payment_received.AutoSize = true;
            this.label_payment_received.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_payment_received.Location = new System.Drawing.Point(35, 278);
            this.label_payment_received.Name = "label_payment_received";
            this.label_payment_received.Size = new System.Drawing.Size(155, 20);
            this.label_payment_received.TabIndex = 5;
            this.label_payment_received.Text = "Payment received:";
            // 
            // label_CHANGE
            // 
            this.label_CHANGE.AutoSize = true;
            this.label_CHANGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CHANGE.Location = new System.Drawing.Point(57, 313);
            this.label_CHANGE.Name = "label_CHANGE";
            this.label_CHANGE.Size = new System.Drawing.Size(64, 16);
            this.label_CHANGE.TabIndex = 6;
            this.label_CHANGE.Text = "Change:";
            // 
            // textName
            // 
            this.textName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(50, 41);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(187, 25);
            this.textName.TabIndex = 7;
            // 
            // button_COMPUTE
            // 
            this.button_COMPUTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_COMPUTE.Location = new System.Drawing.Point(197, 151);
            this.button_COMPUTE.Name = "button_COMPUTE";
            this.button_COMPUTE.Size = new System.Drawing.Size(91, 26);
            this.button_COMPUTE.TabIndex = 8;
            this.button_COMPUTE.Text = "Compute";
            this.button_COMPUTE.UseVisualStyleBackColor = true;
            this.button_COMPUTE.Click += new System.EventHandler(this.button_COMPUTE_Click);
            // 
            // textPrice
            // 
            this.textPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textPrice.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrice.Location = new System.Drawing.Point(76, 101);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(140, 25);
            this.textPrice.TabIndex = 9;
            // 
            // textDiscount
            // 
            this.textDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textDiscount.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDiscount.Location = new System.Drawing.Point(282, 41);
            this.textDiscount.Name = "textDiscount";
            this.textDiscount.Size = new System.Drawing.Size(205, 25);
            this.textDiscount.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(340, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(84, 25);
            this.textBox4.TabIndex = 11;
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.Location = new System.Drawing.Point(396, 274);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(91, 26);
            this.button_Submit.TabIndex = 12;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // textPayment
            // 
            this.textPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textPayment.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPayment.Location = new System.Drawing.Point(197, 280);
            this.textPayment.Name = "textPayment";
            this.textPayment.Size = new System.Drawing.Size(169, 25);
            this.textPayment.TabIndex = 13;
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(412, 313);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(55, 30);
            this.button_Clear.TabIndex = 14;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(507, 372);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.textPayment);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textDiscount);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.button_COMPUTE);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label_CHANGE);
            this.Controls.Add(this.label_payment_received);
            this.Controls.Add(this.label_TOTAL);
            this.Controls.Add(this.label_Quantity);
            this.Controls.Add(this.label_Discount);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_item);
            this.Name = "Form1";
            this.Text = "Purchased Discounted Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_item;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label_Discount;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.Label label_TOTAL;
        private System.Windows.Forms.Label label_payment_received;
        private System.Windows.Forms.Label label_CHANGE;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button button_COMPUTE;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textDiscount;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.TextBox textPayment;
        private System.Windows.Forms.Button button_Clear;
    }
}

