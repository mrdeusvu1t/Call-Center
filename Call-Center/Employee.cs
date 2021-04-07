using System;
using System.Collections.Generic;
using System.Text;

namespace Call_Center
{
	abstract class Employee
	{
		private string firstName;
		private string lastName;
		private bool available;

		public string FirstName
		{
			get => firstName;
			private set => firstName = value;
		}

		public string LastName
		{
			get => lastName;
			private set => lastName = value;
		}

		public bool Available
		{
			get => available;
			private set => available = value;
		}

		public Employee(string fName, string lName, bool available)
		{
			FirstName = fName;
			LastName = lName;
			Available = available;
		}

		public virtual string Call()
		{
			if (Available)
			{
				Available = false;
				return $"{this.ToString()} на связи.";
			}
			else
			{
				Available = true;
				return "Сотрудник сейчас не доступен.\nВызов передается другому сотруднику.";
			}
		}

		public override string ToString()
		{
			return $"{FirstName} {LastName}";
		}
	}
}
