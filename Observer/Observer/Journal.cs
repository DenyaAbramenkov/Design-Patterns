using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Journal: IObservable
    {
        List<string> Note;

        List<IObserver> observers;
        public Journal()
        {
            observers = new List<IObserver>();
            Note = new List<string>();
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(Note);
            }
        }

        public void AddNote()
        {
            Random random = new Random();
            int mark = random.Next(1, 12);
            Note.Add($"Your mark is {mark}");
            Console.WriteLine($"Your mark is {mark}");
            NotifyObservers();
        }
    }
}
