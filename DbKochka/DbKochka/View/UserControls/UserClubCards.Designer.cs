namespace DbKochka.View.UserControls
{
    partial class UserClubCards
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
            this.labelGrafik = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelClubCard
            // 
            this.labelClubCard.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelClubCard.Location = new System.Drawing.Point(13, 15);
            this.labelClubCard.Name = "labelClubCard";
            this.labelClubCard.Size = new System.Drawing.Size(401, 26);
            this.labelClubCard.TabIndex = 8;
            this.labelClubCard.Text = "Название клубной карты: ";
            this.labelClubCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelGrafik
            // 
            this.labelGrafik.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelGrafik.Location = new System.Drawing.Point(13, 41);
            this.labelGrafik.Name = "labelGrafik";
            this.labelGrafik.Size = new System.Drawing.Size(370, 26);
            this.labelGrafik.TabIndex = 10;
            this.labelGrafik.Text = "График: ";
            this.labelGrafik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCost
            // 
            this.labelCost.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelCost.Location = new System.Drawing.Point(13, 67);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(657, 26);
            this.labelCost.TabIndex = 11;
            this.labelCost.Text = "Стоимость на месяц/полгода/год: ";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelQuantity
            // 
            this.labelQuantity.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelQuantity.Location = new System.Drawing.Point(13, 93);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(370, 26);
            this.labelQuantity.TabIndex = 12;
            this.labelQuantity.Text = "Занятий в месяц: ";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserClubCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelGrafik);
            this.Controls.Add(this.labelClubCard);
            this.Name = "UserClubCards";
            this.Size = new System.Drawing.Size(797, 149);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelClubCard;
        private System.Windows.Forms.Label labelGrafik;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelQuantity;
    }
}
