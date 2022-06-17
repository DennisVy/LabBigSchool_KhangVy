using LabBigSchool_KhangVy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabBigSchool_KhangVy.ViewModels
{
    public class CoursesViewModels
    {
        public string Place { get; set; }
        public string Date { get; set; }

        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime ()
        {
            return DateTime.Parse(string.Format("{0} {1}"));
        }
    }
}