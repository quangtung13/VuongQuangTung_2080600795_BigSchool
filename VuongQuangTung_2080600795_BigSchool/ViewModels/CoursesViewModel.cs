using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VuongQuangTung_2080600795_BigSchool.Models;

namespace VuongQuangTung_2080600795_BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}