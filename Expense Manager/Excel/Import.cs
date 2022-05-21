using ClosedXML.Excel;
using DAL.Controllers;
using DAL.Models;

namespace Expense_Manager.Excel
{
    internal static class Import
    {
        public static async Task FromXlsx()
        {
            var filePath = GetImportPath();
            if (filePath == string.Empty)
            {
                MessageBox.Show("Incorrect file!");
                return;
            }

            using (XLWorkbook workBook = new XLWorkbook(filePath))
            {
                try
                {
                    var dataToImport = GetDataFromXlsx(workBook);
                    await InsertPaymentsToDatabase(dataToImport);
                    MessageBox.Show("Data imported!\nPlease, restart your page...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private static async Task InsertPaymentsToDatabase(List<Payment> data)
        {
            foreach (Payment payment in data)
            {
                await PaymentController.InsertPaymentByUser(payment);
            }
        }

        private static string GetImportPath()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            return filePath;
        }

        private static List<Payment> GetDataFromXlsx(XLWorkbook workBook)
        {
            var result = new List<Payment>();
            IXLWorksheet workSheet = workBook.Worksheet(1);

            bool firstRow = true;
            foreach (IXLRow row in workSheet.Rows())
            {
                bool isIncome;
                DateTime dateCreated;
                double amount;

                if (firstRow)
                {
                    firstRow = false;
                }
                else
                {
                    
                    try
                    {
                        isIncome = Convert.ToBoolean(row.Cell("A").Value);
                        dateCreated = DateTime.Parse(row.Cell("B").Value.ToString());
                        amount = Convert.ToDouble(row.Cell("C").Value);

                        result.Add(new Payment
                        {
                            IsIncome = isIncome,
                            DateCreated = dateCreated,
                            Amount = amount,
                            UserId = Globals.User.Id
                        });
                    } catch
                    {
                        throw new Exception($"Row {row.RowNumber()} has incorrect values!");
                    }
                }
            }

            return result;
        }
    }
}
