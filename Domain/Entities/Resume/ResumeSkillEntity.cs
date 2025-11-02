using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Resume
{
    public class ResumeSkillEntity
    {
        public int ResumeId { get; set; }
        public ResumeEntity? Resume { get; set; }

        public int SkillId { get; set; }
        public SkillEntity? Skill { get; set; }

    }
}
