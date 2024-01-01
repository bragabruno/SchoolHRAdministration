using System;

namespace HRAdministrationAPI
{
	public class FactoryPattern<K, T> where T:class,K,new()
	{
		public static K GetInstance()
		{
			K objK;
			objK = new T();
			return objK;
		}
	}
}

