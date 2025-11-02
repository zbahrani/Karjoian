using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Resume
{
    public class ResumeEntity
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public GenderEnum Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public MilitaryServiceStatusEnum MilitaryService { get; set; }
        public MaritalStatusEnum MaritalStatus { get; set; }
        public int? MinSalary { get; set; }
        public int? MaxSalary { get; set; }
        public ICollection<ResumeSkillEntity> ResumeSkills { get; set; } = new List<ResumeSkillEntity>();
    }
}
