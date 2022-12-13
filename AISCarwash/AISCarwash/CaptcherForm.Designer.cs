namespace AISCarwash
{
    partial class CaptcherForm
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
            this.pictureCaptcher = new System.Windows.Forms.PictureBox();
            this.textCaptcher = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaptcher)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCaptcher
            // 
            this.pictureCaptcher.Location = new System.Drawing.Point(81, 62);
            this.pictureCaptcher.Name = "pictureCaptcher";
            this.pictureCaptcher.Size = new System.Drawing.Size(219, 97);
            this.pictureCaptcher.TabIndex = 0;
            this.pictureCaptcher.TabStop = false;
            // 
            // textCaptcher
            // 
            this.textCaptcher.Location = new System.Drawing.Point(81, 181);
            this.textCaptcher.Name = "textCaptcher";
            this.textCaptcher.Size = new System.Drawing.Size(219, 20);
            this.textCaptcher.TabIndex = 1;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(144, 207);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(89, 62);
            this.reset.TabIndex = 2;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(81, 284);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(219, 62);
            this.login.TabIndex = 3;
            this.login.Text = "войти";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(78, 162);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(112, 13);
            this.counter.TabIndex = 4;
            this.counter.Text = "осталось попыток: 3";
            // 
            // CaptcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 377);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.login);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.textCaptcher);
            this.Controls.Add(this.pictureCaptcher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CaptcherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaptcherForm";
            this.Load += new System.EventHandler(this.CaptcherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCaptcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCaptcher;
        private System.Windows.Forms.TextBox textCaptcher;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label counter;
    }
}