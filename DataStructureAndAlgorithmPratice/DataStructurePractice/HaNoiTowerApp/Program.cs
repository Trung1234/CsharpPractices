using System;

namespace HaNoiTowerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTower(3, 'A', 'B', 'C');
            Console.ReadLine();
        }
        /// <summary>
        /// solve the tower of HaNoi puzzle
        /// </summary>
        /// <param name="N"></param>
        /// <param name="from"></param>
        /// <param name="inner"></param>
        /// <param name="to"></param>
        static void DoTower(int N, char from, char inner, char to)
        {
            if(N == 1)
            {
                Console.WriteLine("Disk 1 from "+from+" to "+to);
            }
            else
            {
                // move N-1 disk from A -> B
                DoTower(N - 1, from, to, inner);
                // move disk N from A -> C
                Console.WriteLine("Disk "+N+" from " + from + " to " + to);
                // move N-1 disk from B -> C
                DoTower(N - 1,inner,from,to);
            }
        } 
    }
}
