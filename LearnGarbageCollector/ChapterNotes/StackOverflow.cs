using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnGarbageCollector.ChapterNotes
{
    public class StackOverflow //This Stack overflow Exception happens when a method is called infinite number of times.Every time we go out of a method their variables  are destroyed
    {
        public void InfinteReference()
        {
            Console.WriteLine("This is a eternal circular shitty reference so stack overflow exception its throwed!");
            //InfinteReference();
        }
    }
}
