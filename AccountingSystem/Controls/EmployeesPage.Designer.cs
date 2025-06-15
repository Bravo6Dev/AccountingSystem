namespace AccountingSystem.Controls
{
    partial class EmployeesPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            gpFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            paginationInfo = new Panel();
            btnPrev = new Guna.UI2.WinForms.Guna2ImageButton();
            lblPagInfo = new Label();
            btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            panel2 = new Panel();
            picLoading = new PictureBox();
            dgvEmployees = new Guna.UI2.WinForms.Guna2DataGridView();
            gpFilter.SuspendLayout();
            paginationInfo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // gpFilter
            // 
            gpFilter.BackColor = Color.White;
            gpFilter.BorderColor = Color.Transparent;
            gpFilter.Controls.Add(btnAddNew);
            gpFilter.Controls.Add(txtFilter);
            gpFilter.CustomBorderColor = Color.Transparent;
            gpFilter.CustomizableEdges = customizableEdges5;
            gpFilter.Dock = DockStyle.Top;
            gpFilter.Font = new Font("Segoe UI", 9F);
            gpFilter.ForeColor = Color.FromArgb(125, 137, 149);
            gpFilter.Location = new Point(0, 0);
            gpFilter.Name = "gpFilter";
            gpFilter.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gpFilter.Size = new Size(901, 80);
            gpFilter.TabIndex = 1;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.BorderRadius = 10;
            btnAddNew.Cursor = Cursors.Hand;
            btnAddNew.CustomizableEdges = customizableEdges1;
            btnAddNew.FillColor = Color.FromArgb(0, 123, 255);
            btnAddNew.Font = new Font("Segoe UI", 12F);
            btnAddNew.ForeColor = Color.White;
            btnAddNew.HoverState.FillColor = Color.FromArgb(0, 105, 217);
            btnAddNew.Location = new Point(652, 23);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddNew.Size = new Size(180, 40);
            btnAddNew.TabIndex = 0;
            btnAddNew.Text = "اضافة موظف جديد";
            btnAddNew.Click += btnAddNew_Click;
            // 
            // txtFilter
            // 
            txtFilter.BackColor = Color.Transparent;
            txtFilter.BorderRadius = 10;
            txtFilter.CustomizableEdges = customizableEdges3;
            txtFilter.DefaultText = "";
            txtFilter.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFilter.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFilter.FillColor = Color.WhiteSmoke;
            txtFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilter.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFilter.IconLeft = Properties.Resources.search;
            txtFilter.IconLeftCursor = Cursors.Hand;
            txtFilter.IconLeftSize = new Size(24, 24);
            txtFilter.Location = new Point(20, 20);
            txtFilter.Margin = new Padding(4);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderForeColor = Color.Gray;
            txtFilter.PlaceholderText = "الاسم او رقم الهاتف";
            txtFilter.SelectedText = "";
            txtFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtFilter.Size = new Size(294, 43);
            txtFilter.TabIndex = 0;
            // 
            // paginationInfo
            // 
            paginationInfo.BackColor = Color.White;
            paginationInfo.Controls.Add(btnPrev);
            paginationInfo.Controls.Add(lblPagInfo);
            paginationInfo.Controls.Add(btnNext);
            paginationInfo.Dock = DockStyle.Bottom;
            paginationInfo.Location = new Point(0, 545);
            paginationInfo.Name = "paginationInfo";
            paginationInfo.Padding = new Padding(5);
            paginationInfo.Size = new Size(901, 50);
            paginationInfo.TabIndex = 0;
            // 
            // btnPrev
            // 
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.Dock = DockStyle.Left;
            btnPrev.HoverState.ImageSize = new Size(24, 24);
            btnPrev.Image = Properties.Resources.arrow_back;
            btnPrev.ImageOffset = new Point(0, 0);
            btnPrev.ImageRotate = 0F;
            btnPrev.ImageSize = new Size(24, 24);
            btnPrev.Location = new Point(5, 5);
            btnPrev.Name = "btnPrev";
            btnPrev.PressedState.ImageSize = new Size(24, 24);
            btnPrev.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnPrev.Size = new Size(64, 40);
            btnPrev.TabIndex = 0;
            // 
            // lblPagInfo
            // 
            lblPagInfo.BackColor = Color.FromArgb(240, 240, 245);
            lblPagInfo.Dock = DockStyle.Fill;
            lblPagInfo.Font = new Font("Segoe UI", 14F);
            lblPagInfo.ForeColor = Color.FromArgb(50, 50, 50);
            lblPagInfo.Location = new Point(5, 5);
            lblPagInfo.Name = "lblPagInfo";
            lblPagInfo.Size = new Size(827, 40);
            lblPagInfo.TabIndex = 1;
            lblPagInfo.Text = "0 / 0";
            lblPagInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Cursor = Cursors.Hand;
            btnNext.Dock = DockStyle.Right;
            btnNext.HoverState.ImageSize = new Size(24, 24);
            btnNext.Image = Properties.Resources.arrow;
            btnNext.ImageOffset = new Point(0, 0);
            btnNext.ImageRotate = 0F;
            btnNext.ImageSize = new Size(24, 24);
            btnNext.Location = new Point(832, 5);
            btnNext.Name = "btnNext";
            btnNext.PressedState.ImageSize = new Size(24, 24);
            btnNext.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnNext.Size = new Size(64, 40);
            btnNext.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(picLoading);
            panel2.Controls.Add(dgvEmployees);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(901, 465);
            panel2.TabIndex = 4;
            // 
            // picLoading
            // 
            picLoading.BackColor = Color.White;
            picLoading.Image = Properties.Resources.Loading;
            picLoading.Location = new Point(404, 185);
            picLoading.Name = "picLoading";
            picLoading.Size = new Size(93, 68);
            picLoading.SizeMode = PictureBoxSizeMode.Zoom;
            picLoading.TabIndex = 2;
            picLoading.TabStop = false;
            // 
            // dgvCashBoxes
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToResizeColumns = false;
            dgvEmployees.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dgvEmployees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvEmployees.ColumnHeadersHeight = 40;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.GridColor = Color.LightGray;
            dgvEmployees.Location = new Point(0, 0);
            dgvEmployees.Name = "dgvCashBoxes";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dgvEmployees.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmployees.RowTemplate.Height = 40;
            dgvEmployees.Size = new Size(901, 465);
            dgvEmployees.TabIndex = 3;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvEmployees.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvEmployees.ThemeStyle.BackColor = Color.White;
            dgvEmployees.ThemeStyle.GridColor = Color.LightGray;
            dgvEmployees.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvEmployees.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmployees.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.5F);
            dgvEmployees.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvEmployees.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEmployees.ThemeStyle.HeaderStyle.Height = 40;
            dgvEmployees.ThemeStyle.ReadOnly = true;
            dgvEmployees.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvEmployees.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployees.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5F);
            dgvEmployees.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvEmployees.ThemeStyle.RowsStyle.Height = 40;
            dgvEmployees.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvEmployees.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            dgvEmployees.CellMouseEnter += dgvEmployees_CellMouseEnter;
            dgvEmployees.CellMouseLeave += dgvEmployees_CellMouseLeave;
            dgvEmployees.CellMouseMove += dgvEmployees_CellMouseMove;
            // 
            // EmployeesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(paginationInfo);
            Controls.Add(gpFilter);
            Name = "EmployeesPage";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(901, 595);
            Load += Employees_Load;
            gpFilter.ResumeLayout(false);
            paginationInfo.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLoading).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox gpFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Panel paginationInfo;
        private Panel panel2;
        private PictureBox picLoading;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmployees;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Guna.UI2.WinForms.Guna2ImageButton btnPrev;
        private Label lblPagInfo;
    }
}
