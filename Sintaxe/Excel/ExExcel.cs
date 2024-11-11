using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Sintaxe.Pdf;

namespace Sintaxe.Excel;


/*closedXML é uma biblioteca C# usada para criar, modificar e ler
 arquivos do Excel (XLSX). Ele simplifica o trabalho com o Excel em C#, 
 fornecendo uma API de alto nível e fácil de usar. Aqui está uma análise 
 de como ele funciona e seus principais recursos.*/

public class ExExcel
{

 public void ExcelExemplos()
 {

    // Caminho para a área de trabalho do usuário
     string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
     string filePath = Path.Combine(desktopPath, "exemplo.xlsx");
     
     var workbook = new XLWorkbook(); // criar um arquivo, ou coloca o endereço que ele abre
     
     //criar uma planilha
     var worksheet = workbook.Worksheets.Add("nova planilha");
     
     
     
     //worksheet.Cell(string cellReference): Acessa uma célula específica, usando uma referência (ex: "A1").
     var cell = worksheet.Cell("A1");
     cell.Value = "Olá, mundo!";

     //worksheet.Cells(): Acessa todas as células da planilha.
      // var allCells = worksheet.Cells();

     //worksheet.Row(int rowNumber): Acessa uma linha específica. 
      var row = worksheet.Row(1);

      
      //worksheet.Column(int columnNumber): Acessa uma coluna específ
      var column = worksheet.Column(1); // Acessa a coluna A
      
      
      //worksheet.Clear(): Limpa todas as células da planilha.
      //worksheet.Clear();

      
      
      
      /*3. IXLCell
A classe IXLCell representa uma célula individual em uma planilha
. Você pode ler ou escrever valores e aplicar formatação.*/
      
       //cell.Value: Define ou obtém o valor de uma célula.

       worksheet.Cell("A1").Value = "lucas lopes costa";
       var value = worksheet.Cell("A1").Value;

      //cell.Style: Acessa o estilo da célula, permitindo modificar a formatação, como fonte, bordas e alinhamento.
      worksheet.Cell("A1").Style.Font.Bold = true;
      worksheet.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

      
      //cell.Formula: Define ou obtém a fórmula da célula.
      //worksheet.Cell("B1").FormulaA1 = "=SOMA(A1:A10)";

      
      //cell.Merged: Verifica se a célula está mesclada com outras células.
      //worksheet.Cell("A1").Merge();

  
      /*A classe IXLRange representa um conjunto de
       células (ou um intervalo) na planilha.*/
      
      //range.Merge(): Mescla todas as células no intervalo.
      worksheet.Range("A1:B2").Merge();

      
      //range.Cells(): Acessa todas as células dentro do intervalo.
      var cellsInRange = worksheet.Range("A1:B2").Cells();

      //O método AdjustToContents() é usado para ajustar automaticamente a largura das colunas ou a altura das linhas para que se ajustem ao conteúdo.
      worksheet.Column(1).AdjustToContents(); // Ajusta a largura da coluna A
      worksheet.Row(1).AdjustToContents();    // Ajusta a altura da linha 1

      
      
      
     //SaveAs(string filePath): Salva o arquivo Excel no caminho especificado.
     workbook.SaveAs(filePath);

     
 }


 public void escreverExcel()
 {
  
  
  
  // Caminho para a área de trabalho do usuário
  string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
  string filePath = Path.Combine(desktopPath, "Teste.xlsx");
     
  var workbook = new XLWorkbook(); // criar um arquivo, ou coloca o endereço que ele abre
     
  //criar uma planilha
  var worksheet = workbook.Worksheets.Add("Escrevendo");
  
  // Escrevendo um valor em uma célula específica (linha 2, coluna 3)
  worksheet.Cell(2, 3).Value = "Lucas";  // Linha 2, Coluna 3 (C2)
  
  
  //SaveAs(string filePath): Salva o arquivo Excel no caminho especificado.
  workbook.SaveAs(filePath);
 }
}