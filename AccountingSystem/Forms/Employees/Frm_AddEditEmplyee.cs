using Applications.Services;
using Domain.DTOs.CashBoxes;
using Domain.DTOs.Employees;
using Domain.DTOs;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Applications.Util;

namespace AccountingSystem.Forms.Employees
{
    public partial class Frm_AddEditEmplyee : Form
    {
        private readonly IServiceManager serviceManager;

        private string MapPermission(string permission)
        {
            return permission switch
            {
                "SuperAdmin" => "مشرف عام",
                "Admin" => "مدير",
                "User" => "مستخدم",
                _ => "غير معروف"
            };
        }

        private async Task LoadPermissionAsync()
        {
            try
            {
                Result<IEnumerable<Permission>> result = await serviceManager.PermissionService.GetPermissions();

                result.Data?.ToList().ForEach(permission => { permission.Name = MapPermission(permission.Name); });

                if (result.Status == ResultStatus.Success)
                {
                    cmbPermission.DataSource = result.Data?.ToList();
                    cmbPermission.DisplayMember = "Name";
                    cmbPermission.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show($"فشل تحميل الصلاحيات: {result.Error}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل الصلاحيات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshFields()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtSalary.Text = string.Empty;
            cmbPermission.SelectedIndex = 0;
        }

        private async Task HandleAddNew()
        {
            try
            {
                NewEmployee employee = new NewEmployee
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    Salary = decimal.Parse(txtSalary.Text.Trim()),
                    PermissionId = Convert.ToInt32(cmbPermission.SelectedValue)
                };

                Result addNewResult = await serviceManager.EmployeeService.AddNewEmployee(employee, CancellationToken.None);
                if (addNewResult.Status == ResultStatus.Success)
                {
                    MessageBox.Show("تم إضافة الموظف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshFields();
                }
                else
                    MessageBox.Show(addNewResult.Error, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show(Messages.ServerError, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Frm_AddEditEmplyee(IServiceManager serviceManager)
        {
            InitializeComponent();
            this.serviceManager = serviceManager;
        }

        private async void Frm_AddEditEmplyee_Load(object sender, EventArgs e)
        {
            await LoadPermissionAsync();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await HandleAddNew();
        }
    }
}
