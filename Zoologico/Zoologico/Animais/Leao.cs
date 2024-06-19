using Zoologico.TiposDeAnimais;

namespace Zoologico.Animais
{
	public class Leao : Mamiferos
	{
		public Mamiferos ConfiguraMamiferos()
		{
			return new Mamiferos
			{
				Nome = "Leao",
				TipoAnimal = TipoAnimalEnum.Mamiferos,
				CaracteristicaEspecífica = "Tem juba",
				ApresentamPelos = true
			};
		}
	}
}
