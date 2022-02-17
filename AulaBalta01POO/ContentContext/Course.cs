using AulaBalta01POO.ContentContext.Enums;
using System.Collections.Generic;

namespace AulaBalta01POO.ContentContext
{
    internal class Course : Content
    {
        public Course(string title, string url) : base(title, url) 
        {
            //sempre iniciar a lista no construtor
            Modules = new List<Module>();        
        }

        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }  
}
