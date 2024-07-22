using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmLich : Form
    {
        public FrmLich()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Lấy ngày được chọn
            DateTime date = dateTimePicker1.Value;

            // Tạo DataTable để lưu dữ liệu
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Thứ 2", typeof(string));
            dataTable.Columns.Add("Thứ 3", typeof(string));
            dataTable.Columns.Add("Thứ 4", typeof(string));
            dataTable.Columns.Add("Thứ 5", typeof(string));
            dataTable.Columns.Add("Thứ 6", typeof(string));
            dataTable.Columns.Add("Thứ 7", typeof(string));
            dataTable.Columns.Add("Chủ Nhật", typeof(string));

            DayOfWeek dayOfWeek = date.DayOfWeek;
            DateTime currentDate = date.AddDays(0 - (int)dayOfWeek);


            DataRow row = dataTable.NewRow();

            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    row["Chủ nhật"] = currentDate.AddDays(7).ToString("dd/MM/yyyy");
                    row["Thứ 2"] = date.ToString("dd/MM/yyyy");
                    row["Thứ 3"] = currentDate.AddDays(2).ToString("dd/MM/yyyy");
                    row["Thứ 4"] = currentDate.AddDays(3).ToString("dd/MM/yyyy");
                    row["Thứ 5"] = currentDate.AddDays(4).ToString("dd/MM/yyyy");
                    row["Thứ 6"] = currentDate.AddDays(5).ToString("dd/MM/yyyy");
                    row["Thứ 7"] = currentDate.AddDays(6).ToString("dd/MM/yyyy");
                    break;
                case DayOfWeek.Tuesday:
                    row["Thứ 2"] = currentDate.AddDays(1).ToString("dd/MM/yyyy");
                    row["Thứ 3"] = date.ToString("dd/MM/yyyy");
                    row["Thứ 4"] = currentDate.AddDays(3).ToString("dd/MM/yyyy");
                    row["Thứ 5"] = currentDate.AddDays(4).ToString("dd/MM/yyyy");
                    row["Thứ 6"] = currentDate.AddDays(5).ToString("dd/MM/yyyy");
                    row["Thứ 7"] = currentDate.AddDays(6).ToString("dd/MM/yyyy");
                    row["Chủ Nhật"] = currentDate.AddDays(7).ToString("dd/MM/yyyy");
                    break;
                case DayOfWeek.Wednesday:
                    row["Thứ 2"] = currentDate.AddDays(1).ToString("dd/MM/yyyy");
                    row["Thứ 3"] = currentDate.AddDays(2).ToString("dd/MM/yyyy");
                    row["Thứ 4"] = date.ToString("dd/MM/yyyy");
                    row["Thứ 5"] = currentDate.AddDays(4).ToString("dd/MM/yyyy");
                    row["Thứ 6"] = currentDate.AddDays(5).ToString("dd/MM/yyyy");
                    row["Thứ 7"] = currentDate.AddDays(6).ToString("dd/MM/yyyy");
                    row["Chủ Nhật"] = currentDate.AddDays(7).ToString("dd/MM/yyyy");
                    break;
                case DayOfWeek.Thursday:
                    row["Thứ 2"] = currentDate.AddDays(1).ToString("dd/MM/yyyy");
                    row["Thứ 3"] = currentDate.AddDays(2).ToString("dd/MM/yyyy");
                    row["Thứ 4"] = currentDate.AddDays(3).ToString("dd/MM/yyyy");
                    row["Thứ 5"] = date.ToString("dd/MM/yyyy");
                    row["Thứ 6"] = currentDate.AddDays(5).ToString("dd/MM/yyyy");
                    row["Thứ 7"] = currentDate.AddDays(6).ToString("dd/MM/yyyy");
                    row["Chủ Nhật"] = currentDate.AddDays(7).ToString("dd/MM/yyyy");
                    break;
                case DayOfWeek.Friday:
                    row["Thứ 2"] = currentDate.AddDays(1).ToString("dd/MM/yyyy");
                    row["Thứ 3"] = currentDate.AddDays(2).ToString("dd/MM/yyyy");
                    row["Thứ 4"] = currentDate.AddDays(3).ToString("dd/MM/yyyy");
                    row["Thứ 5"] = currentDate.AddDays(4).ToString("dd/MM/yyyy");
                    row["Thứ 6"] = date.ToString("dd/MM/yyyy");
                    row["Thứ 7"] = currentDate.AddDays(6).ToString("dd/MM/yyyy");
                    row["Chủ Nhật"] = currentDate.AddDays(7).ToString("dd/MM/yyyy");
                    break;
                case DayOfWeek.Saturday:
                    row["Thứ 2"] = currentDate.AddDays(1).ToString("dd/MM/yyyy");
                    row["Thứ 3"] = currentDate.AddDays(2).ToString("dd/MM/yyyy");
                    row["Thứ 4"] = currentDate.AddDays(3).ToString("dd/MM/yyyy");
                    row["Thứ 5"] = currentDate.AddDays(4).ToString("dd/MM/yyyy");
                    row["Thứ 6"] = currentDate.AddDays(6).ToString("dd/MM/yyyy");
                    row["Thứ 7"] = date.ToString("dd/MM/yyyy");
                    row["Chủ Nhật"] = currentDate.AddDays(7).ToString("dd/MM/yyyy");
                    break;
                case DayOfWeek.Sunday:
                    row["Thứ 2"] = currentDate.AddDays(-6).ToString("dd/MM/yyyy");
                    row["Thứ 3"] = currentDate.AddDays(-5).ToString("dd/MM/yyyy");
                    row["Thứ 4"] = currentDate.AddDays(-4).ToString("dd/MM/yyyy");
                    row["Thứ 5"] = currentDate.AddDays(-3).ToString("dd/MM/yyyy");
                    row["Thứ 6"] = currentDate.AddDays(-2).ToString("dd/MM/yyyy");
                    row["Thứ 7"] = currentDate.AddDays(-1).ToString("dd/MM/yyyy");
                    row["Chủ Nhật"] = date.ToString("dd/MM/yyyy");
                    break;
            }

            dataTable.Rows.Add(row);

            // Gán DataTable vào DataGridView
            dataGridView1.DataSource = dataTable;
        }
    }
}
