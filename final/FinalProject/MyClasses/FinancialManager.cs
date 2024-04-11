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

			Company myCompany = new Company(
			nit: "987654321-0",
			rif: "J-123456789",
			businessName: "Palpay Financial",
			tradeName: "Palpay",
			email: "info@palpay.com",
			phones: new string[] { "+1 123-456-7890", "+1 987-654-3210" },
			webPage: "www.palpay.com",
			address: "123 Wall Street, Financial District, New York"
		);
			_contacts.Add(myCompany);
			FillDummyContacts();
			FillDummyTransactions(60, 60);
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

		public void RecordTransaction(bool isExpense)
		{
			string transactionTypeName = isExpense ? "expense" : "income";

			Console.WriteLine($"Enter {transactionTypeName} details:");
			Console.Write("Transaction ID: ");
			string transactionID = Console.ReadLine();

			Console.Write("Date (MM/DD/YYYY): ");
			DateTime date;
			while (!DateTime.TryParse(Console.ReadLine(), out date))
			{
				Console.WriteLine("Invalid date format. Please enter date in MM/DD/YYYY format:");
			}

			Console.Write("Description: ");
			string description = Console.ReadLine();

			Console.Write("Amount: ");
			decimal amount;
			while (!decimal.TryParse(Console.ReadLine(), out amount))
			{
				Console.WriteLine("Invalid amount. Please enter a valid number:");
			}

			Console.Clear();
			Console.WriteLine($"Select the entity associated with the {transactionTypeName}:");

			// Display the list of entities sorted by name
			var sortedEntities = _contacts
				.OrderBy(contact => contact.GetName())
				.ToList();

			for (int i = 0; i < sortedEntities.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {sortedEntities[i].GetName()}");
			}

			Console.Write("Enter the number corresponding to the entity: ");
			int entityIndex;
			while (!int.TryParse(Console.ReadLine(), out entityIndex) || entityIndex < 1 || entityIndex > sortedEntities.Count)
			{
				Console.WriteLine("Invalid selection. Please enter a valid number:");
			}

			ContactInformation selectedEntity = sortedEntities[entityIndex - 1];

			Console.Clear();
			Console.WriteLine($"{transactionTypeName} Details:");
			Console.WriteLine($"Transaction ID: {transactionID}");
			Console.WriteLine($"Date: {date}");
			Console.WriteLine($"Description: {description}");
			Console.WriteLine($"Amount: {amount}");
			Console.WriteLine($"Associated Entity: {selectedEntity.GetName()}");

			// Ask if the information is correct
			if (Utils.IsInformationCorrect())
			{
				Transaction transaction;
				if (isExpense)
				{
					transaction = new Expense(transactionID, date, description, amount, selectedEntity);
				}
				else
				{
					transaction = new Income(transactionID, date, description, amount, selectedEntity);
				}

				_transactions.Add(transaction);
				Console.WriteLine($"{transactionTypeName} recorded successfully.");
			}
			else
			{
				Console.WriteLine($"{transactionTypeName} recording cancelled.");
			}
		}

		public void ShowTransactions(int daysToConsider)
		{
			// Obtener las transacciones dentro del período especificado o todas si daysToConsider = 0
			DateTime startDate = DateTime.Today.AddDays(-daysToConsider);
			// var transactionsWithinPeriod = _transactions.Where(t => t.GetDate() >= startDate);
			var transactionsWithinPeriod = daysToConsider == 0 ? _transactions : _transactions.Where(t => t.GetDate() >= startDate);




			// Ordenar las transacciones por fecha
			transactionsWithinPeriod = transactionsWithinPeriod.OrderBy(t => t.GetDate());

			// Imprimir encabezado
			Console.WriteLine("Date        | Entity            | Description                   | Expense        | Income ");
			Console.WriteLine("==================================================================================================");

			// Variables para almacenar el total de ingresos y gastos
			decimal totalIncome = 0;
			decimal totalExpenses = 0;

			// Imprimir cada transacción dentro del período
			foreach (var transaction in transactionsWithinPeriod)
			{
				// Obtener el nombre de la entidad
				string entityName = transaction.GetMadeBy().GetName();

				// Ajustar la longitud de las columnas
				string date = transaction.GetDate().ToString("MM/dd/yyyy").PadRight(12);
				string description = transaction.GetDescription().PadRight(30);
				string amount = transaction.GetAmount().ToString("C").PadLeft(15);

				// Determinar el color según el tipo de transacción
				if (transaction is Income)
				{
					totalIncome += transaction.GetAmount();
					Console.ForegroundColor = ConsoleColor.Green;

					// Imprimir el monto de ingreso en la columna correspondiente
					Console.WriteLine($"{date}| {entityName.PadRight(18)}| {description}|                | {amount}|");
				}
				else if (transaction is Expense)
				{
					totalExpenses += transaction.GetAmount();
					Console.ForegroundColor = ConsoleColor.Red;

					// Imprimir el monto de gasto en la columna correspondiente
					Console.WriteLine($"{date}| {entityName.PadRight(18)}| {description}| {amount}|                |");
				}

				Console.ResetColor();
			}

			// Imprimir resumen del estado dentro del período
			Console.WriteLine("\nCurrent Overall Status:");
			Console.WriteLine($"Total Income: {totalIncome:C}");
			Console.WriteLine($"Total Expenses: {totalExpenses:C}");

			// Calcular el balance dentro del período y establecer el color de la consola
			decimal balance = totalIncome + totalExpenses;
			Console.Write("Balance: ");
			Console.ForegroundColor = balance >= 0 ? ConsoleColor.Green : ConsoleColor.Red;
			Console.Write($"\x1b[1m{balance:C}\x1b[0m");
			Console.ResetColor();
		}

		public void CalculateAverageIncomeAndExpenses(out decimal averageIncome, out decimal averageExpenses, int days)
		{
			DateTime startDate = DateTime.Today.AddDays(-days);
			var transactionsWithinPeriod = _transactions.Where(t => t.GetDate() >= startDate);

			decimal totalIncome = 0;
			decimal totalExpenses = 0;
			int incomeCount = 0;
			int expenseCount = 0;

			foreach (var transaction in transactionsWithinPeriod)
			{
				if (transaction is Income income)
				{
					totalIncome += income.GetAmount();
					incomeCount++;
				}
				else if (transaction is Expense expense)
				{
					totalExpenses += expense.GetAmount();
					expenseCount++;
				}
			}

			averageIncome = incomeCount > 0 ? totalIncome / days : 0;
			averageExpenses = expenseCount > 0 ? totalExpenses / days : 0;
		}

		public void ShowForecast(int daysToForecast)
		{
			string forecastDuration = daysToForecast == 1 ? "tomorrow" : $"the next {daysToForecast} days";

			// Calcular los promedios de ingresos y gastos de los últimos 90 días
			decimal averageIncome;
			decimal averageExpenses;
			CalculateAverageIncomeAndExpenses(out averageIncome, out averageExpenses, 90);

			// Calcular las proyecciones para el futuro
			decimal projectedIncome = averageIncome * daysToForecast;
			decimal projectedExpenses = averageExpenses * daysToForecast;

			// Calcular la ganancia necesaria para un crecimiento del 6% en el período de tiempo especificado
			decimal grossProfit = projectedIncome - projectedExpenses;
			decimal growthIncome = averageIncome * daysToForecast * 1.06m;

			// Imprimir la proyección y la ganancia necesaria
			Console.WriteLine($"Predicted Expenses for {forecastDuration}: {projectedExpenses:C}");
			Console.WriteLine($"A gross income equivalent to {growthIncome:C} is needed for {forecastDuration} to achieve a daily growth of 6%.");
			Console.WriteLine("Based on the company's current average income.");
		}





























		public void FillDummyTransactions(int previousDays, int numberOfTransactions)
		{
			Random random = new Random();

			// Crear 30 gastos aleatorios
			for (int i = 0; i < numberOfTransactions / 2; i++)
			{
				string transactionID = $"EXP-{i + 1}";
				DateTime date = DateTime.Now.AddDays(-random.Next(1, previousDays));
				string description = $"Expense {i + 1}";
				decimal amount = random.Next(10, 1000);
				int entityIndex = random.Next(0, _contacts.Count);
				ContactInformation selectedEntity = _contacts[entityIndex];
				Expense expense = new Expense(transactionID, date, description, amount, selectedEntity);
				_transactions.Add(expense);
			}

			// Crear 30 ingresos aleatorios
			for (int i = 0; i < numberOfTransactions / 2; i++)
			{
				string transactionID = $"INC-{i + 1}";
				DateTime date = DateTime.Now.AddDays(-random.Next(1, previousDays));
				string description = $"Income {i + 1}";
				decimal amount = random.Next(100, 5000);
				int entityIndex = random.Next(0, _contacts.Count);
				ContactInformation selectedEntity = _contacts[entityIndex];
				Income income = new Income(transactionID, date, description, amount, selectedEntity);
				_transactions.Add(income);
			}

			Console.WriteLine("Dummy transactions filled successfully.");
		}


		public void FillDummyContacts()
		{
			Random random = new Random();

			// Lista de nombres aleatorios para personas
			string[] firstNames = { "Emma", "Noah", "Olivia", "Liam", "Ava", "William", "Sophia", "Mason", "Isabella", "James", "Charlotte", "Benjamin", "Amelia", "Lucas", "Mia", "Henry", "Harper", "Alexander", "Evelyn", "Michael", "Abigail", "Elijah", "Emily", "Daniel", "Elizabeth", "Matthew", "Sofia", "Jackson", "Avery", "Sebastian", "Ella", "David", "Scarlett", "Joseph", "Grace", "Gabriel", "Chloe", "Carter", "Victoria", "Owen", "Riley", "Wyatt", "Aria", "John", "Luna", "Jack", "Hannah" };

			// Agregar 4 empresas aleatorias (igual que antes)
			for (int i = 0; i < 4; i++)
			{
				string nit = $"NIT-{random.Next(100000000, 999999999)}-{random.Next(1, 9)}";
				string rif = $"RIF-{random.Next(10000000, 99999999)}-{random.Next(1, 9)}";
				string businessName = $"Business {i + 1}";
				string tradeName = $"Trade {i + 1}";
				string email = $"info{random.Next(1, 100)}@company.com";
				string[] phones = { $"+1 {random.Next(100, 999)}-{random.Next(100, 999)}-{random.Next(1000, 9999)}" };
				string webPage = $"www.company{i + 1}.com";
				string address = $"{random.Next(1, 100)} Main St, City";

				Company company = new Company(nit, rif, businessName, tradeName, email, phones, webPage, address);
				_contacts.Add(company);
			}

			// Agregar 2 personas aleatorias con nombres reales
			for (int i = 0; i < 2; i++)
			{
				string nit = $"NIT-{random.Next(100000000, 999999999)}-{random.Next(1, 9)}";
				string rif = $"RIF-{random.Next(10000000, 99999999)}-{random.Next(1, 9)}";
				string idCard = $"ID-{random.Next(1000000, 9999999)}-{random.Next(1, 9)}";
				string firstName = firstNames[random.Next(firstNames.Length)];
				string lastName = $"Last {i + 1}";
				string email = $"info{random.Next(1, 100)}@person.com";
				string[] phones = { $"+1 {random.Next(100, 999)}-{random.Next(100, 999)}-{random.Next(1000, 9999)}" };
				string webPage = "";
				string address = $"{random.Next(1, 100)} Street, City";

				Person person = new Person(nit, rif, idCard, firstName, lastName, email, phones, webPage, address);
				_contacts.Add(person);
			}

			Console.WriteLine("Dummy contacts filled successfully.");
		}



	}
}
