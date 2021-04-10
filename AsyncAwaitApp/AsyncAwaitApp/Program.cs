using AsyncAwaitApp.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncAwaitApp
{
    class Program
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static async Task Main(string[] args)
        {
            //1. Pour a cup of coffee.
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            //The asynchronously prepared breakfast took roughly 20 minutes, this time savings is because some tasks ran concurrently.
            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            //var eggs = await eggsTask;
            //Console.WriteLine("eggs are ready");

            //var bacon = await baconTask;
            //Console.WriteLine("bacon is ready");

            //var toast = await toastTask;
            //Console.WriteLine("toast is ready");
            // WhenAll, which returns a Task that completes when all the tasks in its argument list have completed, 
            //await Task.WhenAll(eggsTask, baconTask, toastTask);
            //Console.WriteLine("eggs are ready");
            //Console.WriteLine("bacon is ready");
            //Console.WriteLine("toast is ready");

            //use WhenAny to await the first task to finish and then process its resul
            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finishedTask == toastTask)
                {
                    Console.WriteLine("toast is ready");
                }
                //After processing the result from the completed task, 
                //you remove that completed task from the list of tasks
                breakfastTasks.Remove(finishedTask);
            }
            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        //private static async Task<Toast> ToastBreadAsync(int slices)
        //{
        //    for (int slice = 0; slice < slices; slice++)
        //    {
        //        Console.WriteLine("Putting a slice of bread in the toaster");
        //    }
        //    Console.WriteLine("Start toasting...");
        //    await Task.Delay(2000);
        //    Console.WriteLine("Fire! Toast is ruined!");
        //    throw new InvalidOperationException("The toaster is on fire");
        //    await Task.Delay(1000);
        //    Console.WriteLine("Remove toast from toaster");

        //    return new Toast();
        //}

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}
