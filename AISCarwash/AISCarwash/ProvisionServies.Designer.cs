namespace AISCarwash
{
    partial class ProvisionServies
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
            this.label1 = new System.Windows.Forms.Label();
            this.textPatronymicClient = new System.Windows.Forms.MaskedTextBox();
            this.textSurnameClient = new System.Windows.Forms.MaskedTextBox();
            this.textNameClient = new System.Windows.Forms.MaskedTextBox();
            this.textModelCarClient = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupAddClient = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.selectAddClient = new System.Windows.Forms.CheckBox();
            this.selectClient = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectService = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.selectWasher = new System.Windows.Forms.ComboBox();
            this.buttonProvisionService = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupAddClient.SuspendLayout();
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
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BackToolStripMenuItem
            // 
            this.BackToolStripMenuItem.Name = "BackToolStripMenuItem";
            this.BackToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.BackToolStripMenuItem.Text = "Назад";
            this.BackToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Предоставление услуги (по мойке автомобиля):\r\n";
            // 
            // textPatronymicClient
            // 
            this.textPatronymicClient.Location = new System.Drawing.Point(38, 174);
            this.textPatronymicClient.Mask = "???????????????";
            this.textPatronymicClient.Name = "textPatronymicClient";
            this.textPatronymicClient.PromptChar = ' ';
            this.textPatronymicClient.Size = new System.Drawing.Size(227, 31);
            this.textPatronymicClient.TabIndex = 49;
            // 
            // textSurnameClient
            // 
            this.textSurnameClient.Location = new System.Drawing.Point(38, 112);
            this.textSurnameClient.Mask = "???????????????";
            this.textSurnameClient.Name = "textSurnameClient";
            this.textSurnameClient.PromptChar = ' ';
            this.textSurnameClient.Size = new System.Drawing.Size(227, 31);
            this.textSurnameClient.TabIndex = 48;
            // 
            // textNameClient
            // 
            this.textNameClient.Location = new System.Drawing.Point(38, 52);
            this.textNameClient.Mask = "???????????????";
            this.textNameClient.Name = "textNameClient";
            this.textNameClient.PromptChar = ' ';
            this.textNameClient.Size = new System.Drawing.Size(227, 31);
            this.textNameClient.TabIndex = 47;
            // 
            // textModelCarClient
            // 
            this.textModelCarClient.Location = new System.Drawing.Point(296, 52);
            this.textModelCarClient.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            this.textModelCarClient.Name = "textModelCarClient";
            this.textModelCarClient.PromptChar = ' ';
            this.textModelCarClient.Size = new System.Drawing.Size(350, 31);
            this.textModelCarClient.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Фамилия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "Имя:";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(296, 112);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(350, 45);
            this.buttonAddClient.TabIndex = 42;
            this.buttonAddClient.Text = "Добавить";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Модель авто:";
            // 
            // groupAddClient
            // 
            this.groupAddClient.Controls.Add(this.buttonAddClient);
            this.groupAddClient.Controls.Add(this.textPatronymicClient);
            this.groupAddClient.Controls.Add(this.label7);
            this.groupAddClient.Controls.Add(this.textSurnameClient);
            this.groupAddClient.Controls.Add(this.label6);
            this.groupAddClient.Controls.Add(this.textNameClient);
            this.groupAddClient.Controls.Add(this.label5);
            this.groupAddClient.Controls.Add(this.textModelCarClient);
            this.groupAddClient.Controls.Add(this.label2);
            this.groupAddClient.Enabled = false;
            this.groupAddClient.Location = new System.Drawing.Point(78, 107);
            this.groupAddClient.Name = "groupAddClient";
            this.groupAddClient.Size = new System.Drawing.Size(714, 208);
            this.groupAddClient.TabIndex = 50;
            this.groupAddClient.TabStop = false;
            this.groupAddClient.Text = "Добавить нового клиента:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-31, 102);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 52;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // selectAddClient
            // 
            this.selectAddClient.AutoSize = true;
            this.selectAddClient.Location = new System.Drawing.Point(54, 113);
            this.selectAddClient.Name = "selectAddClient";
            this.selectAddClient.Size = new System.Drawing.Size(18, 17);
            this.selectAddClient.TabIndex = 53;
            this.selectAddClient.UseVisualStyleBackColor = true;
            this.selectAddClient.CheckedChanged += new System.EventHandler(this.selectAddClient_CheckedChanged);
            // 
            // selectClient
            // 
            this.selectClient.FormattingEnabled = true;
            this.selectClient.Location = new System.Drawing.Point(116, 367);
            this.selectClient.Name = "selectClient";
            this.selectClient.Size = new System.Drawing.Size(608, 32);
            this.selectClient.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 54;
            this.label3.Text = "Клиент:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Оказываемая услуга:";
            // 
            // selectService
            // 
            this.selectService.FormattingEnabled = true;
            this.selectService.Location = new System.Drawing.Point(116, 460);
            this.selectService.Name = "selectService";
            this.selectService.Size = new System.Drawing.Size(608, 32);
            this.selectService.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 24);
            this.label8.TabIndex = 58;
            this.label8.Text = "Исполнитель:";
            // 
            // selectWasher
            // 
            this.selectWasher.FormattingEnabled = true;
            this.selectWasher.Location = new System.Drawing.Point(116, 557);
            this.selectWasher.Name = "selectWasher";
            this.selectWasher.Size = new System.Drawing.Size(608, 32);
            this.selectWasher.TabIndex = 57;
            // 
            // buttonProvisionService
            // 
            this.buttonProvisionService.Location = new System.Drawing.Point(729, 609);
            this.buttonProvisionService.Name = "buttonProvisionService";
            this.buttonProvisionService.Size = new System.Drawing.Size(265, 100);
            this.buttonProvisionService.TabIndex = 59;
            this.buttonProvisionService.Text = "Провести услугу";
            this.buttonProvisionService.UseVisualStyleBackColor = true;
            this.buttonProvisionService.Click += new System.EventHandler(this.buttonProvisionService_Click);
            // 
            // ProvisionServies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.buttonProvisionService);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.selectWasher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectClient);
            this.Controls.Add(this.selectAddClient);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupAddClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProvisionServies";
            this.Text = "ProvisionServies";
            this.Load += new System.EventHandler(this.ProvisionServies_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupAddClient.ResumeLayout(false);
            this.groupAddClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textPatronymicClient;
        private System.Windows.Forms.MaskedTextBox textSurnameClient;
        private System.Windows.Forms.MaskedTextBox textNameClient;
        private System.Windows.Forms.MaskedTextBox textModelCarClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupAddClient;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox selectAddClient;
        private System.Windows.Forms.ComboBox selectClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox selectWasher;
        private System.Windows.Forms.Button buttonProvisionService;
    }
}