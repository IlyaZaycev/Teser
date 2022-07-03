using System;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace Teser 
{
    public class Words
    {
        public void CreateWord()
        {
            var wordApplication = new Word.Application();
            Object template = Type.Missing;
            var newTemplate = Type.Missing;
            var documentType = Type.Missing;
            var visible = Type.Missing;
            wordApplication.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
            var doc = wordApplication.ActiveDocument;
            wordApplication.Visible = true;
            //var r = Type.Missing;
            //var par = doc.Content.Paragraphs.Add(ref r);
            var missing = Type.Missing;
            var rng = doc.Range(ref missing, ref missing);
            //создание таблицы
            rng.Tables.Add(doc.Paragraphs[doc.Paragraphs.Count].Range, 13, 2, ref missing, ref missing);
            var tbl = doc.Tables[doc.Tables.Count];
            //Отрисовка таблицы
            var borders = new Word.Border[6];
            borders[0] = tbl.Borders[Word.WdBorderType.wdBorderLeft];
            borders[1] = tbl.Borders[Word.WdBorderType.wdBorderRight];
            borders[2] = tbl.Borders[Word.WdBorderType.wdBorderTop];
            borders[3] = tbl.Borders[Word.WdBorderType.wdBorderBottom];
            borders[4] = tbl.Borders[Word.WdBorderType.wdBorderHorizontal];
            borders[5] = tbl.Borders[Word.WdBorderType.wdBorderVertical];
            foreach (Word.Border border in borders)
            {
                border.LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                border.Color = Word.WdColor.wdColorBlack;
            }

            tbl.Cell(1, 1).Range.Text = "№ п/п";
            tbl.Cell(1, 2).Range.Text = "Объект";
            tbl.Cell(2, 1).Range.Text = "Кадастровый номер";
            tbl.Cell(3, 1).Range.Text = "Действующая КС, руб.";
            tbl.Cell(4, 1).Range.Text = "Дата определения КС";
            tbl.Cell(5, 1).Range.Text = "Ставка налога/аренды %";
            tbl.Cell(6, 1).Range.Text = "Налог на имущество, руб. в год";
            tbl.Cell(7, 1).Range.Text = "Возможное снижение КС, руб.";
            tbl.Cell(8, 1).Range.Text = "Налог на имущество при снижении КС, руб в год";
            tbl.Cell(9, 1).Range.Text = "Экономия, руб. в год";
            tbl.Cell(10, 1).Range.Text =
                "Экономия ретроспектива, руб. в год(до 3 лет от даты определения КС до 01.01 текущего года)";
            tbl.Cell(11, 1).Range.Text = "Экономия перспектива, руб. (за 3 года от 01.01 текущего года)";
            tbl.Cell(12, 1).Range.Text = "Экономия перспектива, руб. (за 5 лет от 01.01 текущего года)";
            tbl.Cell(13, 1).Range.Text = "Примечания";

            var adress = "https://yandex.ru/search/?text=Add+hyperlink+to+tableusing+word+Interop+word+c%23&lr=44";
            Object qq = "123";
            rng.Hyperlinks.Add(qq, adress);


            qq = "1";
            for (int i = 1; i < 13; i++)
            {
                qq += "+1";
                tbl.Cell(i, 2).Range.Text = qq.ToString();
            }
        }
        
    }
}