using Microsoft.AspNetCore.Mvc;
using CVApp.Models;

namespace CVApp.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            var cvData = GetKatlegoCVData();
            return View(cvData);
        }

        public IActionResult Print()
        {
            var cvData = GetKatlegoCVData();
            return View(cvData);
        }

        private CVViewModel GetKatlegoCVData()
        {
            return new CVViewModel
            {
                PersonalInfo = new PersonalInfo
                {
                    FullName = "Katlego Mothapo",
                    Title = "Computer Science Student | Digital Marketing & Content Specialist",
                    Email = "katlegomothapo10@gmail.com",
                    Phone = "+27 71 885 9488",
                    Profile = "Results-driven Computer Science student with proven experience in digital marketing, content creation, and social media management. Skilled in developing creative strategies to boost engagement, grow online communities, and deliver measurable results. Combines a technical foundation with a strong understanding of marketing principles, enabling effective collaboration across creative and technical teams. Experienced in remote collaboration tools such as Slack, Trello, and Google Workspace.",
                    LinkedIn = "www.linkedin.com/in/katlego-mothapo-435a2b31b",
                    GitHub = "github.com/MothapoKatlego",
                    PortfolioUrl = "https://drive.google.com/drive/folders/1KAyVGxSRfpay5SwNiqzv0s0O601X6Uz"
                },

                Education = new List<Education>
                {
                    new Education
                    {
                        Institution = "IIE MSA",
                        Qualification = "Bachelor of Computer Science (B.C.S)",
                        Years = "2024 - 2026 (Expected)",
                        Description = "Currently pursuing degree in Computer Science"
                    },
                    new Education
                    {
                        Institution = "Hoerskool Drie Riviere",
                        Qualification = "Matric (NSC)",
                        Years = "2019 - 2023"
                    }
                },

                WorkExperiences = new List<WorkExperience>
                {
                    new WorkExperience
                    {
                        Position = "Social Media Manager (Part-time)",
                        Company = "OntrackConnect",
                        Year = "2025",
                        Responsibilities = new List<string>
                        {
                            "Managed Instagram content strategy, designing posts, writing captions, and analyzing performance metrics",
                            "Improved engagement and brand presence through consistent posting and interactive campaigns",
                            "Coordinated schedules and content rollout aligned with company marketing goals"
                        },
                        Achievement = "Increased engagement and brand presence by 40%"
                    },
                    new WorkExperience
                    {
                        Position = "Marketing Assistant (Part-time)",
                        Company = "DermaFix",
                        Year = "2024",
                        Responsibilities = new List<string>
                        {
                            "Produced copywriting material for campaigns, newsletters, and landing pages",
                            "Assisted with product marketing initiatives and coordinated email campaigns",
                            "Supported the marketing team by monitoring analytics and preparing engagement reports"
                        }
                    },
                    new WorkExperience
                    {
                        Position = "Safety & Security Resident Assistant (RA)",
                        Company = "IIE MSA",
                        Year = "2025",
                        Responsibilities = new List<string>
                        {
                            "Managed safety and security protocols for residence, ensuring a secure living environment for 250+ students",
                            "Developed and enforced community guidelines, resolving conflicts and promoting positive resident behavior",
                            "Conducted safety audits and collaborated with campus security to implement risk-reduction measures",
                            "Facilitated resident engagement initiatives, fostering a sense of community and accountability"
                        }
                    },
                    new WorkExperience
                    {
                        Position = "Founder & Social Media Manager",
                        Company = "OurGoatedLunchbox",
                        Year = "2023 - Present",
                        Responsibilities = new List<string>
                        {
                            "Founded a social media brand centered around lifestyle and community engagement",
                            "Increased following through consistent and creative posting"
                        },
                        Achievement = "Increased following by 35% within three months; Organized a food drive providing meals for 15-25 people within 2 weeks"
                    }
                },

                Skills = new List<Skill>
                {
                    new Skill
                    {
                        Category = "Social Media & Marketing",
                        Items = new List<string>
                        {
                            "Social Media Management & Strategy",
                            "Content Creation & Copywriting (Canva)",
                            "Digital Marketing & Paid Ads",
                            "Community Management & Engagement",
                            "Analytics & Insights (Google Analytics, Instagram Insights, TikTok Insights)"
                        }
                    },
                    new Skill
                    {
                        Category = "Programming",
                        Items = new List<string>
                        {
                            "Java", "C#", "SQL", "HTML", "CSS", "Delphi"
                        }
                    },
                    new Skill
                    {
                        Category = "Tools",
                        Items = new List<string>
                        {
                            "VS Code", "GitHub", "MySQL", "Visual Studio",
                            "Canva", "Adobe Creative Suite", "Squarespace", "Meta Business Suite"
                        }
                    }
                },

                Languages = new List<Language>
                {
                    new Language { Name = "English", Proficiency = "Fluent/Native" },
                    new Language { Name = "Afrikaans", Proficiency = "Intermediate" },
                    new Language { Name = "Sepedi", Proficiency = "Fluent" }
                },

                Projects = new List<Project>
                {
                    new Project
                    {
                        Name = "E-Commerce Marketing Campaign",
                        Year = "2023",
                        Description = "Created and managed TikTok and Instagram ad campaigns for e-commerce personal skincare brand",
                        Achievement = "Generated R6,000 in a month"
                    },
                    new Project
                    {
                        Name = "Personal Portfolio Website",
                        Year = "2023",
                        Description = "Designed a responsive Squarespace/HTML portfolio site for content creators; integrated analytics and SEO optimization"
                    }
                },

                Certifications = new List<Certification>
                {
                    new Certification { Name = "Google Digital Marketing & E-Commerce", Provider = "Google", ExpectedDate = "Oct. 2025" },
                    new Certification { Name = "HubSpot Social Media Marketing Certification", Provider = "HubSpot", ExpectedDate = "Oct. 2025" },
                    new Certification { Name = "Introduction to SQL", Provider = "Sololearn", ExpectedDate = "Oct. 2025" },
                    new Certification { Name = "Intro to Cybersecurity", Provider = "Cisco Networking Academy", ExpectedDate = "Oct. 2025" }
                },

                SocialLinks = new List<SocialLink>
                {
                    new SocialLink { Platform = "LinkedIn", Url = "www.linkedin.com/in/katlego-mothapo-435a2b31b" },
                    new SocialLink { Platform = "GitHub", Url = "github.com/MothapoKatlego" },
                    new SocialLink { Platform = "OurGoatedLunchbox", Url = "www.tiktok.com/@ourgoatedlunchbox", Description = "Social Media Brand" },
                    new SocialLink { Platform = "Personal Branding", Url = "www.tiktok.com/@katlegounfiltered", Description = "Personal Social Media" }
                }
            };
        }
    }
}