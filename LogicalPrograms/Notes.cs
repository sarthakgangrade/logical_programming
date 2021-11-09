using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Notes
    {


        public void notesCounter()
        {

            int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] counter = new int[notes.Length];
            int amount;


            Console.WriteLine("enter the amount:");
            amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    counter[i] = amount / notes[i];
                    amount = amount - counter[i] * notes[i];
                }
            }
            Console.WriteLine("the number of note is required");
            for (int i = 0; i < notes.Length; i++)
            {
                if (counter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " = " + counter[i]);
                }

            }

        }





    }
}
