using System;
namespace CodeKyJuly12
{
	public class MyCounter
	{
		private int _happy;

		private int _sad;
	
		public MyCounter()
		{
			_happy = 10;
			_sad = 0;
		}

		public void happyCustomer()
        {
			this._happy++;
        }

		public void sadCustomer()
        {
			this._sad++;
        }

		public int allCustomers()
        {
			return _happy + _sad;
        }

		public void saveToFile()
        {
			// TODO: save this to file
        }
	}
}

