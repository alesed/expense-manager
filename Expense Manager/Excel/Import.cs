using ClosedXML.Excel;
using DAL.Models;

namespace Expense_Manager.Excel
{
    internal static class Import
    {
        public static void FromXlsx()
        {
            var filePath = GetImportPath();
            if (filePath == string.Empty)
            {
                MessageBox.Show("Incorrect file!");
                return;
            }

            using (XLWorkbook workBook = new XLWorkbook(filePath))
            {
                var dataToImport = GetDataFromXlsx(workBook);
                // TODO:
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
                if (firstRow)
                {
                    firstRow = false;
                }
                else
                {
                    var isIncome = Convert.ToBoolean(row.Cell("A").Value);
                    var dateCreated = DateTime.Parse(row.Cell("B").Value.ToString());
                    var amount = Convert.ToDouble(row.Cell("C").Value);

                    result.Add(new Payment
                    {
                        IsIncome = isIncome,
                        DateCreated = dateCreated,
                        Amount = amount,
                        UserId = Globals.User.Id
                    });
                }
            }

            return result;
        }
    }
}
