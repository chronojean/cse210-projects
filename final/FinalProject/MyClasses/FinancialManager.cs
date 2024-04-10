using System;
using System.Collections.Generic;

namespace FinalProject.MyClasses
{
	public class FinancialManager
	{
		private List<ContactInformation> _contacts;
		private List<Transaction> _transactions;

		public FinancialManager()
		{
			_contacts = new List<ContactInformation>();
			_transactions = new List<Transaction>();
		}

		// Método para agregar una compañía a la lista de contactos
		public void AddCompany()
		{
			string nit, rif, businessName, tradeName, email, webPage, address;
			string[] phones;

			Console.WriteLine("Enter company details:");
			Console.Write("NIT: ");
			nit = Console.ReadLine();
			Console.Write("RIF: ");
			rif = Console.ReadLine();
			Console.Write("Trade name: ");
			tradeName = Console.ReadLine();
			Console.Write("Business name: ");
			businessName = Console.ReadLine();
			Console.Write("Email: ");
			email = Console.ReadLine();
			Console.Write("Website: ");
			webPage = Console.ReadLine();
			Console.Write("Address: ");
			address = Console.ReadLine();

			Console.WriteLine("Enter phone numbers (separate each number with a comma): ");
			phones = Console.ReadLine().Split(',');

			if (Utils.IsInformationCorrect())
			{
				Company company = new Company(nit, rif, businessName, tradeName, email, phones, webPage, address);
				_contacts.Add(company);
				Console.WriteLine("The company has been added successfully.");
			}
			else
			{
				Console.WriteLine("Operation cancelled. Please try again.");
			}
		}

		public void AddPerson()
		{
			string nit, rif, idCard, firstName, lastName, email, webPage, address;
			string[] phones;

			Console.WriteLine("Enter person details:");
			Console.Write("NIT: ");
			nit = Console.ReadLine();
			Console.Write("RIF: ");
			rif = Console.ReadLine();
			Console.Write("ID Card: ");
			idCard = Console.ReadLine();
			Console.Write("First Name: ");
			firstName = Console.ReadLine();
			Console.Write("Last Name: ");
			lastName = Console.ReadLine();
			Console.Write("Email: ");
			email = Console.ReadLine();
			Console.Write("Website: ");
			webPage = Console.ReadLine();
			Console.Write("Address: ");
			address = Console.ReadLine();

			Console.WriteLine("Enter phone numbers (separate each number with a comma): ");
			phones = Console.ReadLine().Split(',');

			if (Utils.IsInformationCorrect())
			{
				Person person = new Person(nit, rif, idCard, firstName, lastName, email, phones, webPage, address);
				_contacts.Add(person);
				Console.WriteLine("The person has been added successfully.");
			}
			else
			{
				Console.WriteLine("Operation cancelled. Please try again.");
			}
		}

		public void ListCompanies()
		{
			// Filtrar las compañías
			var companies = _contacts.OfType<Company>();

			// Ordenar alfabéticamente por TradeName
			var sortedCompanies = companies.OrderBy(company => company.GetName());

			// Mostrar la lista enumerada
			Console.WriteLine("List of companies:");
			int index = 1;
			foreach (var company in sortedCompanies)
			{
				Console.WriteLine($"{index}. Trade Name: {company.GetName()}");
				index++;
			}
		}
		public void ListPeople()
		{
			// Filtrar las personas
			var people = _contacts.OfType<Person>();

			// Ordenar alfabéticamente por nombre
			var sortedPeople = people.OrderBy(person => person.GetName());

			// Mostrar la lista enumerada
			Console.WriteLine("List of people:");
			int index = 1;
			foreach (var person in sortedPeople)
			{
				Console.WriteLine($"{index}. {person.GetName()}");
				index++;
			}
		}


	}
}
