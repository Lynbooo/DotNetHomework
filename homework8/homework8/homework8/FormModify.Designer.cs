
namespace homework8
{
    partial class FormModify
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
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.textBox_orderDiscount = new System.Windows.Forms.TextBox();
            this.textBox_clientAddr = new System.Windows.Forms.TextBox();
            this.textBox_clientTel = new System.Windows.Forms.TextBox();
            this.textBox_clientName = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label_discount = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_clientAddr = new System.Windows.Forms.Label();
            this.label_clientTel = new System.Windows.Forms.Label();
            this.label_clientName = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_saveOrder = new System.Windows.Forms.Button();
            this.button_deleteDetail = new System.Windows.Forms.Button();
            this.button_modifyDetail = new System.Windows.Forms.Button();
            this.button_addDetail = new System.Windows.Forms.Button();
            this.groupBox_details = new System.Windows.Forms.GroupBox();
            this.dataGridView_orderDetails = new System.Windows.Forms.DataGridView();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox_details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.lbl_time);
            this.groupBox_info.Controls.Add(this.textBox_orderDiscount);
            this.groupBox_info.Controls.Add(this.textBox_clientAddr);
            this.groupBox_info.Controls.Add(this.textBox_clientTel);
            this.groupBox_info.Controls.Add(this.textBox_clientName);
            this.groupBox_info.Controls.Add(this.lbl_id);
            this.groupBox_info.Controls.Add(this.label_discount);
            this.groupBox_info.Controls.Add(this.label_time);
            this.groupBox_info.Controls.Add(this.label_clientAddr);
            this.groupBox_info.Controls.Add(this.label_clientTel);
            this.groupBox_info.Controls.Add(this.label_clientName);
            this.groupBox_info.Controls.Add(this.label_id);
            this.groupBox_info.Location = new System.Drawing.Point(12, 12);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(776, 188);
            this.groupBox_info.TabIndex = 0;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "订单信息";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(367, 26);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(0, 15);
            this.lbl_time.TabIndex = 11;
            // 
            // textBox_orderDiscount
            // 
            this.textBox_orderDiscount.Location = new System.Drawing.Point(100, 153);
            this.textBox_orderDiscount.Name = "textBox_orderDiscount";
            this.textBox_orderDiscount.Size = new System.Drawing.Size(100, 25);
            this.textBox_orderDiscount.TabIndex = 10;
            this.textBox_orderDiscount.Text = "1.0";
            // 
            // textBox_clientAddr
            // 
            this.textBox_clientAddr.Location = new System.Drawing.Point(100, 114);
            this.textBox_clientAddr.Name = "textBox_clientAddr";
            this.textBox_clientAddr.Size = new System.Drawing.Size(100, 25);
            this.textBox_clientAddr.TabIndex = 9;
            this.textBox_clientAddr.Text = "default";
            // 
            // textBox_clientTel
            // 
            this.textBox_clientTel.Location = new System.Drawing.Point(100, 86);
            this.textBox_clientTel.Name = "textBox_clientTel";
            this.textBox_clientTel.Size = new System.Drawing.Size(100, 25);
            this.textBox_clientTel.TabIndex = 8;
            this.textBox_clientTel.Text = "000";
            // 
            // textBox_clientName
            // 
            this.textBox_clientName.Location = new System.Drawing.Point(100, 58);
            this.textBox_clientName.Name = "textBox_clientName";
            this.textBox_clientName.Size = new System.Drawing.Size(100, 25);
            this.textBox_clientName.TabIndex = 7;
            this.textBox_clientName.Text = "default";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(100, 25);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 15);
            this.lbl_id.TabIndex = 6;
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.Location = new System.Drawing.Point(20, 156);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(75, 15);
            this.label_discount.TabIndex = 5;
            this.label_discount.Text = "订单折扣:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(287, 25);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(75, 15);
            this.label_time.TabIndex = 4;
            this.label_time.Text = "下单时间:";
            // 
            // label_clientAddr
            // 
            this.label_clientAddr.AutoSize = true;
            this.label_clientAddr.Location = new System.Drawing.Point(20, 118);
            this.label_clientAddr.Name = "label_clientAddr";
            this.label_clientAddr.Size = new System.Drawing.Size(75, 15);
            this.label_clientAddr.TabIndex = 3;
            this.label_clientAddr.Text = "客户地址:";
            // 
            // label_clientTel
            // 
            this.label_clientTel.AutoSize = true;
            this.label_clientTel.Location = new System.Drawing.Point(20, 90);
            this.label_clientTel.Name = "label_clientTel";
            this.label_clientTel.Size = new System.Drawing.Size(75, 15);
            this.label_clientTel.TabIndex = 2;
            this.label_clientTel.Text = "客户号码:";
            // 
            // label_clientName
            // 
            this.label_clientName.AutoSize = true;
            this.label_clientName.Location = new System.Drawing.Point(20, 63);
            this.label_clientName.Name = "label_clientName";
            this.label_clientName.Size = new System.Drawing.Size(75, 15);
            this.label_clientName.TabIndex = 1;
            this.label_clientName.Text = "客户姓名:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(20, 25);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(75, 15);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "订单编号:";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "OrderDetails";
            this.bindingSource1.DataSource = typeof(orderService.Order);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_saveOrder);
            this.panel1.Controls.Add(this.button_deleteDetail);
            this.panel1.Controls.Add(this.button_modifyDetail);
            this.panel1.Controls.Add(this.button_addDetail);
            this.panel1.Location = new System.Drawing.Point(12, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 49);
            this.panel1.TabIndex = 2;
            // 
            // button_saveOrder
            // 
            this.button_saveOrder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_saveOrder.Location = new System.Drawing.Point(649, 9);
            this.button_saveOrder.Name = "button_saveOrder";
            this.button_saveOrder.Size = new System.Drawing.Size(121, 36);
            this.button_saveOrder.TabIndex = 3;
            this.button_saveOrder.Text = "保存订单";
            this.button_saveOrder.UseVisualStyleBackColor = true;
            this.button_saveOrder.Click += new System.EventHandler(this.button_saveOrder_Click);
            // 
            // button_deleteDetail
            // 
            this.button_deleteDetail.Location = new System.Drawing.Point(220, 9);
            this.button_deleteDetail.Name = "button_deleteDetail";
            this.button_deleteDetail.Size = new System.Drawing.Size(86, 36);
            this.button_deleteDetail.TabIndex = 2;
            this.button_deleteDetail.Text = "删除明细";
            this.button_deleteDetail.UseVisualStyleBackColor = true;
            // 
            // button_modifyDetail
            // 
            this.button_modifyDetail.Location = new System.Drawing.Point(115, 9);
            this.button_modifyDetail.Name = "button_modifyDetail";
            this.button_modifyDetail.Size = new System.Drawing.Size(85, 36);
            this.button_modifyDetail.TabIndex = 1;
            this.button_modifyDetail.Text = "修改明细";
            this.button_modifyDetail.UseVisualStyleBackColor = true;
            // 
            // button_addDetail
            // 
            this.button_addDetail.Location = new System.Drawing.Point(7, 9);
            this.button_addDetail.Name = "button_addDetail";
            this.button_addDetail.Size = new System.Drawing.Size(89, 36);
            this.button_addDetail.TabIndex = 0;
            this.button_addDetail.Text = "添加明细";
            this.button_addDetail.UseVisualStyleBackColor = true;
            this.button_addDetail.Click += new System.EventHandler(this.button_addDetail_Click);
            // 
            // groupBox_details
            // 
            this.groupBox_details.Controls.Add(this.dataGridView_orderDetails);
            this.groupBox_details.Location = new System.Drawing.Point(12, 206);
            this.groupBox_details.Name = "groupBox_details";
            this.groupBox_details.Size = new System.Drawing.Size(776, 177);
            this.groupBox_details.TabIndex = 7;
            this.groupBox_details.TabStop = false;
            this.groupBox_details.Text = "订单明细";
            // 
            // dataGridView_orderDetails
            // 
            this.dataGridView_orderDetails.AutoGenerateColumns = false;
            this.dataGridView_orderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodNameDataGridViewTextBoxColumn,
            this.goodPriceDataGridViewTextBoxColumn,
            this.goodNumberDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.dataGridView_orderDetails.DataSource = this.bindingSource1;
            this.dataGridView_orderDetails.Location = new System.Drawing.Point(7, 24);
            this.dataGridView_orderDetails.Name = "dataGridView_orderDetails";
            this.dataGridView_orderDetails.RowHeadersWidth = 51;
            this.dataGridView_orderDetails.RowTemplate.Height = 27;
            this.dataGridView_orderDetails.Size = new System.Drawing.Size(763, 151);
            this.dataGridView_orderDetails.TabIndex = 0;
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodPriceDataGridViewTextBoxColumn
            // 
            this.goodPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodPrice";
            this.goodPriceDataGridViewTextBoxColumn.HeaderText = "GoodPrice";
            this.goodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodPriceDataGridViewTextBoxColumn.Name = "goodPriceDataGridViewTextBoxColumn";
            this.goodPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodNumberDataGridViewTextBoxColumn
            // 
            this.goodNumberDataGridViewTextBoxColumn.DataPropertyName = "GoodNumber";
            this.goodNumberDataGridViewTextBoxColumn.HeaderText = "GoodNumber";
            this.goodNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNumberDataGridViewTextBoxColumn.Name = "goodNumberDataGridViewTextBoxColumn";
            this.goodNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = this.bindingSource1;
            // 
            // FormModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_details);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_info);
            this.Name = "FormModify";
            this.Text = "FormModify";
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox_details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.Label label_clientName;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_saveOrder;
        private System.Windows.Forms.Button button_deleteDetail;
        private System.Windows.Forms.Button button_modifyDetail;
        private System.Windows.Forms.Button button_addDetail;
        private System.Windows.Forms.Label label_discount;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_clientAddr;
        private System.Windows.Forms.Label label_clientTel;
        private System.Windows.Forms.GroupBox groupBox_details;
        private System.Windows.Forms.DataGridView dataGridView_orderDetails;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox textBox_orderDiscount;
        private System.Windows.Forms.TextBox textBox_clientAddr;
        private System.Windows.Forms.TextBox textBox_clientTel;
        private System.Windows.Forms.TextBox textBox_clientName;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
    }
}