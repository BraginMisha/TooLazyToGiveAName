using individual_project_bragin_sport.Models;
using individual_project_bragin_sport.Temp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace individual_project_bragin_sport.AppForms
{
    public partial class historyorder : Form
    {
        public historyorder()
        {
            InitializeComponent();
        }

        private void historyorder_Load(object sender, EventArgs e)
        {
            GridCreating();
            if (UserMemory.securityLevel < 3)
            {
                groupBox1.Visible = false;
            }
        }

        private void GridCreating()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;
            if (UserMemory.securityLevel < 2)
                dataGridView1.DataSource = Program.context.order_.Where(it=>it.fio_clienta==UserMemory.userID).ToList();
            else
                dataGridView1.DataSource = Program.context.order_.ToList();
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.Visible = false;////////
            }
            dataGridView1.Columns["orderNumber"].Visible = true;
            dataGridView1.Columns["orderNumber"].DisplayIndex = 0;
            dataGridView1.Columns["orderNumber"].HeaderText = "Номер заказа";
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "good", HeaderText = "Позиция" });
            dataGridView1.Columns["good"].DisplayIndex = 1;
            dataGridView1.Columns["kolichestvo"].Visible = true;
            dataGridView1.Columns["kolichestvo"].DisplayIndex = 2;
            dataGridView1.Columns["kolichestvo"].HeaderText = "Количество";
            dataGridView1.Columns["date_order"].Visible = true;
            dataGridView1.Columns["date_order"].DisplayIndex = 3;
            dataGridView1.Columns["date_order"].HeaderText = "Дата заказа";
            dataGridView1.Columns["date_delivery"].Visible = true;
            dataGridView1.Columns["date_delivery"].DisplayIndex = 4;
            dataGridView1.Columns["date_delivery"].HeaderText = "дата доставки";
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "pickup", HeaderText = "Место доставки" });
            dataGridView1.Columns["pickup"].DisplayIndex = 5; 
            dataGridView1.Columns["cod_verification"].Visible = true;
            dataGridView1.Columns["cod_verification"].HeaderText = "Код подтверждения";
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { Name = "status", HeaderText = "Статус заявки" });
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int idBuffer = (int)row.Cells["id_goods"].Value;
                row.Cells["good"].Value = Program.context.goods_.Where(x => x.id_goods == idBuffer).ToList()[0].description;
                idBuffer = (int)row.Cells["pick_up_point"].Value;
                C_pick_up_point__ result1 = Program.context.C_pick_up_point__.Where(x => x.id_point == idBuffer).ToList()[0];
                row.Cells["pickup"].Value = $"{result1.index}, {result1.city_point_.city}, {result1.street} {result1.house}";
                idBuffer = (int)row.Cells["status_order"].Value;
                row.Cells["status"].Value = Program.context.status_order_.Where(x => x.status_id == idBuffer).ToList()[0].status_order;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
                if (MessageBox.Show($"Вы уверены, что хотите удалить данн{(dataGridView1.SelectedRows.Count > 1 ? "ые" : "ую")} позиц{(dataGridView1.SelectedRows.Count > 1 ? "ии" : "ию")}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        var idBuffer = (int)row.Cells["id_order"].Value;
                        Program.context.order_.Remove(Program.context.order_.Where(it => it.id_order == idBuffer).First());
                    }
                    Program.context.SaveChanges();
                    GridCreating();
                }
                else;
            else
                MessageBox.Show("Выберите, что хотите удалить", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddChangingOrder add = new AddChangingOrder();
            add.ShowDialog();
            GridCreating();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddChangingOrder add = new AddChangingOrder(dataGridView1.SelectedRows[0]);
            add.ShowDialog();
            GridCreating();
        }
    }
}
