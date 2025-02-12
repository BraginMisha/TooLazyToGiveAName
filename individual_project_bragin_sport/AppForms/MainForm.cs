using individual_project_bragin_sport.CustomControl;
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
using individual_project_bragin_sport.AppForms;
using System.Diagnostics;
using individual_project_bragin_sport.Temp;

namespace individual_project_bragin_sport.AppForms
{
    public partial class MainForm : Form
    {
        private List<goods_> goodList = new List<goods_>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartComboBoxes();
            ShowGoods();
        }
        private void StartComboBoxes()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            var goods = Program.context.goods_.ToList();
            foreach (goods_ good in goods)
            {
                bool next = false;
                foreach (string str in comboBox1.Items)
                {
                    if(str == good.suplier_.shop.ToString())
                        { next = true; break; }
                }
                if (!next) comboBox1.Items.Add(good.suplier_.shop.ToString());
                next = false;
                foreach (string str in comboBox2.Items)
                {
                    if (str == good.product_category_.product_cat.ToString())
                    { next = true; break; }
                }
                if (!next) comboBox2.Items.Add(good.product_category_.product_cat.ToString());
            }
            comboBox1.SelectedIndexChanged += Searching;
            comboBox2.SelectedIndexChanged += Searching;
        }

        private void ShowGoods()
        {
            splitContainer1.Panel2.Controls[0].Controls.Clear();
            var goods = Program.context.goods_.ToList();
            foreach (goods_ good in goods)
            {
                if((comboBox1.SelectedIndex==0|| good.suplier_.shop.ToString()==comboBox1.SelectedItem.ToString())&&
                    (comboBox2.SelectedIndex==0|| good.product_category_.product_cat.ToString() == comboBox2.SelectedItem.ToString())&&
                     good.description.ToLower().Contains(textBox1.Text.ToLower().Trim()))
                splitContainer1.Panel2.Controls[0].Controls.Add(new GoodsControl(good, this));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserMemory.autorized)
            {
                if (goodList.Count > 0)
                {
                    korzina korzina = new korzina(goodList);
                    korzina.ShowDialog();
                }
                else
                    MessageBox.Show("Ваша корзина пуста.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Вы должны быть авторизованы для составления заказа.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (button.Text == "Авторизоваться")
            {
                autorization autorization = new autorization();
                autorization.ShowDialog();
                if (UserMemory.autorized)
                {
                    button.Text = "Выйти из аккаунта";
                    label5.Text = $"Приветствуем, {UserMemory.username}!\nВаш уровень допуска: {UserMemory.securityLevel}";
                    if (UserMemory.securityLevel >= 1)
                        button2.Visible = true;
                }
                
            }
            else
            {
                UserMemory.Flash();
                button.Text = "Авторизоваться";
                label5.Text = "";
                button2.Visible = false;
                MessageBox.Show("Вы вышли из аккаунта", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void AddOrder(goods_ good)
        {
            goodList.Add(good);
        }
        public int GetCountInOrder(goods_ good)
        {
            return goodList.Count(it => it == good);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            historyorder historyorder= new historyorder();
            Hide();
            historyorder.ShowDialog();
            Show();
        }

        private void Searching(object sender, EventArgs e)
        {
            ShowGoods();
        }
    }
}
