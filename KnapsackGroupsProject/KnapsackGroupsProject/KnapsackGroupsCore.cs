using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackGroupsProject
{
    public class KnapsackGroupsCore
    {
        private DynamicTable table;

        public DynamicTable ParseInitialTableFromFile(string filePath)
        {
            if (filePath.Length == 0)
            {
                throw new ArgumentException("Put to datoteke ne smije biti prazan!");
            }
            else if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Datoteka nije pronađena!");
            }

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = sr.ReadLine();
                    int targetCost = int.Parse(line.Split('=')[1]);
                    List<DynamicTableObject> tableObjects = new List<DynamicTableObject>();
                    List<List<int>> costList = new List<List<int>>();
                    List<string> groupNames = new List<string>();
                    Boolean groupAdded = false;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.StartsWith("#"))
                        {
                            if (groupAdded)
                            {
                                groupNames.RemoveAt(groupNames.Count - 1);
                            }
                            groupNames.Add(line.Substring(1));
                            groupAdded = true;
                        }
                        else
                        {
                            if (groupNames.Count == 0)
                            {
                                groupNames.Add("(nepoznata grupa)");
                                groupAdded = true;
                            }
                            string name = line.Split('=')[0];
                            string numbersStr = line.Split('=')[1];
                            int value = int.Parse(numbersStr.Split(';')[0]);
                            int cost = int.Parse(numbersStr.Split(';')[1]);
                            int groupIndex = groupNames.Count - 1;
                            tableObjects.Add(new DynamicTableObject(name, value, cost, groupIndex));
                            costList.Add(new List<int>());
                            groupAdded = false;
                        }
                    }
                    if (groupAdded)
                    {
                        groupNames.RemoveAt(groupNames.Count - 1);
                    }
                    table = new DynamicTable(targetCost, tableObjects, costList, groupNames);
                }
                return table;
            }
            catch (Exception)
            {
                throw new FormatException("Datoteka nije u ispravnom formatu!\n"+
                    "Pogledajte primjer datoteke u dijelu 'Pomoć' (klik na gumb upitnik).");
            }
        }

        public List<int> SolveProblem(bool allValuesNeeded)
        {
            table.SolveProblem(allValuesNeeded);
            List<int> rows = table.FindBest(); ;
            if (allValuesNeeded)
            {
                return rows;
            }
            else return null;
        }
    }
}
