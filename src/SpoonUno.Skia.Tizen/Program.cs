using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace SpoonUno.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new SpoonUno.App(), args);
		host.Run();
	}
}
}
