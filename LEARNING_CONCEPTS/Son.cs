namespace LEARNING_CONCEPTS
{
	public class Son : Father
	{
		public Son() : base()
		{
		}

		public void SomeFunction2()
		{
			X = 10; // OK
			//y = 20; // Not Accessable
			Z = 30; // OK
		}
	}
}
