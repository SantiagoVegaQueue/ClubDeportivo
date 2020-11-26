using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CapaPresentacion
{
    public static class ImprimirPDF
    {
        public static void printTabla(ref DataGridView tabla)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(tabla.Columns.Count);
            pdfPTable.DefaultCell.Padding = 5;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 5, iTextSharp.text.Font.NORMAL);

            foreach (DataGridViewColumn column in tabla.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240,240,240);
                pdfPTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in tabla.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "filename";
            saveFileDialog.DefaultExt = ".pdf";

            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfPTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }

        }
    }
}
