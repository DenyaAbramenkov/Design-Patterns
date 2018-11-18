using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Parent: IObserver
    {
        public string Name { get; set; }

        IObservable _jornal;

        public Parent(string name, IObservable journal)
        {
            this.Name = name;
            _jornal = journal;
            _jornal.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            Console.WriteLine("What a horrible mark again? Why did Vasya get better mark?");
        }
    }
}
