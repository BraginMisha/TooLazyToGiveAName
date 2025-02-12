using individual_project_bragin_sport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individual_project_bragin_sport.AppForms
{
    public partial class AddChangingOrder : Form
    {
        DataGridViewRow data;
        public AddChangingOrder()
        {
            InitializeComponent();
            foreach (var item in Program.context.goods_)
                comboBox1.Items.Add(item.name);
            comboBox1.SelectedIndex = 0;
            foreach (var item in Program.context.C_pick_up_point__)
                comboBox2.Items.Add($"{item.index}, {item.city_point_.city}, {item.street} {item.house}");
            comboBox2.SelectedIndex = 0;
            foreach (var item in Program.context.user_)
                comboBox3.Items.Add($"{item.Surname} {item.name} {item.otchestvo}");
            comboBox3.SelectedIndex = 0;
            foreach (var item in Program.context.status_order_)
                comboBox4.Items.Add(item.status_order);
            comboBox4.SelectedIndex = 0;
        }
        public AddChangingOrder(DataGridViewRow data)
        {
            InitializeComponent();
            this.data = data;
            numericUpDown2.Value = (int)data.Cells["orderNumber"].Value;
            foreach (var item in Program.context.goods_)
                comboBox1.Items.Add(item.name);
            comboBox1.SelectedIndex = (int)data.Cells["id_goods"].Value - 1;
            numericUpDown1.Value = (int)data.Cells["kolichestvo"].Value;
            date_orderDateTimePicker.Value = (DateTime)data.Cells["date_order"].Value;
            dateTimePicker1.Value = (DateTime)data.Cells["date_delivery"].Value;
            foreach (var item in Program.context.C_pick_up_point__)
                comboBox2.Items.Add($"{item.index}, {item.city_point_.city}, {item.street} {item.house}");
            comboBox2.SelectedIndex = (int)data.Cells["pick_up_point"].Value - 1;
            foreach (var item in Program.context.user_)
                comboBox3.Items.Add($"{item.Surname} {item.name} {item.otchestvo}");
            comboBox3.SelectedIndex = (int)data.Cells["fio_clienta"].Value - 1;
            textBox4.Text = data.Cells["cod_verification"].Value.ToString();
            foreach (var item in Program.context.status_order_)
                comboBox4.Items.Add(item.status_order);
            comboBox4.SelectedIndex = (int)data.Cells["status_order"].Value - 1;
        }

        private void order_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void AddChangingOrder_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (data != null)
            {
                int idbuf = (int)data.Cells["id_order"].Value;
                var order = Program.context.order_.Where(it => it.id_order == idbuf ).First();
                order.orderNumber = (int)numericUpDown2.Value;
                order.id_goods = comboBox1.SelectedIndex + 1;
                order.kolichestvo = (int)numericUpDown1.Value;
                order.date_order = date_orderDateTimePicker.Value;
                order.date_delivery = dateTimePicker1.Value;
                order.pick_up_point = comboBox2.SelectedIndex + 1;
                order.fio_clienta = comboBox3.SelectedIndex + 1;
                int buf = -1;
                int.TryParse(textBox4.Text, out buf);
                if(buf!=-1)
                    order.cod_verification = buf;
                else
                {
                    Random r = new Random();
                    order.cod_verification = r.Next(100, 1000);
                }
                order.status_order = comboBox4.SelectedIndex + 1;
            }
            else
            {
                var order = new order_();
                order.orderNumber = (int)numericUpDown2.Value;
                order.id_goods = comboBox1.SelectedIndex + 1;
                order.kolichestvo = (int)numericUpDown1.Value;
                order.date_order = date_orderDateTimePicker.Value;
                order.date_delivery = dateTimePicker1.Value;
                order.pick_up_point = comboBox2.SelectedIndex + 1;
                order.fio_clienta = comboBox3.SelectedIndex + 1;
                int buf = -1;
                int.TryParse(textBox4.Text, out buf);
                if (buf != -1)
                    order.cod_verification = buf;
                else
                {
                    Random r = new Random();
                    order.cod_verification = r.Next(100, 1000);
                }
                order.status_order = comboBox4.SelectedIndex + 1;
                Program.context.order_.Add(order);
            }
            Program.context.SaveChanges();
            MessageBox.Show("Успешно сохранено!", "Успех!", MessageBoxButtons.OK);
            Close();
        }
    }
}
