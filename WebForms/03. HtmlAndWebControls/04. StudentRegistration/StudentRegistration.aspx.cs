using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace _04.StudentRegistration
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            var fullName = new HtmlGenericControl("h1");
            fullName.InnerText = this.firstName.Value + " " + this.lastName.Value;
            var facultyNumber = new HtmlGenericControl("p");
            facultyNumber.InnerText = "Faculty number: " + this.facultyNumber.Value;
            var university = new HtmlGenericControl("p");
            university.InnerText = "University: " + this.university.Text;
            var specialty = new HtmlGenericControl("p");
            specialty.InnerText = "Specialty: " + this.specialty.Text;
            var courses = new HtmlGenericControl("ul");
            courses.InnerText = "Courses: ";

            foreach (ListItem item in this.courses.Items)
            {
                if (item.Selected)
                {
                    var course = new HtmlGenericControl("li");
                    course.InnerText = item.Text;
                    courses.Controls.Add(course);
                }
            }

            this.result.Controls.Add(fullName);
            this.result.Controls.Add(facultyNumber);
            this.result.Controls.Add(university);
            this.result.Controls.Add(specialty);
            this.result.Controls.Add(courses);
        }
    }
}