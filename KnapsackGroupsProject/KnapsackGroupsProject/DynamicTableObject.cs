using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackGroupsProject
{
    public class DynamicTableObject
    {
        private string name;
        private int value;
        private int cost;
        private int groupIndex;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public int Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }

        public int GroupIndex
        {
            get
            {
                return groupIndex;
            }

            set
            {
                groupIndex = value;
            }
        }

        public DynamicTableObject(string name, int value, int cost, int groupIndex)
        {
            this.name = name;
            this.value = value;
            this.cost = cost;
            this.groupIndex = groupIndex;
        }

        public override string ToString()
        {
            return string.Format("{0} (V={1}, C={2})", name, value, cost);
        }

    }
}
