// See https://aka.ms/new-console-template for more information
using Zoologico.Animais;

Console.WriteLine("Hello, World!");

var arara = new Arara().ConfiguraAves();
Console.WriteLine($"Animal: {arara.Nome}, Tipo: {arara.TipoAnimal}, Característica específica: {arara.CaracteristicaEspecífica}, Pode: {arara.LevantarVoo()} e {arara.Pousar()}");

var iguana = new Iguana().ConfiguraRepteis();
Console.WriteLine($"Animal: {iguana.Nome}, Tipo: '{iguana.TipoAnimal}', Característica específica: {iguana.CaracteristicaEspecífica}, Colocam ovos: {iguana.ColocamOvos}");

var leao = new Leao().ConfiguraMamiferos();
Console.WriteLine($"Animal: {leao.Nome}, Tipo: {leao.TipoAnimal}, Característica específica: {leao.CaracteristicaEspecífica}, Apresentam pelos: {leao.ApresentamPelos}");

var peixePalhaco = new PeixePalhaco().ConfiguraPeixes();
Console.WriteLine($"Animal: {peixePalhaco.Nome}, Tipo: {peixePalhaco.TipoAnimal}, Característica específica: {peixePalhaco.CaracteristicaEspecífica}, Pode: {peixePalhaco.Subir(1)} e {peixePalhaco.Descer(12)}");

var salamandra = new Salamandra();
salamandra.ConfiguraAnfibios();
Console.WriteLine($"Animal: {salamandra.Nome}, Tipo: {salamandra.TipoAnimal}, Característica específica: {salamandra.CaracteristicaEspecífica}, Pode nadar: {salamandra.PodemNadar}, Pode: {salamandra.Subir(0)} e {salamandra.Descer(1)}");

Console.ReadLine();
