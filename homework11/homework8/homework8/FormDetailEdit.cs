using orderService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace homework8
{
    public partial class FormDetailEdit : Form
    {
        public OrderDetails Detail { get; set; } = new OrderDetails();
        public FormDetailEdit()
        {
            InitializeComponent();
        }
        public FormDetailEdit(OrderDetails detail, Boolean mode) : this()
        {
            this.Detail = detail;
            if (mode)
            {
                Detail.GoodName = detail.GoodName;
                Detail.GoodNumber = detail.GoodNumber;
                Detail.GoodPrice = detail.GoodPrice;
            }
            //textBox_goodName.DataBindings.Add("Text", Detail, "GoodName");
            //textBox_goodPrice.DataBindings.Add("Text", Detail, "GoodPrice");
            //textBox_goodNumber.DataBindings.Add("Text", Detail, "GoodNumber");
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                Detail.GoodName = textBox_goodName.Text;
                Detail.GoodNumber = Convert.ToInt32(textBox_goodNumber.Text);
                Detail.GoodPrice = Convert.ToDouble(textBox_goodPrice.Text);
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            
        }
    }
}
