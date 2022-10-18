using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylibcs
{

    public class SkipList
    {
        private class Node
        {
            public int key;
            public Node[] next;
            public Node(int key, int level)
            {
                this.key = key;
                next = new Node[level];
            }
        }

        private Node head;
        private int level;
        private int maxLevel;
        private Random random;

        public SkipList(int maxLevel)
        {
            this.maxLevel = maxLevel;
            level = 1;
            head = new Node(int.MinValue, maxLevel);
            random = new Random();
        }
        private int randomLevel()
        {
            int lvl = 1;
            while (random.Next(2) == 1 && lvl < maxLevel)
                lvl++;
            return lvl;
        }

        /// <summary>
        /// Add Data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int Insert(MyData data)
        {
            int lvl = randomLevel();
            Node newNode = new Node(data.key, lvl);
            Node[] update = new Node[lvl];
            Node x = head;
            for (int i = lvl - 1; i >= 0; i--)
            {
                while (x.next[i] != null && x.next[i].key < data.key)
                    x = x.next[i];
                update[i] = x;
            }
            x = x.next[0];
            if (x == null || x.key != data.key)
            {
                for (int i = 0; i < lvl; i++)
                {
                    newNode.next[i] = update[i].next[i];
                    update[i].next[i] = newNode;
                }
                if (level < lvl)
                    level = lvl;
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int removeByKey(MyData data, int key)
        {
            Node[] update = new Node[maxLevel];
            Node x = head;
            for (int i = level - 1; i >= 0; i--)
            {
                while (x.next[i] != null && x.next[i].key < key)
                    x = x.next[i];
                update[i] = x;
            }
            x = x.next[0];
            if (x.key == key)
            {
                for (int i = 0; i < level; i++)
                {
                    if (update[i].next[i] != x)
                        break;
                    update[i].next[i] = x.next[i];
                }
                while (level > 1 && head.next[level - 1] == null)
                    level--;
            }
            return 0;
        }

        /// <summary>
        /// Return list for data array
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public MyData[] list()
        {
            MyData[] data = new MyData[0];
            Node x = head.next[0];
            while (x != null)
            {
                Array.Resize(ref data, data.Length + 1);
                data[data.Length - 1] = new MyData(x.key);
                x = x.next[0];
            }
            return data;
        }
        /// <summary>
        /// Search list and return data
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public MyData searchByKey(int key)
        {
            Node x = head;
            for (int i = level - 1; i >= 0; i--)
            {
                while (x.next[i] != null && x.next[i].key < key)
                    x = x.next[i];
            }
            x = x.next[0];
            if (x != null && x.key == key)
                return new MyData(x.key);
            return null;
        }

    }
}
