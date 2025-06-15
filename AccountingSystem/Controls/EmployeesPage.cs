using AccountingSystem.Forms.Employees;
using Domain.DTOs;
using Domain.DTOs.Employees;
using Domain.Interfaces.Services;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSystem.Controls
{
    public partial class EmployeesPage : UserControl
    {
        private readonly IServiceManager serviceManager;
        private int currentPage = 1;
        private bool hasNext = false;
        private bool hasPrev = false;
        private bool actionsSetupDone = false;

        private DataGridViewCell? hoveredCell = null;

        public EmployeesPage(IServiceManager serviceManager)
        {
            InitializeComponent();
            this.serviceManager = serviceManager;
        }

        public EmployeesPage()
        {
            InitializeComponent();
        }

        private async Task DeleteEmployeeAsync(int id)
        {
            try
            {
                var confirm = MessageBox.Show("هل أنت متأكد من حذف هذا الموظف؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                    return;

                var result = await serviceManager.EmployeeService.DeleteEmplyoee(id);

                if (result.Status == Domain.Enums.ResultStatus.Failed)
                {
                    MessageBox.Show(result.Error ?? "فشل في حذف الموظف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("تم حذف الموظف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadEmployeesAsync(); 
                }
            }
            catch (Exception ex)
            {
                FormHelper.ServerError(ex);
            }
        }

        private async void UpdateEmployee(EmployeeDto employee)
        {
            Frm_AddEditEmplyee frm = new Frm_AddEditEmplyee(serviceManager, employee);
            frm.ShowDialog();
            await LoadEmployeesAsync();
        }

        private void SetupDataGridViewColumns()
        {
            if (actionsSetupDone) return; 

            // إعداد رؤوس الأعمدة
            if (dgvEmployees.Columns.Contains("Id"))
                dgvEmployees.Columns["Id"].Visible = false;

            dgvEmployees.Columns["Username"].HeaderText = "اسم المستخدم";
            dgvEmployees.Columns["PhoneNumber"].HeaderText = "رقم الهاتف";
            dgvEmployees.Columns["Salary"].HeaderText = "المرتب";
            dgvEmployees.Columns["Salary"].DefaultCellStyle.Format = "C2";
            dgvEmployees.Columns["CreateDate"].HeaderText = "تاريخ الإنشاء";
            dgvEmployees.Columns["CreateDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvEmployees.Columns["Permission"].Visible = false;


            DataGridViewImageColumn infoGrid = new DataGridViewImageColumn()
            {
                Name = "ShowInfo",
                HeaderText = "",
                Image = Properties.Resources.personInfo,
                Width = Properties.Resources.personInfo.Width + 8,
                ImageLayout = DataGridViewImageCellLayout.Normal
            };
            dgvEmployees.Columns.Add(infoGrid);

            DataGridViewImageColumn editColumn = new DataGridViewImageColumn()
            {
                Name = "Edit",
                HeaderText = "",
                Image = Properties.Resources.edit,
                Width = Properties.Resources.edit.Width + 8,
                ImageLayout = DataGridViewImageCellLayout.Normal
            };
            dgvEmployees.Columns.Add(editColumn);

            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn()
            {
                Name = "Delete",
                HeaderText = "",
                Image = Properties.Resources.delete,
                Width = Properties.Resources.delete.Width + 8,
                ImageLayout = DataGridViewImageCellLayout.Normal
            };
            dgvEmployees.Columns.Add(deleteColumn);

            dgvEmployees.ClearSelection();

            actionsSetupDone = true;

        }

        private void UpdatePaginationButtons(bool hasPrev, bool hasNext)
        {
            btnPrev.Enabled = hasPrev;
            btnNext.Enabled = hasNext;

            ApplyButtonStyle(btnPrev, hasPrev);
            ApplyButtonStyle(btnNext, hasNext);
        }

        private void ApplyButtonStyle(Guna2ImageButton btn, bool enabled)
        {
            if (enabled)
            {
                btn.BackColor = ColorTranslator.FromHtml("#2563EB"); // أزرق
                btn.ForeColor = Color.White;
                btn.Cursor = Cursors.Hand;
            }
            else
            {
                btn.BackColor = ColorTranslator.FromHtml("#1E293B"); // داكن
                btn.ForeColor = ColorTranslator.FromHtml("#94A3B8"); // رمادي فاتح
                btn.Cursor = Cursors.Default;
            }
        }

        private async Task LoadEmployeesAsync()
        {
            try
            {
                var result = await serviceManager.EmployeeService.GetEmployees(currentPage);
                if (result.Status == Domain.Enums.ResultStatus.Success)
                {
                    picLoading.Visible = false;
                    picLoading.Image = null;

                    dgvEmployees.DataSource = result.Data?.Items.ToList();
                    lblPagInfo.Text = $"{result.Data?.PageNumber} / {result.Data?.TotalPages}";

                    hasNext = result.Data?.HasNext ?? false;
                    hasPrev = result.Data?.HasPrev ?? false;

                    UpdatePaginationButtons(hasPrev, hasNext);

                    SetupDataGridViewColumns();
                }
                else
                {
                    MessageBox.Show("فشل في تحميل الموظفين", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                FormHelper.ServerError(ex);
            }
        }

        private async void Employees_Load(object sender, EventArgs e)
        {
            if (serviceManager != null)
                await LoadEmployeesAsync();
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            using (Frm_AddEditEmplyee frm_AddEditEmplyee = new Frm_AddEditEmplyee(serviceManager))
            {
                frm_AddEditEmplyee.ShowDialog();
                picLoading.Visible = true;
                picLoading.Image = Properties.Resources.Loading;
                await LoadEmployeesAsync();
            }
        }

        private void dgvEmployees_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvEmployees.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                    dgvEmployees.Cursor = Cursors.Hand;
                else
                    dgvEmployees.Cursor = Cursors.Default;
            }
        }

        private void dgvEmployees_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (hoveredCell != null)
            {
                hoveredCell.Style.BackColor = dgvEmployees.DefaultCellStyle.BackColor;
                hoveredCell = null;
                dgvEmployees.Cursor = Cursors.Default;
            }
        }

        private async void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var selectedRow = dgvEmployees.Rows[e.RowIndex];
            var employeeDto = selectedRow.DataBoundItem as EmployeeDto; // type حسب الـ DTO اللي انت مستخدمه
            if (employeeDto == null)
                return;

            var columnName = dgvEmployees.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "ShowInfo":
                    break;

                case "Edit":
                    UpdateEmployee(employeeDto);
                    break;

                case "Delete":
                    await DeleteEmployeeAsync(employeeDto.Id);
                    break;
            }

            dgvEmployees.ClearSelection();
        }

        private void dgvEmployees_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var column = dgvEmployees.Columns[e.ColumnIndex];
                if (column.Name == "Edit" || column.Name == "Delete" || column.Name == "ShowInfo")
                {
                    hoveredCell = dgvEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    hoveredCell.Style.BackColor = ColorTranslator.FromHtml("#E2E8F0"); 
                    dgvEmployees.Cursor = Cursors.Hand;
                }
            }
        }

    }
}
