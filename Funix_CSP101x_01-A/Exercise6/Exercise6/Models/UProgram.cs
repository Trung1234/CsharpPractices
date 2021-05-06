using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    public class UProgram
    {
        public string Name { get; set; }
        public List<Degree> Degrees;

        public UProgram(string name)
        {
            Name = name;
            Degrees = new List<Degree>();
        }
        public void AddDegree(Degree degree)
        {
            Degrees.Add(degree);
        }
    }
}
