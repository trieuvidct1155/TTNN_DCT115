﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebASP.Models
{
    public class DistrictModel
    {
        public int ID { set; get; }
        [Display(Name = "Quận/ Huyện")]
        public string Name { set; get; }
        public int ProvinceID { set; get; }
    }
}