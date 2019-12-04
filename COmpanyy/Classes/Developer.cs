using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmpanyy
{
    class Developer:Person
    {
        public State ProjectState { get; set; }
        private string projectName;
        public string ProjectName
        {
            get => projectName;
            set => projectName = value;
        }
        private DateTime projectStartDate;
        public DateTime ProjectStartDate
        {
            get
            {
                return this.projectStartDate;
            }
            set
            {
                projectStartDate = value;
            }
        }

        

        public Developer()
        { }
        public Developer(string projectName, DateTime projectStartDate, State projectState):base()
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.ProjectState = projectState;
        }
        public override string ToString()
        {
            return $"{Name} {LastName} {ProjectName}, which start at {projectStartDate}, project state is` {ProjectState}";

        }
        //public int Salary
        //{
        //    get => throw new NotImplementedException();
        //    set => throw new NotImplementedException();
        //}
        //public string Departments
        //{
        //    get => throw new NotImplementedException();
        //    set => throw new NotImplementedException();
        //}

    }
}