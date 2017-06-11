namespace LEARNING_CONCEPTS
{
	public class Father : object
	{
		public Father() : base()
		{
		}

		public int X;
		protected int Y;
		private int _z;

		public void SomeFunction1()
		{
			X = 10;
			Y = 20;
			_z = 30;
		}
	}
}
