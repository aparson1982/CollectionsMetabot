using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsMetabot
{
    internal class Iterator : IAbstractIterator
    {
        private Collection collection;
        private int current = 0;
        //private int step = 1;

        public Iterator(Collection collection)
        {
            this.collection = collection;
        }

        
        public Item First()
        {
            return collection[current] as Item;
        }

        public  Item Next()
        {
            object ret = null;
            
            if (!IsDone)
            {
                ret = collection[++current] as Item;
            }
            return (Item)ret;
        }

        public bool IsDone
        {
            get { return current >= collection.Count - 1; }
        }

        public Item CurrentItem
        {
            get { return collection[current] as Item; }
        }

    }
}
