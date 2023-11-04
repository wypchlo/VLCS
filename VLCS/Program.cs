using VLCS.Classes;

namespace VLCS
{
    internal class Program
    {
        static void Main()
        {
            List<string> options = new List<string>{"Search", "Add", "Exit"};
            MenuSelector music = new MenuSelector("music", options);
            
            string pathToFile = @"../../../Titles/music.txt";
            string title = File.ReadAllText(pathToFile);
            ConsoleKey pressedKey = ConsoleKey.E;
            int index = 0;
            const int optionCount = 3;

            Console.WriteLine(title);
            Console.WriteLine(" 1. Search \n 2. Add \n 3. Exit");

            var bottomLine = Console.CursorTop;

            while (true) 
            {
                switch (pressedKey)
                {
                    case ConsoleKey.UpArrow:
                        index++;
                        if (index > optionCount - 1)
                            index = 0;
                        break;

                    case ConsoleKey.DownArrow:
                        index--;
                        if (index < 0)
                            index = optionCount - 1;
                        break;
                }
                Console.SetCursorPosition(1, bottomLine - (index + 1));

                pressedKey = Console.ReadKey().Key;
            }
        }
    }
}

/*
DBManager db = new DBManager(@"../../../db/VLCS.db");           
db.connection.Open();

db.NonQuery("CREATE TABLE IF NOT EXISTS music (music_id INTEGER PRIMARY KEY, music_name TEXT, music_path TEXT)");
db.NonQuery("INSERT INTO music (music_path) VALUES ('Desktop')");
SQLiteDataReader reader = db.Query("SELECT music_id, music_name FROM music");
using (reader)
{
    while (reader.Read()) 
    {
        Console.WriteLine(reader["music_id"].ToString());
    }
}

db.connection.Close();
*/