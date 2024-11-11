namespace Sintaxe.Pdf;

using System;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;


public class ExLerPdf
{
        
        
    public void PdfEx ()
    { 
        string pdfPath = @"C:\Users\lucas\Desktop\Curriculo.pdf"; // Definindo o nome do arquivo como "MeuArquivo.pdf" na área de trabalho
        
        // Verifica se o diretório existe; caso contrário, cria o diretório
        string directoryPath = Path.GetDirectoryName(pdfPath);
        try
        {
            // Abrir o PDF com PdfReader
            PdfReader reader = new PdfReader(pdfPath);

            // Criar o objeto PdfDocument
            PdfDocument pdfDoc = new PdfDocument(reader);

            // Usar um StringBuilder para armazenar o texto extraído
            /*O StringBuilder é utilizado para manipular strings de forma eficiente,
             especialmente quando você precisa fazer muitas operações de concatenação
             ou alteração em grandes volumes de dados.*/
            var extractedText = new System.Text.StringBuilder();

            // Iterar por cada página do PDF
            for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
            {
                // Cria um texto de parser
                //LocationTextExtractionStrategy: Mantém a posição e o layout dos textos.
                //SimpleTextExtractionStrategy: Extrai texto simples sem manter a posição.
                //  TextRenderListener: Fornece controle total sobre como o texto é extraído.
                //ImageRenderListener: Focado na extração e manipulação de imagens.
                //CustomRenderListener: Permite a implementação de um listener completamente personalizado.
                //LineSegmentTextExtractionStrategy: Foca na extração de texto por linha.
                //PositionTextExtractionStrategy: Mantém a ordem e a posição do texto.
                //WordWrapperTextExtractionStrategy: Tenta corrigir quebras de palavras ou texto mal formatado.
                        
                //A classe LocationTextExtractionStrategy ajuda a manter a posição dessas palavras enquanto extrai o texto. Ou seja, ela tenta "preservar" a maneira como o texto está distribuído no PDF, 
                var strategy = new LocationTextExtractionStrategy();
                   
                //PdfTextExtractor é uma classe da biblioteca iText que serve para extrair o texto de documentos PDF
                //O método GetTextFromPage vai lá, "lê" o conteúdo da página do PDF e pega o texto 
                string pageContent = PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(page), strategy);

                // Adicionar conteúdo da página extraída
                extractedText.Append(pageContent);
            }

            // Fechar o documento
            pdfDoc.Close();

            // Exibir o texto extraído
            Console.WriteLine("Texto extraído:");
            Console.WriteLine(extractedText.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao ler o PDF: " + ex.Message);
        }
    }
}