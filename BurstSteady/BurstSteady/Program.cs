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

			Console.WriteLine (qstr.size ());
			Console.WriteLine (qstr.isEmpty ());

			goldenCat.test (qstr);
		}
	}
}
