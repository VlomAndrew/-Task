using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СРМ_Солюшнс_Task
{
    public partial class FormCreateUser : Form
    {
        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            foreach (var item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    if (((TextBox) item).Text == string.Empty)
                    {
                        user = null;
                        errorProvider1.SetError((TextBox)item,"Проверьте правильность ввода");
                        return;
                    }

                }
            }

            using (UserContext db = new UserContext())
            {
                user = db.users.FirstOrDefault(u => u.Email == temail.Text);
                if (user != null)
                {
                    errorProvider1.SetError(temail, "Такой пользователь уже существует");
             
                    return;
                }
                user = db.users.FirstOrDefault(u => u.Phone == tphone.Text);
                if (user != null)
                {
                    errorProvider1.SetError(tphone, "Такой пользователь уже существует");
                    return;

                }
            }

            user = new User {GivenName = tname.Text,Surname = tsurname.Text,MiddleName = tlastname.Text,Email = temail.Text, Phone = tphone.Text};
            user.PasswordHash = User.Hash(tpass.Text);
            Close();
        }
    }
}
