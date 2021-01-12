namespace DbKochka.View.UserControls
{
    partial class UserControlApp
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelDate.Location = new System.Drawing.Point(3, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(345, 26);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Дата и время: ";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumber
            // 
            this.labelNumber.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelNumber.Location = new System.Drawing.Point(3, 26);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(345, 26);
            this.labelNumber.TabIndex = 11;
            this.labelNumber.Text = "Номер: ";
            this.labelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(3, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(345, 26);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Имя: ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelDate);
            this.Name = "UserControlApp";
            this.Size = new System.Drawing.Size(793, 89);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelName;
    }
}
