﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regbhas.Models
{
   public interface IListable
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
