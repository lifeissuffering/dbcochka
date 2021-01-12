namespace DbKochka.View
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelBorderUp = new System.Windows.Forms.Panel();
            this.panelBorderDown = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonTeam = new System.Windows.Forms.Button();
            this.buttonContacts = new System.Windows.Forms.Button();
            this.buttonClubCard = new System.Windows.Forms.Button();
            this.buttonProvide = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelGuestVisit = new System.Windows.Forms.Panel();
            this.buttonGuestVisit = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelMain.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelGuestVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.Controls.Add(this.panelLogo);
            this.flowLayoutPanelMain.Controls.Add(this.panelInfo);
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(6, 66);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(822, 459);
            this.flowLayoutPanelMain.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(783, 191);
            this.panelLogo.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.AutoScroll = true;
            this.panelInfo.Controls.Add(this.panelBorderUp);
            this.panelInfo.Controls.Add(this.panelBorderDown);
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Location = new System.Drawing.Point(3, 200);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(783, 259);
            this.panelInfo.TabIndex = 1;
            // 
            // panelBorderUp
            // 
            this.panelBorderUp.BackColor = System.Drawing.Color.Black;
            this.panelBorderUp.Location = new System.Drawing.Point(280, 31);
            this.panelBorderUp.Name = "panelBorderUp";
            this.panelBorderUp.Size = new System.Drawing.Size(234, 1);
            this.panelBorderUp.TabIndex = 3;
            // 
            // panelBorderDown
            // 
            this.panelBorderDown.BackColor = System.Drawing.Color.Black;
            this.panelBorderDown.Location = new System.Drawing.Point(280, 219);
            this.panelBorderDown.Name = "panelBorderDown";
            this.panelBorderDown.Size = new System.Drawing.Size(234, 1);
            this.panelBorderDown.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(223, 35);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(345, 185);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Кочка – это сеть\r\nспортивных клубов эконом - класса,\r\nпредоставляющая \r\nспортивно" +
    "-оздоровительные услуги \r\nпо доступной цене.\r\nХочешь быть здоровым и красивым?\r\n" +
    "Теперь ты можешь себе это позволить!";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonTeam);
            this.panelMenu.Controls.Add(this.buttonContacts);
            this.panelMenu.Controls.Add(this.buttonClubCard);
            this.panelMenu.Controls.Add(this.buttonProvide);
            this.panelMenu.Controls.Add(this.buttonLogin);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(828, 67);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonTeam
            // 
            this.buttonTeam.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeam.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonTeam.Location = new System.Drawing.Point(642, 5);
            this.buttonTeam.Name = "buttonTeam";
            this.buttonTeam.Size = new System.Drawing.Size(150, 56);
            this.buttonTeam.TabIndex = 4;
            this.buttonTeam.Text = "Команда";
            this.buttonTeam.UseVisualStyleBackColor = true;
            this.buttonTeam.Click += new System.EventHandler(this.buttonTeam_Click);
            // 
            // buttonContacts
            // 
            this.buttonContacts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonContacts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContacts.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonContacts.Location = new System.Drawing.Point(486, 5);
            this.buttonContacts.Name = "buttonContacts";
            this.buttonContacts.Size = new System.Drawing.Size(150, 56);
            this.buttonContacts.TabIndex = 3;
            this.buttonContacts.Text = "Контакты";
            this.buttonContacts.UseVisualStyleBackColor = true;
            this.buttonContacts.Click += new System.EventHandler(this.buttonContacts_Click);
            // 
            // buttonClubCard
            // 
            this.buttonClubCard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClubCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClubCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClubCard.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonClubCard.Location = new System.Drawing.Point(298, 5);
            this.buttonClubCard.Name = "buttonClubCard";
            this.buttonClubCard.Size = new System.Drawing.Size(182, 56);
            this.buttonClubCard.TabIndex = 2;
            this.buttonClubCard.Text = "Клубные карты";
            this.buttonClubCard.UseVisualStyleBackColor = true;
            this.buttonClubCard.Click += new System.EventHandler(this.buttonClubCard_Click);
            // 
            // buttonProvide
            // 
            this.buttonProvide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonProvide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonProvide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProvide.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonProvide.Location = new System.Drawing.Point(142, 4);
            this.buttonProvide.Name = "buttonProvide";
            this.buttonProvide.Size = new System.Drawing.Size(150, 56);
            this.buttonProvide.TabIndex = 1;
            this.buttonProvide.Text = "Услуги";
            this.buttonProvide.UseVisualStyleBackColor = true;
            this.buttonProvide.Click += new System.EventHandler(this.buttonProvide_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.Location = new System.Drawing.Point(4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(132, 56);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelGuestVisit
            // 
            this.panelGuestVisit.Controls.Add(this.buttonGuestVisit);
            this.panelGuestVisit.Location = new System.Drawing.Point(6, 531);
            this.panelGuestVisit.Name = "panelGuestVisit";
            this.panelGuestVisit.Size = new System.Drawing.Size(797, 65);
            this.panelGuestVisit.TabIndex = 2;
            // 
            // buttonGuestVisit
            // 
            this.buttonGuestVisit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonGuestVisit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonGuestVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuestVisit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonGuestVisit.Location = new System.Drawing.Point(228, 14);
            this.buttonGuestVisit.Name = "buttonGuestVisit";
            this.buttonGuestVisit.Size = new System.Drawing.Size(355, 35);
            this.buttonGuestVisit.TabIndex = 5;
            this.buttonGuestVisit.Text = "Записаться на гостевой визит";
            this.buttonGuestVisit.UseVisualStyleBackColor = true;
            this.buttonGuestVisit.Click += new System.EventHandler(this.buttonGuestVisit_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(311, 17);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(172, 158);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 608);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.panelGuestVisit);
            this.Name = "Form2";
            this.Text = "Form2";
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelGuestVisit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelGuestVisit;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonTeam;
        private System.Windows.Forms.Button buttonContacts;
        private System.Windows.Forms.Button buttonClubCard;
        private System.Windows.Forms.Button buttonProvide;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonGuestVisit;
        private System.Windows.Forms.Panel panelBorderDown;
        private System.Windows.Forms.Panel panelBorderUp;
    }
}