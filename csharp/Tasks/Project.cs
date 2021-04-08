using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Project
    {
        public Project(string name, IEnumerable<Task> tasks)
        {
            Name = name;
            Tasks = tasks.ToList();
        }

        public string Name { get; }
        public IList<Task> Tasks { get; }
    }
}
