using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsMetabot
{
    internal class Collection : IAbstractCollection
    {
        private List<object> items = new List<object>();
        
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        internal int Count => items.Count;

        internal void Demolish()
        {
            items.Clear();
        }

        internal Item item;

        internal object this[int index]
        {
            get => items[index];
            set => items.Add(value);
        }

        public static implicit operator Collection(Dictionary<string, string> v)
        {
            throw new NotImplementedException();
        }
    }
}
