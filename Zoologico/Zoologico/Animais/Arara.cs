using Zoologico.TiposDeAnimais;

namespace Zoologico.Animais
{
	public class Arara : Aves
	{
		public Aves ConfiguraAves()
		{
			return new Aves
			{
				Nome = "Arara",
				TipoAnimal = TipoAnimalEnum.Aves,
				CaracteristicaEspecífica = "Tem asas",
			};
		}
	}
}
