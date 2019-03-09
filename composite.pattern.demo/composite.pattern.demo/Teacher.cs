using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite.pattern.demo
{
    class Teacher: ITeacher
    {
        private string teacherName;
        private string deptName;
        private List<ITeacher> controls;

        public Teacher(string teacherName, string deptName)
        {
            this.teacherName = teacherName;
            this.deptName = deptName;
            controls = new List<ITeacher>();
        }

        public void Add(Teacher teacher) {
            controls.Add(teacher);
        }

        public void Remove(Teacher teacher) {
            controls.Remove(teacher);
        }

        public List<ITeacher> getControllingDepts() {
            return controls;
        }

        public string getDetails()
        {
            return teacherName + " is the " + deptName;
        }
    }
}
