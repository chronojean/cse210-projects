namespace FinalProject.MyClasses
{
	public class Menu
	{
		private List<string> _options;
		private Dictionary<string, Action> _actions;

		public Menu(List<string> options, Dictionary<string, Action> actions)
		{
			_options = options;
			_actions = actions;
		}

		public void AddOption(string option, Action action)
		{
			_options.Add(option);
			_actions.Add(option, action);
		}

		public int GetOptionCount()
		{
			return _options.Count;
		}

		public bool ValidateInput(string input)
		{
			int option;
			if (int.TryParse(input, out option))
			{
				if (option >= 1 && option <= _options.Count)
				{
					return true;
				}
			}
			return false;
		}

		public void DisplayMenu()
		{
			Console.WriteLine("Menu");
			for (int i = 0; i < _options.Count; i++)
			{
				Console.WriteLine((i + 1) + ". " + _options[i]);
			}
			Console.WriteLine((_options.Count + 1) + ". " + "Quit");
		}

		public void ExecuteAction(string input)
		{
			if (_actions.ContainsKey(input))
			{
				_actions[input]();
			}
		}
	}
}