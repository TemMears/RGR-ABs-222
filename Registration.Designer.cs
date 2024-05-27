namespace FlightCrane
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            closed = new Label();
            panel1 = new Panel();
            label5 = new Label();
            textBox_Code = new EgoldsGoogleTextBox();
            textBox_UID = new EgoldsGoogleTextBox();
            button_registration = new yt_Button();
            label4 = new Label();
            picture_cran_icon = new PictureBox();
            egoldsFormStyle1 = new EgoldsFormStyle(components);
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_cran_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            closed.TabIndex = 5;
            closed.Text = "Х";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox_Code);
            panel1.Controls.Add(textBox_UID);
            panel1.Controls.Add(button_registration);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-116, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 486);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(204, 0);
            label5.Name = "label5";
            label5.Size = new Size(206, 33);
            label5.TabIndex = 10;
            label5.Text = "РЕГИСТРАЦИЯ";
            // 
            // textBox_Code
            // 
            textBox_Code.BackColor = Color.LightCyan;
            textBox_Code.BackgroundImageLayout = ImageLayout.Center;
            textBox_Code.BorderColor = Color.FromArgb(52, 152, 219);
            textBox_Code.BorderColorNotActive = Color.RoyalBlue;
            textBox_Code.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Code.FontTextPreview = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Code.ForeColor = Color.Black;
            textBox_Code.Location = new Point(204, 114);
            textBox_Code.Name = "textBox_Code";
            textBox_Code.SelectionStart = 0;
            textBox_Code.Size = new Size(219, 41);
            textBox_Code.TabIndex = 12;
            textBox_Code.TextInput = "";
            textBox_Code.TextPreview = "Введите код подлинности";
            textBox_Code.UseSystemPasswordChar = false;
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
            textBox_UID.Location = new Point(204, 56);
            textBox_UID.Name = "textBox_UID";
            textBox_UID.SelectionStart = 0;
            textBox_UID.Size = new Size(219, 41);
            textBox_UID.TabIndex = 11;
            textBox_UID.TextInput = "";
            textBox_UID.TextPreview = "Введите UID";
            textBox_UID.UseSystemPasswordChar = false;
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
            button_registration.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_registration.ForeColor = Color.RoyalBlue;
            button_registration.Location = new Point(224, 188);
            button_registration.Name = "button_registration";
            button_registration.RoundingEnable = true;
            button_registration.Size = new Size(160, 47);
            button_registration.TabIndex = 10;
            button_registration.Text = "Далее";
            button_registration.TextHover = null;
            button_registration.Click += button_registration_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(183, 252);
            label4.Name = "label4";
            label4.Size = new Size(240, 85);
            label4.TabIndex = 9;
            label4.Text = "ВНИМАНИЕ! Если у вас отсутствуют \r\nрегистрационные данные, \r\nпожалуйста, обратитесь к руководству\r\n за их выдачей.\r\n\r\n";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // picture_cran_icon
            // 
            picture_cran_icon.BackColor = Color.Transparent;
            picture_cran_icon.Image = (Image)resources.GetObject("picture_cran_icon.Image");
            picture_cran_icon.InitialImage = (Image)resources.GetObject("picture_cran_icon.InitialImage");
            picture_cran_icon.Location = new Point(-94, -76);
            picture_cran_icon.Name = "picture_cran_icon";
            picture_cran_icon.Size = new Size(51, 52);
            picture_cran_icon.TabIndex = 3;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 114);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(590, 390);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(384, 451);
            Controls.Add(closed);
            Controls.Add(panel1);
            Controls.Add(picture_cran_icon);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_cran_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label closed;
        private Panel panel1;
        private PictureBox picture_cran_icon;
        private Label label4;
        private Label label5;
        public EgoldsFormStyle egoldsFormStyle1;
        private yt_Button button_registration;
        public EgoldsGoogleTextBox textBox_Code;
        public EgoldsGoogleTextBox textBox_UID;
        private PictureBox pictureBox2;
    }
}