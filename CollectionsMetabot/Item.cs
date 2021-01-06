using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsMetabot
{
    internal class Item
    {
        internal Item(string name)
        {
            this.Name = name;
        }

        internal string Name { get; }
    }
}
