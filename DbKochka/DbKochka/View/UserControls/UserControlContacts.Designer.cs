namespace DbKochka.View.UserControls
{
    partial class UserControlContacts
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
            this.labelClubCard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelClubCard
            // 
            this.labelClubCard.Font = new System.Drawing.Font("Arial", 15.25F, System.Drawing.FontStyle.Bold);
            this.labelClubCard.Location = new System.Drawing.Point(106, 27);
            this.labelClubCard.Name = "labelClubCard";
            this.labelClubCard.Size = new System.Drawing.Size(559, 89);
            this.labelClubCard.TabIndex = 9;
            this.labelClubCard.Text = "График работы: 07:00 - 22:00\r\nАдрес: г. Липецк, ул. Нижняя Логовая, 2\r\nТелефон: +" +
    "7(474)228-1337";
            this.labelClubCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelClubCard);
            this.Name = "UserControlContacts";
            this.Size = new System.Drawing.Size(797, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelClubCard;
    }
}
