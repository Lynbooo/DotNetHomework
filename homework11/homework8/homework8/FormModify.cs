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
    public partial class FormModify : Form
    {
        private int c;
        private OrderService service = new OrderService();
        private bool editMode; //mode=true=modify mode=false=add
        public Order CurrentOrder { get; set; }
        public Order OldOrder { get; set; } = new Order();
        //public Action<FormModify> CloseForm { get; set; }
        
        public FormModify()
        {
            InitializeComponent();
        }
        public FormModify(Order order, bool mode, OrderService service, int count)
        {
            InitializeComponent();
            this.service = service;
            this.editMode = mode;
            this.c = count;
            this.CurrentOrder = order;
            this.OldOrder = order;

            if (mode)
            {
                lbl_id.Text = CurrentOrder.OrderId;
                lbl_time.Text = Convert.ToString(CurrentOrder.OrderCreateTime);
                textBox_clientName.Text = CurrentOrder.ClientInfo.ClientName;
                textBox_clientTel.Text = CurrentOrder.ClientInfo.ClientTel;
                textBox_clientAddr.Text = CurrentOrder.ClientInfo.ClientAddress;
                textBox_orderDiscount.Text = Convert.ToString(CurrentOrder.OrderDiscount);
            }
            Client c = new Client("wang", "123", "whu");
            OrderDetails d = new OrderDetails("qq", 1, 2);
            Order o = new Order(c, "1", 0.9, DateTime.Now, d);
            CurrentOrder = o;
            //textBox_clientName.DataBindings.Add("Text", CurrentOrder.ClientInfo, "ClientName");
            //textBox_clientTel.DataBindings.Add("Text", CurrentOrder.ClientInfo, "ClientTel");
            //textBox_clientAddr.DataBindings.Add("Text", CurrentOrder.ClientInfo, "ClientAddress");
            //textBox_orderDiscount.DataBindings.Add("Text", CurrentOrder, "OrderDiscount");
            
        }

        private void button_saveOrder_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentOrder.ClientInfo.ClientName = textBox_clientName.Text;
                CurrentOrder.ClientInfo.ClientTel = textBox_clientTel.Text;
                CurrentOrder.ClientInfo.ClientAddress = textBox_clientAddr.Text;
                CurrentOrder.OrderDiscount = Convert.ToDouble(textBox_orderDiscount.Text);
                CurrentOrder.OrderCreateTime = DateTime.Now;
                CurrentOrder.OrderId = Convert.ToString(DateTime.Now.Year)
                            + Convert.ToString(DateTime.Now.Month)
                            + Convert.ToString(DateTime.Now.Day)
                            + Convert.ToString(c);
                if (this.editMode) {
                    service.ModifyOrder(OldOrder, CurrentOrder);
                }else {
                    service.AddOrder(CurrentOrder);
                }
                //CloseForm(this);
                if (this != null) this.Close();
            }
            catch (Exception exc1)
            {
                MessageBox.Show(exc1.Message);
            }
        }

        private void button_addDetail_Click(object sender, EventArgs e)
        {
            FormDetailEdit formDetailEdit = new FormDetailEdit(new OrderDetails(), editMode);
            try {
                if (formDetailEdit.ShowDialog() == DialogResult.OK) {
                    CurrentOrder.AddOrderDetail(formDetailEdit.Detail);
                    bindingSource1.ResetBindings(false);
                    orderDetailsBindingSource.ResetBindings(false);
                }
            }catch(Exception exc2) {
                MessageBox.Show(exc2.Message);
            }
        }
    }
}