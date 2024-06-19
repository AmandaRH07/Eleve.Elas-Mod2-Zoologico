using System.Linq.Expressions;
using Zoologico.Interfaces;
using Zoologico.TiposDeAnimais;

namespace Zoologico.Animais
{
	public class Salamandra : Anfibios, INadar
	{
		public void ConfiguraAnfibios()
		{

			Nome = "Salamandra";
			TipoAnimal = TipoAnimalEnum.Anfibios;
			CaracteristicaEspecífica = "Não tem escamas";
			PodemNadar = true;
		}

		public string Descer(int metros)
		{
			return $"Descer {metros} mts";
		}

		public string Subir(int metros)
		{
			return $"Subir {metros} mts";
		}
	}
}
