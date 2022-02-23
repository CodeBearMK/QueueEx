using System.Collections;

namespace QueueEx
{
    class Program
    {

        public static void Printout(Queue q)
        {
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Queue QName = new Queue();
            string[] aryName = { "David", "Tom", "Jack", "Mary", "Bob" };
            for (int i = 0; i < aryName.Length; i++)
            {
                QName.Enqueue(aryName[i]); //由 QName 物件尾部加入一個元素
            }

            // 原始資料
            Console.WriteLine("Queue 原始資料, 元素共計：{0}", QName.Count);
            Console.Write("\t");
            foreach (var item in QName)
            {
                Console.Write("{0}\t", item);
            }

            Console.WriteLine("\n");

            // 從最前面移除一個元素
            QName.Dequeue();

            // 移除一個元素後
            Console.WriteLine("Queue 移除一個資料, 元素共計：{0}", QName.Count);
            Console.Write("\t");
            foreach (var item in QName)
            {
                Console.Write("{0}\t", item);
            }

            Console.WriteLine("\n");

            // 顯示最前面第一個資料
            Console.WriteLine("Queue 顯示最前面第一個資料：{0}", QName.Peek());

            Console.WriteLine("\n");

            // 清除所有元素
            QName.Clear();

            // 移除所有元素後
            Console.Write("Queue 移除所有資料, 元素共計：{0}", QName.Count);
            Console.Read();
        }
    }
}