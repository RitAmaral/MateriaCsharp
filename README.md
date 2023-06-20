# Aulas e Exercícios em C#

- [Console App1](ConsoleApp1) - declaração de variáveis, Console.ReadLine e Console.WriteLine, if/else, while, for, do/while, array
- [Console App2](ConsoleApp2) - classes, propriedades/atributos, construtores, métodos
- [Console App3](ConsoleApp3) - outro exercício sobre classes, propriedades/atributos, construtores, métodos
- [Console App4](ConsoleApp4) - struct, vetores/array, foreach
- [Console App5](ConsoleApp5) - Listas, switch, funções DateTime
- [Aula C# - Listas](AulaC-Listas) - Listas
- [Console App6](ConsoleApp6) - Entidades, Enum, StringBuilder - classe que permite imprimir maiores quantidades de texto (appendLine)
- [Console App7](ConsoleApp7) - Entidades, Listas, StringBuilder
- [Forms1](Forms1) - Introdução forms (pouca informação), maior detalhe e comentários no [Win Forms App1](WinFormsApp1).
- [Triângulos - exercício](Triangulos) - Mais exercícios que envolvem tudo o que foi dado até agora
- [Herança](Heranca) - Herança, Upcasting, Downcasting, Sobreposição ou sobrescrita, Polimorfismo, Classes e métodos Abstratos
- [Interfaces](Interfaces) - Serviços -> Interfaces, funções Subtract e Math.Ceiling
- [Exception / Exceções](Exception) - Exceções, exceções personalizadas, try/catch
- [Win Forms App1](WinFormsApp1) - Forms

---

## Notas:

### Classes Estáticas / Static Classes

A classe **Console** é um exemplo de classe estática (static). Usamos o seu método estático *WriteLine()* para enviar para a tela ou o método estático *ReadLine()* para obter a entrada do utilizador. A classe **Convert**, usada para converter tipos de valor (ConvertToInt32), também é uma classe estática.

Classe **Math** contém vários métodos que nos permite fazer várias operações:
- `Math.Max(3, 7);` -> output é 7, vai buscar o número maior
- `Math.Min(3, 7);` -> output é 3, vai buscar o número mais pequeno
- `Math.Sqrt(64);` -> output é 8, raíz quadrada
- `Math.Abs(-2.1);` -> output é 2.1, número absoluto
- `Math.Round(9.99);` -> output é 10, aproximação
- `Math.Pow(2, 3)` -> output é 8, potenciação 2^3
- `Math.PI` -> output é 3,14... constante Pi

Classe **Array** também inclui métodos estáticos para manipular vetores, exemplo:
- `int[] arr = {1, 2, 3, 4};`
- `Array.Reverse(arr);` -> arr = {4, 3, 2, 1}
- `Array.Sort(arr);` -> arr = {1, 2, 3, 4}


