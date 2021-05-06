using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {      
            //Instantiate three Student objects.;
            Student alex = new Student { Name = "Alex" };
            Student bob = new Student { Name = "Bob" };
            Student henry = new Student { Name = "Henry" };
            // Instantiate a Course object called Programming with C#.
            Course programming = new Course(" Programming");
            //Add your three students to this Course object.
            programming.AddStudent(alex);
            programming.AddStudent(bob);
            programming.AddStudent(henry);
            // Instantiate at least one Teacher object.
            Teacher gate = new Teacher { Name = "Gate" };
            //Add that Teacher object to your Course object.
            programming.AddTeacher(gate);
            // Instantiate a Degree object, such as Bachelor.
            Degree bachelor = new Degree("Bachelor");
            // Add your Course object to the Degree object.
            bachelor.AddCourse(programming);
            //"Instantiate a UProgram object called Information Technology.";
            UProgram informationTechnology = new UProgram("Information Technology");
            informationTechnology.AddDegree(bachelor);
            Console.WriteLine("The name of the program : {0}", informationTechnology.Name);
            Console.WriteLine("The name of the degree : {0}", bachelor.Name);
            Console.WriteLine("The name of the course in the degree : {0}", programming.Name);
            Console.WriteLine("The count of the number of students in the course : {0}", programming.Students.Count);
            Console.ReadLine();
        }
    }
}
