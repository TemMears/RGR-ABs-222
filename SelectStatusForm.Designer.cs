namespace FlightCrane
{
    partial class SelectStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectStatusForm));
            egoldsFormStyle1 = new EgoldsFormStyle(components);
            button_change = new yt_Button();
            comboBox_status_change = new ComboBox();
            label5 = new Label();
            SuspendLayout();
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
            // button_change
            // 
            button_change.BackColor = Color.PaleTurquoise;
            button_change.BackColorAdditional = Color.Gray;
            button_change.BackColorGradientEnabled = false;
            button_change.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            button_change.BorderColor = Color.Tomato;
            button_change.BorderColorEnabled = false;
            button_change.BorderColorOnHover = Color.Tomato;
            button_change.BorderColorOnHoverEnabled = false;
            button_change.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button_change.ForeColor = Color.RoyalBlue;
            button_change.Location = new Point(99, 92);
            button_change.Name = "button_change";
            button_change.RoundingEnable = true;
            button_change.Size = new Size(160, 47);
            button_change.TabIndex = 23;
            button_change.Text = "OK";
            button_change.TextHover = null;
            button_change.Click += button_OK_Click;
            // 
            // comboBox_status_change
            // 
            comboBox_status_change.BackColor = Color.LightCyan;
            comboBox_status_change.DropDownHeight = 110;
            comboBox_status_change.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_status_change.FlatStyle = FlatStyle.Popup;
            comboBox_status_change.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_status_change.ForeColor = Color.RoyalBlue;
            comboBox_status_change.FormattingEnabled = true;
            comboBox_status_change.IntegralHeight = false;
            comboBox_status_change.ItemHeight = 20;
            comboBox_status_change.Location = new Point(48, 58);
            comboBox_status_change.Name = "comboBox_status_change";
            comboBox_status_change.Size = new Size(280, 28);
            comboBox_status_change.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(34, 18);
            label5.Name = "label5";
            label5.Size = new Size(307, 26);
            label5.TabIndex = 27;
            label5.Text = "ВЫБЕРИТЕ НОВЫЙ СТАТУС";
            // 
            // SelectStatusForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(372, 208);
            Controls.Add(label5);
            Controls.Add(comboBox_status_change);
            Controls.Add(button_change);
            Name = "SelectStatusForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public EgoldsFormStyle egoldsFormStyle1;
        private yt_Button button_change;
        private ComboBox comboBox_status_change;
        private Label label5;
    }
}