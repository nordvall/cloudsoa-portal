﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSOA.NetPortal.Web.Models
{
    public class ToDoItemViewModel
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Text")]
        public string text { get; set; }

        public string updated_by { get; set; }

        public DateTimeOffset updated_at { get; set; }
    }
}
