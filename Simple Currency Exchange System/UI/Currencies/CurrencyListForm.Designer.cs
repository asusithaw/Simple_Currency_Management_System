namespace Simple_Currency_Exchange_System.UI.Currencies
{
    partial class CurrencyListForm
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
            this.components = new System.ComponentModel.Container();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.AllowNew = false;
            this.currencyBindingSource.DataSource = typeof(Simple_Currency_Exchange_System.Entities.Currency);
            // 
            // currencyGridControl
            // 
            this.currencyGridControl.DataSource = this.currencyBindingSource;
            this.currencyGridControl.Location = new System.Drawing.Point(-2, -1);
            this.currencyGridControl.MainView = this.gridView1;
            this.currencyGridControl.Name = "currencyGridControl";
            this.currencyGridControl.Size = new System.Drawing.Size(877, 249);
            this.currencyGridControl.TabIndex = 1;
            this.currencyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.currencyGridControl.Load += new System.EventHandler(this.currencyGridControl_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colName,
            this.colCountryName,
            this.colMiddleRate,
            this.colBuyRate,
            this.colSellRate});
            this.gridView1.GridControl = this.currencyGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "Country";
            this.colCountryName.FieldName = "Country.Name";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 2;
            // 
            // colMiddleRate
            // 
            this.colMiddleRate.FieldName = "MiddleRate";
            this.colMiddleRate.Name = "colMiddleRate";
            this.colMiddleRate.Visible = true;
            this.colMiddleRate.VisibleIndex = 3;
            // 
            // colBuyRate
            // 
            this.colBuyRate.FieldName = "BuyRate";
            this.colBuyRate.Name = "colBuyRate";
            this.colBuyRate.Visible = true;
            this.colBuyRate.VisibleIndex = 4;
            // 
            // colSellRate
            // 
            this.colSellRate.Caption = "SellRate";
            this.colSellRate.FieldName = "SellRate";
            this.colSellRate.Name = "colSellRate";
            this.colSellRate.Visible = true;
            this.colSellRate.VisibleIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(572, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(755, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(662, 275);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // CurrencyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 310);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.currencyGridControl);
            this.Name = "CurrencyListForm";
            this.Text = "CurrencyListForm";
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource currencyBindingSource;
        private DevExpress.XtraGrid.GridControl currencyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleRate;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyRate;
        private DevExpress.XtraGrid.Columns.GridColumn colSellRate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}