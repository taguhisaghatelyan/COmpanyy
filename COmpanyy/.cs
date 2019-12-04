using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmpanyy
{
    interface IDeveloper
    {
        //holds a set of projects. 
        //A project holds project name, project start date, 
        //detailsand a project state(open or closed).
        string ProjectName { get; set; }
        DateTime ProjectStartDate { get; set; }
        string ProjectState { get; set; }
    }
}
