namespace AISCarwash
{
    partial class ChangeForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabWashers = new System.Windows.Forms.TabPage();
            this.textPatronymicWasher = new System.Windows.Forms.MaskedTextBox();
            this.textSurnameWasher = new System.Windows.Forms.MaskedTextBox();
            this.textNameWasher = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateOBWasher = new System.Windows.Forms.DateTimePicker();
            this.buttonDelWasher = new System.Windows.Forms.Button();
            this.buttonChangeWasher = new System.Windows.Forms.Button();
            this.tabCliets = new System.Windows.Forms.TabPage();
            this.textModelCarClient = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPatronymicClient = new System.Windows.Forms.MaskedTextBox();
            this.textSurnameClient = new System.Windows.Forms.MaskedTextBox();
            this.textNameClient = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDelClient = new System.Windows.Forms.Button();
            this.buttonChangeClient = new System.Windows.Forms.Button();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.textNameService = new System.Windows.Forms.MaskedTextBox();
            this.textPriceService = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonDelService = new System.Windows.Forms.Button();
            this.buttonChangeService = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.counterTable = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabWashers.SuspendLayout();
            this.tabCliets.SuspendLayout();
            this.tabServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPriceService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabWashers);
            this.tabControl.Controls.Add(this.tabCliets);
            this.tabControl.Controls.Add(this.tabServices);
            this.tabControl.Location = new System.Drawing.Point(0, 495);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1006, 226);
            this.tabControl.TabIndex = 5;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabWashers
            // 
            this.tabWashers.Controls.Add(this.textPatronymicWasher);
            this.tabWashers.Controls.Add(this.textSurnameWasher);
            this.tabWashers.Controls.Add(this.textNameWasher);
            this.tabWashers.Controls.Add(this.label4);
            this.tabWashers.Controls.Add(this.label3);
            this.tabWashers.Controls.Add(this.label1);
            this.tabWashers.Controls.Add(this.label8);
            this.tabWashers.Controls.Add(this.dateOBWasher);
            this.tabWashers.Controls.Add(this.buttonDelWasher);
            this.tabWashers.Controls.Add(this.buttonChangeWasher);
            this.tabWashers.Location = new System.Drawing.Point(4, 33);
            this.tabWashers.Name = "tabWashers";
            this.tabWashers.Padding = new System.Windows.Forms.Padding(3);
            this.tabWashers.Size = new System.Drawing.Size(998, 189);
            this.tabWashers.TabIndex = 0;
            this.tabWashers.Text = "Сотрудники (мойщики)";
            this.tabWashers.UseVisualStyleBackColor = true;
            // 
            // textPatronymicWasher
            // 
            this.textPatronymicWasher.Location = new System.Drawing.Point(8, 151);
            this.textPatronymicWasher.Mask = "???????????????";
            this.textPatronymicWasher.Name = "textPatronymicWasher";
            this.textPatronymicWasher.Size = new System.Drawing.Size(227, 31);
            this.textPatronymicWasher.TabIndex = 41;
            // 
            // textSurnameWasher
            // 
            this.textSurnameWasher.Location = new System.Drawing.Point(8, 91);
            this.textSurnameWasher.Mask = "???????????????";
            this.textSurnameWasher.Name = "textSurnameWasher";
            this.textSurnameWasher.Size = new System.Drawing.Size(227, 31);
            this.textSurnameWasher.TabIndex = 40;
            // 
            // textNameWasher
            // 
            this.textNameWasher.Location = new System.Drawing.Point(8, 29);
            this.textNameWasher.Mask = "???????????????";
            this.textNameWasher.Name = "textNameWasher";
            this.textNameWasher.Size = new System.Drawing.Size(227, 31);
            this.textNameWasher.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Отчество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "Имя:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Дата рождения:";
            // 
            // dateOBWasher
            // 
            this.dateOBWasher.Location = new System.Drawing.Point(267, 30);
            this.dateOBWasher.MaxDate = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            this.dateOBWasher.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateOBWasher.Name = "dateOBWasher";
            this.dateOBWasher.Size = new System.Drawing.Size(350, 31);
            this.dateOBWasher.TabIndex = 33;
            this.dateOBWasher.Value = new System.DateTime(2022, 11, 19, 0, 0, 0, 0);
            // 
            // buttonDelWasher
            // 
            this.buttonDelWasher.Enabled = false;
            this.buttonDelWasher.Location = new System.Drawing.Point(267, 137);
            this.buttonDelWasher.Name = "buttonDelWasher";
            this.buttonDelWasher.Size = new System.Drawing.Size(350, 45);
            this.buttonDelWasher.TabIndex = 29;
            this.buttonDelWasher.Text = "Удалить";
            this.buttonDelWasher.UseVisualStyleBackColor = true;
            this.buttonDelWasher.Click += new System.EventHandler(this.buttonDelWasher_Click);
            // 
            // buttonChangeWasher
            // 
            this.buttonChangeWasher.Enabled = false;
            this.buttonChangeWasher.Location = new System.Drawing.Point(267, 76);
            this.buttonChangeWasher.Name = "buttonChangeWasher";
            this.buttonChangeWasher.Size = new System.Drawing.Size(350, 45);
            this.buttonChangeWasher.TabIndex = 22;
            this.buttonChangeWasher.Text = "Редактировать";
            this.buttonChangeWasher.UseVisualStyleBackColor = true;
            this.buttonChangeWasher.Click += new System.EventHandler(this.buttonChangeWasher_Click);
            // 
            // tabCliets
            // 
            this.tabCliets.Controls.Add(this.textModelCarClient);
            this.tabCliets.Controls.Add(this.label7);
            this.tabCliets.Controls.Add(this.textPatronymicClient);
            this.tabCliets.Controls.Add(this.textSurnameClient);
            this.tabCliets.Controls.Add(this.textNameClient);
            this.tabCliets.Controls.Add(this.label2);
            this.tabCliets.Controls.Add(this.label5);
            this.tabCliets.Controls.Add(this.label6);
            this.tabCliets.Controls.Add(this.buttonDelClient);
            this.tabCliets.Controls.Add(this.buttonChangeClient);
            this.tabCliets.Location = new System.Drawing.Point(4, 33);
            this.tabCliets.Name = "tabCliets";
            this.tabCliets.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliets.Size = new System.Drawing.Size(998, 189);
            this.tabCliets.TabIndex = 1;
            this.tabCliets.Text = "Клиенты";
            this.tabCliets.UseVisualStyleBackColor = true;
            // 
            // textModelCarClient
            // 
            this.textModelCarClient.Location = new System.Drawing.Point(266, 31);
            this.textModelCarClient.Mask = "?????????????????????????";
            this.textModelCarClient.Name = "textModelCarClient";
            this.textModelCarClient.Size = new System.Drawing.Size(350, 31);
            this.textModelCarClient.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Модель авто:";
            // 
            // textPatronymicClient
            // 
            this.textPatronymicClient.Location = new System.Drawing.Point(8, 151);
            this.textPatronymicClient.Mask = "???????????????";
            this.textPatronymicClient.Name = "textPatronymicClient";
            this.textPatronymicClient.Size = new System.Drawing.Size(227, 31);
            this.textPatronymicClient.TabIndex = 46;
            // 
            // textSurnameClient
            // 
            this.textSurnameClient.Location = new System.Drawing.Point(8, 89);
            this.textSurnameClient.Mask = "???????????????";
            this.textSurnameClient.Name = "textSurnameClient";
            this.textSurnameClient.Size = new System.Drawing.Size(227, 31);
            this.textSurnameClient.TabIndex = 45;
            // 
            // textNameClient
            // 
            this.textNameClient.Location = new System.Drawing.Point(8, 29);
            this.textNameClient.Mask = "???????????????";
            this.textNameClient.Name = "textNameClient";
            this.textNameClient.Size = new System.Drawing.Size(227, 31);
            this.textNameClient.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Фамилия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Имя:";
            // 
            // buttonDelClient
            // 
            this.buttonDelClient.Enabled = false;
            this.buttonDelClient.Location = new System.Drawing.Point(266, 137);
            this.buttonDelClient.Name = "buttonDelClient";
            this.buttonDelClient.Size = new System.Drawing.Size(350, 45);
            this.buttonDelClient.TabIndex = 29;
            this.buttonDelClient.Text = "Удалить";
            this.buttonDelClient.UseVisualStyleBackColor = true;
            this.buttonDelClient.Click += new System.EventHandler(this.buttonDelClient_Click);
            // 
            // buttonChangeClient
            // 
            this.buttonChangeClient.Enabled = false;
            this.buttonChangeClient.Location = new System.Drawing.Point(266, 76);
            this.buttonChangeClient.Name = "buttonChangeClient";
            this.buttonChangeClient.Size = new System.Drawing.Size(350, 45);
            this.buttonChangeClient.TabIndex = 22;
            this.buttonChangeClient.Text = "Редактировать";
            this.buttonChangeClient.UseVisualStyleBackColor = true;
            this.buttonChangeClient.Click += new System.EventHandler(this.buttonChangeClient_Click);
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.textNameService);
            this.tabServices.Controls.Add(this.textPriceService);
            this.tabServices.Controls.Add(this.label9);
            this.tabServices.Controls.Add(this.label12);
            this.tabServices.Controls.Add(this.buttonDelService);
            this.tabServices.Controls.Add(this.buttonChangeService);
            this.tabServices.Location = new System.Drawing.Point(4, 33);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(998, 189);
            this.tabServices.TabIndex = 2;
            this.tabServices.Text = "Услуги";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // textNameService
            // 
            this.textNameService.Location = new System.Drawing.Point(8, 66);
            this.textNameService.Mask = "?????????????????????????????????????????????";
            this.textNameService.Name = "textNameService";
            this.textNameService.Size = new System.Drawing.Size(374, 31);
            this.textNameService.TabIndex = 48;
            // 
            // textPriceService
            // 
            this.textPriceService.Location = new System.Drawing.Point(8, 129);
            this.textPriceService.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.textPriceService.Name = "textPriceService";
            this.textPriceService.Size = new System.Drawing.Size(120, 31);
            this.textPriceService.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 46;
            this.label9.Text = "Цена:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 24);
            this.label12.TabIndex = 45;
            this.label12.Text = "Наименование услуги:";
            // 
            // buttonDelService
            // 
            this.buttonDelService.Enabled = false;
            this.buttonDelService.Location = new System.Drawing.Point(393, 127);
            this.buttonDelService.Name = "buttonDelService";
            this.buttonDelService.Size = new System.Drawing.Size(350, 45);
            this.buttonDelService.TabIndex = 40;
            this.buttonDelService.Text = "Удалить";
            this.buttonDelService.UseVisualStyleBackColor = true;
            this.buttonDelService.Click += new System.EventHandler(this.buttonDelService_Click);
            // 
            // buttonChangeService
            // 
            this.buttonChangeService.Enabled = false;
            this.buttonChangeService.Location = new System.Drawing.Point(393, 66);
            this.buttonChangeService.Name = "buttonChangeService";
            this.buttonChangeService.Size = new System.Drawing.Size(350, 45);
            this.buttonChangeService.TabIndex = 38;
            this.buttonChangeService.Text = "Редактировать";
            this.buttonChangeService.UseVisualStyleBackColor = true;
            this.buttonChangeService.Click += new System.EventHandler(this.buttonChangeService_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 31);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1006, 468);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.BackToolStripMenuItem.Text = "Назад";
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(742, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Число строк в таблице:";
            // 
            // counterTable
            // 
            this.counterTable.AutoSize = true;
            this.counterTable.Location = new System.Drawing.Point(944, 3);
            this.counterTable.Name = "counterTable";
            this.counterTable.Size = new System.Drawing.Size(17, 24);
            this.counterTable.TabIndex = 6;
            this.counterTable.Text = "-";
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.counterTable);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "ChangeForm";
            this.Text = "ChangeForm";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabWashers.ResumeLayout(false);
            this.tabWashers.PerformLayout();
            this.tabCliets.ResumeLayout(false);
            this.tabCliets.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textPriceService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabWashers;
        private System.Windows.Forms.Button buttonDelWasher;
        private System.Windows.Forms.Button buttonChangeWasher;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.TabPage tabCliets;
        private System.Windows.Forms.Button buttonDelClient;
        private System.Windows.Forms.Button buttonChangeClient;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.Button buttonDelService;
        private System.Windows.Forms.Button buttonChangeService;
        private System.Windows.Forms.MaskedTextBox textNameService;
        private System.Windows.Forms.NumericUpDown textPriceService;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox textPatronymicClient;
        private System.Windows.Forms.MaskedTextBox textSurnameClient;
        private System.Windows.Forms.MaskedTextBox textNameClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox textModelCarClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateOBWasher;
        private System.Windows.Forms.MaskedTextBox textPatronymicWasher;
        private System.Windows.Forms.MaskedTextBox textSurnameWasher;
        private System.Windows.Forms.MaskedTextBox textNameWasher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label counterTable;
    }
}