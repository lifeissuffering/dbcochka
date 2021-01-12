namespace DbKochka.View.UserControls
{
    partial class UserControlVisitor
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
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelClubCard = new System.Windows.Forms.Label();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelPassport = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelClientName
            // 
            this.labelClientName.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelClientName.Location = new System.Drawing.Point(3, 0);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(406, 26);
            this.labelClientName.TabIndex = 13;
            this.labelClientName.Text = "Клиент: ";
            this.labelClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelClubCard
            // 
            this.labelClubCard.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelClubCard.Location = new System.Drawing.Point(3, 26);
            this.labelClubCard.Name = "labelClubCard";
            this.labelClubCard.Size = new System.Drawing.Size(520, 26);
            this.labelClubCard.TabIndex = 14;
            this.labelClubCard.Text = "Номер клубной карты:";
            this.labelClubCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBirth
            // 
            this.labelBirth.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelBirth.Location = new System.Drawing.Point(3, 52);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(520, 26);
            this.labelBirth.TabIndex = 15;
            this.labelBirth.Text = "Год рождения:";
            this.labelBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPassport
            // 
            this.labelPassport.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelPassport.Location = new System.Drawing.Point(3, 78);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(520, 26);
            this.labelPassport.TabIndex = 16;
            this.labelPassport.Text = "Паспортные данные:";
            this.labelPassport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(6, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 1);
            this.panel1.TabIndex = 24;
            // 
            // UserControlVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.labelClubCard);
            this.Controls.Add(this.labelClientName);
            this.Name = "UserControlVisitor";
            this.Size = new System.Drawing.Size(797, 110);
            this.Load += new System.EventHandler(this.UserControlVisitor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelClubCard;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Panel panel1;
    }
}
