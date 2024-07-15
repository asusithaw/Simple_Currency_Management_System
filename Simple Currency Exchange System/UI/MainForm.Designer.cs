namespace Simple_Currency_Exchange_System
{
    partial class MainForm
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
            this.btnCurrencies = new System.Windows.Forms.Button();
            this.btnDeals = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCurrencies
            // 
            this.btnCurrencies.Location = new System.Drawing.Point(12, 27);
            this.btnCurrencies.Name = "btnCurrencies";
            this.btnCurrencies.Size = new System.Drawing.Size(97, 23);
            this.btnCurrencies.TabIndex = 0;
            this.btnCurrencies.Text = "Currencies";
            this.btnCurrencies.UseVisualStyleBackColor = true;
            this.btnCurrencies.Click += new System.EventHandler(this.btnCurrencies_Click);
            // 
            // btnDeals
            // 
            this.btnDeals.Location = new System.Drawing.Point(135, 27);
            this.btnDeals.Name = "btnDeals";
            this.btnDeals.Size = new System.Drawing.Size(75, 23);
            this.btnDeals.TabIndex = 0;
            this.btnDeals.Text = "Deals";
            this.btnDeals.UseVisualStyleBackColor = true;
            this.btnDeals.Click += new System.EventHandler(this.btnDeals_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(255, 27);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(75, 23);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 137);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnDeals);
            this.Controls.Add(this.btnCurrencies);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCurrencies;
        private System.Windows.Forms.Button btnDeals;
        private System.Windows.Forms.Button btnUsers;
    }
}