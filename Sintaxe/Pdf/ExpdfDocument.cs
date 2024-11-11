using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
namespace Sintaxe.Pdf;

/*
A classe PdfDocument é uma das principais classes da biblioteca iText7
para manipulação de PDFs. Ela representa um documento PDF inteiro e
 oferece várias funcionalidades, desde a criação e manipulação de
páginas até o ajuste de metadados e o fechamento do documento.

Diferente do PdfReader, que é apenas para leitura, o PdfDocument
 permite criar, editar e salvar PDFs.
*/


public class ExpdfDocument
{
    public void PdfDocumentExemplo()
    {
       
        try{ 
            string pdfPath = @"C:\Users\lucas\Desktop\x.pdf"; // Definindo o nome do arquivo como "MeuArquivo.pdf" na área de trabalho

            // Verifica se o diretório existe; caso contrário, cria o diretório
            string directoryPath = Path.GetDirectoryName(pdfPath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            /*PdfWriter: O PdfWriter é uma classe que representa o mecanismo
             de escrita do PDF. Ele define onde e como o PDF será salvo, e é
             necessário para criar novos arquivos PDF.*/
            using(PdfWriter writer = new PdfWriter(pdfPath))
            {

                /*PdfDocument: Esta é a classe central para manipular o documento PDF.
                 É usada para adicionar e manipular páginas, definir metadados e
                 gerenciar o conteúdo do documento.*/
                using(PdfDocument pdfDoc = new PdfDocument(writer))
                {

                    /*Document: Essa classe, da biblioteca iText.Layout,
                   representa o layout do documento e permite adicionar
                   elementos visuais como parágrafos, imagens, tabelas, etc., ao PDF*/
                    Document document = new Document(pdfDoc);
            
            
            
                    /*GetDocumentInfo: Esse método permite acessar os metadados do
                     documento PDF, como título, autor, assunto e palavras-chave.
                      Isso ajuda a identificar e classificar o documento PDF.

                    SetTitle, SetAuthor, SetSubject, SetKeywords: Esses métodos são
                    usados para configurar os valores dos metadados do PDF.*/
                    pdfDoc.GetDocumentInfo()
                        .SetTitle("Título do PDF")
                        .SetAuthor("Autor do PDF")
                        .SetSubject("Assunto do PDF")
                        .SetKeywords("iText, PDF, metadados");

        
        
        
                    // Adicionando parágrafos
                    Paragraph textoSimples = new Paragraph("Texto simples no PDF!");
                    Paragraph textoEstilizado = new Paragraph("Texto em negrito e com estilo!");
           
                    // Adicionando os parágrafos ao documento
                    document.Add(textoSimples);
                    document.Add(textoEstilizado);
        
        
                    //AddNewPage: Esse método adiciona uma nova página em branco ao documento PDF.
                    PdfPage newPage = pdfDoc.AddNewPage();

        

                    // Add: O método Add permite adicionar conteúdo ao documento. Aqui, estamos adicionando um Paragraph (parágrafo) com um texto específico.
                    document.Add(new Paragraph("Este é um exemplo de PDF usando iText 7!"));

                    //GetNumberOfPages: Retorna o número total de páginas no documento PDF.
                    // int totalPages = pdfDoc.GetNumberOfPages();
                    // Console.WriteLine("Total de páginas no PDF: " + totalPages);
       
                    // Garante que todos os dados sejam escritos no arquivo
                    writer.Flush();
                    // Fechar o documento
                    document.Close();
                    Console.WriteLine("PDF gerado com sucesso!");
        
                }
        
            }
       

            Console.WriteLine("Documento PDF criado e fechado com sucesso.");
        }catch (Exception e)
        {
            Console.WriteLine(e.Message); 
        }
    
    }
}