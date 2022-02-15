using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaBalta01POO.ContentContext
{
    internal class Course : Content
    {
        public Course()
        {
            //sempre iniciar a lista no construtor
            Modules = new List<Module>();        
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }     
    }

    public class Module
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }

    public class Lecture
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
    }
}
