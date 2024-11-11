using System.Text;
using ClosedXML.Excel;

namespace Sintaxe.Excel;
using System;
using iText.Kernel.Pdf;

using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;


public class PdfParaExcel
{


    public void Conversor()
    {
        // Chamar o método PdfEx para obter o texto extraído do PDF
        string texto = PdfParaExcel.pdf();
        
        // Criar o arquivo Excel
        var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("Dados do PDF");
        
        worksheet.Cell(1, 1).Value = texto;
        
        // Salvar o arquivo Excel na área de trabalho
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = System.IO.Path.Combine(desktopPath, "Extraidos.xlsx");
        workbook.SaveAs(filePath);
    }
    
    
    
    public static string pdf()
    {
        
        string pdfPath = @"C:\Users\lucas\Desktop\Curriculo.pdf"; // Definindo o nome do arquivo como "MeuArquivo.pdf" na área de trabalho
        var extractedText = new StringBuilder();
        // Verifica se o diretório existe; caso contrário, cria o diretório
        string directoryPath = Path.GetDirectoryName(pdfPath);
        try
        {
            // Abrir o PDF com PdfReader
            PdfReader reader = new PdfReader(pdfPath);

            // Criar o objeto PdfDocument
            PdfDocument pdfDoc = new PdfDocument(reader);
            

            // Iterar por cada página do PDF
            for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
            {
                var strategy = new LocationTextExtractionStrategy();
                   
                //PdfTextExtractor é uma classe da biblioteca iText que serve para extrair o texto de documentos PDF
                //O método GetTextFromPage vai lá, "lê" o conteúdo da página do PDF e pega o texto 
                string pageContent = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy);

                // Adicionar conteúdo da página extraída
                extractedText.Append(pageContent);
            }

            // Fechar o documento
            pdfDoc.Close();


        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao ler o PDF: " + ex.Message);
        }
        return extractedText.ToString();

    }
    
    
    
    
    
    
}