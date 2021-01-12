namespace DbKochka.View.UserControls
{
    partial class UserControlAdd
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelTabel = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelClubNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(102, 111);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(369, 21);
            this.textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 81);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(411, 21);
            this.textBox3.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 51);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 21);
            this.textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 21);
            this.textBox1.TabIndex = 26;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(604, 63);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(156, 30);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelPosition
            // 
            this.labelPosition.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelPosition.Location = new System.Drawing.Point(17, 105);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(370, 30);
            this.labelPosition.TabIndex = 23;
            this.labelPosition.Text = "Должность: ";
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTabel
            // 
            this.labelTabel.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelTabel.Location = new System.Drawing.Point(477, 15);
            this.labelTabel.Name = "labelTabel";
            this.labelTabel.Size = new System.Drawing.Size(303, 30);
            this.labelTabel.TabIndex = 22;
            this.labelTabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelExp
            // 
            this.labelExp.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelExp.Location = new System.Drawing.Point(17, 75);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(370, 30);
            this.labelExp.TabIndex = 21;
            this.labelExp.Text = "Стаж: ";
            this.labelExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFIO
            // 
            this.labelFIO.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelFIO.Location = new System.Drawing.Point(17, 15);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(370, 30);
            this.labelFIO.TabIndex = 20;
            this.labelFIO.Text = "ФИО сотрудника: ";
            this.labelFIO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelClubNumber
            // 
            this.labelClubNumber.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelClubNumber.Location = new System.Drawing.Point(17, 45);
            this.labelClubNumber.Name = "labelClubNumber";
            this.labelClubNumber.Size = new System.Drawing.Size(370, 30);
            this.labelClubNumber.TabIndex = 19;
            this.labelClubNumber.Text = "Номер клуба: ";
            this.labelClubNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelTabel);
            this.Controls.Add(this.labelExp);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelClubNumber);
            this.Name = "UserControlAdd";
            this.Size = new System.Drawing.Size(797, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelTabel;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelClubNumber;
    }
}
