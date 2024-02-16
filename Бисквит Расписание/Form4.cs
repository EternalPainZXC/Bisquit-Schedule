using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
using System;
using System.Collections.Generic;
using System.Linq;
//susing System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.IO;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.ExtendedProperties;
using System.Diagnostics;
using DocumentFormat.OpenXml.Packaging;










namespace Бисквит_Расписание
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void ConvertDocToDocx(string fileName)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(this);
            textBox1.Text = openFileDialog.FileName;


            // ConvertDocToDocx(openFileDialog.FileName);



        }






















        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void ConvertDocToDocx(string path)
            {
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

                if (path.ToLower().EndsWith(".doc"))
                {
                    var sourceFile = new FileInfo(path);
                    var document = word.Documents.Open(sourceFile.FullName);

                    string newFileName = sourceFile.FullName.Replace(".doc", ".docx");
                    document.SaveAs2(newFileName, WdSaveFormat.wdFormatXMLDocument,
                                     CompatibilityMode: WdCompatibilityMode.wdWord2010);

                    word.ActiveDocument.Close();
                    word.Quit();

                    //File.Delete(path);
                }
            }


            ConvertDocToDocx(textBox1.Text);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Object filename = openFileDialog1.FileName;

            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();

            object nullobj = System.Reflection.Missing.Value;
            doc = word.Documents.Open2000(ref filename, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj, ref nullobj);
            word.Visible = false;
            Microsoft.Office.Interop.Word.Range wordrange = doc.Range(ref nullobj, ref nullobj);
            File.WriteAllText(@"D:\text_of_Word.txt", wordrange.Text);

            //Process[] List;
            //List = Process.GetProcessesByName("WINWORD");
            //foreach (Process proc in List)
            // {
            //    proc.Kill();
            //}

            word = null;


            WordprocessingDocument wordDoc = WordprocessingDocument.Open(@"D:\Документ Microsoft Office Word.docx", true);
            MainDocumentPart body = wordDoc.MainDocumentPart;

            var qwe = body.WordCommentsExtensiblePart;
            //DocumentFormat.OpenXml.OpenXmlElementList ChildElements = new wordDoc.ChildElements;


            // var qwe = body.ChildElements;
            // 
            // foreach (var child_element in qwe)
            // {
            //     var asdf = child_element.InnerText;
            //     File.AppendAllText(@"D:\text_of_Word_2.txt", '\n' + asdf);
            // }

            // var qwe = wordDoc.MainDocumentPart.Document.Body.;

            //MainDocumentPart body1 = wordDoc.MainDocumentPart.Document.Body;
            //MainDocumentPart.Document.Body.RemoveAllChildren(body);





            //foreach (var child_element in qwe)
            //{
            //     var asdf = child_element.InnerText;
            //    File.AppendAllText(@"D:\text_of_Word_2.txt", " ");
            /// }
            /// File.AppendAllText(@"D:\text_of_Word_2.txt", '\n' +asdf);
            /// 
            File.AppendAllText(@"D:\text_of_Word_2.txt", " ");
        }
    }
}
