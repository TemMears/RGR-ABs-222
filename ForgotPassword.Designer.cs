namespace FlightCrane
{
    partial class ForgotPassword
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            egoldsFormStyle1 = new EgoldsFormStyle(components);
            button_OK = new yt_Button();
            label5 = new Label();
            textBox_UID = new EgoldsGoogleTextBox();
            textBox_login = new EgoldsGoogleTextBox();
            pictureBox2 = new PictureBox();
            textBox_NewPassword = new EgoldsGoogleTextBox();
            button_ChangePassword = new yt_Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // egoldsFormStyle1
            // 
            egoldsFormStyle1.AllowUserResize = false;
            egoldsFormStyle1.BackColor = Color.DarkCyan;
            egoldsFormStyle1.ContextMenuForm = null;
            egoldsFormStyle1.ControlBoxButtonsWidth = 30;
            egoldsFormStyle1.EnableControlBoxIconsLight = true;
            egoldsFormStyle1.EnableControlBoxMouseLight = false;
            egoldsFormStyle1.Form = this;
            egoldsFormStyle1.FormStyle = EgoldsFormStyle.fStyle.UserStyle;
            egoldsFormStyle1.HeaderColor = Color.DarkSlateGray;
            egoldsFormStyle1.HeaderColorAdditional = Color.Teal;
            egoldsFormStyle1.HeaderColorGradientEnable = true;
            egoldsFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            egoldsFormStyle1.HeaderHeight = 40;
            egoldsFormStyle1.HeaderImage = (Image)resources.GetObject("egoldsFormStyle1.HeaderImage");
            egoldsFormStyle1.HeaderTextColor = Color.Black;
            egoldsFormStyle1.HeaderTextFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // button_OK
            // 
            button_OK.BackColor = Color.PaleTurquoise;
            button_OK.BackColorAdditional = Color.Gray;
            button_OK.BackColorGradientEnabled = false;
            button_OK.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            button_OK.BorderColor = Color.Tomato;
            button_OK.BorderColorEnabled = false;
            button_OK.BorderColorOnHover = Color.Tomato;
            button_OK.BorderColorOnHoverEnabled = false;
            button_OK.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_OK.ForeColor = Color.RoyalBlue;
            button_OK.Location = new Point(105, 235);
            button_OK.Name = "button_OK";
            button_OK.RoundingEnable = true;
            button_OK.Size = new Size(160, 47);
            button_OK.TabIndex = 11;
            button_OK.Text = "Далее";
            button_OK.TextHover = null;
            button_OK.Click += button_OK_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(84, 63);
            label5.Name = "label5";
            label5.Size = new Size(222, 33);
            label5.TabIndex = 12;
            label5.Text = "ЗАБЫЛ ПАРОЛЬ";
            // 
            // textBox_UID
            // 
            textBox_UID.BackColor = Color.LightCyan;
            textBox_UID.BackgroundImageLayout = ImageLayout.Center;
            textBox_UID.BorderColor = Color.FromArgb(52, 152, 219);
            textBox_UID.BorderColorNotActive = Color.RoyalBlue;
            textBox_UID.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_UID.FontTextPreview = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_UID.ForeColor = Color.Black;
            textBox_UID.Location = new Point(84, 118);
            textBox_UID.Name = "textBox_UID";
            textBox_UID.SelectionStart = 0;
            textBox_UID.Size = new Size(219, 41);
            textBox_UID.TabIndex = 13;
            textBox_UID.TextInput = "";
            textBox_UID.TextPreview = "Введите UID";
            textBox_UID.UseSystemPasswordChar = false;
            // 
            // textBox_login
            // 
            textBox_login.BackColor = Color.LightCyan;
            textBox_login.BackgroundImageLayout = ImageLayout.Center;
            textBox_login.BorderColor = Color.FromArgb(52, 152, 219);
            textBox_login.BorderColorNotActive = Color.RoyalBlue;
            textBox_login.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_login.FontTextPreview = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_login.ForeColor = Color.Black;
            textBox_login.Location = new Point(84, 165);
            textBox_login.Name = "textBox_login";
            textBox_login.SelectionStart = 0;
            textBox_login.Size = new Size(219, 41);
            textBox_login.TabIndex = 14;
            textBox_login.TextInput = "";
            textBox_login.TextPreview = "Введите логин";
            textBox_login.UseSystemPasswordChar = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-120, 148);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(590, 390);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // textBox_NewPassword
            // 
            textBox_NewPassword.BackColor = Color.LightCyan;
            textBox_NewPassword.BackgroundImageLayout = ImageLayout.Center;
            textBox_NewPassword.BorderColor = Color.FromArgb(52, 152, 219);
            textBox_NewPassword.BorderColorNotActive = Color.RoyalBlue;
            textBox_NewPassword.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_NewPassword.FontTextPreview = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_NewPassword.ForeColor = Color.Black;
            textBox_NewPassword.Location = new Point(84, 148);
            textBox_NewPassword.Name = "textBox_NewPassword";
            textBox_NewPassword.SelectionStart = 0;
            textBox_NewPassword.Size = new Size(219, 41);
            textBox_NewPassword.TabIndex = 16;
            textBox_NewPassword.TextInput = "";
            textBox_NewPassword.TextPreview = "Введите новый пароль";
            textBox_NewPassword.UseSystemPasswordChar = false;
            // 
            // button_ChangePassword
            // 
            button_ChangePassword.BackColor = Color.PaleTurquoise;
            button_ChangePassword.BackColorAdditional = Color.Gray;
            button_ChangePassword.BackColorGradientEnabled = false;
            button_ChangePassword.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            button_ChangePassword.BorderColor = Color.Tomato;
            button_ChangePassword.BorderColorEnabled = false;
            button_ChangePassword.BorderColorOnHover = Color.Tomato;
            button_ChangePassword.BorderColorOnHoverEnabled = false;
            button_ChangePassword.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_ChangePassword.ForeColor = Color.RoyalBlue;
            button_ChangePassword.Location = new Point(105, 195);
            button_ChangePassword.Name = "button_ChangePassword";
            button_ChangePassword.RoundingEnable = true;
            button_ChangePassword.Size = new Size(160, 47);
            button_ChangePassword.TabIndex = 17;
            button_ChangePassword.Text = "Изменить";
            button_ChangePassword.TextHover = null;
            button_ChangePassword.Click += button_ChangePassword_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(384, 451);
            Controls.Add(button_ChangePassword);
            Controls.Add(textBox_NewPassword);
            Controls.Add(textBox_login);
            Controls.Add(textBox_UID);
            Controls.Add(label5);
            Controls.Add(button_OK);
            Controls.Add(pictureBox2);
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public EgoldsFormStyle egoldsFormStyle1;
        private yt_Button button_OK;
        private Label label5;
        public EgoldsGoogleTextBox textBox_UID;
        public EgoldsGoogleTextBox textBox_login;
        private PictureBox pictureBox2;
        public EgoldsGoogleTextBox textBox_NewPassword;
        private yt_Button button_ChangePassword;
    }
}