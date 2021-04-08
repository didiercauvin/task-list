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

        public Projects(IDictionary<string, IList<Task>> projectsMap)
        {
            _projects = projectsMap.Select(x => new Project(x.Key, x.Value)).ToList();
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
