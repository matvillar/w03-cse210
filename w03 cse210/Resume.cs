using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace w03_cse210
{
    public class Resume
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();


        public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }     
    }
   


}