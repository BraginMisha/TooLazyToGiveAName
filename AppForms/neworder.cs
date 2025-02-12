using individual_project_bragin_sport.Models;
using individual_project_bragin_sport.Temp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individual_project_bragin_sport.AppForms
{
    public partial class neworder : Form
    {
        public List<goods_> goodList;
        public neworder(List<goods_> goodList)
        {
            this.goodList = goodList;
            InitializeComponent();
        }

        private void neworder_Load(object sender, EventArgs e)
        {
            foreach(C_pick_up_point__ item in Program.context.C_pick_up_point__)
            {
                comboBox1.Items.Add($"{item.index}, {item.city_point_.city}, {item.street} {item.house}");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                button1.Enabled = true;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (MessageBox.Show("Вы уверены, что указали всё правильно?", "Заказ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var order = Program.context.order_;

                var orderNumber = order.Max(it => it.orderNumber) + 1;
                var verificationCode = rand.Next(100, 1000);
                while (goodList.Count > 0)
                {
                    order.Add(new order_()
                    {
                        id_order = order.Max(it => it.id_order) + 1,
                        orderNumber = orderNumber,
                        id_goods = goodList.First().id_goods,
                        kolichestvo = goodList.Count(it => it == goodList.First()),
                        date_order = DateTime.Now,
                        date_delivery = DateTime.Now.AddDays(7),
                        pick_up_point = Program.context.C_pick_up_point__.ToList()[comboBox1.SelectedIndex].id_point,
                        fio_clienta = UserMemory.userID,
                        cod_verification = verificationCode,
                        status_order = 3
                    });
                    goodList.RemoveAll(it => it == goodList.First());
                    Program.context.SaveChanges();
                }
                MessageBox.Show("Ваш заказ успешен!", "Успешно!", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}
