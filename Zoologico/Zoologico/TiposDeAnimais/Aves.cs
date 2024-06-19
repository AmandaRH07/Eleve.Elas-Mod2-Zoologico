using Zoologico.Interfaces;

namespace Zoologico.TiposDeAnimais
{
    public class Aves : Animal, IVoar
    {
		public string LevantarVoo()
		{
			return "Levantar voo";
		}

		public string Pousar()
		{
			return "Pousar";
		}
    }
}
