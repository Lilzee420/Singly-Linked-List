using System.Diagnostics.Eventing.Reader;

namespace Linked_List
{
    public partial class Form1 : Form
    {
        LinkedList myList = new LinkedList();
        String text;
        int num;

        public Form1()
        {
            InitializeComponent();
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num = myList.convert(textBox1.Text);
            myList.AddFirst(num);
            richTextBox1.Text = myList.PrintList(text);
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num = myList.convert(textBox1.Text);
            myList.AddLast(num);
            richTextBox1.Text = myList.PrintList(text);
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myList.Arrange();
            richTextBox1.Text = myList.PrintList(text);
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = myList.convert(textBox1.Text);
            myList.AddSorted(num);
            richTextBox1.Text = myList.PrintList(text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            myList.RemoveFirst();
            richTextBox1.Text = myList.PrintList(text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myList.RemoveLast();
            richTextBox1.Text = myList.PrintList(text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myList.Clear();
            richTextBox1.Text = myList.PrintList(text);
            button4.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            myList.Reverse();
            richTextBox1.Text = myList.PrintList(text);
            button4.Enabled = false;
        }

        public class Node
        {
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }

        public class LinkedList
        {
            public Node head;

            public LinkedList()
            {
                head = null;
            }

            // this adds a data to the beginning of the list
            public void AddFirst(int value)
            {
                Node newNode = new Node(value);
                newNode.Next = head;
                head = newNode;
            }

            // this adds a data to the end of the list
            public void AddLast(int value)
            {
                Node newNode = new Node(value);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }

            // this arranges the data numerically (lowest to highest)
            public void Arrange()
            {
                if (head == null || head.Next == null)
                {
                    return;
                }

                bool swapped;
                do
                {
                    swapped = false;
                    Node current = head;
                    Node prev = null;

                    while (current != null && current.Next != null)
                    {
                        if (current.Value > current.Next.Value)
                        {
                            Node temp = current.Next;
                            current.Next = temp.Next;
                            temp.Next = current;

                            if (prev == null)
                            {
                                head = temp;
                            }
                            else
                            {
                                prev.Next = temp;
                            }

                            swapped = true;
                        }

                        prev = current;
                        current = current.Next;
                    }
                } while (swapped);
            }

            // this adds a data in a sorted manner numerically (lowest to highest)
            public void AddSorted(int data)
            {
                Node newNode = new Node(data);
                Node current = head;

                if (head == null)
                {
                    head = newNode;
                    return;
                }

                if (current.Value >= data)
                {
                    AddFirst(data);
                    return;
                }

                while (current.Next != null)
                {
                    if (current.Next.Value >= data)
                    {
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        return;
                    }
                    current = current.Next;
                }

                AddLast(data);
            }

            // this will reverse the linked list
            public void Reverse()
            {
                if (head == null || head.Next == null)
                {
                    return;
                }

                Node prev = null;
                Node current = head;
                Node next = null;

                while (current != null)
                {
                    next = current.Next;
                    current.Next = prev;
                    prev = current;
                    current = next;
                }

                head = prev;
            }

            // this removes the first node from the list
            public void RemoveFirst()
            {
                if (head != null)
                {
                    head = head.Next;
                }
            }

            // this removes the last node from the list
            public void RemoveLast()
            {
                if (head == null || head.Next == null)
                {
                    head = null;
                }
                else
                {
                    Node current = head;
                    while (current.Next.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                }
            }

            // this clears the whole linked list
            public void Clear()
            {
                head = null;
            }

            // this outputs the linked list
            public String PrintList(String text)
            {
                Node current = head;

                while (current != null)
                {
                    text = text + current.Value + " ";
                    current = current.Next;
                }
                return text;
            }

            // this converts the user input to an integer
            public int convert(String text)
            {
                int num = Convert.ToInt32(text);
                return num;
            }
        }
    }
}
