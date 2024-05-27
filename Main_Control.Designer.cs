namespace FlightCrane
{
    partial class Main_Control
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Control));
            picture_cran_icon = new PictureBox();
            panel1 = new Panel();
            textBox_password = new EgoldsGoogleTextBox();
            textBox_login = new EgoldsGoogleTextBox();
            fogot_password = new yt_Button();
            button_registration = new yt_Button();
            button_login = new yt_Button();
            picture_cran = new PictureBox();
            pictureBox1 = new PictureBox();
            egoldsFormStyle1 = new EgoldsFormStyle(components);
            ((System.ComponentModel.ISupportInitialize)picture_cran_icon).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_cran).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // picture_cran_icon
            // 
            picture_cran_icon.BackColor = Color.Transparent;
            picture_cran_icon.Image = (Image)resources.GetObject("picture_cran_icon.Image");
            picture_cran_icon.InitialImage = (Image)resources.GetObject("picture_cran_icon.InitialImage");
            picture_cran_icon.Location = new Point(2, 2);
            picture_cran_icon.Name = "picture_cran_icon";
            picture_cran_icon.Size = new Size(51, 52);
            picture_cran_icon.TabIndex = 0;
            picture_cran_icon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(textBox_password);
            panel1.Controls.Add(textBox_login);
            panel1.Controls.Add(fogot_password);
            panel1.Controls.Add(button_registration);
            panel1.Controls.Add(button_login);
            panel1.Controls.Add(picture_cran);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-20, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 622);
            panel1.TabIndex = 1;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.LightCyan;
            textBox_password.BorderColor = Color.FromArgb(52, 152, 219);
            textBox_password.BorderColorNotActive = Color.RoyalBlue;
            textBox_password.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.FontTextPreview = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.ForeColor = Color.Black;
            textBox_password.Location = new Point(198, 399);
            textBox_password.MaxLength = 32767;
            textBox_password.Name = "textBox_password";
            textBox_password.SelectionStart = 0;
            textBox_password.Size = new Size(206, 41);
            textBox_password.TabIndex = 11;
            textBox_password.TextInput = "";
            textBox_password.TextPreview = "Пароль";
            textBox_password.UseSystemPasswordChar = true;
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
            textBox_login.Location = new Point(198, 352);
            textBox_login.MaxLength = 32767;
            textBox_login.Name = "textBox_login";
            textBox_login.SelectionStart = 0;
            textBox_login.Size = new Size(206, 41);
            textBox_login.TabIndex = 10;
            textBox_login.TextInput = "";
            textBox_login.TextPreview = "Логин";
            textBox_login.UseSystemPasswordChar = false;
            // 
            // fogot_password
            // 
            fogot_password.BackColor = Color.PaleTurquoise;
            fogot_password.BackColorAdditional = Color.Gray;
            fogot_password.BackColorGradientEnabled = false;
            fogot_password.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            fogot_password.BorderColor = Color.Tomato;
            fogot_password.BorderColorEnabled = false;
            fogot_password.BorderColorOnHover = Color.Tomato;
            fogot_password.BorderColorOnHoverEnabled = false;
            fogot_password.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            fogot_password.ForeColor = Color.RoyalBlue;
            fogot_password.Location = new Point(52, 500);
            fogot_password.Name = "fogot_password";
            fogot_password.RoundingEnable = true;
            fogot_password.Size = new Size(160, 47);
            fogot_password.TabIndex = 9;
            fogot_password.Text = "Забыл пароль";
            fogot_password.TextHover = null;
            fogot_password.Click += fogot_password_Click;
            // 
            // button_registration
            // 
            button_registration.BackColor = Color.PaleTurquoise;
            button_registration.BackColorAdditional = Color.Gray;
            button_registration.BackColorGradientEnabled = false;
            button_registration.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            button_registration.BorderColor = Color.Tomato;
            button_registration.BorderColorEnabled = false;
            button_registration.BorderColorOnHover = Color.Tomato;
            button_registration.BorderColorOnHoverEnabled = false;
            button_registration.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            button_registration.ForeColor = Color.RoyalBlue;
            button_registration.Location = new Point(380, 500);
            button_registration.Name = "button_registration";
            button_registration.RoundingEnable = true;
            button_registration.Size = new Size(160, 47);
            button_registration.TabIndex = 8;
            button_registration.Text = "Регистрация";
            button_registration.TextHover = null;
            button_registration.Click += button_registration_Click;
            // 
            // button_login
            // 
            button_login.BackColor = Color.PaleTurquoise;
            button_login.BackColorAdditional = Color.Gray;
            button_login.BackColorGradientEnabled = false;
            button_login.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            button_login.BorderColor = Color.Tomato;
            button_login.BorderColorEnabled = false;
            button_login.BorderColorOnHover = Color.Tomato;
            button_login.BorderColorOnHoverEnabled = false;
            button_login.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            button_login.ForeColor = Color.RoyalBlue;
            button_login.Location = new Point(214, 500);
            button_login.Name = "button_login";
            button_login.RoundingEnable = true;
            button_login.Size = new Size(160, 47);
            button_login.TabIndex = 7;
            button_login.Text = "Войти";
            button_login.TextHover = null;
            button_login.Click += button_login_Click;
            // 
            // picture_cran
            // 
            picture_cran.BackColor = Color.Transparent;
            picture_cran.Image = (Image)resources.GetObject("picture_cran.Image");
            picture_cran.InitialImage = null;
            picture_cran.Location = new Point(143, 0);
            picture_cran.Name = "picture_cran";
            picture_cran.Size = new Size(329, 331);
            picture_cran.TabIndex = 0;
            picture_cran.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(678, 575);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // egoldsFormStyle1
            // 
            egoldsFormStyle1.AllowUserResize = false;
            egoldsFormStyle1.BackColor = Color.SkyBlue;
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
            // Main_Control
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(557, 612);
            Controls.Add(panel1);
            Controls.Add(picture_cran_icon);
            Name = "Main_Control";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)picture_cran_icon).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_cran).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picture_cran_icon;
        private Panel panel1;
        private PictureBox picture_cran;
        private PictureBox pictureBox1;
        private yt_Button button_login;
        private yt_Button button_registration;
        private yt_Button fogot_password;
        private EgoldsGoogleTextBox textBox_password;
        public EgoldsFormStyle egoldsFormStyle1;
        public EgoldsGoogleTextBox textBox_login;
    }
}