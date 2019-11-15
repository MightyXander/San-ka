namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addString = new System.Windows.Forms.Button();
            this.delString = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deviceCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wiserDBDataSet = new WindowsFormsApp2.wiserDBDataSet();
            this.devicesTableAdapter = new WindowsFormsApp2.wiserDBDataSetTableAdapters.DevicesTableAdapter();
            this.wiserDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiserDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiserDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addString
            // 
            this.addString.Location = new System.Drawing.Point(12, 12);
            this.addString.Name = "addString";
            this.addString.Size = new System.Drawing.Size(75, 23);
            this.addString.TabIndex = 0;
            this.addString.Text = "Add string";
            this.addString.UseVisualStyleBackColor = true;
            this.addString.Click += new System.EventHandler(this.AddString_Click);
            // 
            // delString
            // 
            this.delString.Location = new System.Drawing.Point(12, 41);
            this.delString.Name = "delString";
            this.delString.Size = new System.Drawing.Size(75, 23);
            this.delString.TabIndex = 1;
            this.delString.Text = "Delete string";
            this.delString.UseVisualStyleBackColor = true;
            this.delString.Click += new System.EventHandler(this.DelString_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceCodeDataGridViewTextBoxColumn,
            this.deviceNameDataGridViewTextBoxColumn,
            this.devicePriceDataGridViewTextBoxColumn,
            this.deviceCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.devicesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(93, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 252);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // deviceCodeDataGridViewTextBoxColumn
            // 
            this.deviceCodeDataGridViewTextBoxColumn.DataPropertyName = "deviceCode";
            this.deviceCodeDataGridViewTextBoxColumn.HeaderText = "deviceCode";
            this.deviceCodeDataGridViewTextBoxColumn.Name = "deviceCodeDataGridViewTextBoxColumn";
            // 
            // deviceNameDataGridViewTextBoxColumn
            // 
            this.deviceNameDataGridViewTextBoxColumn.DataPropertyName = "deviceName";
            this.deviceNameDataGridViewTextBoxColumn.HeaderText = "deviceName";
            this.deviceNameDataGridViewTextBoxColumn.Name = "deviceNameDataGridViewTextBoxColumn";
            // 
            // devicePriceDataGridViewTextBoxColumn
            // 
            this.devicePriceDataGridViewTextBoxColumn.DataPropertyName = "devicePrice";
            this.devicePriceDataGridViewTextBoxColumn.HeaderText = "devicePrice";
            this.devicePriceDataGridViewTextBoxColumn.Name = "devicePriceDataGridViewTextBoxColumn";
            // 
            // deviceCountDataGridViewTextBoxColumn
            // 
            this.deviceCountDataGridViewTextBoxColumn.DataPropertyName = "deviceCount";
            this.deviceCountDataGridViewTextBoxColumn.HeaderText = "deviceCount";
            this.deviceCountDataGridViewTextBoxColumn.Name = "deviceCountDataGridViewTextBoxColumn";
            // 
            // devicesBindingSource
            // 
            this.devicesBindingSource.DataMember = "Devices";
            this.devicesBindingSource.DataSource = this.wiserDBDataSet;
            // 
            // wiserDBDataSet
            // 
            this.wiserDBDataSet.DataSetName = "wiserDBDataSet";
            this.wiserDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devicesTableAdapter
            // 
            this.devicesTableAdapter.ClearBeforeFill = true;
            // 
            // wiserDBDataSetBindingSource
            // 
            this.wiserDBDataSetBindingSource.DataSource = this.wiserDBDataSet;
            this.wiserDBDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 301);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delString);
            this.Controls.Add(this.addString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiserDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wiserDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addString;
        private System.Windows.Forms.Button delString;
        private System.Windows.Forms.DataGridView dataGridView1;
        private wiserDBDataSet wiserDBDataSet;
        private System.Windows.Forms.BindingSource devicesBindingSource;
        private wiserDBDataSetTableAdapters.DevicesTableAdapter devicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wiserDBDataSetBindingSource;
    }
}

