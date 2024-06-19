using Zoologico.TiposDeAnimais;

namespace Zoologico.Animais
{
	public class Iguana : Animal
	{
		public Repteis ConfiguraRepteis()
		{
			return new Repteis
			{
				Nome = "Iguana",
				TipoAnimal = TipoAnimalEnum.Repteis,
				CaracteristicaEspecífica = "Tem escamas",
				ColocamOvos = true
			};
		}
	}
}
