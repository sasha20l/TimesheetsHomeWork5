﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Models.Request
{
    public class CreateDepartmentRequest
    {
        public int Id { get; set; }

        public string Description { get; set; }
    }
}
