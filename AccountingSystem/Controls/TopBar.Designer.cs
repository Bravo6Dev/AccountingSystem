namespace AccountingSystem.Controls
{
    partial class TopBar
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.CheckedState.ImageSize = new Size(32, 32);
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.HoverState.ImageSize = new Size(32, 32);
            btnClose.Image = Properties.Resources.close;
            btnClose.ImageOffset = new Point(0, 0);
            btnClose.ImageRotate = 0F;
            btnClose.ImageSize = new Size(32, 32);
            btnClose.Location = new Point(753, 0);
            btnClose.Name = "btnClose";
            btnClose.PressedState.ImageSize = new Size(64, 64);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnClose.Size = new Size(32, 45);
            btnClose.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Almarai", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 25);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title";
            // 
            // TopBar
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            Name = "TopBar";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(785, 45);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Label lblTitle;
    }
}
