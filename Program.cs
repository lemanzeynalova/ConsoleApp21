namespace ConsoleApp21
{
   public class Program
   {
        public static void Main()
        {
            MyList<int> myList = new MyList<int>();

            Console.WriteLine($"Capacity: {myList.Capacity}");
            Console.WriteLine($"Count: {myList.Count}");

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            Console.WriteLine("Elements in the list:");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine($"Capacity: {myList.Capacity}");
            Console.WriteLine($"Count: {myList.Count}");

            Console.WriteLine($"Is 3 in the list? {myList.Exists(3)}");

            myList.Remove(3);

            Console.WriteLine($"Is 3 in the list after removal? {myList.Exists(3)}");

            Console.WriteLine("Reversing the list...");
            myList.Reverse();

            Console.WriteLine("Elements in the reversed list:");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine($"Index of 2: {myList.IndexOf(2)}");
            Console.WriteLine($"Last index of 2: {myList.LastIndexOf(2)}");

            myList.Clear();

            Console.WriteLine("Cleared the list. Count: " + myList.Count);
        }
    }
}





