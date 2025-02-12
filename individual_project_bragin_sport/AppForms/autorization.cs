using individual_project_bragin_sport.Temp;
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
    public partial class autorization : Form
    {
        public autorization()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            foreach (var user in Program.context.user_.ToList())
            {
                if (loginTB.Text == user.login.ToString() && passwordTB.Text == user.password.ToString())
                {
                    MessageBox.Show("Вы успешно авторизовались!","Успех!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    UserMemory.autorized = true;
                    UserMemory.username = $"{user.Surname} {user.name} {user.otchestvo}";
                    UserMemory.securityLevel = user.account_level;
                    UserMemory.userID = user.id_user;
                    Close();
                }
            }
        }
    }
}
