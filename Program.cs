Console.Clear();

string especie, raca, alcunha, cor;
int idade;

Console.Write("Digite a espécie do seu cão: ");
especie = Console.ReadLine();

Console.Write("Digite a raça do seu cão: ");
raca = Console.ReadLine();

Console.Write("Digite a alcunha do seu cão: ");
alcunha = Console.ReadLine();

Console.Write("Digite a idade do seu cão: ");
idade = int.Parse(Console.ReadLine());

Console.Write("Digite a cor do seu cão: ");
cor = Console.ReadLine();

Console.WriteLine("");

Console.WriteLine("+=========================================================+\n|                 Pet Hotel Nem um pio                  |\n+=========================================================+\n| Espécie: ............{0} | Raça: ............{1} |\n+=========================================================+\n| Atende pela alcunha de: ...........................{2} |\n| Idade: {3} ano(s) | Pelagem/cor: ...............{4} |\n+=========================================================+", especie, raca, alcunha, idade, cor);