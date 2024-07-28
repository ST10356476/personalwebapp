using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

public class IndexModel : PageModel
{
    public string Name { get; set; } = "Phalanndwa Munyai";
    public string Profession { get; set; } = "Incoming Software Engineering Fellowship|Computer and Information Science Tutor";
    public string AboutMe { get; set; } = "I'm an enthusiastic student with a keen interest in the world of computer science and information technology. My educational journey has been a thrilling exploration of the ever-evolving digital landscape. While I'm still in the process of acquiring proficiency in programming languages like Java, C#, Python, and C++, I'm deeply committed to honing my skills and mastering these powerful tools.\r\n\r\nMy dedication to learning extends beyond the classroom, as I actively seek opportunities to enhance my knowledge and gain practical experience. I'm drawn to challenging projects and enjoy immersing myself in coding challenges and problem-solving exercises. I firmly believe that continuous learning is the key to staying relevant in the tech industry.\r\n\r\nAs I embark on this exciting journey of mastering new programming languages, I'm eager to connect with peers, mentors, and professionals who can share their insights and experiences. I'm motivated to contribute to the tech community, collaborate on projects, and collectively shape the future of technology.";
    public List<Job> Experience { get; set; } = new List<Job>
    {
        new Job { Title = "ICT Manager", Company = "Lordwick ICT Center", Description = "Responsible for overseeing the ICT infrastructure and ensuring that the center's technological resources are up-to-date and effectively utilized." },
        new Job { Title = "Incoming Software Engineering Fellowship", Company = "Headstarter AI", Description = "Career Development" },
        new Job { Title = "Computer and Information Science Tutor", Company = "The IIE's Varsity College Pretoria", Description = "Tutoring 1st year Computer and Information Sciences students who are struggling with programming basics and concepts while offering them support with problem solving skills." }
    };
    public List<Project> Projects { get; set; } = new List<Project>
    {
        new Project { Name = "Lordwick ICT Center", Description = "Developed the center's Website." },
        new Project { Name = "Home Based Care", Description = "Compiled and drafted a business plan for them that secured them funding." }
    };

    public class Job
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
    }

    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
