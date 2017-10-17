using System;
using System.Collections.Generic;
using System.Collections;

namespace week03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getal?");
            int input = Convert.ToInt32(Console.ReadLine());

            int [] outputArray = new int[11];
            List<int> outputList = new List<int>();
            
            Hashtable outputHashtable = new Hashtable();
            
            for (int i = 1; i<=10; i++){
                int intOutput = (i * input);
                    Console.WriteLine(i + " x " + input + " = "+ intOutput );
                    
                    // Add values to OutputList
                    outputList.Add(intOutput);
                    outputArray[i] = intOutput;
                    //Hashtable[i] = intOutput;
                    outputHashtable[10-i] = intOutput;
                    
            }


            // Output List values
            Console.WriteLine("List values: ");
             foreach (int key in outputList)
            {
                System.Console.WriteLine(key);
            }


            Console.WriteLine("Hashtable values: ");
            foreach (DictionaryEntry entry in outputHashtable){
                System.Console.WriteLine(entry.Value);
            }


            // Output Array values
            Console.WriteLine("Array values: ");
            for (int k = 0; k < outputArray.Length; k++ ){
                    Console.WriteLine(outputArray[k]);
            }


            


            }
        }
    }

