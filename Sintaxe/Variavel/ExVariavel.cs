namespace Sintaxe.Variavel;

/*
 
 Modificador	Funcionamento
 public	O acesso não é restrito.
 protected	O acesso é limitado às classes ou tipos derivados daclasse que a variável está.
 Internal	O acesso é limitado ao conjunto de módulos(assembly) corrente.
 protected internal	O acesso é limitado ao conjunto corrente ou tiposderivados da classe recipiente.
 
 */


public class ExVariavel
{
    
 public void variavel()
 {

  string nome = "lucas";
  int idade = 23;
  double altura = 1.70;
  char genero = 'M';
  bool estudante = true;
  
  Console.WriteLine($"meu nome e {nome}, {idade}, {altura}, {genero}, {estudante}");
  
  }
}