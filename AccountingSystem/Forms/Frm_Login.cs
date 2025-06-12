using AccountingSystem.Properties;
using Applications.Util;
using Domain.DTOs;
using Domain.DTOs.Employees;
using Domain.Enums;
using Domain.Interfaces.Services;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
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
    public partial class Frm_Login : Form
    {
        private readonly IServiceManager serviceManager;

        private async Task LoadUsersAsync()
        {
            Result<IEnumerable<EmployeeDto>> result = await serviceManager.EmployeeService.GetEmployees();
            if (result.Status == ResultStatus.Success)
            {
                cmbUsers.DataSource = result.Data;
                cmbUsers.DisplayMember = "Username";
                cmbUsers.ValueMember = "Username";
            }
            else
            {
                lblError.Text = result.Error;
                lblError.Visible = true;
            }
        }


        private async Task HanldeLogin(CancellationToken cancellationToken)
        {
            try
            {
                cancellationToken.ThrowIfCancellationRequested();

                LoginDto data = new LoginDto
                {
                    Password = txtPassword.Text,
                    Username = cmbUsers.SelectedValue?.ToString() ?? string.Empty,
                };

                Result result = await serviceManager.EmployeeService.Login(data, cancellationToken);
                if (result.Status == ResultStatus.Failed)
                {
                    lblError.Visible = true;
                    lblError.Text = result.Error;
                    return;
                }

                // For test
                lblError.Visible = true;
                lblError.Text = "Done";
            } catch
            {
                lblError.Visible = true;
                lblError.Text = Messages.ServerError;
            }
        }

        public Frm_Login(IServiceManager serviceManager)
        {
            InitializeComponent();
            this.serviceManager = serviceManager;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                await HanldeLogin(CancellationToken.None);
            }
            catch
            {
                lblError.Visible = true;
                lblError.Text = "تم إلغاء العملية";
            }
        }

        private async void Frm_Login_Load(object sender, EventArgs e)
        {
            await LoadUsersAsync();
        }
    }
}
