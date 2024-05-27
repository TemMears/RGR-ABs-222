namespace FlightCrane
{
    partial class Registration_OK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_OK));
            closed = new Label();
            panel1 = new Panel();
            textBox_password = new EgoldsGoogleTextBox();
            textBox_login = new EgoldsGoogleTextBox();
            label5 = new Label();
            button_OK = new yt_Button();
            pictureBox2 = new PictureBox();
            picture_cran_icon = new PictureBox();
            egoldsFormStyle1 = new EgoldsFormStyle(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_cran_icon).BeginInit();
            SuspendLayout();
            // 
            // closed
            // 
            closed.AutoSize = true;
            closed.Cursor = Cursors.Hand;
            closed.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            closed.Location = new Point(418, -69);
            closed.Name = "closed";
            closed.Size = new Size(31, 29);
            closed.TabIndex = 13;
            closed.Text = "Х";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(textBox_password);
            panel1.Controls.Add(textBox_login);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button_OK);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-116, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 486);
            panel1.TabIndex = 12;
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.LightCyan;
            textBox_password.BackgroundImageLayout = ImageLayout.Center;
            textBox_password.BorderColor = Color.FromArgb(52, 152, 219);
            textBox_password.BorderColorNotActive = Color.RoyalBlue;
            textBox_password.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.FontTextPreview = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.ForeColor = Color.Black;
            textBox_password.Location = new Point(204, 141);
            textBox_password.Name = "textBox_password";
            textBox_password.SelectionStart = 0;
            textBox_password.Size = new Size(219, 41);
            textBox_password.TabIndex = 13;
            textBox_password.TextInput = "";
            textBox_password.TextPreview = "Введите пароль";
            textBox_password.UseSystemPasswordChar = false;
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
            textBox_login.Location = new Point(204, 68);
            textBox_login.Name = "textBox_login";
            textBox_login.SelectionStart = 0;
            textBox_login.Size = new Size(219, 41);
            textBox_login.TabIndex = 12;
            textBox_login.TextInput = "";
            textBox_login.TextPreview = "Введите логин";
            textBox_login.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(204, 0);
            label5.Name = "label5";
            label5.Size = new Size(206, 33);
            label5.TabIndex = 16;
            label5.Text = "РЕГИСТРАЦИЯ";
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
            button_OK.Location = new Point(228, 214);
            button_OK.Name = "button_OK";
            button_OK.RoundingEnable = true;
            button_OK.Size = new Size(160, 47);
            button_OK.TabIndex = 11;
            button_OK.Text = "OK";
            button_OK.TextHover = null;
            button_OK.Click += button_registration_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(590, 390);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // picture_cran_icon
            // 
            picture_cran_icon.BackColor = Color.Transparent;
            picture_cran_icon.Image = (Image)resources.GetObject("picture_cran_icon.Image");
            picture_cran_icon.InitialImage = (Image)resources.GetObject("picture_cran_icon.InitialImage");
            picture_cran_icon.Location = new Point(-94, -76);
            picture_cran_icon.Name = "picture_cran_icon";
            picture_cran_icon.Size = new Size(51, 52);
            picture_cran_icon.TabIndex = 11;
            picture_cran_icon.TabStop = false;
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
            // Registration_OK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(384, 463);
            Controls.Add(closed);
            Controls.Add(panel1);
            Controls.Add(picture_cran_icon);
            Name = "Registration_OK";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_cran_icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label closed;
        private Panel panel1;
        private Label label5;
        private PictureBox picture_cran_icon;
        private yt_Button button_OK;
        public EgoldsGoogleTextBox textBox_login;
        public EgoldsGoogleTextBox textBox_password;
        public EgoldsFormStyle egoldsFormStyle1;
        private PictureBox pictureBox2;
    }
}