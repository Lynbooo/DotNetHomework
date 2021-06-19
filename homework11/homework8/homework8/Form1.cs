using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using orderService;

namespace homework8
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public OrderService service = new OrderService();
        public String OrderId { get; set; }
        public Order CurrentOrder { get; set; } = new Order();
        public Form1()
        {
            InitializeComponent();
            bindingSource_order.DataSource = service.ordersList;
            bindingSource_detail.DataSource = bindingSource_order;
            bindingSource_detail.DataMember = "orderDetails";
            textBox_id.DataBindings.Add("Text", this, "OrderId");
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            //调出订单修改界面
            count++;
            FormModify form2 = new FormModify(CurrentOrder, false, service, count);
            form2.ShowDialog();
            bindingSource_order.ResetBindings(false);
            bindingSource_detail.ResetBindings(false);
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            //CurrentOrder = service.QueryOrder(OrderId);
            CurrentOrder = bindingSource_order.Current as Order;
            if (CurrentOrder == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            //调出订单修改界面
            FormModify form2 = new FormModify(CurrentOrder, true, service, count);
            form2.ShowDialog();
            bindingSource_order.ResetBindings(false);
            bindingSource_detail.ResetBindings(false);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //CurrentOrder = service.QueryOrder(OrderId);
            CurrentOrder = bindingSource_order.Current as Order;
            if (CurrentOrder == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            service.DeleteOrder(CurrentOrder);
            QueryAll();
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                service.Export(fileName);
            }
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                service.Import(fileName);
                QueryAll();
            }
        }

        private void button_query_Click(object sender, EventArgs e)
        {
            Order order = service.QueryOrder(OrderId);
            if (order != null) bindingSource_order.DataSource = order;
            else MessageBox.Show("无此订单");
        }
        public void QueryAll()
        {
            bindingSource_order.DataSource = service.ordersList;
            bindingSource_order.ResetBindings(false);
            bindingSource_detail.ResetBindings(false);
        }
    }
}
