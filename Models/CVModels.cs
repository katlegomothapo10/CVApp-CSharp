using System.ComponentModel.DataAnnotations;

namespace CVApp.Models
{
    public class PersonalInfo
    {
        [Required]
        public string FullName { get; set; } = "Katlego Mothapo";

        [Required]
        public string Title { get; set; } = "Computer Science Student | Digital Marketing & Content Specialist";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "katlegomothapo10@gmail.com";

        [Phone]
        public string Phone { get; set; } = "+27 71 885 9488";

        public string Profile { get; set; } = "Results-driven Computer Science student with proven experience in digital marketing, content creation, and social media management. Skilled in developing creative strategies to boost engagement, grow online communities, and deliver measurable results. Combines a technical foundation with a strong understanding of marketing principles, enabling effective collaboration across creative and technical teams. Experienced in remote collaboration tools such as Slack, Trello, and Google Workspace.";

        public string LinkedIn { get; set; } = "www.linkedin.com/in/katlego-mothapo-435a2b31b";
        public string GitHub { get; set; } = "github.com/MothapoKatlego";
        public string PortfolioUrl { get; set; } = "https://drive.google.com/drive/folders/1KAyVGxSRfpay5SwNiqzv0s0O601X6Uz";
    }

    public class Education
    {
        public int Id { get; set; }
        public string Institution { get; set; } = string.Empty;
        public string Qualification { get; set; } = string.Empty;
        public string Years { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class WorkExperience
    {
        public int Id { get; set; }
        public string Position { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public List<string> Responsibilities { get; set; } = new List<string>();
        public string Achievement { get; set; } = string.Empty;
    }

    public class Skill
    {
        public int Id { get; set; }
        public string Category { get; set; } = string.Empty;
        public List<string> Items { get; set; } = new List<string>();
    }

    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Proficiency { get; set; } = string.Empty;
    }

    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Achievement { get; set; } = string.Empty;
    }

    public class Certification
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Provider { get; set; } = string.Empty;
        public string ExpectedDate { get; set; } = string.Empty;
    }

    public class SocialLink
    {
        public int Id { get; set; }
        public string Platform { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class CVViewModel
    {
        public PersonalInfo PersonalInfo { get; set; } = new PersonalInfo();
        public List<Education> Education { get; set; } = new List<Education>();
        public List<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Language> Languages { get; set; } = new List<Language>();
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<Certification> Certifications { get; set; } = new List<Certification>();
        public List<SocialLink> SocialLinks { get; set; } = new List<SocialLink>();
    }
}