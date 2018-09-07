namespace LEARNING_CONCEPTS
{
	public class Father : object
	{
		public Father() : base()
		{
		}

		public int X;
		private int y;
		protected int Z;

		public void SomeFunction1()
		{
			X = 10; // OK
			y = 20; // OK
			Z = 30; // OK
		}
	}
}
