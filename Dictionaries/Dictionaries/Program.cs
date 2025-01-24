namespace Dictionaries
{
    internal class Program
    {
        Dictionary<string, Room> rooms = new Dictionary<string, Room>();
        static void Main(string[] args)

        {
            Program program = new Program();
            program.run();

        }
        internal void run()
        {

            Dictionary<int, string> personeelnummer = new Dictionary<int, string>();

            personeelnummer.Add(382942, "jim");
            personeelnummer.Add(382941, "zim");


            string jim = personeelnummer[382942];
            string zim = personeelnummer[382941];

            foreach (int key in personeelnummer.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (string value in personeelnummer.Values)
            {
                Console.WriteLine(value);
            }


            Room start = new Room(0, 0, [
         "XXXXX",
            "X...X",
            "X...X",
            "X...X",
            "XXXXX"
         ]);

            rooms.Add(start.GetRoomLocationKey(), start);
            Showroom(0, 0);

        }




        private void Showroom(int x, int y)

        {
            bool hasRoom = rooms.ContainsKey($"{x},{y}");

            if (hasRoom)
            {


                Room room = rooms[$"{x},{y}"];

                Console.WriteLine($"You are in room {x}, {y}");

                foreach (string r in room.level)
                {
                    Console.WriteLine(r);
                }


            }

            else
            {
                Console.WriteLine("error room does not exist");
            }
        }
    }
}
