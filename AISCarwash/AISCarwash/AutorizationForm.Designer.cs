namespace AISCarwash
{
    partial class AutorizationForm
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
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(218, 362);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(186, 59);
            this.buttonLogIn.TabIndex = 2;
            this.buttonLogIn.Text = "войти";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            this.buttonLogIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLogIn_MouseClick);
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(191, 204);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(236, 26);
            this.textLogin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(211, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Авторизация:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пароль:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(191, 275);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(236, 26);
            this.textPassword.TabIndex = 10;
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(192, 304);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(149, 19);
            this.counter.TabIndex = 11;
            this.counter.Text = "осталось попыток: 3";
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.buttonLogIn);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AutorizationForm";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.AutorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label counter;
    }
}