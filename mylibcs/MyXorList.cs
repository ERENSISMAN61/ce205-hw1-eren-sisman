using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylibcs
{
    public class MyXorList
    {

        public class Node
        {
            public MyData data;
            public Node next;
            public Node prev;
        }

        public Node head;

        public MyXorList()
        {
            head = new Node();
            head.next = head;
            head.prev = head;
        }

        /// <summary>
        /// Add data from starting of list
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public void insertFront(MyData data)
        {
            Node node = new Node();
            node.data = data;
            node.next = head.next;
            node.prev = head;
            head.next.prev = node;
            head.next = node;
        }

        /// <summary>
        /// Add data end of List
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int insertEnd(MyData data)
        {
            Node node = new Node();
            node.data = data;
            node.next = head;
            node.prev = head.prev;
            head.prev.next = node;
            head.prev = node;

            return data.key;
        }
        /// <summary>
        /// Search list end delete data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int removeByKey(MyData data)
        {
            Node node = head.next;
            Node prev = head;
            Node next = head.next.next;
            while (node != head)
            {
                if (node.data.key == data.key)
                {
                    prev.next = next;
                    next.prev = prev;
                    return data.key;
                }
                prev = node;
                node = next;
                next = next.next;
            }
            return -1;
        }

        /// <summary>
        /// Add data after item that have key parameter
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int insertAfter(MyData data, int key)
        {
            Node node = head.next;
            Node prev = head;
            Node next = head.next.next;
            while (node != head)
            {
                if (node.data.key == key)
                {
                    Node newNode = new Node();
                    newNode.data = data;
                    newNode.next = next;
                    newNode.prev = node;
                    node.next = newNode;
                    next.prev = newNode;
                    return data.key;
                }
                prev = node;
                node = next;
                next = next.next;
            }
            return -1;
        }

        /// <summary>
        /// Return list for data array
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public MyData[] list()
        {
            List<MyData> list = new List<MyData>();
            Node node = head.next;
            while (node != head)
            {
                list.Add(node.data);
                node = node.next;
            }
            return list.ToArray();
        }

        /// <summary>
        /// Search list and return data
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public MyData searchByKey(int key)
        {
            Node node = head.next;
            while (node != head)
            {
                if (node.data.key == key)
                {
                    return node.data;
                }
                node = node.next;
            }
            return null;
        }
    }
}
