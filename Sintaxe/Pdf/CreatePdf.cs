using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Sintaxe.Pdf;

public class CreatePdf
{
    
    public void createPdf()
    {

        try
        {
            string
                pdfPath ="x.pdf"; // Definindo o nome do arquivo como "MeuArquivo.pdf" na área de trabalho

            // Inicializando o PdfWriter com o caminho do arquivo de saída
            PdfWriter pdfWriter = new PdfWriter(pdfPath);

            // Criando um novo documento PDF
            PdfDocument pdfDocument = new PdfDocument(pdfWriter);

            // Criando um objeto Document, que permite adicionar conteúdo
            Document document = new Document(pdfDocument);
            //AddNewPage: Esse método adiciona uma nova página em branco ao documento PDF.
            PdfPage newPage = pdfDocument.AddNewPage();
     

            // Fechando o documento após a adição de conteúdo
            document.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message); 
        }
    }
}