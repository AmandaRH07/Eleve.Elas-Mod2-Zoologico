using Zoologico.TiposDeAnimais;

namespace Zoologico.Animais
{
	public class PeixePalhaco : Peixes
	{
		public Peixes ConfiguraPeixes()
		{
			return new Peixes
			{
				Nome = "Peixe palhaço",
				TipoAnimal = TipoAnimalEnum.Peixes,
				CaracteristicaEspecífica = "Vive em uma anêmona",
			};
		}
	}
}
