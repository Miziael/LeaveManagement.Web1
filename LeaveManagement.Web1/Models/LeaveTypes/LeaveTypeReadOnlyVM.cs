using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web1.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
    {

        
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Maximum number of Days")]
        public int NumberOfDays { get; set; }
    }
}
