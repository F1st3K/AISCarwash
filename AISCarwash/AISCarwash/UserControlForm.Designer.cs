namespace AISCarwash
{
    partial class UserControlForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabContro = new System.Windows.Forms.TabControl();
            this.TabChange = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.ChangeMode = new System.Windows.Forms.ComboBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textChangeFullname = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textCreatePassword = new System.Windows.Forms.TextBox();
            this.textCreateLogin = new System.Windows.Forms.TextBox();
            this.CreateMode = new System.Windows.Forms.ComboBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textCreateFullname = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabContro.SuspendLayout();
            this.TabChange.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.BackToolStripMenuItem.Text = "Назад";
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 468);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabContro
            // 
            this.tabContro.Controls.Add(this.TabChange);
            this.tabContro.Controls.Add(this.tabPage2);
            this.tabContro.Location = new System.Drawing.Point(0, 496);
            this.tabContro.Name = "tabContro";
            this.tabContro.SelectedIndex = 0;
            this.tabContro.Size = new System.Drawing.Size(1006, 226);
            this.tabContro.TabIndex = 2;
            // 
            // TabChange
            // 
            this.TabChange.Controls.Add(this.buttonDelete);
            this.TabChange.Controls.Add(this.label4);
            this.TabChange.Controls.Add(this.label3);
            this.TabChange.Controls.Add(this.label2);
            this.TabChange.Controls.Add(this.textPassword);
            this.TabChange.Controls.Add(this.textLogin);
            this.TabChange.Controls.Add(this.ChangeMode);
            this.TabChange.Controls.Add(this.buttonChange);
            this.TabChange.Controls.Add(this.label1);
            this.TabChange.Controls.Add(this.textChangeFullname);
            this.TabChange.Location = new System.Drawing.Point(4, 33);
            this.TabChange.Name = "TabChange";
            this.TabChange.Padding = new System.Windows.Forms.Padding(3);
            this.TabChange.Size = new System.Drawing.Size(998, 189);
            this.TabChange.TabIndex = 0;
            this.TabChange.Text = "Редактирование/Удаление";
            this.TabChange.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Привелегия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "ФИО:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(12, 90);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(227, 31);
            this.textPassword.TabIndex = 25;
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(12, 30);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(227, 31);
            this.textLogin.TabIndex = 24;
            // 
            // ChangeMode
            // 
            this.ChangeMode.FormattingEnabled = true;
            this.ChangeMode.Location = new System.Drawing.Point(12, 150);
            this.ChangeMode.Name = "ChangeMode";
            this.ChangeMode.Size = new System.Drawing.Size(181, 32);
            this.ChangeMode.TabIndex = 23;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(266, 76);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(350, 45);
            this.buttonChange.TabIndex = 22;
            this.buttonChange.Text = "Редактировать";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Логин:";
            // 
            // textChangeFullname
            // 
            this.textChangeFullname.Location = new System.Drawing.Point(266, 30);
            this.textChangeFullname.Name = "textChangeFullname";
            this.textChangeFullname.Size = new System.Drawing.Size(350, 31);
            this.textChangeFullname.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textCreatePassword);
            this.tabPage2.Controls.Add(this.textCreateLogin);
            this.tabPage2.Controls.Add(this.CreateMode);
            this.tabPage2.Controls.Add(this.buttonCreate);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textCreateFullname);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация нового пользователя";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Привелегия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Пароль:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "ФИО:";
            // 
            // textCreatePassword
            // 
            this.textCreatePassword.Location = new System.Drawing.Point(12, 90);
            this.textCreatePassword.Name = "textCreatePassword";
            this.textCreatePassword.Size = new System.Drawing.Size(227, 31);
            this.textCreatePassword.TabIndex = 34;
            // 
            // textCreateLogin
            // 
            this.textCreateLogin.Location = new System.Drawing.Point(12, 30);
            this.textCreateLogin.Name = "textCreateLogin";
            this.textCreateLogin.Size = new System.Drawing.Size(227, 31);
            this.textCreateLogin.TabIndex = 33;
            // 
            // CreateMode
            // 
            this.CreateMode.FormattingEnabled = true;
            this.CreateMode.Location = new System.Drawing.Point(12, 150);
            this.CreateMode.Name = "CreateMode";
            this.CreateMode.Size = new System.Drawing.Size(181, 32);
            this.CreateMode.TabIndex = 32;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(266, 120);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(350, 45);
            this.buttonCreate.TabIndex = 31;
            this.buttonCreate.Text = "Добавить пользователя";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Логин:";
            // 
            // textCreateFullname
            // 
            this.textCreateFullname.Location = new System.Drawing.Point(266, 49);
            this.textCreateFullname.Name = "textCreateFullname";
            this.textCreateFullname.Size = new System.Drawing.Size(350, 31);
            this.textCreateFullname.TabIndex = 29;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(266, 137);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(350, 45);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // UserControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.tabContro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "UserControlForm";
            this.Text = "UserControlForm";
            this.Load += new System.EventHandler(this.UserControlForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabContro.ResumeLayout(false);
            this.TabChange.ResumeLayout(false);
            this.TabChange.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabContro;
        private System.Windows.Forms.TabPage TabChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.ComboBox ChangeMode;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textChangeFullname;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCreatePassword;
        private System.Windows.Forms.TextBox textCreateLogin;
        private System.Windows.Forms.ComboBox CreateMode;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCreateFullname;
        private System.Windows.Forms.Button buttonDelete;
    }
}