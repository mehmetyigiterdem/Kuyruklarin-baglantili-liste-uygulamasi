using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class Queue
{
    private Node Front;
    private Node Rear;

    public Queue()
    {
        Front = null;
        Rear = null;
    }

    public void Enqueue(int data)
    {
        Node newNode = new Node(data);

        if (Rear == null)
        {
            Front = newNode;
            Rear = newNode;
        }
        else
        {
            Rear.Next = newNode;
            Rear = newNode;
        }

        Console.WriteLine("Eleman kuyruğa eklendi: " + data);
    }

    public void Dequeue()
    {
        if (Front == null)
        {
            Console.WriteLine("Kuyruk boş.");
            return;
        }

        int data = Front.Data;
        Front = Front.Next;

        if (Front == null)
        {
            Rear = null;
        }

        Console.WriteLine("Çıkarılan eleman: " + data);
    }

    public void Display()
    {
        if (Front == null)
        {
            Console.WriteLine("Kuyruk boş.");
            return;
        }

        Node current = Front;
        Console.Write("Kuyruk: ");
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();

        while (true)
        {
            Console.WriteLine("Lütfen aşağıdaki işlemlerden birini seçiniz");
            Console.WriteLine("1. Ekle");
            Console.WriteLine("2. Sil");
            Console.WriteLine("3. Görüntüle");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminizi yapın: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Eklenecek elemanı girin: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    queue.Enqueue(data);
                    break;
                case 2:
                    queue.Dequeue();
                    break;
                case 3:
                    queue.Display();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçenek.");
                    break;
            }
        }
    }
}
