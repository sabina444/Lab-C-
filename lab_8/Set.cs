using System.Collections;

namespace lab_8
{
    class Set
    {
        private int[] Elements;
        public int Count = 0;
        public Set()
        {
            Console.WriteLine("Введите количество: ");
            var count = Convert.ToInt32(Console.ReadLine());
            Elements = new int[count];
            Fill();
        }
        public Set(int[] elements)
        {
            Elements = new int[1];
            for (int i = 0; i < elements.Length; i++)
            {
                Add(elements[i]);
            }
        }
        public Set(int item) 
        {
            Elements = new int[1];
        }
        public bool Add(int item)
        {
            if (IndexOf(item) == -1)
            {
                Array.Resize(ref Elements, Elements.Length + 1);
                Elements[Count++] = item;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int IndexOf(int item)
        {
            for (int i = 0; i < Elements.Length; i++)
            {
                if (item == Elements[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public void Fill()
        {
            Console.WriteLine("Введите элементы множества: ");
            int len = Elements.Length; 

            for (int i = 0; i < len; i++)
            {
                var item = Convert.ToInt32(Console.ReadLine());
                Add(item);
            }
        }
        public void ShowSet()
        {
            Console.WriteLine(this);
        }
        public bool Remove(int item)
        {
            if (IndexOf(item) == -1 || IndexOf(item) > Count-1) return false;

            for (int i = IndexOf(item); i < Count; i++)
            {
                Elements[i] = Elements[i + 1];
            }
            Count--;
            return true;
        }
        public int this[int index]
        {
            get
            {
                return Elements[index];
            }
        }
        public override string ToString()
        {
            string str = "";

            for (int i = 0; i < Count; i++)
            {
                str += Elements[i] + " ";
            }
            return str;
        }
        public Set Increase() //увеличение значений элементов множества на 1
        {
            for(int i = 0;i < Count;i++)
            {
                Elements[i] += 1;
            }
             return this;
        }
        public Set Union(Set other) //объединение множеств
        {
            Set result = new Set(0);

            foreach (var item in Elements)
            {
                result.Add(item);
            }
            foreach (var item in other.Elements)
            {
                result.Add(item);
            }

            return result;
        }
        public Set Intersection(Set other) //пересечение множеств
        {
            var result = new Set(0);
            Set big;
            Set small;

            if (Count >= other.Count)
            {
                big = this;
                small = other;
            }
            else
            {
                big = other;
                small = this;
            }

            foreach(var item1 in small.Elements) 
            {
                foreach (var item2 in big.Elements)
                {
                    if (item1 == item2) 
                    {
                        result.Add(item1);
                        break;
                    }
                }
            }

            return result;
        }
        public Set Difference(Set other) //разность множеств
        {
            var result = new Set(Elements);

            foreach (var item in other.Elements) 
            {
                result.Remove(item);
            }

            return result;
        }
        public bool Comparison(Set other)//сравнение количества элементов множеств
        {
            if (Count > other.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Comparison2(Set other)//сравнение количества элементов множеств
        {
            if (Count < other.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Set operator ++(Set set) => set.Increase();
        public static Set operator +(Set left, Set right) => left.Union(right);
        public static Set operator *(Set left, Set right) => left.Intersection(right);
        public static Set operator /(Set left, Set right) => left.Difference(right);
        public static bool operator >(Set left, Set right) => left.Comparison(right);
        public static bool operator <(Set left, Set right) => left.Comparison2(right);
    }
}