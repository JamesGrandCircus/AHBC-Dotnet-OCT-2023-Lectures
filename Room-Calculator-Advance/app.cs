namespace Room_Calculator_Advance;

public static class App
{
	public static void Run()
	{
		var rooms = new List<Room>();
		Console.Clear();

		var texts = new List<(string, ConsoleColor)> 
		{
			("Welcome to the " , ConsoleColor.White),
			("OFFICIAL UNOFFICIAL ", ConsoleColor.DarkBlue),
			("GRAND CIRCUS ", ConsoleColor.DarkYellow),
			("room calculator ", ConsoleColor.White),
			("BABY! ", ConsoleColor.Magenta),
			("what would you like to do?\n", ConsoleColor.White),
		};

		foreach (var (text, color) in texts)
		{
			ConsoleHelper.WriteColors(text, color);
		}

		MainMenu(rooms);
		Console.WriteLine("Goodbye!");
		ConsoleHelper.ReadLineClear();
	}

	private static void MainMenu(IList<Room> rooms)
	{
		bool isRunning;
		do 
		{
			Menu menu = GetMenuSelection();
			Console.Clear();
			switch (menu)
			{
				case Menu.Add: 
					Add(rooms);
					break;
				case Menu.Remove:
					Remove(rooms);
					break;
				case Menu.ViewAll:
					TryPrintRooms(rooms);
					break;
				case Menu.Exit:
					break;
			}

			Console.WriteLine("Press any key to continue...");
			ConsoleHelper.ReadLineClear();
			isRunning = menu != Menu.Exit;
		} while (isRunning);
	}

	private static Menu GetMenuSelection()
	{
		while (true)
		{
			Console.WriteLine("Please enter a valid number selection");

			var selectionRange = Enumerable.Range(1, 4);
			var choices = new string[] { "Add a room", "Remove a room", "View all rooms", "Exit" };

			Console.ForegroundColor = ConsoleColor.Green;
			foreach (var choice in selectionRange.Zip(choices, (i, s) => $"[{i}]. {s}"))
			{
				ConsoleHelper.WriteLineColors(choice, ConsoleColor.Green);
			}

			Console.Write("Enter your selection: ");
			if (Enum.TryParse(Console.ReadLine(), out Menu menu) && selectionRange.Contains((int)menu))
			{
				return menu;
			}

			Console.WriteLine("Invalid input, please try again...");
			ConsoleHelper.ReadLineClear();
		}
	}

	private static void Add(IList<Room> rooms) 
	{
		string name = Room.GetValidName();
		double length = Room.GetValidCalculation(Dimension.length);
		double width = Room.GetValidCalculation(Dimension.width);
		double height = Room.GetValidCalculation(Dimension.height);
		var room = new Room(name, length, width, height);
		ConsoleHelper.WriteLineColors(room.ToString(), ConsoleColor.Cyan);

		Console.WriteLine("Would you like to add this room? [Y/N]");
		var userInput = Console.ReadKey().Key;
		Console.Clear();

		if (userInput == ConsoleKey.Y)
		{
			ConsoleHelper.WriteLineColors("Room added!", ConsoleColor.Blue);
			rooms.Add(room);
		} 
		else 
		{
			ConsoleHelper.WriteLineColors("Room not added!", ConsoleColor.Red);
		}
	}

	private static void Remove(IList<Room> rooms)
	{
		if (TryPrintRoomInfo(rooms, out var ids))
		{
			Console.Write("Enter the ID of the room you would like to remove: ");
			var userInput = Console.ReadLine();
			Console.Clear();
			if (int.TryParse(userInput, out int id) && ids.Contains(id))
			{
				var room = rooms.First(x => x.Id == id);
				Console.WriteLine(room);
				ConsoleHelper.WriteLineColors("Would you like to remove this room? [Y/N]", ConsoleColor.Red);
				var userKey = Console.ReadKey().Key;
				Console.Clear();
				string message;
				if (userKey == ConsoleKey.Y)
				{
					rooms.Remove(room);
					message = "Room removed!";
				}
				else
				{
					message = "Room not removed!";
				}
				ConsoleHelper.WriteLineColors(message, ConsoleColor.Blue);
			}
			else
			{
				Console.WriteLine("Invalid ID");
			}
		}
	}


	private static bool TryPrintRoomInfo(IList<Room> rooms, out IEnumerable<int> ids)
	{
		if (rooms.Any())
		{
			foreach (var room in rooms)
				ConsoleHelper.WriteLineColors(room.RoomInfo, ConsoleColor.Cyan);

			ids = rooms.Select(x => x.Id);
			return true;
		} 
		else 
		{
			ConsoleHelper.WriteLineColors("No rooms to display", ConsoleColor.Red);
			ids = new List<int>();
			return false;
		}
	}

	private static bool TryPrintRooms(IList<Room> rooms)
	{
		if (rooms.Any())
		{
			foreach (var room in rooms)
				ConsoleHelper.WriteLineColors(room.ToString(), ConsoleColor.Cyan);

			return true;
		}
		else
		{
			ConsoleHelper.WriteLineColors("No rooms to display", ConsoleColor.Red);
			return false;
		}
	}
}