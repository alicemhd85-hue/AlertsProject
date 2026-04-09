using System;
using System.Collections.Generic;

namespace AlertsProject.Models
{
    public partial class ErrorAlert
    {
        public int Id { get; set; }
        public string ErrorCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string errorName { get; set; } = null!;
        public string errorType { get; set; } = null!;
    }
}
