namespace AISCarwash
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonProvisionServies = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonUserControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(93, 424);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(297, 72);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавление в БД";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(93, 502);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(297, 72);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "Редактирование БД";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonProvisionServies
            // 
            this.buttonProvisionServies.Location = new System.Drawing.Point(93, 147);
            this.buttonProvisionServies.Name = "buttonProvisionServies";
            this.buttonProvisionServies.Size = new System.Drawing.Size(297, 72);
            this.buttonProvisionServies.TabIndex = 2;
            this.buttonProvisionServies.Text = "Предоставление услуг";
            this.buttonProvisionServies.UseVisualStyleBackColor = true;
            this.buttonProvisionServies.Click += new System.EventHandler(this.buttonProvisionServies_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(93, 619);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(297, 72);
            this.exit.TabIndex = 3;
            this.exit.Text = "выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(93, 69);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(297, 72);
            this.buttonView.TabIndex = 4;
            this.buttonView.Text = "просмотр предоставленных услуг";
            this.buttonView.UseVisualStyleBackColor = true;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(93, 225);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(297, 72);
            this.buttonInfo.TabIndex = 5;
            this.buttonInfo.Text = "О разработчике";
            this.buttonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonUserControl
            // 
            this.buttonUserControl.Location = new System.Drawing.Point(93, 346);
            this.buttonUserControl.Name = "buttonUserControl";
            this.buttonUserControl.Size = new System.Drawing.Size(297, 72);
            this.buttonUserControl.TabIndex = 6;
            this.buttonUserControl.Text = "Управление пользователями";
            this.buttonUserControl.UseVisualStyleBackColor = true;
            this.buttonUserControl.Click += new System.EventHandler(this.buttonUserControl_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 703);
            this.Controls.Add(this.buttonUserControl);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.buttonProvisionServies);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(500, 750);
            this.MinimumSize = new System.Drawing.Size(500, 750);
            this.Name = "MainForm";
            this.Text = "АИС Автомойка";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonProvisionServies;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonUserControl;
    }
}

