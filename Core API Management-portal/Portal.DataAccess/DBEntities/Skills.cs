﻿using DitsPortal.DataAccess.Base.DBEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DitsPortal.DataAccess.DBEntities
{
    public class Skills: BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SkillId { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string SkillName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Description { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Rating { get; set; }
    }
}
