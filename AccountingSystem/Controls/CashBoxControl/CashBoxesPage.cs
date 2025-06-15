using Applications.Util;
using Domain.DTOs;
using Domain.DTOs.Employees;
using Domain.Entities;
using Domain.Interfaces.Services;
using Guna.UI2.WinForms;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSystem.Controls
{
    public partial class CashBoxesPage : UserControl
    {
        private IServiceManager serviceManager;

        private int currentPage = 1;
        private bool hasNext = false;
        private bool hasPrev = false;
        private bool actionsSetupDone = false;

        private DataGridViewCell hoveredCell = null;

        public CashBoxesPage(IServiceManager serviceManager)
        {
            InitializeComponent();
            this.serviceManager = serviceManager;
        }

        public void SetupDataGridViewColumns()
        {
            if (actionsSetupDone) return;

            if (dgvCashBoxes.Columns.Contains("Id"))
                dgvCashBoxes.Columns["Id"].Visible = false;

            if (dgvCashBoxes.Columns.Contains("Status"))
                dgvCashBoxes.Columns["Status"].Visible = false;

            dgvCashBoxes.Columns["Name"].HeaderText = "اسم الخزنة";

            dgvCashBoxes.Columns["Balance"].HeaderText = "الرصيد";
            dgvCashBoxes.Columns["Balance"].DefaultCellStyle.Format = "C2";

            dgvCashBoxes.Columns["CreateDate"].HeaderText = "تاريخ الانشاء";
            dgvCashBoxes.Columns["CreateDate"].DefaultCellStyle.Format = "dd-MM-yyyy";


            DataGridViewImageColumn infoGrid = new DataGridViewImageColumn()
            {
                Name = "ShowInfo",
                HeaderText = "",
                Image = Properties.Resources.showCashBoxDetails,
                Width = Properties.Resources.showCashBoxDetails.Width + 8,
                ImageLayout = DataGridViewImageCellLayout.Normal
            };
            dgvCashBoxes.Columns.Add(infoGrid);

            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn()
            {
                Name = "Delete",
                HeaderText = "",
                Image = Properties.Resources.delete,
                Width = Properties.Resources.delete.Width + 8,
                ImageLayout = DataGridViewImageCellLayout.Normal
            };
            dgvCashBoxes.Columns.Add(deleteColumn);

            dgvCashBoxes.ClearSelection();

            actionsSetupDone = true;
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

        private async Task DeleteAsync(int id)
        {
            try
            {
                var confirmResult = MessageBox.Show("هل أنت متأكد أنك تريد حذف هذه الخزنة؟", "تأكيد الحذف",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult != DialogResult.Yes)
                    return;

                Result result = await serviceManager.CashBoxService.DeleteCashBoxAsync(id);

                if (result.Status == Domain.Enums.ResultStatus.Failed)
                {
                    MessageBox.Show(result.Error, "خطـأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("تم حذف الخزنة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadCashBoxesAsync();
            }
            catch (Exception ex)
            {
                FormHelper.ServerError(ex);
            }
        }

        private void UpdatePaginationButtons(bool hasPrev, bool hasNext)
        {
            btnPrev.Enabled = hasPrev;
            btnNext.Enabled = hasNext;

            ApplyButtonStyle(btnPrev, hasPrev);
            ApplyButtonStyle(btnNext, hasNext);
        }

        private async Task AddNewAsync()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewCashBoxName.Text)) return;

                Result result = await serviceManager.CashBoxService.AddNewCashBox(txtNewCashBoxName.Text);
                if (result.Status == Domain.Enums.ResultStatus.Failed)
                {
                    MessageBox.Show(result.Error, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                picLoading.Visible = true;
                picLoading.Image = Properties.Resources.Loading;

                await LoadCashBoxesAsync();
            }
            catch (Exception ex) 
            {
                FormHelper.ServerError(ex);
            }
        }

        private async Task LoadCashBoxesAsync()
        {
            try
            {
                var result = await serviceManager.CashBoxService.GetCashBoxesAsync(currentPage);
                if (result.Status == Domain.Enums.ResultStatus.Success)
                {

                    dgvCashBoxes.DataSource = result.Data?.Items.ToList();
                    lblPagInfo.Text = $"{result.Data?.PageNumber} / {result.Data?.TotalPages}";

                    hasNext = result.Data?.HasNext ?? false;
                    hasPrev = result.Data?.HasPrev ?? false;

                    UpdatePaginationButtons(hasPrev, hasNext);

                    SetupDataGridViewColumns();
                }
                else
                {
                    MessageBox.Show("فشل في تحميل الخزاين", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                FormHelper.ServerError(ex);
            }
            finally
            {
                picLoading.Visible = false;
                picLoading.Image = null;
            }
        }

        private async void CashBoxesPage_Load(object sender, EventArgs e)
        {
            if (serviceManager != null)
                await LoadCashBoxesAsync();
        }

        private void dgvCashBoxes_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgvCashBoxes.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                    dgvCashBoxes.Cursor = Cursors.Hand;
                else
                    dgvCashBoxes.Cursor = Cursors.Default;
            }
        }

        private void dgvCashBoxes_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (hoveredCell != null)
            {
                hoveredCell.Style.BackColor = dgvCashBoxes.DefaultCellStyle.BackColor;
                hoveredCell = null;
                dgvCashBoxes.Cursor = Cursors.Default;
            }
        }

        private async void dgvCashBoxes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var selectedRow = dgvCashBoxes.Rows[e.RowIndex];
            var cashBox = selectedRow.DataBoundItem as CashBox; 
            if (cashBox == null)
                return;

            var columnName = dgvCashBoxes.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "ShowInfo":
                    break;
                case "Delete":
                    await DeleteAsync(cashBox.Id);
                    break;
            }

            dgvCashBoxes.ClearSelection();
        }

        private void dgvCashBoxes_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var column = dgvCashBoxes.Columns[e.ColumnIndex];
                if (column.Name == "Edit" || column.Name == "Delete" || column.Name == "ShowInfo")
                {
                    hoveredCell = dgvCashBoxes.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    hoveredCell.Style.BackColor = ColorTranslator.FromHtml("#E2E8F0");
                    dgvCashBoxes.Cursor = Cursors.Hand;
                }
            }
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
            await AddNewAsync();
        }
    }
}
