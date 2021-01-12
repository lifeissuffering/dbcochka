namespace DbKochka.View.UserControls
{
    partial class UserControlVisits
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
            this.labelCardName = new System.Windows.Forms.Label();
            this.labelContractId = new System.Windows.Forms.Label();
            this.labelNumberOfCLub = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelClientName
            // 
            this.labelClientName.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelClientName.Location = new System.Drawing.Point(3, 104);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(345, 26);
            this.labelClientName.TabIndex = 22;
            this.labelClientName.Text = "Имя посетителя: ";
            this.labelClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCardName
            // 
            this.labelCardName.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelCardName.Location = new System.Drawing.Point(3, 52);
            this.labelCardName.Name = "labelCardName";
            this.labelCardName.Size = new System.Drawing.Size(345, 26);
            this.labelCardName.TabIndex = 21;
            this.labelCardName.Text = "Название абонемента: ";
            this.labelCardName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelContractId
            // 
            this.labelContractId.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelContractId.Location = new System.Drawing.Point(3, 78);
            this.labelContractId.Name = "labelContractId";
            this.labelContractId.Size = new System.Drawing.Size(561, 26);
            this.labelContractId.TabIndex = 20;
            this.labelContractId.Text = "Номер договора: ";
            this.labelContractId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumberOfCLub
            // 
            this.labelNumberOfCLub.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelNumberOfCLub.Location = new System.Drawing.Point(3, 26);
            this.labelNumberOfCLub.Name = "labelNumberOfCLub";
            this.labelNumberOfCLub.Size = new System.Drawing.Size(485, 26);
            this.labelNumberOfCLub.TabIndex = 19;
            this.labelNumberOfCLub.Text = "Номер клуба: ";
            this.labelNumberOfCLub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelDate.Location = new System.Drawing.Point(3, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(370, 26);
            this.labelDate.TabIndex = 18;
            this.labelDate.Text = "Дата посещения: ";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(6, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 1);
            this.panel1.TabIndex = 23;
            // 
            // UserControlVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.labelCardName);
            this.Controls.Add(this.labelContractId);
            this.Controls.Add(this.labelNumberOfCLub);
            this.Controls.Add(this.labelDate);
            this.Name = "UserControlVisits";
            this.Size = new System.Drawing.Size(797, 139);
            this.Load += new System.EventHandler(this.UserControlVisits_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelCardName;
        private System.Windows.Forms.Label labelContractId;
        private System.Windows.Forms.Label labelNumberOfCLub;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panel1;
    }
}
