namespace AccountingSystem.Forms
{
    partial class Frm_Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            topBar1 = new Controls.TopBar();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            lblError = new Label();
            cmbUsers = new Guna.UI2.WinForms.Guna2ComboBox();
            pictureBox1 = new PictureBox();
            txtPassword = new Controls.PasswordTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // topBar1
            // 
            topBar1.Dock = DockStyle.Top;
            topBar1.Location = new Point(0, 0);
            topBar1.Margin = new Padding(3, 4, 3, 4);
            topBar1.Name = "topBar1";
            topBar1.RightToLeft = RightToLeft.Yes;
            topBar1.Size = new Size(662, 54);
            topBar1.TabIndex = 0;
            topBar1.Title = "تسجيل الدخول";
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 10;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.CustomizableEdges = customizableEdges1;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(37, 99, 235);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(228, 354);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogin.Size = new Size(198, 47);
            btnLogin.TabIndex = 2;
            btnLogin.Text = " تسجيل الدخول";
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.Dock = DockStyle.Bottom;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(0, 431);
            lblError.Name = "lblError";
            lblError.Size = new Size(662, 39);
            lblError.TabIndex = 3;
            lblError.Text = "Error";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // cmbUsers
            // 
            cmbUsers.BackColor = Color.Transparent;
            cmbUsers.BorderRadius = 10;
            cmbUsers.CustomizableEdges = customizableEdges3;
            cmbUsers.DrawMode = DrawMode.OwnerDrawFixed;
            cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsers.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbUsers.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbUsers.Font = new Font("Segoe UI", 12F);
            cmbUsers.ForeColor = Color.Black;
            cmbUsers.ItemHeight = 30;
            cmbUsers.Location = new Point(69, 226);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cmbUsers.Size = new Size(507, 36);
            cmbUsers.TabIndex = 4;
            cmbUsers.TextAlign = HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(244, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 10;
            txtPassword.CustomizableEdges = customizableEdges5;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = (Image)resources.GetObject("txtPassword.IconLeft");
            txtPassword.IconLeftCursor = Cursors.Hand;
            txtPassword.Location = new Point(69, 288);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "كلمة المرور";
            txtPassword.RightToLeft = RightToLeft.Yes;
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassword.Size = new Size(507, 36);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(662, 470);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox1);
            Controls.Add(cmbUsers);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(topBar1);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_Login";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Login";
            Load += Frm_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.TopBar topBar1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Label lblError;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUsers;
        private PictureBox pictureBox1;
        private Controls.PasswordTextBox txtPassword;
    }
}