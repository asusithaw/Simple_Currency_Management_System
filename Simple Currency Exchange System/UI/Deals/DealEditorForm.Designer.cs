namespace Simple_Currency_Exchange_System.UI.Deals
{
    partial class DealEditorForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtAmount = new DevExpress.XtraEditors.SpinEdit();
            this.txtRate = new DevExpress.XtraEditors.SpinEdit();
            this.currencyLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNett = new DevExpress.XtraEditors.TextEdit();
            this.cboAction = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNett.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAction.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Action";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nett";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(140, 28);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(373, 22);
            this.txtCustomer.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAmount.Location = new System.Drawing.Point(140, 107);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.ValueChanged += new System.EventHandler(this.txtAmount_ValueChanged);
            // 
            // txtRate
            // 
            this.txtRate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtRate.Location = new System.Drawing.Point(140, 148);
            this.txtRate.Name = "txtRate";
            this.txtRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtRate.Size = new System.Drawing.Size(100, 22);
            this.txtRate.TabIndex = 8;
            this.txtRate.ValueChanged += new System.EventHandler(this.txtRate_ValueChanged);
            // 
            // currencyLookUpEdit
            // 
            this.currencyLookUpEdit.Location = new System.Drawing.Point(264, 107);
            this.currencyLookUpEdit.Name = "currencyLookUpEdit";
            this.currencyLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.currencyLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.currencyLookUpEdit.Properties.DisplayMember = "Code";
            this.currencyLookUpEdit.Properties.NullText = "Select Currency";
            this.currencyLookUpEdit.Properties.ValueMember = "Id";
            this.currencyLookUpEdit.Size = new System.Drawing.Size(116, 22);
            this.currencyLookUpEdit.TabIndex = 10;
            this.currencyLookUpEdit.EditValueChanged += new System.EventHandler(this.currencyLookUpEdit_EditValueChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(305, 232);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(413, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNett
            // 
            this.txtNett.EditValue = "";
            this.txtNett.Location = new System.Drawing.Point(140, 190);
            this.txtNett.Name = "txtNett";
            this.txtNett.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtNett.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNett.Size = new System.Drawing.Size(100, 22);
            this.txtNett.TabIndex = 9;
            // 
            // cboAction
            // 
            this.cboAction.Location = new System.Drawing.Point(140, 73);
            this.cboAction.Name = "cboAction";
            this.cboAction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboAction.Properties.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.cboAction.Size = new System.Drawing.Size(240, 22);
            this.cboAction.TabIndex = 13;
            this.cboAction.SelectedIndexChanged += new System.EventHandler(this.cboAction_SelectedIndexChanged);
            // 
            // DealEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 267);
            this.Controls.Add(this.cboAction);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.currencyLookUpEdit);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNett);
            this.Name = "DealEditorForm";
            this.Text = "DealForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNett.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAction.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomer;
        private DevExpress.XtraEditors.SpinEdit txtAmount;
        private DevExpress.XtraEditors.SpinEdit txtRate;
        private DevExpress.XtraEditors.LookUpEdit currencyLookUpEdit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraEditors.TextEdit txtNett;
        private DevExpress.XtraEditors.ComboBoxEdit cboAction;
    }
}