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
            this.buttonServies = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(93, 46);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(297, 72);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавление";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(93, 156);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(297, 72);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "Редактирование";
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonServies
            // 
            this.buttonServies.Location = new System.Drawing.Point(93, 266);
            this.buttonServies.Name = "buttonServies";
            this.buttonServies.Size = new System.Drawing.Size(297, 72);
            this.buttonServies.TabIndex = 2;
            this.buttonServies.Text = "Предоставление услуг";
            this.buttonServies.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(93, 602);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(297, 72);
            this.exit.TabIndex = 3;
            this.exit.Text = "выход";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 703);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.buttonServies);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(500, 750);
            this.MinimumSize = new System.Drawing.Size(500, 750);
            this.Name = "MainForm";
            this.Text = "АИС Автомойка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonServies;
        private System.Windows.Forms.Button exit;
    }
}

