namespace DataStructures.myHashTable
{
    public class MyCountingHashTable : MyHashTable<int>
    {
       public MyCountingHashTable(int bucketCount) : base(bucketCount)
        {
            myEqualityComparer = new MyEqualityComparer();
            this.bucketCount = ((bucketCount > 1024) ? bucketCount : 1024);
            this.buckets = new Node[bucketCount];
        }

        public override int Add(string key, int value)
        {
            int hashIndex = myEqualityComparer.GetHashCode(key) % bucketCount;
         

            if (buckets[hashIndex] == null)
            {
                Node newNode = new Node(key, value);
                buckets[hashIndex] = newNode;
              
            }
            else
            {
                while (buckets[hashIndex] != null)
                {
                    if (buckets[hashIndex].Key == key)
                    {
                        buckets[hashIndex].Value++;
                        return 0;
                    }
                    else
                    {
                        buckets[hashIndex] = buckets[hashIndex].Next;
                    }
                  
                }
                Node newNode = new Node(key, value);
                buckets[hashIndex] = newNode;
            }
            
            return 0;
        }
    }
}
