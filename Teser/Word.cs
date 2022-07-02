using System;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using Emgu.CV.Structure;

namespace Teser
{
    public class Word
    {
        //сделал с помощью Microsoft.Office.Interop.Word
        //документ создается, но нужно попробовать сделать ссылки хотя бы на существующий текст
        //делал так же в другом проекте
        //вот сайты: https://docs.microsoft.com/ru-RU/previous-versions/office/troubleshoot/office-developer/automate-word-create-file-using-visual-c
        //http://www.ludovicperrichon.com/create-a-word-document-with-openxml-and-c/#createword
        //опять же, если найдешь что-то лучше или узнаешь как все сделать скинь сюда я подредачу, главный акцент сейчас на ссылках

        /*
        Word.Application wordApplication = new Word.Application(); 
        Object template = Type.Missing;
        Object newTemplate = Type.Missing;
        Object documentType = Type.Missing;
        Object visible = Type.Missing;
        wordApplication.Documents.Add(ref template, ref newTemplate, ref documentType, ref
            visible); 
        Word.Document doc = wordApplication.ActiveDocument;
        wordApplication.Visible = true; 
        Object r = Type.Missing;
        Word.Paragraph par = doc.Content.Paragraphs.Add(ref r); 
        Object missing = Type.Missing;
        Word.Range rng = doc.Range(ref missing, ref missing); 
        rng.Tables.Add(doc.Paragraphs[doc.Paragraphs.Count].Range, 13, 2, ref missing, ref
            missing); 
        Word.Table tbl = doc.Tables[doc.Tables.Count]; 

        string adress = @"https://www.codewars.com/kata/526571aae218b8ee490006f4/train/csharp";

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

        string abc = "1";
            for (int i = 1; i< 13; i++)
        {
            abc += "+1";
            tbl.Cell(i, 2).Range.Text = abc;
        }
        Word.Border[] borders = new Word.Border[6]; 
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
        */
    }
}