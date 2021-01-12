namespace DbKochka.View.UserControls
{
    partial class UserControlProvide
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelClubNumber = new System.Windows.Forms.Label();
            this.labelProvide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelClubNumber
            // 
            this.labelClubNumber.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelClubNumber.Location = new System.Drawing.Point(193, 13);
            this.labelClubNumber.Name = "labelClubNumber";
            this.labelClubNumber.Size = new System.Drawing.Size(370, 26);
            this.labelClubNumber.TabIndex = 5;
            this.labelClubNumber.Text = "Номер клуба: ";
            this.labelClubNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProvide
            // 
            this.labelProvide.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelProvide.Location = new System.Drawing.Point(193, 39);
            this.labelProvide.Name = "labelProvide";
            this.labelProvide.Size = new System.Drawing.Size(370, 26);
            this.labelProvide.TabIndex = 6;
            this.labelProvide.Text = "Название услуги: ";
            this.labelProvide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlProvide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelProvide);
            this.Controls.Add(this.labelClubNumber);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlProvide";
            this.Size = new System.Drawing.Size(797, 182);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelClubNumber;
        private System.Windows.Forms.Label labelProvide;
    }
}
