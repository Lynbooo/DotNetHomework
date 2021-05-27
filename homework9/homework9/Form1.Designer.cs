
namespace homework9
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.Button();
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.lbl_message = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_message);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.tb_url);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 58);
            this.panel1.TabIndex = 0;
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(12, 17);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(550, 25);
            this.tb_url.TabIndex = 0;
            this.tb_url.Text = "https://www.baidu.com";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_result);
            this.panel2.Location = new System.Drawing.Point(13, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 472);
            this.panel2.TabIndex = 1;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(583, 17);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(80, 25);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // dgv_result
            // 
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_result.Location = new System.Drawing.Point(3, 3);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.RowHeadersWidth = 51;
            this.dgv_result.RowTemplate.Height = 27;
            this.dgv_result.Size = new System.Drawing.Size(979, 466);
            this.dgv_result.TabIndex = 0;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(696, 22);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 15);
            this.lbl_message.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.Label lbl_message;
    }
}

