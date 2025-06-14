namespace AccountingSystem.Forms.Employees
{
    partial class Frm_AddEditEmplyee
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddEditEmplyee));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            topBar1 = new Controls.TopBar();
            gpEmplyeeInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            txtSalary = new Controls.NumericTextBox();
            txtPassword = new Controls.PasswordTextBox();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            cmbPermission = new Guna.UI2.WinForms.Guna2ComboBox();
            gpEmplyeeInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 10;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.CustomizableEdges = customizableEdges15;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(22, 163, 74);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(825, 432);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnAdd.Size = new Size(180, 45);
            btnAdd.TabIndex = 11;
            btnAdd.TabStop = false;
            btnAdd.Text = "اضافة";
            btnAdd.Click += btnAdd_Click;
            // 
            // topBar1
            // 
            topBar1.Dock = DockStyle.Top;
            topBar1.Location = new Point(0, 0);
            topBar1.Name = "topBar1";
            topBar1.RightToLeft = RightToLeft.Yes;
            topBar1.Size = new Size(1017, 39);
            topBar1.TabIndex = 13;
            topBar1.TabStop = false;
            topBar1.Title = "الموظفين";
            // 
            // gpEmplyeeInfo
            // 
            gpEmplyeeInfo.BorderThickness = 2;
            gpEmplyeeInfo.Controls.Add(txtSalary);
            gpEmplyeeInfo.Controls.Add(txtPassword);
            gpEmplyeeInfo.Controls.Add(txtUsername);
            gpEmplyeeInfo.Controls.Add(txtPhoneNumber);
            gpEmplyeeInfo.Controls.Add(cmbPermission);
            gpEmplyeeInfo.CustomBorderColor = Color.FromArgb(16, 99, 205);
            gpEmplyeeInfo.CustomizableEdges = customizableEdges27;
            gpEmplyeeInfo.Dock = DockStyle.Top;
            gpEmplyeeInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            gpEmplyeeInfo.ForeColor = Color.White;
            gpEmplyeeInfo.Location = new Point(0, 39);
            gpEmplyeeInfo.Name = "gpEmplyeeInfo";
            gpEmplyeeInfo.ShadowDecoration.CustomizableEdges = customizableEdges28;
            gpEmplyeeInfo.ShadowDecoration.Depth = 10;
            gpEmplyeeInfo.ShadowDecoration.Enabled = true;
            gpEmplyeeInfo.Size = new Size(1017, 366);
            gpEmplyeeInfo.TabIndex = 14;
            gpEmplyeeInfo.TabStop = false;
            gpEmplyeeInfo.Text = "بيانات الموظف";
            gpEmplyeeInfo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSalary
            // 
            txtSalary.BorderRadius = 10;
            txtSalary.CustomizableEdges = customizableEdges17;
            txtSalary.DefaultText = "";
            txtSalary.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSalary.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSalary.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSalary.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSalary.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSalary.Font = new Font("Segoe UI", 12F);
            txtSalary.ForeColor = Color.Black;
            txtSalary.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSalary.Location = new Point(750, 250);
            txtSalary.Margin = new Padding(4);
            txtSalary.Name = "txtSalary";
            txtSalary.PlaceholderText = "المرتب";
            txtSalary.SelectedText = "";
            txtSalary.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtSalary.Size = new Size(257, 43);
            txtSalary.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 10;
            txtPassword.CustomizableEdges = customizableEdges19;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.IconLeft = (Image)resources.GetObject("txtPassword.IconLeft");
            txtPassword.IconLeftCursor = Cursors.Hand;
            txtPassword.Location = new Point(603, 126);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "كلمة المرور";
            txtPassword.RightToLeft = RightToLeft.Yes;
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtPassword.Size = new Size(404, 43);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderRadius = 10;
            txtUsername.CustomizableEdges = customizableEdges21;
            txtUsername.DefaultText = "";
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(603, 64);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "اسم المستخدم";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges22;
            txtUsername.Size = new Size(404, 43);
            txtUsername.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.White;
            txtPhoneNumber.BorderRadius = 10;
            txtPhoneNumber.CustomizableEdges = customizableEdges23;
            txtPhoneNumber.DefaultText = "";
            txtPhoneNumber.Font = new Font("Segoe UI", 12F);
            txtPhoneNumber.ForeColor = Color.Black;
            txtPhoneNumber.Location = new Point(603, 188);
            txtPhoneNumber.Margin = new Padding(4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "رقم الهاتف";
            txtPhoneNumber.SelectedText = "";
            txtPhoneNumber.ShadowDecoration.CustomizableEdges = customizableEdges24;
            txtPhoneNumber.Size = new Size(404, 43);
            txtPhoneNumber.TabIndex = 2;
            // 
            // cmbPermission
            // 
            cmbPermission.BackColor = Color.White;
            cmbPermission.BorderRadius = 10;
            cmbPermission.CustomizableEdges = customizableEdges25;
            cmbPermission.DrawMode = DrawMode.OwnerDrawFixed;
            cmbPermission.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPermission.FocusedColor = Color.Empty;
            cmbPermission.Font = new Font("Segoe UI", 12F);
            cmbPermission.ForeColor = Color.Black;
            cmbPermission.ItemHeight = 30;
            cmbPermission.Location = new Point(851, 312);
            cmbPermission.Name = "cmbPermission";
            cmbPermission.ShadowDecoration.CustomizableEdges = customizableEdges26;
            cmbPermission.Size = new Size(156, 36);
            cmbPermission.TabIndex = 4;
            cmbPermission.TabStop = false;
            // 
            // Frm_AddEditEmplyee
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1017, 503);
            Controls.Add(gpEmplyeeInfo);
            Controls.Add(topBar1);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_AddEditEmplyee";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Employee";
            Load += Frm_AddEditEmplyee_Load;
            gpEmplyeeInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Controls.TopBar topBar1;
        private Guna.UI2.WinForms.Guna2GroupBox gpEmplyeeInfo;
        private Controls.NumericTextBox txtSalary;
        private Controls.PasswordTextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPermission;
    }
}