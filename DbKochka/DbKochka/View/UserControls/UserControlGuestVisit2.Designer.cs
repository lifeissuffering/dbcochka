namespace DbKochka.View.UserControls
{
    partial class UserControlGuestVisit2
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelMiddleNumber = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(157, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(166, 26);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSecondName
            // 
            this.labelSecondName.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelSecondName.Location = new System.Drawing.Point(157, 46);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(166, 26);
            this.labelSecondName.TabIndex = 4;
            this.labelSecondName.Text = "Фамилия:";
            this.labelSecondName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMiddleNumber
            // 
            this.labelMiddleNumber.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelMiddleNumber.Location = new System.Drawing.Point(157, 88);
            this.labelMiddleNumber.Name = "labelMiddleNumber";
            this.labelMiddleNumber.Size = new System.Drawing.Size(166, 26);
            this.labelMiddleNumber.TabIndex = 5;
            this.labelMiddleNumber.Text = "Номер телефона:";
            this.labelMiddleNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(461, 20);
            this.textBox3.TabIndex = 8;
            // 
            // buttonSend
            // 
            this.buttonSend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSend.Location = new System.Drawing.Point(314, 133);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(156, 30);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // UserControlGuestVisit2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelMiddleNumber);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelName);
            this.Name = "UserControlGuestVisit2";
            this.Size = new System.Drawing.Size(797, 166);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelMiddleNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonSend;
    }
}
