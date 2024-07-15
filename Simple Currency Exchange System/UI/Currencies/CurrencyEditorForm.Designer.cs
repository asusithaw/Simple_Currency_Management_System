namespace Simple_Currency_Exchange_System.UI.Currencies
{
    partial class CurrencyEditorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.countryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMiddleRate = new DevExpress.XtraEditors.SpinEdit();
            this.txtBuyRate = new DevExpress.XtraEditors.SpinEdit();
            this.txtSellRate = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.countryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSellRate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(103, 26);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(350, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 22);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Country";
            // 
            // countryLookUpEdit
            // 
            this.countryLookUpEdit.Location = new System.Drawing.Point(103, 73);
            this.countryLookUpEdit.Name = "countryLookUpEdit";
            this.countryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.countryLookUpEdit.Properties.DisplayMember = "Name";
            this.countryLookUpEdit.Properties.NullText = "<Select Country>";
            this.countryLookUpEdit.Properties.ValueMember = "Id";
            this.countryLookUpEdit.Size = new System.Drawing.Size(536, 22);
            this.countryLookUpEdit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Middle Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Buy Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sell Rate";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(126, 179);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(82, 21);
            this.chkIsActive.TabIndex = 12;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(450, 232);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(564, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMiddleRate
            // 
            this.txtMiddleRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMiddleRate.Location = new System.Drawing.Point(126, 127);
            this.txtMiddleRate.Name = "txtMiddleRate";
            this.txtMiddleRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMiddleRate.Size = new System.Drawing.Size(100, 22);
            this.txtMiddleRate.TabIndex = 15;
            // 
            // txtBuyRate
            // 
            this.txtBuyRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtBuyRate.Location = new System.Drawing.Point(341, 127);
            this.txtBuyRate.Name = "txtBuyRate";
            this.txtBuyRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBuyRate.Size = new System.Drawing.Size(100, 22);
            this.txtBuyRate.TabIndex = 16;
            // 
            // txtSellRate
            // 
            this.txtSellRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSellRate.Location = new System.Drawing.Point(539, 129);
            this.txtSellRate.Name = "txtSellRate";
            this.txtSellRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSellRate.Size = new System.Drawing.Size(100, 22);
            this.txtSellRate.TabIndex = 17;
            // 
            // CurrencyEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 287);
            this.Controls.Add(this.txtSellRate);
            this.Controls.Add(this.txtBuyRate);
            this.Controls.Add(this.txtMiddleRate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countryLookUpEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Name = "CurrencyEditorForm";
            this.Text = "CurrencyEditorForm";
            ((System.ComponentModel.ISupportInitialize)(this.countryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiddleRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSellRate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit countryLookUpEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraEditors.SpinEdit txtMiddleRate;
        private DevExpress.XtraEditors.SpinEdit txtBuyRate;
        private DevExpress.XtraEditors.SpinEdit txtSellRate;
    }
}