﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web1.Models.LeaveTypes
{
    public class LeaveTypeCreateVM 
    {
        [Required]
        [Length(4,150, ErrorMessage ="You have violated the length requirements")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1,90)]
        [Display(Name = "Maximum number of Days")]
        public int NumberOfDays { get; set; }
    }

}
