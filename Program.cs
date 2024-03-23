/* Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 * C.S.T. em Análise e Desenvolvimento de Sistemas
 * Discipline de Algoritmo e Lógica de Programação II
 * Professor Clayton Ferraz de Andrade
 * 
 * Acadêmico Vinicius de Oliveira Pinheiro
 * Aula do dia 11-09-2023
 * - Introdução a Funções e Métodos
 */


// 1ª tentativa de utilização de método:
Console.WriteLine("Hi! Let me guess your full name based on the parts of your name you give me!");
void WhatsYourNameMethod()
{
    Console.WriteLine("What is your first name?");
    string name = Console.ReadLine()!;
    Console.WriteLine("What is your last name?");
    string surname = Console.ReadLine()!;
    Console.WriteLine($"Is your name {FullName(name, surname)}?");
    string answer = Console.ReadLine()!;
    YesOrNo(answer);
}
string FullName(string name, string surname)
{ return name + surname; }

bool YesOrNo(string x)
{ if(x == "yes") { Console.WriteLine("That's great!");  return true; } else { WhatsYourNameMethod();  return false; } }
