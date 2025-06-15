namespace AccountingSystem.Controls
{
    partial class CashBoxesPage
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            gpFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            paginationInfo = new Panel();
            btnPrev = new Guna.UI2.WinForms.Guna2ImageButton();
            lblPagInfo = new Label();
            btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            panel1 = new Panel();
            btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            txtNewCashBoxName = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            picLoading = new PictureBox();
            dgvCashBoxes = new Guna.UI2.WinForms.Guna2DataGridView();
            gpFilter.SuspendLayout();
            paginationInfo.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCashBoxes).BeginInit();
            SuspendLayout();
            // 
            // gpFilter
            // 
            gpFilter.BackColor = Color.White;
            gpFilter.BorderColor = Color.Transparent;
            gpFilter.Controls.Add(txtFilter);
            gpFilter.CustomBorderColor = Color.Transparent;
            gpFilter.CustomizableEdges = customizableEdges3;
            gpFilter.Dock = DockStyle.Top;
            gpFilter.Font = new Font("Segoe UI", 9F);
            gpFilter.ForeColor = Color.FromArgb(125, 137, 149);
            gpFilter.Location = new Point(0, 0);
            gpFilter.Name = "gpFilter";
            gpFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gpFilter.Size = new Size(901, 80);
            gpFilter.TabIndex = 6;
            // 
            // txtFilter
            // 
            txtFilter.BackColor = Color.Transparent;
            txtFilter.BorderRadius = 10;
            txtFilter.CustomizableEdges = customizableEdges1;
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
            txtFilter.Location = new Point(538, 17);
            txtFilter.Margin = new Padding(4);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderForeColor = Color.Gray;
            txtFilter.PlaceholderText = "اسم الخزينة";
            txtFilter.SelectedText = "";
            txtFilter.ShadowDecoration.CustomizableEdges = customizableEdges2;
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
            paginationInfo.Location = new Point(0, 684);
            paginationInfo.Name = "paginationInfo";
            paginationInfo.Padding = new Padding(5);
            paginationInfo.Size = new Size(901, 50);
            paginationInfo.TabIndex = 5;
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
            btnPrev.ShadowDecoration.CustomizableEdges = customizableEdges5;
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
            btnNext.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnNext.Size = new Size(64, 40);
            btnNext.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnAddNew);
            panel1.Controls.Add(txtNewCashBoxName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 83);
            panel1.TabIndex = 9;
            // 
            // btnAddNew
            // 
            btnAddNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNew.BorderRadius = 10;
            btnAddNew.Cursor = Cursors.Hand;
            btnAddNew.CustomizableEdges = customizableEdges7;
            btnAddNew.FillColor = Color.FromArgb(0, 123, 255);
            btnAddNew.Font = new Font("Segoe UI", 12F);
            btnAddNew.ForeColor = Color.White;
            btnAddNew.HoverState.FillColor = Color.FromArgb(0, 105, 217);
            btnAddNew.Location = new Point(652, 19);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddNew.Size = new Size(180, 40);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "اضافة خزينة جديدة";
            btnAddNew.Click += btnAddNew_Click;
            // 
            // txtNewCashBoxName
            // 
            txtNewCashBoxName.BackColor = Color.Transparent;
            txtNewCashBoxName.BorderRadius = 10;
            txtNewCashBoxName.CustomizableEdges = customizableEdges9;
            txtNewCashBoxName.DefaultText = "";
            txtNewCashBoxName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNewCashBoxName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNewCashBoxName.FillColor = Color.WhiteSmoke;
            txtNewCashBoxName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNewCashBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewCashBoxName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNewCashBoxName.IconLeftCursor = Cursors.Hand;
            txtNewCashBoxName.IconLeftSize = new Size(24, 24);
            txtNewCashBoxName.Location = new Point(20, 19);
            txtNewCashBoxName.Margin = new Padding(4);
            txtNewCashBoxName.Name = "txtNewCashBoxName";
            txtNewCashBoxName.PlaceholderForeColor = Color.Gray;
            txtNewCashBoxName.PlaceholderText = "اسم الخزينة";
            txtNewCashBoxName.SelectedText = "";
            txtNewCashBoxName.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtNewCashBoxName.Size = new Size(294, 43);
            txtNewCashBoxName.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(picLoading);
            panel2.Controls.Add(dgvCashBoxes);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(901, 521);
            panel2.TabIndex = 10;
            // 
            // picLoading
            // 
            picLoading.BackColor = Color.White;
            picLoading.Image = Properties.Resources.Loading;
            picLoading.Location = new Point(404, 198);
            picLoading.Name = "picLoading";
            picLoading.Size = new Size(93, 68);
            picLoading.SizeMode = PictureBoxSizeMode.Zoom;
            picLoading.TabIndex = 2;
            picLoading.TabStop = false;
            // 
            // dgvCashBoxes
            // 
            dgvCashBoxes.AllowUserToAddRows = false;
            dgvCashBoxes.AllowUserToDeleteRows = false;
            dgvCashBoxes.AllowUserToResizeColumns = false;
            dgvCashBoxes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dgvCashBoxes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCashBoxes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCashBoxes.ColumnHeadersHeight = 40;
            dgvCashBoxes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCashBoxes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCashBoxes.Dock = DockStyle.Fill;
            dgvCashBoxes.GridColor = Color.LightGray;
            dgvCashBoxes.Location = new Point(0, 0);
            dgvCashBoxes.Name = "dgvCashBoxes";
            dgvCashBoxes.ReadOnly = true;
            dgvCashBoxes.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dgvCashBoxes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCashBoxes.RowTemplate.Height = 40;
            dgvCashBoxes.Size = new Size(901, 521);
            dgvCashBoxes.TabIndex = 3;
            dgvCashBoxes.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCashBoxes.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCashBoxes.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCashBoxes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCashBoxes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCashBoxes.ThemeStyle.BackColor = Color.White;
            dgvCashBoxes.ThemeStyle.GridColor = Color.LightGray;
            dgvCashBoxes.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCashBoxes.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCashBoxes.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.5F);
            dgvCashBoxes.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCashBoxes.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCashBoxes.ThemeStyle.HeaderStyle.Height = 40;
            dgvCashBoxes.ThemeStyle.ReadOnly = true;
            dgvCashBoxes.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCashBoxes.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCashBoxes.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5F);
            dgvCashBoxes.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCashBoxes.ThemeStyle.RowsStyle.Height = 40;
            dgvCashBoxes.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCashBoxes.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvCashBoxes.CellClick += dgvCashBoxes_CellClick;
            dgvCashBoxes.CellMouseEnter += dgvCashBoxes_CellMouseEnter;
            dgvCashBoxes.CellMouseLeave += dgvCashBoxes_CellMouseLeave;
            dgvCashBoxes.CellMouseMove += dgvCashBoxes_CellMouseMove;
            // 
            // CashBoxesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(gpFilter);
            Controls.Add(paginationInfo);
            Name = "CashBoxesPage";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(901, 734);
            Load += CashBoxesPage_Load;
            gpFilter.ResumeLayout(false);
            paginationInfo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLoading).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCashBoxes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox gpFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Panel paginationInfo;
        private Guna.UI2.WinForms.Guna2ImageButton btnPrev;
        private Label lblPagInfo;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Panel panel1;
        private Panel panel2;
        private PictureBox picLoading;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCashBoxes;
        private Guna.UI2.WinForms.Guna2TextBox txtNewCashBoxName;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
    }
}
