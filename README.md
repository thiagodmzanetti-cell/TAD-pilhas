# TAD-pilhas

Aluno: Thiago Debrotoli Moreira Zanetti || matricula: 923972

Código em `src/` (Pilha.cs, Algoritmos.cs, Program.cs). Pra rodar: `dotnet run`

## Parte 2 - Rastreio (Pilha(4))

| Operação | Retorno | Pilha (base → topo) | topo |
|---|---|---|---|
| empilha(10) | – | [10] | 1 |
| empilha(20) | – | [10, 20] | 2 |
| desempilha() | 20 | [10] | 1 |
| empilha(30) | – | [10, 30] | 2 |
| empilha(40) | – | [10, 30, 40] | 3 |
| desempilha() | 40 | [10, 30] | 2 |
| desempilha() | 30 | [10] | 1 |
| empilha(50) | – | [10, 50] | 2 |

**Pare e pense:** `item[2]` guarda 40, mas não faz mais parte da pilha, porque com topo = 2 só as posições 0 e 1 valem. O desempilha só diminui o topo, e a posição é sobrescrita no próximo empilha. Por isso não precisa apagar nada.

## Parte 4.1 - Rastreio de {5, 2, 9, 1, 7}

| Passada | carry final | B (base → topo) | R (base → topo) |
|---|---|---|---|
| 1 | 9 | [1, 7, 2, 5] | [9] |
| 2 | 7 | [2, 5, 1] | [9, 7] |
| 3 | 5 | [1, 2] | [9, 7, 5] |
| 4 | 2 | [1] | [9, 7, 5, 2] |
| 5 | 1 | [] | [9, 7, 5, 2, 1] |

## Parte 4.3 - Questões

**(a)** 10 comparações para n = 5. Fórmula: n(n-1)/2, igual ao Bubble Sort clássico sem otimização.

**(b)** O Bubble Sort com vetor usa memória extra O(1). Com pilhas usamos 3 pilhas de tamanho n (A, B e R), ou seja, cerca de 3n posições extras, O(n).

**(c)** Perdemos o acesso direto por índice (v[j], v[j+1]). O código compensa com a variável `carry`, que carrega a "bolha", e passando os elementos de uma pilha pra outra, trocando os papéis de A e B a cada passada.

**(d)** Não vale a pena como método geral: é O(n²) em tempo, gasta mais memória e existem algoritmos melhores. Só faz sentido se os dados só puderem ser acessados em ordem LIFO, ou como exercício didático.