namespace FlightCrane
{
    partial class ChangeRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeRoute));
            textBox_route = new EgoldsGoogleTextBox();
            button_OK = new yt_Button();
            egoldsFormStyle1 = new EgoldsFormStyle(components);
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox_route
            // 
            textBox_route.BackColor = Color.LightCyan;
            textBox_route.BackgroundImageLayout = ImageLayout.Center;
            textBox_route.BorderColor = Color.FromArgb(52, 152, 219);
            textBox_route.BorderColorNotActive = Color.RoyalBlue;
            textBox_route.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_route.FontTextPreview = new Font("Times New Roman", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_route.ForeColor = Color.Black;
            textBox_route.Location = new Point(40, 45);
            textBox_route.MaxLength = 32767;
            textBox_route.Name = "textBox_route";
            textBox_route.SelectionStart = 0;
            textBox_route.Size = new Size(285, 41);
            textBox_route.TabIndex = 11;
            textBox_route.TextInput = "";
            textBox_route.TextPreview = "Новое значение";
            textBox_route.UseSystemPasswordChar = false;
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
            button_OK.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            button_OK.ForeColor = Color.RoyalBlue;
            button_OK.Location = new Point(96, 96);
            button_OK.Name = "button_OK";
            button_OK.RoundingEnable = true;
            button_OK.Size = new Size(160, 47);
            button_OK.TabIndex = 12;
            button_OK.Text = "ОК";
            button_OK.TextHover = null;
            button_OK.Click += button_OK_Click;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(50, 9);
            label5.Name = "label5";
            label5.Size = new Size(261, 33);
            label5.TabIndex = 27;
            label5.Text = "НОВЫЙ МАРШРУТ";
            // 
            // ChangeRoute
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(357, 214);
            Controls.Add(label5);
            Controls.Add(button_OK);
            Controls.Add(textBox_route);
            Name = "ChangeRoute";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public EgoldsGoogleTextBox textBox_route;
        private yt_Button button_OK;
        public EgoldsFormStyle egoldsFormStyle1;
        private Label label5;
    }
}