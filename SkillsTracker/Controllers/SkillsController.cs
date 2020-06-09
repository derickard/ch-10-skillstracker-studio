using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        [HttpGet]
        public IActionResult Skills()
        {
            return Content("<h1>Skills Tracker</h1>" +
                "<h2>Coding skills to learn:</h2>" +
                "<table style='text-align:left>;'" +
                    "<tr>" +
                        "<th>Priority</th>" +
                        "<th>Language</th>" +
                    "</tr>" +
                    "<tr>" +
                        "<th>1</th>" +
                        "<th>C#</th>" +
                    "</tr>" +
                    "<tr>" +
                        "<th>2</th>" +
                        "<th>JavaScript</th>" +
                    "</tr>" +
                    "<tr>" +
                        "<th>3</th>" +
                        "<th>C++</th>" +
                    "</tr>" +
                "</table>","text/html");
        }

        [HttpGet("form")]
        public IActionResult SkillsForm()
        {
            return Content("<form method='post' action='/skills/tracker'>" +
                "<label for='date'>Date:</label><input type='date' id='date' name='date'><br>" +
                "<label for='csharp'>C#:</label>" +
                "<select id='csharp' name='csharp'>" +
                    "<option value='noob'>What is this</option>" +
                    "<option value='beginner'>I can do Hello World</option>" +
                    "<option value='learner'>I can copy and paste from Google</option>" +
                    "<option value='intermediate'>I can do Code Wars</option>" +
                    "<option value='advanced'>I can answer questions on StackOverflow</option>" +
                    "<option value='expert'>I can do anything</option>" +
                "</select><br>" +
                "<label for='javascript'>JavaScript:</label>" +
                "<select id='javascript' name='javascript'>" +
                    "<option value='noob'>What is this</option>" +
                    "<option value='beginner'>I can do Hello World</option>" +
                    "<option value='learner'>I can copy and paste from Google</option>" +
                    "<option value='intermediate'>I can do Code Wars</option>" +
                    "<option value='advanced'>I can answer questions on StackOverflow</option>" +
                    "<option value='expert'>I can do anything</option>" +
                "</select><br>" +
                "<label for='cpp'>C++:</label>" +
                "<select id='cpp' name='cpp'>" +
                    "<option value='noob'>What is this</option>" +
                    "<option value='beginner'>I can do Hello World</option>" +
                    "<option value='learner'>I can copy and paste from Google</option>" +
                    "<option value='intermediate'>I can do Code Wars</option>" +
                    "<option value='advanced'>I can answer questions on StackOverflow</option>" +
                    "<option value='expert'>I can do anything</option>" +
                "</select><br>" +
                "<input type='submit' value='Submit'>" +
                "</form>", "text/html");
        }

        [HttpPost("tracker")]
        public IActionResult SkillsTracker(string date, string csharp, string javascript, string cpp)
        {
            return Content($"<h1>{date}</h1>" +
                "<table>" +
                    "<tr>" +
                        "<th>Priority</th>" +
                        "<th>Language</th>" +
                        "<th>Progress</th>" +
                    "</tr>" +
                    "<tr>" +
                        "<th>1</th>" +
                        "<th>C#</th>" +
                        $"<th>{csharp}</th>" +
                    "</tr>" +
                    "<tr>" +
                        "<th>2</th>" +
                        "<th>JavaScript</th>" +
                        $"<th>{javascript}</th>" +
                    "</tr>" +
                    "<tr>" +
                        "<th>3</th>" +
                        "<th>C++</th>" +
                        $"<th>{cpp}</th>" +
                    "</tr>" +
                "</table>", "text/html");
        }
    }
}
