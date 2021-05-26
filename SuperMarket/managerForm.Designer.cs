namespace SuperMarket
{
    partial class managerForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.AddEmpBtn = new System.Windows.Forms.Button();
            this.AddSupBtn = new System.Windows.Forms.Button();
            this.addProdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WelcomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WelcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WelcomeLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WelcomeLabel.Location = new System.Drawing.Point(154, 69);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(278, 36);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Welcome Manager";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEmpBtn
            // 
            this.AddEmpBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddEmpBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpBtn.ForeColor = System.Drawing.Color.White;
            this.AddEmpBtn.Location = new System.Drawing.Point(189, 163);
            this.AddEmpBtn.Name = "AddEmpBtn";
            this.AddEmpBtn.Size = new System.Drawing.Size(206, 54);
            this.AddEmpBtn.TabIndex = 7;
            this.AddEmpBtn.Text = "Add Employee";
            this.AddEmpBtn.UseVisualStyleBackColor = false;
            this.AddEmpBtn.Click += new System.EventHandler(this.AddEmpBtn_Click);
            // 
            // AddSupBtn
            // 
            this.AddSupBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.AddSupBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupBtn.ForeColor = System.Drawing.Color.White;
            this.AddSupBtn.Location = new System.Drawing.Point(189, 247);
            this.AddSupBtn.Name = "AddSupBtn";
            this.AddSupBtn.Size = new System.Drawing.Size(206, 54);
            this.AddSupBtn.TabIndex = 8;
            this.AddSupBtn.Text = "Add Supplier";
            this.AddSupBtn.UseVisualStyleBackColor = false;
            this.AddSupBtn.Click += new System.EventHandler(this.AddSupBtn_Click);
            // 
            // addProdBtn
            // 
            this.addProdBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addProdBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProdBtn.ForeColor = System.Drawing.Color.White;
            this.addProdBtn.Location = new System.Drawing.Point(189, 323);
            this.addProdBtn.Name = "addProdBtn";
            this.addProdBtn.Size = new System.Drawing.Size(206, 54);
            this.addProdBtn.TabIndex = 9;
            this.addProdBtn.Text = "Add Product";
            this.addProdBtn.UseVisualStyleBackColor = false;
            this.addProdBtn.Click += new System.EventHandler(this.addProdBtn_Click);
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(596, 423);
            this.Controls.Add(this.addProdBtn);
            this.Controls.Add(this.AddSupBtn);
            this.Controls.Add(this.AddEmpBtn);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "managerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.managerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button AddEmpBtn;
        private System.Windows.Forms.Button AddSupBtn;
        private System.Windows.Forms.Button addProdBtn;
    }
}