using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListifyCodeTest.Models
{
    public class Listify : IList<int>
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public IEnumerable<int> Range { get; set; }

        public int this[int index]
        {
            get => getIndex(index);
            set => throw new NotImplementedException();
        }

        public Listify(int min, int max)
        {
            if (min > max)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            this.Min = min;
            this.Max = max - min + 1;
            
            this.Range = Enumerable.Range(this.Min, this.Max);
        }

        private int getIndex(int index)
        {
            var returnValue = 0;

            var rangeMin = 0;
            var rangeMax = this.Max - this.Min;

            if (index < rangeMin || index > rangeMax)
            {
                throw new IndexOutOfRangeException();
            }

            var indexCount = 0;

            foreach (var value in this.Range)
            {
                if (indexCount == index)
                {
                    returnValue = value;
                    break;
                }

                indexCount++;
            }
            
            return returnValue;
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(int item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, int item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}