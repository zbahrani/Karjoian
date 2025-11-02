using Domain.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Resume
{
    public class SkillEntity
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public SkillLevelEnum SkillLevel { get; set; }
        public ICollection<ResumeSkillEntity> ResumeSkills { get; set; } = new List<ResumeSkillEntity>();



    }
}
