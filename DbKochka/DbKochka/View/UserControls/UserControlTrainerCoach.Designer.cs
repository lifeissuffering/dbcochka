namespace DbKochka.View.UserControls
{
    partial class UserControlTrainerCoach
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
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.labelStillHave = new System.Windows.Forms.Label();
            this.labelDateBegin = new System.Windows.Forms.Label();
            this.labelQuanity = new System.Windows.Forms.Label();
            this.labelTrainerName = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelContractId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelDateEnd.Location = new System.Drawing.Point(3, 104);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(345, 26);
            this.labelDateEnd.TabIndex = 17;
            this.labelDateEnd.Text = "Дата окончания: ";
            this.labelDateEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStillHave
            // 
            this.labelStillHave.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelStillHave.Location = new System.Drawing.Point(3, 52);
            this.labelStillHave.Name = "labelStillHave";
            this.labelStillHave.Size = new System.Drawing.Size(345, 26);
            this.labelStillHave.TabIndex = 16;
            this.labelStillHave.Text = "Посещений осталось: ";
            this.labelStillHave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDateBegin
            // 
            this.labelDateBegin.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelDateBegin.Location = new System.Drawing.Point(3, 78);
            this.labelDateBegin.Name = "labelDateBegin";
            this.labelDateBegin.Size = new System.Drawing.Size(561, 26);
            this.labelDateBegin.TabIndex = 15;
            this.labelDateBegin.Text = "Дата оформления: ";
            this.labelDateBegin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelQuanity
            // 
            this.labelQuanity.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelQuanity.Location = new System.Drawing.Point(3, 26);
            this.labelQuanity.Name = "labelQuanity";
            this.labelQuanity.Size = new System.Drawing.Size(485, 26);
            this.labelQuanity.TabIndex = 13;
            this.labelQuanity.Text = "Количество тренировок: ";
            this.labelQuanity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTrainerName
            // 
            this.labelTrainerName.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelTrainerName.Location = new System.Drawing.Point(3, 0);
            this.labelTrainerName.Name = "labelTrainerName";
            this.labelTrainerName.Size = new System.Drawing.Size(370, 26);
            this.labelTrainerName.TabIndex = 12;
            this.labelTrainerName.Text = "ФИО тренера: ";
            this.labelTrainerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelClientName
            // 
            this.labelClientName.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelClientName.Location = new System.Drawing.Point(3, 125);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(370, 26);
            this.labelClientName.TabIndex = 18;
            this.labelClientName.Text = "ФИО клиента: ";
            this.labelClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(6, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 1);
            this.panel1.TabIndex = 24;
            // 
            // labelContractId
            // 
            this.labelContractId.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelContractId.Location = new System.Drawing.Point(529, 0);
            this.labelContractId.Name = "labelContractId";
            this.labelContractId.Size = new System.Drawing.Size(370, 26);
            this.labelContractId.TabIndex = 25;
            this.labelContractId.Text = "Контракт №: ";
            this.labelContractId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlTrainerCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelContractId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.labelStillHave);
            this.Controls.Add(this.labelDateBegin);
            this.Controls.Add(this.labelQuanity);
            this.Controls.Add(this.labelTrainerName);
            this.Name = "UserControlTrainerCoach";
            this.Size = new System.Drawing.Size(797, 151);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Label labelStillHave;
        private System.Windows.Forms.Label labelDateBegin;
        private System.Windows.Forms.Label labelQuanity;
        private System.Windows.Forms.Label labelTrainerName;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelContractId;
    }
}
