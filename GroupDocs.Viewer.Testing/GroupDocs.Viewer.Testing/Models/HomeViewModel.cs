using GroupDocs.Viewer.Examples.CSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace GroupDocs.Viewer.Testing.Models
{
    public class HomeViewModel
    {
        public static void Main()
        {

            //ExStart:ApplyingLicense
            /**
             *  Applying product license
             *  Please uncomment the statement if you do have license.
             */
            //Utilities.ApplyLicense();
            //ExEnd:ApplyingLicense

            #region ViewerHtmlPresentation

            //Render a power point presentation in html form
            //  ViewGenerator.RenderDocumentAsHtml("C:/GroupDocs/SDD.docx");

            //Render a spreadsheet in html form
            //   ViewGenerator.RenderDocumentAsHtml(@"C:\\GroupDocs\\test.docx");

            //Render a MS word document by replacing its 1st page order with 2nd page 
            // ViewGenerator.RenderDocumentAsHtml(@"C:\\GroupDocs\\test.docx", 1, 2);

            //Render a word document in html form and also apply a text as watermark on each page

            //ViewGenerator.RenderDocumentAsHtml(@"C:\GroupDocs\test.docx", "Show me as watermark", Color.Purple);

            //Render a document located at a web location
            // ViewGenerator.RenderDocumentAsHtml(new Uri("http://www.example.com/sample.doc"));

            #endregion

            #region ViewerImagePresentation

            //Render a power point presentation in images form.
            ViewGenerator.RenderDocumentAsImages("C:/GroupDocs/SDD.docx");

            //Render a spreadsheet in images form.
            //ViewGenerator.RenderDocumentAsImages("spreadsheet.xlsx");

            //Render a MS word document by replacing its 1st page order with 2nd page. 
            // ViewGenerator.RenderDocumentAsImages("word.doc",1,2);

            //Render a word document in images form and also apply a text as watermark on each page.
            // ViewGenerator.RenderDocumentAsImages("word.doc", "Show me as watermark", Color.Purple);

            //Render a word document in images form and set the rotation angle to display the rotated page.
            // ViewGenerator.RenderDocumentAsImages("word.doc", 180);

            //Render a document located at a web location
            // ViewGenerator.RenderDocumentAsImages(new Uri("http://www.example.com/sample.doc"));

            #endregion

            #region GeneralRepresentation
            //Render the word document in the form of pdf markup
            //ViewGenerator.RenderDocumentAsPDF("word.doc");

            //Render the document as it is (Original form)
            // ViewGenerator.RenderDocumentAsOriginal(@"C:\\GroupDocs\\test.docx");
            #endregion

        }
    }
}