using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSpan_Prime
{
    class Graphset
    {
        int parent;//store the vertex from which current vertex will be reach

        int weight; // store the weight for printing the minimum span weight

        public int Parent {
            get
            {
                return parent;
            }
            set
            {
                parent = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
    }
}
