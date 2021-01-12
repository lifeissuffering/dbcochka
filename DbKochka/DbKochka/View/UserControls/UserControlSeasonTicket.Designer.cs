namespace DbKochka.View.UserControls
{
    partial class UserControlSeasonTicket
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
            this.labelClubNumber = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelClubCard = new System.Windows.Forms.Label();
            this.labelDateBegin = new System.Windows.Forms.Label();
            this.labelStillHave = new System.Windows.Forms.Label();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.labelContractId = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelClubNumber
            // 
            this.labelClubNumber.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelClubNumber.Location = new System.Drawing.Point(3, 0);
            this.labelClubNumber.Name = "labelClubNumber";
            this.labelClubNumber.Size = new System.Drawing.Size(370, 26);
            this.labelClubNumber.TabIndex = 4;
            this.labelClubNumber.Text = "Номер клуба: ";
            this.labelClubNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(3, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(485, 26);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Название: ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelClubCard
            // 
            this.labelClubCard.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelClubCard.Location = new System.Drawing.Point(3, 52);
            this.labelClubCard.Name = "labelClubCard";
            this.labelClubCard.Size = new System.Drawing.Size(520, 26);
            this.labelClubCard.TabIndex = 6;
            this.labelClubCard.Text = "Номер клубной карты:";
            this.labelClubCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateBegin
            // 
            this.labelDateBegin.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelDateBegin.Location = new System.Drawing.Point(3, 78);
            this.labelDateBegin.Name = "labelDateBegin";
            this.labelDateBegin.Size = new System.Drawing.Size(561, 26);
            this.labelDateBegin.TabIndex = 7;
            this.labelDateBegin.Text = "Дата оформления: ";
            this.labelDateBegin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStillHave
            // 
            this.labelStillHave.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelStillHave.Location = new System.Drawing.Point(3, 104);
            this.labelStillHave.Name = "labelStillHave";
            this.labelStillHave.Size = new System.Drawing.Size(345, 26);
            this.labelStillHave.TabIndex = 8;
            this.labelStillHave.Text = "Посещений осталось: ";
            this.labelStillHave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelDateEnd.Location = new System.Drawing.Point(3, 130);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(345, 26);
            this.labelDateEnd.TabIndex = 9;
            this.labelDateEnd.Text = "Дата окончания: ";
            this.labelDateEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelContractId
            // 
            this.labelContractId.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelContractId.Location = new System.Drawing.Point(3, 156);
            this.labelContractId.Name = "labelContractId";
            this.labelContractId.Size = new System.Drawing.Size(444, 26);
            this.labelContractId.TabIndex = 10;
            this.labelContractId.Text = "Номер договора: ";
            this.labelContractId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEmployee
            // 
            this.labelEmployee.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelEmployee.Location = new System.Drawing.Point(3, 182);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(406, 26);
            this.labelEmployee.TabIndex = 11;
            this.labelEmployee.Text = "Оформил: ";
            this.labelEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelClientName
            // 
            this.labelClientName.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelClientName.Location = new System.Drawing.Point(3, 208);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(406, 26);
            this.labelClientName.TabIndex = 12;
            this.labelClientName.Text = "Клиент: ";
            this.labelClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlSeasonTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.labelContractId);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.labelStillHave);
            this.Controls.Add(this.labelDateBegin);
            this.Controls.Add(this.labelClubCard);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelClubNumber);
            this.Name = "UserControlSeasonTicket";
            this.Size = new System.Drawing.Size(797, 240);
           
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelClubNumber;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelClubCard;
        private System.Windows.Forms.Label labelDateBegin;
        private System.Windows.Forms.Label labelStillHave;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Label labelContractId;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label labelClientName;
    }
}
