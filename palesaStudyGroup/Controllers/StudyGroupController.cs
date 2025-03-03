using palesaStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace palesaStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {    //create a list od all the study group memmbers involved
            var studyGroupMembers = new List<StudyGroupMember>
            {
                new StudyGroupMember { StudentNumber = "u235557509", Name = "Carlton", Surname = "Masara", EmailAddress = "u235557509@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u24892859", Name = "Karen", Surname = "Kumbula", EmailAddress = "u24892859@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u24666492", Name = "Palesa", Surname = "Mokgolobotho", EmailAddress = "u24666492@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u04949872", Name = "Mia", Surname = "Hand", EmailAddress = "u04949872@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u23735831", Name = "Dipuo", Surname = "Ndlala", EmailAddress = "u23735831@tuks.co.za" }
            };
            // take this list to the view(Index)
            return View(studyGroupMembers);
        }
    }
}