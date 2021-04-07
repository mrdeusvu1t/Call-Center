using System;
using System.Collections.Generic;
using System.Text;

namespace Call_Center
{
	class Manager : Employee
	{
		public Manager(string fName, string lName, bool available = true)
			: base(fName, lName, available) { }
	}
}
