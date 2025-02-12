using individual_project_bragin_sport.CustomControl;
using individual_project_bragin_sport.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace individual_project_bragin_sport.AppForms
{
    public partial class korzina : Form
    {
        public List<goods_> goodList;
        public korzina(List<goods_> goodList)
        {
            InitializeComponent();
            this.goodList = goodList;
            ShowGoods();
        }
        
        public void ShowGoods()
        {
            if (goodList.Count == 0) 
            {
                MessageBox.Show("Ваша корзина пуста, вы будете возвращены в меню","Внимание!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Close();
            }
            var panel = splitContainer1.Panel2.Controls[0];
            panel.Controls.Clear();
            var sortList = goodList.OrderBy(x => x.id_goods).Distinct().ToList();
            foreach (goods_ good in sortList)
            {
                var newControl = new GoodsControl(good, this);
                panel.Controls.Add(newControl);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            neworder neworder = new neworder(goodList);
            neworder.ShowDialog();
            if (goodList.Count == 0)
                Close();
        }
    }
}
