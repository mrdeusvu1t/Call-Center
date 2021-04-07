using System;

namespace Call_Center
{
	class Program
	{
		public void DispatchCall(Employee[] emp)
		{
			foreach (object obj in emp)
			{
				if (obj is Respondent r)
				{
					Console.WriteLine($"Respondent: {r.Call()}");
					if (!r.Available)
						return;
				}

			}

			foreach (object obj in emp)
			{
				if (obj is Manager m)
				{
					Console.WriteLine($"Manager: {m.Call()}");
					if (!m.Available)
						return;
				}
			}

			foreach (object obj in emp)
			{
				if (obj is Director d)
				{
					Console.WriteLine($"Director: {d.Call()}");
					if (!d.Available)
						return;
				}
			}
		}

		static void Main(string[] args)
		{
			Employee[] employees = { new Director("director", "one"), new Respondent("respondent", "one", false), new Respondent("respondent", "two", false),
										new Manager("manager", "one")};

			Program p1 = new Program();



			p1.DispatchCall(employees);

			Console.ReadKey();
		}
	}
}
