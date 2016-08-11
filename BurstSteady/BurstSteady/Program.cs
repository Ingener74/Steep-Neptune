using System;

namespace BurstSteady
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			var goldenCat = new GoldenCat ();

			var qstr = QString.fromStdString ("Test");

			goldenCat.test (qstr);
		}
	}
}
