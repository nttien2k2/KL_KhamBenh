using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace DAL
{
    public class Export_DAL
    {
        public void ExportDSNhanVien(System.Data.DataTable dataTable, string sheetName, string title)
        {
            Application oExcel = null;
            Workbooks oBooks = null;
            Workbook oBook = null;
            Sheets oSheets = null;
            Worksheet oSheet = null;

            try
            {
                oExcel = new Application();
                oExcel.Visible = true;
                oExcel.DisplayAlerts = false;
                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;
                oBook = (Workbook)oBooks.Add(Type.Missing);
                oSheets = oBook.Worksheets;
                oSheet = (Worksheet)oSheets.get_Item(1);
                oSheet.Name = sheetName;

                Range head = oSheet.get_Range("A1", "G1");
                head.MergeCells = true;
                head.Value2 = title;
                head.Font.Bold = true;
                head.Font.Name = "Times New Roman";
                head.Font.Size = 20;
                head.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                Range cl1 = oSheet.get_Range("A3", "A3");
                cl1.Value2 = "Mã nhân viên";
                cl1.ColumnWidth = 12;

                Range cl2 = oSheet.get_Range("B3", "B3");
                cl2.Value2 = "Họ tên";
                cl2.ColumnWidth = 25.0;

                Range cl3 = oSheet.get_Range("C3", "C3");
                cl3.Value2 = "Ngày sinh";
                cl3.ColumnWidth = 12.0;

                Range cl4 = oSheet.get_Range("D3", "D3");
                cl4.Value2 = "Giới tính";
                cl4.ColumnWidth = 10.5;

                Range cl5 = oSheet.get_Range("E3", "E3");
                cl5.Value2 = "Phòng ban";
                cl5.ColumnWidth = 20.5;

                Range cl6 = oSheet.get_Range("F3", "F3");
                cl6.Value2 = "Chức vụ";
                cl6.ColumnWidth = 18.5;

                Range cl7 = oSheet.get_Range("G3", "G3");
                cl7.Value2 = "Tình trạng";
                cl7.ColumnWidth = 13.5;

                Range rowHead = oSheet.get_Range("A3", "G3");
                rowHead.Font.Bold = true;
                rowHead.Borders.LineStyle = XlLineStyle.xlContinuous;
                rowHead.Interior.ColorIndex = 6;
                rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    DataRow dataRow = dataTable.Rows[row];
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        arr[row, col] = dataRow[col];
                    }
                }

                int rowStart = 4;
                int columnStart = 1;
                int rowEnd = rowStart + dataTable.Rows.Count - 1;
                int columnEnd = dataTable.Columns.Count;

                Range c1 = (Range)oSheet.Cells[rowStart, columnStart];
                Range c2 = (Range)oSheet.Cells[rowEnd, columnEnd];
                Range range = oSheet.get_Range(c1, c2);

                range.Value2 = arr;
                range.Borders.LineStyle = XlLineStyle.xlContinuous;
                oSheet.get_Range(c1, c2).HorizontalAlignment = XlHAlign.xlHAlignCenter;
            }
            catch (COMException comEx)
            {
                // Handle COM exceptions
                Console.WriteLine(comEx.Message);
            }
            finally
            {
                // Release COM objects to avoid memory leaks
                if (oSheet != null) Marshal.ReleaseComObject(oSheet);
                if (oSheets != null) Marshal.ReleaseComObject(oSheets);
                if (oBook != null) Marshal.ReleaseComObject(oBook);
                if (oBooks != null) Marshal.ReleaseComObject(oBooks);
                if (oExcel != null) Marshal.ReleaseComObject(oExcel);

                // Force garbage collector clean up
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

    }
    
}
