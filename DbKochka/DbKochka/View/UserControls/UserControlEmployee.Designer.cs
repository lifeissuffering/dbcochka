namespace DbKochka.View.UserControls
{
    partial class UserControlEmployee
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelClubNumber = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelTabel = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelFIO.Location = new System.Drawing.Point(18, 9);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(370, 30);
            this.labelFIO.TabIndex = 9;
            this.labelFIO.Text = "ФИО сотрудника: ";
            this.labelFIO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelClubNumber
            // 
            this.labelClubNumber.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelClubNumber.Location = new System.Drawing.Point(18, 39);
            this.labelClubNumber.Name = "labelClubNumber";
            this.labelClubNumber.Size = new System.Drawing.Size(370, 30);
            this.labelClubNumber.TabIndex = 8;
            this.labelClubNumber.Text = "Номер клуба: ";
            this.labelClubNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelExp
            // 
            this.labelExp.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelExp.Location = new System.Drawing.Point(18, 69);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(370, 30);
            this.labelExp.TabIndex = 10;
            this.labelExp.Text = "Стаж: ";
            this.labelExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTabel
            // 
            this.labelTabel.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelTabel.Location = new System.Drawing.Point(478, 9);
            this.labelTabel.Name = "labelTabel";
            this.labelTabel.Size = new System.Drawing.Size(303, 30);
            this.labelTabel.TabIndex = 11;
            this.labelTabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPosition
            // 
            this.labelPosition.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelPosition.Location = new System.Drawing.Point(18, 99);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(370, 30);
            this.labelPosition.TabIndex = 12;
            this.labelPosition.Text = "Должность: ";
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.Location = new System.Drawing.Point(605, 57);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(156, 30);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(605, 93);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(156, 30);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(331, 21);
            this.textBox1.TabIndex = 15;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 45);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(325, 21);
            this.textBox2.TabIndex = 16;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 72);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(327, 21);
            this.textBox3.TabIndex = 17;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 105);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(321, 21);
            this.textBox4.TabIndex = 18;
            this.textBox4.Visible = false;
            // 
            // UserControlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelTabel);
            this.Controls.Add(this.labelExp);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelClubNumber);
            this.Name = "UserControlEmployee";
            this.Size = new System.Drawing.Size(797, 142);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelClubNumber;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Label labelTabel;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}
