using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty List of type object
            List<object> objList = new List<object>();
            // Add the following values to the list: 7, 28, -1, true, "chair"
            objList.Add(7);
            objList.Add(28);
            objList.Add(-1);
            objList.Add(true);
            objList.Add("chair");
            // Loop through the list and print all values (Hint: Type Inference might help here!)
            // Add all values that are Int type together and output the sum
            int sum = 0;
            for (int i = 0; i < objList.Count; i++) {
                Console.WriteLine(objList[i]);
                if (objList[i] is int) {
                    sum += (int)objList[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
