using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СРМ_Солюшнс_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            FormCreateUser f = new FormCreateUser();
            f.ShowDialog();
            var user = f.user;
            if (user== null) return;
            user.Id = Guid.NewGuid();
            f.Dispose();

            using (UserContext db = new UserContext())
            {
                db.users.Add(user);
                db.SaveChanges();
            }
        }

        private void bLog_Click(object sender, EventArgs e)
        {
            if (tlogin.Text != string.Empty && tpass.Text != string.Empty)
            {
                using (UserContext db = new UserContext())
                {
                    var user = db.users.FirstOrDefault(u => u.Email == tlogin.Text || u.Phone == tlogin.Text);
                    if (user == null)
                    {
                        errorProvider1.SetError(tlogin,"неверный логин");
                        return;
                    }

                    if (User.UnHash(user.PasswordHash) == tpass.Text)
                    {
                        currentUser = user;
                        richTextBox1.Text = string.Format("Вы работаете с пользователем: \n Email = {0}\n Name = {1}\n Phone = {2}\n",user.Email,user.GivenName,user.Phone);
                        bLook.Enabled = true;  
                        bload.Enabled = true;
                        bunload.Enabled = true;
                        bout.Enabled = true;
                        filesList.Enabled = true;
                        string userFolder = Auxi.ServerFolderPath + '\\' + currentUser.GivenName + currentUser.Surname;
                        var dir = new DirectoryInfo(userFolder);
                        if (dir.Exists)
                        {
                            foreach (var file in dir.GetFiles())
                            {
                                filesList.Items.Add(file);
                            }
                        }
                        errorProvider1.Clear();
                    }
                    else
                    {
                        errorProvider1.SetError(tpass,"Неверный пароль");
                    }
                }
            }
        }

        private void bout_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            bLook.Enabled = false;
            
            bload.Enabled = false;
            bunload.Enabled = false;
            bout.Enabled = false;
            tlogin.Text = string.Empty;
            tpass.Text = string.Empty;
            filesList.Enabled = false;
            filesList.Items.Clear();
        }

        private void bLook_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            textBox3.Text = filename;
            
        }

        private void bload_Click(object sender, EventArgs e)
        {
            var filename = textBox3.Text;
            filename = filename.Substring(filename.LastIndexOf('\\'));
            string userFolder = Auxi.ServerFolderPath + '\\' + currentUser.GivenName + currentUser.Surname;
            if (!Directory.Exists(userFolder))
            {
                Directory.CreateDirectory(userFolder);
            }
            string newPath = userFolder + filename;
            FileInfo fInfo = new FileInfo(openFileDialog1.FileName);
            if (fInfo.Exists)
            {
                var dir = new DirectoryInfo(userFolder);
                fInfo.CopyTo(newPath, true);
                filesList.Items.Clear();
                foreach (var file in dir.GetFiles())
                {
                    filesList.Items.Add(file);
                }
            }
        }

        private void bunload_Click(object sender, EventArgs e)
        {
            if (filesList.SelectedIndex != -1)
            {
                var filename = filesList.Items[filesList.SelectedIndex].ToString();
                var loadPath = Auxi.LoadPath + '\\' + filename;
                string userFile = Auxi.ServerFolderPath + '\\' + currentUser.Email + '\\'+filename;
                FileInfo fInfo = new FileInfo(userFile);
                if (fInfo.Exists)
                {
                    fInfo.CopyTo(loadPath, true);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = string.Empty;
            using (UserContext db = new UserContext())
            {
                foreach (var user in db.users)
                {
                    richTextBox2.Text+=user.ToString();
                }
            }
        }

        
    }
}
