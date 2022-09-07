using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleLinkedList.DLinkedLists
{
    class SLinkedList
    {
        CustomNode head;
        CustomNode current;
        CustomNode temp;
        public string data;
        int nodeCount;
        List<string> nextlist;

        //adds to the end
        public void appendNode(string data)
        {
            // if the list is empty make a node call it head
            if(head == null)
            {
                head = new CustomNode(data);
                nodeCount++;
                return;
            }

            current = head;

            //loops till it is not null and addsa node, if null, reached the tail
            while (current.Next!=null)
            {
                    current = current.Next;   
            }

            
            current.Next = new CustomNode(data);
            temp = current; //temp node we creating equals to current
            current = current.Next;//created a next node while storing the temp value
            current.Prev = temp;
            
        }

        //adds to the front
        public void prepend(string data)
        {
            if (head == null)
            {
                head=new CustomNode(data);
                nodeCount++;
            }

            else
            {
                CustomNode newHead = new CustomNode(data);
                nodeCount++;
                newHead.Next = head;
                head.Prev = newHead;//checks previous node and adds it  - links the two 
                head = newHead;
               


            }


        }

        public void deteleWithData(string data)
        {
            //Check if the list exists 
            if (head==null)
            {
                Console.WriteLine("Cannot delete a value from an empty list");
                return;
            }

            //2 what if the head contains the data we need to delete

            if (head.data.Equals(data))
            {
                head = head.Next;
                head.Prev = null;//as a head dont need a prev
            }

            // if the node we want to delete is not the head, we need to walk the list
            
            //set the head to current walk the list
            current=head;

            while (current.Next!=null)
            {
                if (current.Next.data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    temp = current; //temp node we creating equals to current
                    current = current.Next;//created a next node while storing the temp value
                    current.Prev = temp;//temp then goes to next node
                    Console.WriteLine( "Node with data" + data + " delted");
                }

                current = current.Next;

            }

            Console.WriteLine( "Could not delete data , data not present in list");
            //if the data does not match- check the next element
           
        }

        public void applyProfanityFilter(string data)
        {

            if (head == null)
            {
                Console.WriteLine( "No list to clean ");
                return;
            }

            

            if (head.data.Contains(data))
            {
                string replaceString = head.data.Replace(data,"*****");
                head.data = replaceString;
                Console.WriteLine(head.data);
                
  
            }

            current =head;

            while (current.Next!=null)
            {
                current = current.Next;
                if (current.data.Contains(data))
                {
                    string replaceString = current.data.Replace(data, "*****");
                    current.data = replaceString;
                    Console.WriteLine(current.data);
                 
                }
            }

            Console.WriteLine( "No swearwords in here !");

        }

        public void insertAfter(string nodeData,string searchData)
        {
            if (head == null)
            {
                Console.WriteLine( "There is no list");
            }

            if(head.data.Contains(searchData))
            {
                CustomNode insertNode = new CustomNode(nodeData);
                insertNode.Next = head.Next;
                insertNode.Prev = head;
                head.Next.Prev = insertNode;
                head.Next = insertNode;

                
            }

            //Dealing with the current
            current = head;

            while (current.Next != null)
            {
                current = current.Next;
                if (current.data.Contains(searchData))
                {
                    CustomNode insertNode = new CustomNode(nodeData);
                    insertNode.Next = current.Next;
                    insertNode.Prev = current;
                    current.Next.Prev = insertNode;
                    current.Next = insertNode;

                }
            }


        }

        public List<string> showNext()
        {
            nextlist = new List<string>();
            current = head;

            nextlist.Add(current.data);

            while (current.Next != null)
            {

                nextlist.Add(current.Next.data);
                current = current.Next;

            }



            return nextlist;

        }


    }

    

}
