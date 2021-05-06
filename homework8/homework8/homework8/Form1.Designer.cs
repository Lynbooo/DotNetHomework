
namespace homework8
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox_service = new System.Windows.Forms.GroupBox();
            this.button_import = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_query = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.groupBox_order = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bindingSource_detail = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_order = new System.Windows.Forms.DataGridView();
            this.clientInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCreateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_order = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_service.SuspendLayout();
            this.groupBox_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_service
            // 
            this.groupBox_service.Controls.Add(this.button_import);
            this.groupBox_service.Controls.Add(this.button_export);
            this.groupBox_service.Controls.Add(this.button_delete);
            this.groupBox_service.Controls.Add(this.button_modify);
            this.groupBox_service.Controls.Add(this.button_add);
            this.groupBox_service.Controls.Add(this.button_query);
            this.groupBox_service.Controls.Add(this.textBox_id);
            this.groupBox_service.Controls.Add(this.label_id);
            this.groupBox_service.Location = new System.Drawing.Point(13, 13);
            this.groupBox_service.Name = "groupBox_service";
            this.groupBox_service.Size = new System.Drawing.Size(775, 104);
            this.groupBox_service.TabIndex = 0;
            this.groupBox_service.TabStop = false;
            this.groupBox_service.Text = "订单服务";
            // 
            // button_import
            // 
            this.button_import.Location = new System.Drawing.Point(450, 55);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(100, 30);
            this.button_import.TabIndex = 7;
            this.button_import.Text = "导入订单";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(340, 55);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(100, 30);
            this.button_export.TabIndex = 6;
            this.button_export.Text = "导出订单";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(230, 55);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(100, 30);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "删除订单";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(120, 55);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(100, 30);
            this.button_modify.TabIndex = 4;
            this.button_modify.Text = "修改订单";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(10, 55);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 30);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "添加订单";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(282, 20);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(87, 25);
            this.button_query.TabIndex = 2;
            this.button_query.Text = "查询";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(95, 20);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(181, 25);
            this.textBox_id.TabIndex = 1;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(7, 25);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(82, 15);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "订单编号：";
            // 
            // groupBox_order
            // 
            this.groupBox_order.Controls.Add(this.dataGridView2);
            this.groupBox_order.Controls.Add(this.dataGridView_order);
            this.groupBox_order.Location = new System.Drawing.Point(13, 123);
            this.groupBox_order.Name = "groupBox_order";
            this.groupBox_order.Size = new System.Drawing.Size(775, 315);
            this.groupBox_order.TabIndex = 1;
            this.groupBox_order.TabStop = false;
            this.groupBox_order.Text = "订单列表";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodNameDataGridViewTextBoxColumn,
            this.goodPriceDataGridViewTextBoxColumn,
            this.goodNumberDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource_detail;
            this.dataGridView2.Location = new System.Drawing.Point(6, 176);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(763, 133);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView_order
            // 
            this.dataGridView_order.AllowUserToAddRows = false;
            this.dataGridView_order.AllowUserToDeleteRows = false;
            this.dataGridView_order.AutoGenerateColumns = false;
            this.dataGridView_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientInfoDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.orderAmountDataGridViewTextBoxColumn,
            this.orderDiscountDataGridViewTextBoxColumn,
            this.orderCreateTimeDataGridViewTextBoxColumn});
            this.dataGridView_order.DataSource = this.bindingSource_order;
            this.dataGridView_order.Location = new System.Drawing.Point(6, 25);
            this.dataGridView_order.Name = "dataGridView_order";
            this.dataGridView_order.ReadOnly = true;
            this.dataGridView_order.RowHeadersWidth = 51;
            this.dataGridView_order.RowTemplate.Height = 27;
            this.dataGridView_order.Size = new System.Drawing.Size(763, 143);
            this.dataGridView_order.TabIndex = 0;
            // 
            // clientInfoDataGridViewTextBoxColumn
            // 
            this.clientInfoDataGridViewTextBoxColumn.DataPropertyName = "ClientInfo";
            this.clientInfoDataGridViewTextBoxColumn.HeaderText = "ClientInfo";
            this.clientInfoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientInfoDataGridViewTextBoxColumn.Name = "clientInfoDataGridViewTextBoxColumn";
            this.clientInfoDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientInfoDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderAmountDataGridViewTextBoxColumn
            // 
            this.orderAmountDataGridViewTextBoxColumn.DataPropertyName = "OrderAmount";
            this.orderAmountDataGridViewTextBoxColumn.HeaderText = "OrderAmount";
            this.orderAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderAmountDataGridViewTextBoxColumn.Name = "orderAmountDataGridViewTextBoxColumn";
            this.orderAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDiscountDataGridViewTextBoxColumn
            // 
            this.orderDiscountDataGridViewTextBoxColumn.DataPropertyName = "OrderDiscount";
            this.orderDiscountDataGridViewTextBoxColumn.HeaderText = "OrderDiscount";
            this.orderDiscountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDiscountDataGridViewTextBoxColumn.Name = "orderDiscountDataGridViewTextBoxColumn";
            this.orderDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderDiscountDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderCreateTimeDataGridViewTextBoxColumn
            // 
            this.orderCreateTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderCreateTime";
            this.orderCreateTimeDataGridViewTextBoxColumn.HeaderText = "OrderCreateTime";
            this.orderCreateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderCreateTimeDataGridViewTextBoxColumn.Name = "orderCreateTimeDataGridViewTextBoxColumn";
            this.orderCreateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderCreateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource_order
            // 
            this.bindingSource_order.DataSource = typeof(orderService.Order);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.bindingSource_order;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodNumberDataGridViewTextBoxColumn
            // 
            this.goodNumberDataGridViewTextBoxColumn.DataPropertyName = "GoodNumber";
            this.goodNumberDataGridViewTextBoxColumn.HeaderText = "GoodNumber";
            this.goodNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNumberDataGridViewTextBoxColumn.Name = "goodNumberDataGridViewTextBoxColumn";
            this.goodNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodPriceDataGridViewTextBoxColumn
            // 
            this.goodPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodPrice";
            this.goodPriceDataGridViewTextBoxColumn.HeaderText = "GoodPrice";
            this.goodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodPriceDataGridViewTextBoxColumn.Name = "goodPriceDataGridViewTextBoxColumn";
            this.goodPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_order);
            this.Controls.Add(this.groupBox_service);
            this.Name = "Form1";
            this.Text = "订单管理";
            this.groupBox_service.ResumeLayout(false);
            this.groupBox_service.PerformLayout();
            this.groupBox_order.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_service;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.GroupBox groupBox_order;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView_order;
        private System.Windows.Forms.BindingSource bindingSource_order;
        private System.Windows.Forms.BindingSource bindingSource_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCreateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
    }
}

