﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature2:IEntity
    {
        [Key]
        public int Feature2ID { get; set;}
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
    }
}
