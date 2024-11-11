using System.Text;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace Sintaxe.Pdf;


/*
 O PdfReader em si é uma classe focada na leitura de arquivos PDF.
 Ele permite abrir o PDF e acessar seu conteúdo, mas não faz
edições ou manipulações mais avançadas, como escrever ou modificar
 o arquivo.

A ideia é que o PdfReader seja a “porta de entrada” para extrair
 texto, imagens ou outras informações que estão dentro do PDF.
 Se você quer alterar, adicionar páginas ou fazer edições no PDF,
  precisará de outras classes ou métodos adicionais fornecidos
  pela mesma biblioteca, como o iText
  */

public class ExPdfReader
{

    public void PdfReaderEx()
    {
        // 1. Caminho para o arquivo PDF que você deseja ler
        string pdfPath = "C:\\Users\\lucas\\Documentos\\C#\\sintaxe\\Sintaxe\\Pdf\\teste.pdf";

        // 2. Cria um PdfReader com o caminho do arquivo PDF
        PdfReader reader = new PdfReader(pdfPath);
        
        
        //// Ignora restrições de segurança
        reader.SetUnethicalReading(true);  
      
        
        //fecha o reader
        reader.Close();
    }
}