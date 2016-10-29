using System;
using System.Collections.Generic;
using System.Linq;

namespace KnapsackGroupsProject
{
    public class DynamicTable
    {
        private int targetCost;

        // table column headers
        private List<DynamicTableObject> tableObjects;

        // cost list (integers) for every table object
        private List<List<int>> costList;

        private List<String> groupNames;

        private List<List<int>> groupMaxValues;
        private List<List<int>> groupMaxIndices;

        private int bestCost;
        private int bestValue;
        private List<int> bestTableObjects;

        public int TargetCost
        {
            get
            {
                return targetCost;
            }

            set
            {
                targetCost = value;
            }
        }

        public List<DynamicTableObject> TableObjects
        {
            get
            {
                return tableObjects;
            }

            set
            {
                tableObjects = value;
            }
        }

        public List<List<int>> CostList
        {
            get
            {
                return costList;
            }

            set
            {
                costList = value;
            }
        }

        public List<string> GroupNames
        {
            get
            {
                return groupNames;
            }

            set
            {
                groupNames = value;
            }
        }

        public List<List<int>> GroupMaxValues
        {
            get
            {
                return groupMaxValues;
            }

            set
            {
                groupMaxValues = value;
            }
        }

        public List<List<int>> GroupMaxIndices
        {
            get
            {
                return groupMaxIndices;
            }

            set
            {
                groupMaxIndices = value;
            }
        }

        public int BestCost
        {
            get
            {
                return bestCost;
            }

            set
            {
                bestCost = value;
            }
        }

        public int BestValue
        {
            get
            {
                return bestValue;
            }

            set
            {
                bestValue = value;
            }
        }

        public List<int> BestTableObjects
        {
            get
            {
                return bestTableObjects;
            }

            set
            {
                bestTableObjects = value;
            }
        }

        public DynamicTable(int targetCost, List<DynamicTableObject> tableObjects, List<List<int>> costList, List<string> groupNames)
        {
            this.TargetCost = targetCost;
            this.TableObjects = tableObjects;
            this.CostList = costList;
            this.GroupNames = groupNames;

            this.GroupMaxValues = new List<List<int>>();
            this.GroupMaxIndices = new List<List<int>>();
            for (int i = 0; i < groupNames.Count; i++)
            {
                this.GroupMaxValues.Add(new List<int>());
                this.GroupMaxIndices.Add(new List<int>());
            }
            BestCost = 0;
            BestValue = 0;
            BestTableObjects = new List<int>();
        }

        public void Reset()
        {
            for (int toInd = 0; toInd < costList.Count; toInd++)
            {
                costList[toInd].Clear();
            }

            for (int group = 0; group < groupMaxIndices.Count; group++)
            {
                GroupMaxValues[group].Clear();
                GroupMaxIndices[group].Clear();
            }

            BestCost = 0;
            BestValue = 0;
            BestTableObjects.Clear();
        }

        internal void SolveProblem(Boolean allValuesNeeded)
        {
            for (int currentCost = 0; currentCost <= targetCost; currentCost++)
            {
                for (int i = 0; i < groupMaxValues.Count; i++)
                {
                    groupMaxValues[i].Add(0);
                }
                for (int objectIndex = 0; objectIndex < tableObjects.Count; objectIndex++)
                {
                    DynamicTableObject tableObject = tableObjects[objectIndex];
                    int groupIndex = tableObject.GroupIndex;
                    if (groupMaxIndices[groupIndex].Count != groupMaxValues[groupIndex].Count)
                    {
                        groupMaxIndices[groupIndex].Add(objectIndex);
                    }

                    int maxValue;
                    if (groupIndex == 0)
                    {
                        if (tableObject.Cost <= currentCost) maxValue = tableObject.Value;
                        else maxValue = 0;
                    }
                    else
                    {
                        if (tableObject.Cost <= currentCost)
                        {
                            int previousMaxValue = groupMaxValues[groupIndex - 1].Last();
                            int currentPlusAboveValue = tableObject.Value + groupMaxValues[groupIndex - 1][currentCost - tableObject.Cost];
                            maxValue = Math.Max(previousMaxValue, currentPlusAboveValue);
                        }
                        else
                        {
                            maxValue = groupMaxValues[groupIndex - 1].Last();
                        }
                    }
                    if (allValuesNeeded) // for populating table grid in GUI version:
                    {
                        costList[objectIndex].Add(maxValue);
                    }

                    if (maxValue > groupMaxValues[groupIndex].Last())
                    {
                        groupMaxValues[groupIndex][currentCost] = maxValue;
                        groupMaxIndices[groupIndex][currentCost] = objectIndex;
                    }

                }
            }
        }

        public List<int> FindBest()
        {
            List<int> rows = new List<int>();

            int beginIndex = groupMaxIndices.Count - 1;
            int maximum = groupMaxValues[beginIndex].Last();

            
            for (int i = 0; i < groupMaxValues.Count; i++)
            {
                if (groupMaxValues[i].Last() == maximum)
                {
                    beginIndex = i;
                    break;
                }
            }
            
            int currentCost = targetCost;
            DynamicTableObject tableObject = null;

            for (int currentList = beginIndex; currentList >= 0; currentList--)
            {
                if (currentList == beginIndex)
                {
                    int tableObjectIndex = groupMaxIndices[beginIndex].Last();
                    tableObject = tableObjects[tableObjectIndex];
                    // if none fit in the 'bag':
                    if (tableObject.Cost > currentCost) break;
                    rows.Add(currentCost);
                    
                    bestTableObjects.Add(tableObjectIndex);
                    bestCost += tableObject.Cost;
                    bestValue += tableObject.Value;
                }
                else
                {
                    int rowIndex = currentCost - tableObject.Cost;

                    while (currentList != 0)
                    {
                        if (groupMaxValues[currentList][rowIndex] == groupMaxValues[currentList - 1][rowIndex])
                        {
                            int colIndexMiddle = groupMaxIndices[currentList][rowIndex];

                            currentList--;
                        }
                        else break;
                    }

                    
                    int colIndex = groupMaxIndices[currentList][rowIndex];
                    tableObject = tableObjects[colIndex];
                    if (tableObject.Cost <= rowIndex)
                    {
                        rows.Add(rowIndex);
                        bestTableObjects.Add(colIndex);
                        bestCost += tableObject.Cost;
                        bestValue += tableObject.Value;
                    }
                    
                    currentCost = rowIndex;
                }
            }



            return rows;
        }

    }
}
