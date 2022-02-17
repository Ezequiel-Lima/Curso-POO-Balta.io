using AulaBalta01POO.ContentContext.Enums;

namespace AulaBalta01POO.ContentContext
{
    public class Lecture : Base
    {
        public Lecture()
        {
        }

        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}
