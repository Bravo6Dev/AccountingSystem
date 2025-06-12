using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSystem.Controls
{
    public partial class TopBar : UserControl
    {
        public TopBar()
        {
            InitializeComponent();

            // حدث الزر للخروج
            btnClose.Click += (s, e) =>
            {
                // إغلاق الفورم الأب (اللي بيحتوي على اليوزر كونترول)
                this.FindForm()?.Close();
            };

            // لجعل الـ UserControl يقدر يسحب الفورم (Drag)
            this.MouseDown += CustomTitleBar_MouseDown;
            lblTitle.MouseDown += CustomTitleBar_MouseDown; // كمان اللابل
        }

        // خاصية لتغيير نص العنوان من الفورم
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        // كود للسحب (نقل) الفورم عن طريق البار
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void CustomTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.FindForm()!.Handle, 0xA1, 0x2, 0);
        }
    }
}
