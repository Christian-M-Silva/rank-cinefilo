﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public abstract class Movies : BaseEntity
    {
        public string Name { get; set; }
        public float Assessment { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Comments { get; set; }
    }
}
