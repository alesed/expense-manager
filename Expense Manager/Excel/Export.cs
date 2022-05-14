using ClosedXML.Excel;
using DAL.Controllers;

namespace Expense_Manager.Excel
{
    internal static class Export
    {
        public static async Task ToXlsx()
        {
            var workbook = new XLWorkbook();
            workbook.AddWorksheet("Export");
            var ws = workbook.Worksheet("Export");
            SetExportHeader(ws);

            var payments = await PaymentController.GetAllPaymentsByUser(Globals.User.Id);

            int row = 2;
            foreach (var item in payments)
            {
                ws.Cell("A" + row.ToString()).Value = item.IsIncome;
                ws.Cell("B" + row.ToString()).Value = item.DateCreated.ToString();
                ws.Cell("C" + row.ToString()).Value = item.Amount;
                row++;
            }

            workbook.SaveAs($"Export_{DateTime.Today.ToString("yyyyMMddHHmmss")}.xlsx");
            MessageBox.Show("Export done successfully, check \"Export\" directory");
        }

        private static void SetExportHeader(IXLWorksheet worksheet)
        {
            worksheet.Cell("A1").Value = "Is income";
            worksheet.Cell("B1").Value = "Date created";
            worksheet.Cell("C1").Value = "Amount";
        }
    }
}
