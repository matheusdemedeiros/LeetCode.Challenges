# 🚀 LeetCode Solutions em C#

Este projeto contém minhas soluções para desafios do LeetCode, implementadas em C#.
O objetivo é praticar algoritmos, estruturas de dados e boas práticas de código.

## 📚 Estrutura do Projeto

Abaixo estão sendo exemplificadas as principais estruturas de pastas do projeto:

LeetCode.ConsoleApp/
 ├── Challenges/
 │   ├── AddTwoNumbers/
 │   │   ├── Challenge.cs
 │   │   ├── BestSolution.cs
 │   │   ├── MySolution.cs
 │   │   └── ListNode.cs
 │   │
 │   ├── LongestSubstringWithoutRepeatingCharacters/
 │   │   ├── Challenge.cs
 │   │   ├── BestSolution.cs
 │   │   └── MySolution.cs
 │   │
 │   ├── MedianOfTwoSortedArrays/
 │   │   ├── Challenge.cs
 │   │   ├── BestSolution.cs
 │   │   ├── MySolution.cs
 │   │   └── MySolution2.cs
 │
 ├── Extensions/
 │   ├── TextExtensions.cs
 │
 └── Program.cs

 - Cada pasta dentro de Challenges/ corresponde a um problema do LeetCode.
 - Dentro de cada pasta:
    - Challenge.cs → Descrição ou entrada principal do desafio.
    - MySolution.cs → Minha primeira solução (mais direta).
    - MySolution2.cs (3,4...) → Alternativas/testes de abordagem.
    - BestSolution.cs → Implementação mais otimizada / solução ideal.
    - Classes auxiliares (ex: ListNode.cs).

## Lista de desafios resolvidos:

## 📂 Desafios Resolvidos

Abaixo estão os desafios já implementados no repositório, organizados por pasta:

### 🔢 Add Two Numbers
**Descrição:** Dado dois números representados como listas encadeadas, some-os e retorne o resultado também como lista encadeada.  
**Categoria:** Linked List / Math  
**Dificuldade:** Medium  
**Algoritmo recomendado:** Iteração sobre listas encadeadas  
**Complexidade:** O(n), onde n é o comprimento da lista maior  

### 🔠 Longest Substring Without Repeating Characters
**Descrição:** Encontre o comprimento da maior substring de uma string que não contém caracteres repetidos.  
**Categoria:** String / Sliding Window  
**Dificuldade:** Medium  
**Algoritmo recomendado:** Janela deslizante (Sliding Window)  
**Complexidade:** O(n), onde n é o tamanho da string  

### ⚖️ Median of Two Sorted Arrays
**Descrição:** Dadas duas arrays ordenadas, encontre a mediana combinada delas de forma eficiente.  
**Categoria:** Array / Binary Search  
**Dificuldade:** Hard  
**Algoritmo recomendado:** Binary Search sobre partições das arrays  
**Complexidade:** O(log(min(n, m))), onde n e m são os tamanhos das arrays  

## ▶️ Como Executar os Desafios

Cada desafio possui sua própria classe dentro do namespace `Challenges`. Para executar um desafio específico, siga os passos abaixo:

1. Abra o arquivo `Program.cs`.
2. Localize a linha onde o desafio é instanciado. Por exemplo:

```csharp
var challenge = new Challenges.MedianOfTwoSortedArrays.Challenge();
```
Substitua **MedianOfTwoSortedArrays** pelo nome do desafio que deseja executar.

Exemplo:

```csharp
// Para executar "Add Two Numbers"
var challenge = new Challenges.AddTwoNumbers.Challenge();
```

Compile e execute o projeto (dotnet run ou pelo Visual Studio).

O programa irá executar duas soluções:

**RunMy()**: Minha implementação personalizada e inicial
**RunBest()**: a melhor implementação conhecida.

O tempo de execução de cada solução será exibido no console:

```cmd
MySolution elapsed time: XX ms
BestSolution elapsed time: XX ms
```

**Dica**: Você também pode habilitar o benchmark oficial usando o BenchmarkRunner executando o projeto em modo **RELEASE** se quiser medir desempenho mais detalhado.
