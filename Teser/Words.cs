using System;
using System.Diagnostics;
using System.Drawing;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Linq;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Teser
{
    public class Words
    {
        public void CreateWord()
        {
            #region DocX doc

            string docName = "KDnumber";
            string fileName = $@"C:\Users\zayce\Desktop\Teser\Documents\{docName}.docx";
            var doc = DocX.Create(fileName);

            #region Create Table

            doc.InsertParagraph();
            Table table = doc.AddTable(14, 2);
            table.Alignment = Alignment.left;
            table.Design = TableDesign.TableGrid;

            table.Rows[0].Cells[0].Paragraphs.First().Append("№ п/п");
            table.Rows[0].Cells[1].Paragraphs.First().Append("-_-");
            
            table.Rows[1].Cells[0].Paragraphs.First().Append("Объект");
            table.Rows[2].Cells[0].Paragraphs.First().Append("Кадастровый номер");
            table.Rows[3].Cells[0].Paragraphs.First().Append("Действующая КС, руб.");
            table.Rows[4].Cells[0].Paragraphs.First().Append("Дата определения КС");
            table.Rows[5].Cells[0].Paragraphs.First().Append("Ставка налога/аренды %");
            table.Rows[6].Cells[0].Paragraphs.First().Append("Налог на имущество, руб. в год");
            table.Rows[7].Cells[0].Paragraphs.First().Append("Возможное снижение КС, руб.");
            table.Rows[8].Cells[0].Paragraphs.First().Append("Налог на имущество при снижении КС, руб в год");
            table.Rows[9].Cells[0].Paragraphs.First().Append("Экономия, руб. в год");
            table.Rows[10].Cells[0].Paragraphs.First().Append(
                "Экономия ретроспектива, руб. в год(до 3 лет от даты определения КС до 01.01 текущего года)");
            table.Rows[11].Cells[0].Paragraphs.First()
                .Append("Экономия перспектива, руб. (за 3 года от 01.01 текущего года)");
            table.Rows[12].Cells[0].Paragraphs.First()
                .Append("Экономия перспектива, руб. (за 5 лет от 01.01 текущего года)");
            table.Rows[13].Cells[0].Paragraphs.First().Append("Примечания");


            var abc = "";
            for (int i = 1; i < table.RowCount; i++)
            {
                abc += "1";
                var url = doc.AddHyperlink(abc, new Uri("https://www.youtube.com/"));
                url.Text = abc;
                table.Rows[i].Cells[1].Paragraphs.First().AppendHyperlink(url).Bold().Color(Color.Aqua);
            }

            doc.InsertTable(table);
            doc.Save();
            Process.Start("WINWORD.EXE", fileName);

            #endregion

            #endregion
        }
    }
}