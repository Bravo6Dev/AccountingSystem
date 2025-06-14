using Domain.Interfaces.Services;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSystem.Forms
{
    public partial class Frm_MainLayout : Form
    {
        private Guna2Button? _actioveButton = null;
        private Frm_Login login;
        private IServiceManager serviceManager;

        private void ActiveNavBarButton(Guna2Button button)
        {
            if (_actioveButton != null)
            {
                _actioveButton.FillColor = Color.FromArgb(226, 232, 240);
                _actioveButton.ForeColor = Color.FromArgb(100, 116, 139);

                _actioveButton.Image = (Image?)Properties.Resources.ResourceManager.GetObject(_actioveButton.Name);
            }

            button.FillColor = Color.FromArgb(15, 23, 42);
            button.ForeColor = Color.White;

            string onImageName = button.Name + "White";
            button.Image = (Image?)Properties.Resources.ResourceManager.GetObject(onImageName);

            _actioveButton = button;

        }

        private void setMainContent(UserControl control)
        {
            foreach (Control existingControl in MainContent.Controls)
            {
                existingControl.Dispose();
            }
            MainContent.Controls.Clear();

            // Add new control
            MainContent.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            control.BringToFront();
        }


        public Frm_MainLayout(Frm_Login login, IServiceManager serviceManager)
        {
            InitializeComponent();
            _actioveButton = home;
            this.login = login;
            this.serviceManager = serviceManager;
        }

        private void Frm_MainLayout_FormClosed(object? sender, FormClosedEventArgs e)
        {
            login.Close();
        }

        private void NavBarButton_Click(object sender, EventArgs e)
        {
            Guna2Button senderButton = (Guna2Button)sender;
            ActiveNavBarButton(senderButton);
            if (senderButton == employee)
                setMainContent(new Controls.EmployeesPage(serviceManager));
        }
    }
}
