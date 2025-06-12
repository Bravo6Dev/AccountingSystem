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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            topBar1 = new Controls.TopBar();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            lblError = new Label();
            cmbUsers = new Guna.UI2.WinForms.Guna2ComboBox();
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
            // txtPassword
            // 
            txtPassword.BorderRadius = 10;
            txtPassword.CustomizableEdges = customizableEdges1;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = Properties.Resources.visibility;
            txtPassword.Location = new Point(68, 268);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderForeColor = Color.Black;
            txtPassword.PlaceholderText = "كلمة المرور";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtPassword.Size = new Size(507, 41);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.IconLeftClick += txtPassword_IconLeftClick;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 10;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.CustomizableEdges = customizableEdges3;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(37, 99, 235);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(228, 354);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            cmbUsers.CustomizableEdges = customizableEdges5;
            cmbUsers.DrawMode = DrawMode.OwnerDrawFixed;
            cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsers.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbUsers.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbUsers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbUsers.ForeColor = Color.Black;
            cmbUsers.ItemHeight = 30;
            cmbUsers.Location = new Point(68, 203);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cmbUsers.Size = new Size(507, 36);
            cmbUsers.TabIndex = 4;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(662, 470);
            Controls.Add(cmbUsers);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
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
            ResumeLayout(false);
        }

        #endregion

        private Controls.TopBar topBar1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Label lblError;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUsers;
    }
}