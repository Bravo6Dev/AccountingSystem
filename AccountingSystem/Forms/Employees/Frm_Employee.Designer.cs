namespace AccountingSystem.Forms.Employees
{
    partial class Frm_Employee
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
            topBar1 = new Controls.TopBar();
            SuspendLayout();
            // 
            // topBar1
            // 
            topBar1.Dock = DockStyle.Top;
            topBar1.Location = new Point(0, 0);
            topBar1.Name = "topBar1";
            topBar1.RightToLeft = RightToLeft.Yes;
            topBar1.Size = new Size(800, 45);
            topBar1.TabIndex = 0;
            topBar1.Title = "الموظفين";
            // 
            // Frm_Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(topBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Employee";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Employee";
            ResumeLayout(false);
        }

        #endregion

        private Controls.TopBar topBar1;
    }
}