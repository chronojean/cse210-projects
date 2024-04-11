using FinalProject.MyClasses;

public class Program
{
	public static void Main()
	{
		FinancialManager fm = new FinancialManager();
		Company company = new Company(
			nit: "987654321-0",
			rif: "J-123456789",
			businessName: "Palpay Financial",
			tradeName: "Palpay",
			email: "info@palpay.com",
			phones: new string[] { "+1 123-456-7890", "+1 987-654-3210" },
			webPage: "www.palpay.com",
			address: "123 Wall Street, Financial District, New York"
		);

		List<string> options = new List<string>
		{
			"Show This Company Details",
			"Add Company",
			"Add Person",
			"List Companies",
			"List People",
			"Register Expense",
			"Register Income",
			"Show Current Overall Status",
			"Show Yesterday's Transactions",
			"Show Transactions for the Last 7 Days",
			"Show Transactions for the Last 30 Days",
			"Tomorrow's Forecast",
			"Forecast for the Next 7 Days",
			"Forecast for the Next 30 Days",
		};
		Dictionary<string, Action> actions = new Dictionary<string, Action>
		{
			{ "1", () => Console.WriteLine(company.GetLetterhead())},
			{"2",fm.AddCompany},
			{"3",fm.AddPerson},
			{"4",fm.ListCompanies},
			{"5",fm.ListPeople},
			{"6",() => fm.RecordTransaction(true)},//Expense
			{"7",() => fm.RecordTransaction(false)},//Income
			{"8",() => fm.ShowTransactions(0)},
			{"9",() => fm.ShowTransactions(1)},
			{"10",() => fm.ShowTransactions(7)},
			{"11",() => fm.ShowTransactions(30)},
			{"12",() => fm.ShowForecast(1)},
			{"13",() => fm.ShowForecast(7)},
			{"14",() => fm.ShowForecast(30)}
		};

		Menu menu = new Menu(options, actions);
		string input = "";
		while (input != (menu.GetOptionCount() + 1).ToString())
		{
			Console.Clear();
			menu.DisplayMenu();
			Console.Write("Please enter an option: ");
			input = Console.ReadLine();
			if (menu.ValidateInput(input))
			{
				Console.Clear();
				menu.ExecuteAction(input);
				Console.WriteLine("\n\tPress enter to continue...");
				Console.ReadLine();
			}
		}
	}
}
