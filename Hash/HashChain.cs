using System;

namespace LearnDSAlgorithms.Hash
{
    public class HashChain
    {
        int hashTableSize = 0;
        LinearLinkedList<int>[] _hashTable;
        public HashChain(int size = 10)
        {
            hashTableSize = size;
            _hashTable = new LinearLinkedList<int>[hashTableSize];
            for (int i = 0; i < hashTableSize; i++)
            {
                _hashTable[i] = new LinearLinkedList<int>();
            }
        }

        int hashCode(int key)
        {
            return key % hashTableSize;
        }
        public void Insert(int elemnt)
        {
            int hash = hashCode(elemnt);
            _hashTable[hash].InsertSorted(elemnt);
        }
        public bool Search(int key)
        {
            int hash = hashCode(key);
            return _hashTable[hash].Search(key) != -1;
        }
        public void Display()
        {
            for (int i = 0; i < hashTableSize; i++)
            {
                Console.Write("[" + i + "]");
                _hashTable[i].Display();
            }
            Console.WriteLine();
        }
    }
}
