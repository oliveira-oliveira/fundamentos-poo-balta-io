using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();    
        }
        
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
    }
}