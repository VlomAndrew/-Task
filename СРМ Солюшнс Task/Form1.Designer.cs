namespace СРМ_Солюшнс_Task
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filesList = new System.Windows.Forms.ComboBox();
            this.bout = new System.Windows.Forms.Button();
            this.bunload = new System.Windows.Forms.Button();
            this.bload = new System.Windows.Forms.Button();
            this.bLook = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bLog = new System.Windows.Forms.Button();
            this.tpass = new System.Windows.Forms.TextBox();
            this.tlogin = new System.Windows.Forms.TextBox();
            this.bCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 59);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(136, 324);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Все пользователи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(640, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 389);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тестовый элемент";
            // 
            // filesList
            // 
            this.filesList.FormattingEnabled = true;
            this.filesList.Location = new System.Drawing.Point(213, 267);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(183, 21);
            this.filesList.TabIndex = 34;
            // 
            // bout
            // 
            this.bout.Enabled = false;
            this.bout.Location = new System.Drawing.Point(42, 143);
            this.bout.Name = "bout";
            this.bout.Size = new System.Drawing.Size(152, 32);
            this.bout.TabIndex = 33;
            this.bout.Text = "Log out";
            this.bout.UseVisualStyleBackColor = true;
            this.bout.Click += new System.EventHandler(this.bout_Click);
            // 
            // bunload
            // 
            this.bunload.Enabled = false;
            this.bunload.Location = new System.Drawing.Point(423, 263);
            this.bunload.Name = "bunload";
            this.bunload.Size = new System.Drawing.Size(184, 22);
            this.bunload.TabIndex = 32;
            this.bunload.Text = "Выгрузить файд";
            this.bunload.UseVisualStyleBackColor = true;
            this.bunload.Click += new System.EventHandler(this.bunload_Click);
            // 
            // bload
            // 
            this.bload.Enabled = false;
            this.bload.Location = new System.Drawing.Point(423, 213);
            this.bload.Name = "bload";
            this.bload.Size = new System.Drawing.Size(184, 22);
            this.bload.TabIndex = 31;
            this.bload.Text = "Загрузить на сервер";
            this.bload.UseVisualStyleBackColor = true;
            this.bload.Click += new System.EventHandler(this.bload_Click);
            // 
            // bLook
            // 
            this.bLook.Enabled = false;
            this.bLook.Location = new System.Drawing.Point(78, 215);
            this.bLook.Name = "bLook";
            this.bLook.Size = new System.Drawing.Size(89, 22);
            this.bLook.TabIndex = 30;
            this.bLook.Text = "Выбрать файл";
            this.bLook.UseVisualStyleBackColor = true;
            this.bLook.Click += new System.EventHandler(this.bLook_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(183, 20);
            this.textBox3.TabIndex = 29;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(213, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(183, 132);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // bLog
            // 
            this.bLog.Location = new System.Drawing.Point(42, 103);
            this.bLog.Name = "bLog";
            this.bLog.Size = new System.Drawing.Size(152, 34);
            this.bLog.TabIndex = 27;
            this.bLog.Text = "Log In";
            this.bLog.UseVisualStyleBackColor = true;
            this.bLog.Click += new System.EventHandler(this.bLog_Click);
            // 
            // tpass
            // 
            this.tpass.Location = new System.Drawing.Point(42, 77);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(152, 20);
            this.tpass.TabIndex = 26;
            // 
            // tlogin
            // 
            this.tlogin.Location = new System.Drawing.Point(42, 33);
            this.tlogin.Name = "tlogin";
            this.tlogin.Size = new System.Drawing.Size(152, 20);
            this.tlogin.TabIndex = 25;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(433, 33);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(174, 51);
            this.bCreate.TabIndex = 24;
            this.bCreate.Text = "Create User";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bout);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bunload);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.bload);
            this.Controls.Add(this.tlogin);
            this.Controls.Add(this.bLook);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.bLog);
            this.Name = "Form1";
            this.Text = "Задание";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private User currentUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox filesList;
        private System.Windows.Forms.Button bout;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bunload;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bload;
        private System.Windows.Forms.TextBox tlogin;
        private System.Windows.Forms.Button bLook;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bLog;
    }
}

