using System;
using System.Collections.Generic;
using System.Text;

namespace Call_Center
{
	class Respondent : Employee
	{
		public Respondent(string fName, string lName, bool available = true)
			: base (fName, lName, available)	{	}
	}
}
