namespace DbKochka.View.UserControls
{
    partial class UserControlGuestVisit
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
            this.labelInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(197, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(412, 102);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "ЗАПОЛНИТЕ АНКЕТУ И ПОЛУЧИТЕ БЕСПЛАТНУЮ ТРЕНИРОВКУ!";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(112, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = "Также, мы проконсультируем Вас по всем направлениям занятий и ответим на ваши воп" +
    "росы\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlGuestVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInfo);
            this.Name = "UserControlGuestVisit";
            this.Size = new System.Drawing.Size(797, 160);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label1;
    }
}
