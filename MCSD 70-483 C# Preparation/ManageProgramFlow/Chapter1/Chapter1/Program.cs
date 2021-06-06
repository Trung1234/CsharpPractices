using System;
using System.Threading;

namespace Chapter1
{
    class Program
    {
        public static void Section1ThreadMethod()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Section2ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void Section3ThreadMethod(object o)
        {
            for (int i = 0; i < (int) o; i++)
            {
                Console.WriteLine("ThreadProc {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void ExecuteSection1()
        {
            Thread thread = new Thread(new ThreadStart(Section1ThreadMethod));
            thread.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Do some work.");
                Thread.Sleep(0);
            }
            //It is used to signal to Windows that this thread is finished. 
            thread.Join();
        }

        public static void ExecuteSection2()
        {
            Thread thread = new Thread(new ThreadStart(Section2ThreadMethod));
            //If you run this application with the IsBackground property set to true,
            //the application exits immediately.
            thread.IsBackground = true;
            thread.Start();
        }

        public static void ExecuteSection3()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(Section3ThreadMethod));
            // the value 5 is passed to the ThreadMethod as an object
            thread.Start(5);
            thread.Join();
        }

        public static void ExecuteSection4()
        {
            bool stopped = false;
            // The thread is initialized with a lambda expression
            Thread thread = new Thread(new ThreadStart(()=>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));
            thread.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            // The thread keeps running until stopped becomes true. 
            stopped = true;
            //Join() causes the console application to wait till the thread finishes execution
            thread.Join();
        }

        /// <summary>
        /// By marking a field with the
        /// ThreadStatic attribute, each thread gets its own copy of a field
        /// </summary>
        [ThreadStatic]
        public static int _staticField;
        public static void ExecuteSection5()
        {
            // With the ThreadStaticAttribute applied, the maximum value of _field becomes 10. 
            // If you remove it, you can see that both threads access the same value and it becomes 20.
            new Thread(() =>
            {
                for(int x = 0; x < 10; x++)
                {
                    _staticField++;
                    Console.WriteLine("Thread A: {0}", _staticField);
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _staticField++;
                    Console.WriteLine("Thread B: {0}", _staticField);
                }
            }).Start();
            
            Console.ReadKey();
        }

        /// <summary>
        /// use local data in a thread and initialize it for each thread
        /// </summary>
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });

        public static void ExecuteSection6()
        {
            //ThreadLocal<T> class takes a delegate to a method that initializes the value. 
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();
            new Thread(() =>
            {
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            ExecuteSection6();
        }
    }
}
