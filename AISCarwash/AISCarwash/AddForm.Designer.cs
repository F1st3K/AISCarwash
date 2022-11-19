namespace AISCarwash
{
    partial class AddForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.dateOBWasher = new System.Windows.Forms.DateTimePicker();
            this.textPatronymicWasher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSurnameWasher = new System.Windows.Forms.TextBox();
            this.textNameWasher = new System.Windows.Forms.TextBox();
            this.buttonAddWasher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCliets = new System.Windows.Forms.TabPage();
            this.textPatronymicClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textSurnameClient = new System.Windows.Forms.TextBox();
            this.textNameClient = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textModelCarClient = new System.Windows.Forms.TextBox();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textPriceService = new System.Windows.Forms.TextBox();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textNameService = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabWashers.SuspendLayout();
            this.tabCliets.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabWashers);
            this.tabControl.Controls.Add(this.tabCliets);
            this.tabControl.Controls.Add(this.tabServices);
            this.tabControl.Location = new System.Drawing.Point(0, 499);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1006, 226);
            this.tabControl.TabIndex = 6;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabWashers
            // 
            this.tabWashers.Controls.Add(this.label8);
            this.tabWashers.Controls.Add(this.dateOBWasher);
            this.tabWashers.Controls.Add(this.textPatronymicWasher);
            this.tabWashers.Controls.Add(this.label4);
            this.tabWashers.Controls.Add(this.label3);
            this.tabWashers.Controls.Add(this.textSurnameWasher);
            this.tabWashers.Controls.Add(this.textNameWasher);
            this.tabWashers.Controls.Add(this.buttonAddWasher);
            this.tabWashers.Controls.Add(this.label1);
            this.tabWashers.Location = new System.Drawing.Point(4, 33);
            this.tabWashers.Name = "tabWashers";
            this.tabWashers.Padding = new System.Windows.Forms.Padding(3);
            this.tabWashers.Size = new System.Drawing.Size(998, 189);
            this.tabWashers.TabIndex = 0;
            this.tabWashers.Text = "Сотрудники (мойщики)";
            this.tabWashers.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "Дата рождения:";
            // 
            // dateOBWasher
            // 
            this.dateOBWasher.Location = new System.Drawing.Point(364, 30);
            this.dateOBWasher.Name = "dateOBWasher";
            this.dateOBWasher.Size = new System.Drawing.Size(350, 31);
            this.dateOBWasher.TabIndex = 31;
            // 
            // textPatronymicWasher
            // 
            this.textPatronymicWasher.Location = new System.Drawing.Point(105, 150);
            this.textPatronymicWasher.Name = "textPatronymicWasher";
            this.textPatronymicWasher.Size = new System.Drawing.Size(227, 31);
            this.textPatronymicWasher.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Отчество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Фамилия:";
            // 
            // textSurnameWasher
            // 
            this.textSurnameWasher.Location = new System.Drawing.Point(105, 90);
            this.textSurnameWasher.Name = "textSurnameWasher";
            this.textSurnameWasher.Size = new System.Drawing.Size(227, 31);
            this.textSurnameWasher.TabIndex = 25;
            // 
            // textNameWasher
            // 
            this.textNameWasher.Location = new System.Drawing.Point(105, 30);
            this.textNameWasher.Name = "textNameWasher";
            this.textNameWasher.Size = new System.Drawing.Size(227, 31);
            this.textNameWasher.TabIndex = 24;
            // 
            // buttonAddWasher
            // 
            this.buttonAddWasher.Location = new System.Drawing.Point(364, 76);
            this.buttonAddWasher.Name = "buttonAddWasher";
            this.buttonAddWasher.Size = new System.Drawing.Size(350, 45);
            this.buttonAddWasher.TabIndex = 22;
            this.buttonAddWasher.Text = "Добавить";
            this.buttonAddWasher.UseVisualStyleBackColor = true;
            this.buttonAddWasher.Click += new System.EventHandler(this.buttonAddWasher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Имя:";
            // 
            // tabCliets
            // 
            this.tabCliets.Controls.Add(this.textPatronymicClient);
            this.tabCliets.Controls.Add(this.label2);
            this.tabCliets.Controls.Add(this.label5);
            this.tabCliets.Controls.Add(this.textSurnameClient);
            this.tabCliets.Controls.Add(this.textNameClient);
            this.tabCliets.Controls.Add(this.label6);
            this.tabCliets.Controls.Add(this.buttonAddClient);
            this.tabCliets.Controls.Add(this.label7);
            this.tabCliets.Controls.Add(this.textModelCarClient);
            this.tabCliets.Location = new System.Drawing.Point(4, 33);
            this.tabCliets.Name = "tabCliets";
            this.tabCliets.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliets.Size = new System.Drawing.Size(998, 189);
            this.tabCliets.TabIndex = 1;
            this.tabCliets.Text = "Клиенты";
            this.tabCliets.UseVisualStyleBackColor = true;
            // 
            // textPatronymicClient
            // 
            this.textPatronymicClient.Location = new System.Drawing.Point(105, 150);
            this.textPatronymicClient.Name = "textPatronymicClient";
            this.textPatronymicClient.Size = new System.Drawing.Size(227, 31);
            this.textPatronymicClient.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Фамилия:";
            // 
            // textSurnameClient
            // 
            this.textSurnameClient.Location = new System.Drawing.Point(105, 90);
            this.textSurnameClient.Name = "textSurnameClient";
            this.textSurnameClient.Size = new System.Drawing.Size(227, 31);
            this.textSurnameClient.TabIndex = 33;
            // 
            // textNameClient
            // 
            this.textNameClient.Location = new System.Drawing.Point(105, 30);
            this.textNameClient.Name = "textNameClient";
            this.textNameClient.Size = new System.Drawing.Size(227, 31);
            this.textNameClient.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Имя:";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(363, 90);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(350, 45);
            this.buttonAddClient.TabIndex = 29;
            this.buttonAddClient.Text = "Добавить";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Модель авто:";
            // 
            // textModelCarClient
            // 
            this.textModelCarClient.Location = new System.Drawing.Point(363, 29);
            this.textModelCarClient.Name = "textModelCarClient";
            this.textModelCarClient.Size = new System.Drawing.Size(350, 31);
            this.textModelCarClient.TabIndex = 18;
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.label9);
            this.tabServices.Controls.Add(this.textPriceService);
            this.tabServices.Controls.Add(this.buttonAddService);
            this.tabServices.Controls.Add(this.label12);
            this.tabServices.Controls.Add(this.textNameService);
            this.tabServices.Location = new System.Drawing.Point(4, 33);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(3);
            this.tabServices.Size = new System.Drawing.Size(998, 189);
            this.tabServices.TabIndex = 2;
            this.tabServices.Text = "Услуги";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 42;
            this.label9.Text = "Цена:";
            // 
            // textPriceService
            // 
            this.textPriceService.Location = new System.Drawing.Point(325, 93);
            this.textPriceService.Name = "textPriceService";
            this.textPriceService.Size = new System.Drawing.Size(148, 31);
            this.textPriceService.TabIndex = 41;
            // 
            // buttonAddService
            // 
            this.buttonAddService.Location = new System.Drawing.Point(325, 132);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(374, 45);
            this.buttonAddService.TabIndex = 40;
            this.buttonAddService.Text = "Добавить";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 24);
            this.label12.TabIndex = 39;
            this.label12.Text = "Наименование услуги:";
            // 
            // textNameService
            // 
            this.textNameService.Location = new System.Drawing.Point(325, 30);
            this.textNameService.Name = "textNameService";
            this.textNameService.Size = new System.Drawing.Size(374, 31);
            this.textNameService.TabIndex = 37;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.BackToolStripMenuItem.Text = "Назад";
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
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
            this.dataGridView.TabIndex = 8;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.tabControl.ResumeLayout(false);
            this.tabWashers.ResumeLayout(false);
            this.tabWashers.PerformLayout();
            this.tabCliets.ResumeLayout(false);
            this.tabCliets.PerformLayout();
            this.tabServices.ResumeLayout(false);
            this.tabServices.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabWashers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateOBWasher;
        private System.Windows.Forms.TextBox textPatronymicWasher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSurnameWasher;
        private System.Windows.Forms.TextBox textNameWasher;
        private System.Windows.Forms.Button buttonAddWasher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCliets;
        private System.Windows.Forms.TextBox textPatronymicClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSurnameClient;
        private System.Windows.Forms.TextBox textNameClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textModelCarClient;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textPriceService;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textNameService;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}