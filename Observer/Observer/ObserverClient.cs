using System;

namespace Observer
{
    class ObserverClient
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            Parent mom = new Parent("Mom", journal);

            journal.AddNote();     
            journal.AddNote();

            Console.Read();
        }
    }
}
