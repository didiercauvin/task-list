using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Projects : IEnumerable<Project>
    {
        private IList<Project> _projects = new List<Project>();

        public Projects()
        {
            _projects = new List<Project>();
        }

        public void Add(string name)
        {
            _projects.Add(new Project(name, new List<Task>()));
        }

        public IEnumerator<Project> GetEnumerator()
        {
            return _projects.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
