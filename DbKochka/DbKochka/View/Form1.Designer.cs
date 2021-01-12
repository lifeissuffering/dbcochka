using System.Windows.Forms;

namespace DbKochka.View
{
    partial class Form1
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
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textboxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxLogin
            // 
            this.textboxLogin.Location = new System.Drawing.Point(203, 122);
            this.textboxLogin.Name = "textboxLogin";
            this.textboxLogin.Size = new System.Drawing.Size(203, 20);
            this.textboxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(203, 163);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(203, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(150, 125);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(47, 17);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(138, 166);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(61, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль";
            // 
            // SignIn
            // 
            this.SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignIn.Location = new System.Drawing.Point(258, 203);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(80, 32);
            this.SignIn.TabIndex = 4;
            this.SignIn.Text = "Войти";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Enabled = false;
            this.labelError.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.Location = new System.Drawing.Point(203, 90);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(223, 17);
            this.labelError.TabIndex = 6;
            this.labelError.Text = "Неверный логин или пароль!";
            this.labelError.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.SignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 339);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textboxLogin);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Авторизация | Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button SignIn = new Button();
        private System.Windows.Forms.Label labelError;
    }
}

