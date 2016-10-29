using System;
using System.Diagnostics;

namespace KnapsackGroupsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Potreban je jedan argument, put do datoteke s vrijednostima i cijenama!");
            }
            else
            {
                KnapsackGroupsCore core = new KnapsackGroupsCore();
                try
                {
                    Stopwatch stopwatch = Stopwatch.StartNew();
                    DynamicTable table = core.ParseInitialTableFromFile(args[0]);
                    core.SolveProblem(false);
                    Console.WriteLine("Traženi zbroj cijena: "+table.TargetCost);
                    Console.WriteLine("Odabrani:");
                    table.BestTableObjects.Reverse();
                    foreach (int tableObjectIndex in table.BestTableObjects)
                    {
                        DynamicTableObject tableObject = table.TableObjects[tableObjectIndex];
                        Console.WriteLine(table.GroupNames[tableObject.GroupIndex] + ": " + tableObject);
                    }
                    Console.WriteLine("---------");
                    Console.WriteLine("Ukupna vrijednost: "+table.BestValue);
                    Console.WriteLine("Ukupna cijena: " + table.BestCost);
                    stopwatch.Stop();
                    Console.WriteLine("Vrijeme izvrsavanja: " + ((float) stopwatch.ElapsedMilliseconds/1000) + " s");

                }
                catch (Exception)
                {
                    Console.WriteLine("Datoteka ne postoji ili nije ispravno formatirana!");
                }
            }
        }
    }
}
