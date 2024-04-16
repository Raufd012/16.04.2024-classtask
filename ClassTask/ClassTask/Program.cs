using ClassTask.Exceptions;
using ClassTask.Models;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test test = new Test();
            //test[0] = 11;
            //test[1] = 32;
            //test[2] = 23;
            //test[3] = 45;
            //test[11] = 46;
            //for (int i = 0; i < test.Length; i++) 

            //{
            //    Console.WriteLine(test[i]);
            //}
            //Test t = new Test();
            //foreach (var item in typeof(Test).GetProperties())
            //{
            //    Console.WriteLine(item.Name);
            //}
            //foreach (var item in typeof(Test).GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
            //{
            //    Console.WriteLine(item.Name);
            //}

            do
            {
                Console.WriteLine("adi daxil edin:");

                string name = Console.ReadLine();

                try
                {

                    Person person = new Person(name);
                    Console.WriteLine(person.Name);

                    break;

                }
                catch (CheckNameException ex)
                {
                    Console.WriteLine("ad duzgun daxil edilmiyib");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            } while (true);


        }
    }
    class Test
    {
        //public int[] arr { get;  }
        //public int Length => arr.Length;

        //public Test()
        //{
        //    arr = new int[10];
        //}
        //public int this[int i]
        //{
        //    get
        //    {
        //        return arr[i];
        //    }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentException("sifirdan kicik ola bilmez");
        //        }
        //        if (i >= arr.Length)
        //        {
        //            throw new IndexOutOfRangeException("arrayin serhedii kecmisiz");
        //        }
        //        arr[i] = value;
        //    }
        //}

    }
}
