using individual_project_bragin_sport.AppForms;
using individual_project_bragin_sport.Models;
using individual_project_bragin_sport.Properties;
using individual_project_bragin_sport.Temp;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individual_project_bragin_sport.CustomControl
{
    public partial class GoodsControl : UserControl
    {
        private goods_ good;
        private MainForm mainForm;
        private korzina korzina;
        public GoodsControl(Models.goods_ good, MainForm mainForm)
        {
            InitializeComponent();
            this.good = good;
            this.mainForm = mainForm;
            SetLabeTextlValues();
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        public GoodsControl(Models.goods_ good, korzina korzina)
        {
            InitializeComponent();
            this.good = good;
            this.korzina = korzina;
            SetLabeTextlValues();
            button1.Visible = false;
            label2.Visible = label3.Visible = button2.Visible = button3.Visible = true;
            label3.Text = korzina.goodList.Count(x => x == good).ToString();
        }

        public goods_ Goods => good;

        private void SetLabeTextlValues()
        {
            if (good.image != null && good.image != "")
            {
                string imageName = good.image.Replace(".jpg", "").Replace(".jpeg", "");

                pictureBox.Image = Resources.ResourceManager.GetObject(imageName) as Bitmap;
                if (pictureBox.Image == null)
                {
                    pictureBox.Image = Resources.picture;
                }
            }
            else
            {
                pictureBox.Image = Resources.picture;
            }
        

            
           
            description.Text = good.description;
            supplier.Text = good.suplier_.shop.ToString();
            Quantity_in_stock.Text = $"Осталось на складе: {good.Quantity_in_stock.ToString()}";
            price.Text = $"цена: {good.price}";
            product_category.Text = good.product_category_.product_cat.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserMemory.autorized)
            {
                if (mainForm.GetCountInOrder(good) == int.Parse(Quantity_in_stock.Text.Replace("Осталось на складе: ", "")))
                {
                    MessageBox.Show("Вы добавили максимальное количество предметов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                mainForm.AddOrder(good);
                label1.Text = $"Добавлено! ({mainForm.GetCountInOrder(good).ToString()})";
                label1.Visible=true;
                timer1.Start();
            }
            else
                MessageBox.Show("Вы должны быть авторизованы для составления заказа.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(korzina.goodList.Count(x => x== good)!=1 ||
                MessageBox.Show("Вы действительно хотите удалить из корзины данную позицию?",
                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            korzina.goodList.Remove(good);
            korzina.ShowGoods();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(korzina.goodList.Count(x => x == good) == int.Parse(Quantity_in_stock.Text.Replace("Осталось на складе: ", "")))
            {
                MessageBox.Show("Вы добавили максимальное количество предметов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            korzina.goodList.Add(good);
            korzina.ShowGoods();
        }
    }

}
