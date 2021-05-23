
namespace SuperMarket
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.AddOrder = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Quant = new System.Windows.Forms.TextBox();
            this.AddItem = new SuperMarket.CircleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Nova Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Nova", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // Item
            // 
            this.Item.BackColor = System.Drawing.Color.White;
            this.Item.Enabled = false;
            this.Item.Font = new System.Drawing.Font("Arial Nova", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.Location = new System.Drawing.Point(235, 206);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(176, 46);
            this.Item.TabIndex = 3;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.White;
            this.Price.Enabled = false;
            this.Price.Font = new System.Drawing.Font("Arial Nova Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(235, 369);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(176, 46);
            this.Price.TabIndex = 4;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(214, 463);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(235, 39);
            this.AddOrder.TabIndex = 7;
            this.AddOrder.Text = "Add Order";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // Products
            // 
            this.Products.FormattingEnabled = true;
            this.Products.Location = new System.Drawing.Point(235, 127);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(176, 28);
            this.Products.TabIndex = 8;
            this.Products.SelectedIndexChanged += new System.EventHandler(this.Products_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Nova Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Products";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Nova", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // Quant
            // 
            this.Quant.BackColor = System.Drawing.Color.White;
            this.Quant.Font = new System.Drawing.Font("Arial Nova Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quant.Location = new System.Drawing.Point(235, 288);
            this.Quant.Name = "Quant";
            this.Quant.Size = new System.Drawing.Size(176, 46);
            this.Quant.TabIndex = 11;
            this.Quant.TextChanged += new System.EventHandler(this.Qunat_TextChanged);
            // 
            // AddItem
            // 
            this.AddItem.FlatAppearance.BorderSize = 0;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Image = ((System.Drawing.Image)(resources.GetObject("AddItem.Image")));
            this.AddItem.Location = new System.Drawing.Point(505, 239);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(53, 43);
            this.AddItem.TabIndex = 5;
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 529);
            this.Controls.Add(this.Quant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Item;
        private System.Windows.Forms.TextBox Price;
        private CircleButton AddItem;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.ComboBox Products;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Quant;
    }
}