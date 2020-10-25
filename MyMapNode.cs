using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class MyMapNode<K,V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

       
        protected int GetPositionInArray(K key)
        {
            return Math.Abs(key.GetHashCode() % size);
        }

        public LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            var linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
              
            }
            return linkedList;
        }

        
        public void Add(K key, V value)
        {
            int position = GetPositionInArray(key);
            var linkedList = GetLinkedList(position);
            var item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        public V Get(K key)
        {
            int position = GetPositionInArray(key);
            var linkedList = GetLinkedList(position);
            foreach (var item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        public void Set(K key, V value)
        {
            int position = GetPositionInArray(key);
            var linkedList = GetLinkedList(position);
            KeyValue<K, V> temp = new KeyValue<K, V>();
            foreach (var item in linkedList)
            {
                if (item.Key.Equals(key))
                    temp = item;
            }
            temp.Value = value;
        }
    }
}
