namespace DbKochka.View.UserControls
{
    partial class UserControlSignIn
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelLastFourNumber = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelLogin.Location = new System.Drawing.Point(157, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(196, 26);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Логин или номер карты:";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLastFourNumber
            // 
            this.labelLastFourNumber.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelLastFourNumber.Location = new System.Drawing.Point(157, 46);
            this.labelLastFourNumber.Name = "labelLastFourNumber";
            this.labelLastFourNumber.Size = new System.Drawing.Size(417, 26);
            this.labelLastFourNumber.TabIndex = 4;
            this.labelLastFourNumber.Text = "Последние 4 цифры телефона, указанного в договоре:";
            this.labelLastFourNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(461, 20);
            this.textBox2.TabIndex = 7;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSignIn.Location = new System.Drawing.Point(312, 92);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(156, 30);
            this.buttonSignIn.TabIndex = 9;
            this.buttonSignIn.Text = "Войти";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(157, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // UserControlSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelLastFourNumber);
            this.Controls.Add(this.labelLogin);
            this.Name = "UserControlSignIn";
            this.Size = new System.Drawing.Size(797, 134);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelLastFourNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label label1;
    }
}
