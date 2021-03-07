namespace counter_Framework
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
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.equal = new System.Windows.Forms.Label();
            this.lbl_operator = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_pow = new System.Windows.Forms.Button();
            this.button_mod = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.textBox_outcome = new System.Windows.Forms.TextBox();
            this.button_clean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(88, 106);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(100, 25);
            this.textBox_x.TabIndex = 1;
            this.textBox_x.TextChanged += new System.EventHandler(this.textBox_x_TextChanged);
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(241, 106);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(100, 25);
            this.textBox_y.TabIndex = 2;
            this.textBox_y.TextChanged += new System.EventHandler(this.textBox_y_TextChanged);
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(368, 111);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(15, 15);
            this.equal.TabIndex = 3;
            this.equal.Text = "=";
            // 
            // lbl_operator
            // 
            this.lbl_operator.AutoSize = true;
            this.lbl_operator.Location = new System.Drawing.Point(206, 111);
            this.lbl_operator.Name = "lbl_operator";
            this.lbl_operator.Size = new System.Drawing.Size(15, 15);
            this.lbl_operator.TabIndex = 5;
            this.lbl_operator.Text = "+";
            this.lbl_operator.Click += new System.EventHandler(this.lbl_operator_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(50, 181);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(25, 25);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_sub
            // 
            this.button_sub.Location = new System.Drawing.Point(140, 181);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(25, 25);
            this.button_sub.TabIndex = 7;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.button_sub_Click);
            // 
            // button_mult
            // 
            this.button_mult.Location = new System.Drawing.Point(230, 181);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(25, 25);
            this.button_mult.TabIndex = 8;
            this.button_mult.Text = "*";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.Click += new System.EventHandler(this.button_mult_Click);
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(320, 181);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(25, 25);
            this.button_div.TabIndex = 9;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button_pow
            // 
            this.button_pow.Location = new System.Drawing.Point(500, 181);
            this.button_pow.Name = "button_pow";
            this.button_pow.Size = new System.Drawing.Size(25, 25);
            this.button_pow.TabIndex = 10;
            this.button_pow.Text = "^";
            this.button_pow.UseVisualStyleBackColor = true;
            this.button_pow.Click += new System.EventHandler(this.button_pow_Click);
            // 
            // button_mod
            // 
            this.button_mod.Location = new System.Drawing.Point(410, 181);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(25, 25);
            this.button_mod.TabIndex = 11;
            this.button_mod.Text = "%";
            this.button_mod.UseVisualStyleBackColor = true;
            this.button_mod.Click += new System.EventHandler(this.button_mod_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(249, 42);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(87, 15);
            this.title.TabIndex = 12;
            this.title.Text = "CALCULATOR";
            // 
            // textBox_outcome
            // 
            this.textBox_outcome.Location = new System.Drawing.Point(410, 106);
            this.textBox_outcome.Name = "textBox_outcome";
            this.textBox_outcome.ReadOnly = true;
            this.textBox_outcome.Size = new System.Drawing.Size(100, 25);
            this.textBox_outcome.TabIndex = 13;
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(252, 240);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(75, 23);
            this.button_clean.TabIndex = 14;
            this.button_clean.Text = "clean";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 290);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.textBox_outcome);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button_mod);
            this.Controls.Add(this.button_pow);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.lbl_operator);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Label lbl_operator;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_pow;
        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox textBox_outcome;
        private System.Windows.Forms.Button button_clean;
    }
}

