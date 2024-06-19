using Zoologico.Interfaces;

namespace Zoologico.TiposDeAnimais
{
	public class Peixes : Animal, INadar
	{
		public string Descer(int metros)
		{
			return $"Descer {metros} mts";
		}

		public string Subir( int metros)
		{
			return $"Subir {metros} mts";
		}
	}
}
