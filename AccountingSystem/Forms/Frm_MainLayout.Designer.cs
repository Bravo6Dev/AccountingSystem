namespace AccountingSystem.Forms
{
    partial class Frm_MainLayout
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainLayout));
            topBar = new Controls.TopBar();
            navBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            employee = new Guna.UI2.WinForms.Guna2Button();
            cashBox = new Guna.UI2.WinForms.Guna2Button();
            paid = new Guna.UI2.WinForms.Guna2Button();
            receipt = new Guna.UI2.WinForms.Guna2Button();
            customers = new Guna.UI2.WinForms.Guna2Button();
            home = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            lblName = new Label();
            MainContent = new Guna.UI2.WinForms.Guna2GradientPanel();
            navBar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.RightToLeft = RightToLeft.Yes;
            topBar.Size = new Size(1240, 45);
            topBar.TabIndex = 0;
            topBar.Title = "الصفحة الرئيسية";
            // 
            // navBar
            // 
            navBar.Controls.Add(employee);
            navBar.Controls.Add(cashBox);
            navBar.Controls.Add(paid);
            navBar.Controls.Add(receipt);
            navBar.Controls.Add(customers);
            navBar.Controls.Add(home);
            navBar.Controls.Add(panel1);
            navBar.CustomizableEdges = customizableEdges13;
            navBar.Dock = DockStyle.Left;
            navBar.FillColor = Color.FromArgb(226, 232, 240);
            navBar.FillColor2 = Color.FromArgb(226, 232, 240);
            navBar.FillColor3 = Color.FromArgb(226, 232, 240);
            navBar.FillColor4 = Color.FromArgb(226, 232, 240);
            navBar.Location = new Point(0, 45);
            navBar.Name = "navBar";
            navBar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            navBar.Size = new Size(312, 739);
            navBar.TabIndex = 1;
            // 
            // employee
            // 
            employee.Cursor = Cursors.Hand;
            employee.CustomizableEdges = customizableEdges1;
            employee.DisabledState.BorderColor = Color.DarkGray;
            employee.DisabledState.CustomBorderColor = Color.DarkGray;
            employee.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            employee.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            employee.Dock = DockStyle.Top;
            employee.FillColor = Color.FromArgb(226, 232, 240);
            employee.Font = new Font("Segoe UI", 14.25F);
            employee.ForeColor = Color.FromArgb(100, 116, 139);
            employee.Image = Properties.Resources.employee;
            employee.ImageAlign = HorizontalAlignment.Left;
            employee.ImageSize = new Size(36, 36);
            employee.Location = new Point(0, 362);
            employee.Name = "employee";
            employee.Padding = new Padding(10);
            employee.ShadowDecoration.CustomizableEdges = customizableEdges2;
            employee.Size = new Size(312, 64);
            employee.TabIndex = 6;
            employee.Text = "الموظفين";
            employee.Click += NavBarButton_Click;
            // 
            // cashBox
            // 
            cashBox.Cursor = Cursors.Hand;
            cashBox.CustomizableEdges = customizableEdges3;
            cashBox.DisabledState.BorderColor = Color.DarkGray;
            cashBox.DisabledState.CustomBorderColor = Color.DarkGray;
            cashBox.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            cashBox.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            cashBox.Dock = DockStyle.Top;
            cashBox.FillColor = Color.FromArgb(226, 232, 240);
            cashBox.Font = new Font("Segoe UI", 14.25F);
            cashBox.ForeColor = Color.FromArgb(100, 116, 139);
            cashBox.Image = Properties.Resources.cashBox;
            cashBox.ImageAlign = HorizontalAlignment.Left;
            cashBox.ImageSize = new Size(36, 36);
            cashBox.Location = new Point(0, 298);
            cashBox.Name = "cashBox";
            cashBox.Padding = new Padding(10);
            cashBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cashBox.Size = new Size(312, 64);
            cashBox.TabIndex = 5;
            cashBox.Text = "الخزاين";
            cashBox.Click += NavBarButton_Click;
            // 
            // paid
            // 
            paid.Cursor = Cursors.Hand;
            paid.CustomizableEdges = customizableEdges5;
            paid.DisabledState.BorderColor = Color.DarkGray;
            paid.DisabledState.CustomBorderColor = Color.DarkGray;
            paid.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            paid.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            paid.Dock = DockStyle.Top;
            paid.FillColor = Color.FromArgb(226, 232, 240);
            paid.Font = new Font("Segoe UI", 14.25F);
            paid.ForeColor = Color.FromArgb(100, 116, 139);
            paid.Image = Properties.Resources.paid;
            paid.ImageAlign = HorizontalAlignment.Left;
            paid.ImageSize = new Size(36, 36);
            paid.Location = new Point(0, 234);
            paid.Name = "paid";
            paid.Padding = new Padding(10);
            paid.ShadowDecoration.CustomizableEdges = customizableEdges6;
            paid.Size = new Size(312, 64);
            paid.TabIndex = 4;
            paid.Text = "الايصالات";
            paid.Click += NavBarButton_Click;
            // 
            // receipt
            // 
            receipt.Cursor = Cursors.Hand;
            receipt.CustomizableEdges = customizableEdges7;
            receipt.DisabledState.BorderColor = Color.DarkGray;
            receipt.DisabledState.CustomBorderColor = Color.DarkGray;
            receipt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            receipt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            receipt.Dock = DockStyle.Top;
            receipt.FillColor = Color.FromArgb(226, 232, 240);
            receipt.Font = new Font("Segoe UI", 14.25F);
            receipt.ForeColor = Color.FromArgb(100, 116, 139);
            receipt.Image = Properties.Resources.receipt;
            receipt.ImageAlign = HorizontalAlignment.Left;
            receipt.ImageSize = new Size(36, 36);
            receipt.Location = new Point(0, 170);
            receipt.Name = "receipt";
            receipt.Padding = new Padding(10);
            receipt.ShadowDecoration.CustomizableEdges = customizableEdges8;
            receipt.Size = new Size(312, 64);
            receipt.TabIndex = 3;
            receipt.Text = "الفواتير";
            receipt.Click += NavBarButton_Click;
            // 
            // customers
            // 
            customers.Cursor = Cursors.Hand;
            customers.CustomizableEdges = customizableEdges9;
            customers.DisabledState.BorderColor = Color.DarkGray;
            customers.DisabledState.CustomBorderColor = Color.DarkGray;
            customers.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            customers.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            customers.Dock = DockStyle.Top;
            customers.FillColor = Color.FromArgb(226, 232, 240);
            customers.Font = new Font("Segoe UI", 14.25F);
            customers.ForeColor = Color.FromArgb(100, 116, 139);
            customers.Image = Properties.Resources.customers;
            customers.ImageAlign = HorizontalAlignment.Left;
            customers.ImageSize = new Size(36, 36);
            customers.Location = new Point(0, 106);
            customers.Name = "customers";
            customers.Padding = new Padding(10);
            customers.ShadowDecoration.CustomizableEdges = customizableEdges10;
            customers.Size = new Size(312, 64);
            customers.TabIndex = 2;
            customers.Text = "العملاء";
            customers.Click += NavBarButton_Click;
            // 
            // home
            // 
            home.Cursor = Cursors.Hand;
            home.CustomizableEdges = customizableEdges11;
            home.DisabledState.BorderColor = Color.DarkGray;
            home.DisabledState.CustomBorderColor = Color.DarkGray;
            home.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            home.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            home.Dock = DockStyle.Top;
            home.FillColor = Color.FromArgb(15, 23, 42);
            home.Font = new Font("Segoe UI", 14.25F);
            home.ForeColor = Color.White;
            home.Image = Properties.Resources.homeWhite;
            home.ImageAlign = HorizontalAlignment.Left;
            home.ImageSize = new Size(36, 36);
            home.Location = new Point(0, 42);
            home.Name = "home";
            home.Padding = new Padding(10);
            home.ShadowDecoration.CustomizableEdges = customizableEdges12;
            home.Size = new Size(312, 64);
            home.TabIndex = 1;
            home.Text = "الصفحة الرئيسية";
            home.Click += NavBarButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 42);
            panel1.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.BackColor = Color.FromArgb(226, 232, 240);
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(312, 42);
            lblName.TabIndex = 1;
            lblName.Text = "Blue lines";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainContent
            // 
            MainContent.CustomizableEdges = customizableEdges15;
            MainContent.Dock = DockStyle.Fill;
            MainContent.Location = new Point(312, 45);
            MainContent.Name = "MainContent";
            MainContent.ShadowDecoration.CustomizableEdges = customizableEdges16;
            MainContent.Size = new Size(928, 739);
            MainContent.TabIndex = 2;
            // 
            // Frm_MainLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1240, 784);
            Controls.Add(MainContent);
            Controls.Add(navBar);
            Controls.Add(topBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Frm_MainLayout";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainLayout";
            FormClosed += Frm_MainLayout_FormClosed;
            navBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.TopBar topBar;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel navBar;
        private Panel panel1;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2GradientPanel MainContent;
        private Guna.UI2.WinForms.Guna2Button employee;
        private Guna.UI2.WinForms.Guna2Button cashBox;
        private Guna.UI2.WinForms.Guna2Button paid;
        private Guna.UI2.WinForms.Guna2Button receipt;
        private Guna.UI2.WinForms.Guna2Button customers;
        private Guna.UI2.WinForms.Guna2Button home;
    }
}