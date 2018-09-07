namespace LEARNING_CONCEPTS
{
	internal static class Program
	{
		static Program()
		{
		}

		internal static void Main(string[] args)
		{
			Father father = new Father();

			father.X = 10; // OK
			//father.y = 20; // Not Accessable
			//father.Z = 30; // Not Accessable

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
