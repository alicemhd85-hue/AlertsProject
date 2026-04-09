using System;
using System.Collections.Generic;

namespace AlertsProject.Models
{
    public partial class AlertsTable
    {
        public double? رمزالخطأ { get; set; }
        public string? اسمالخطأ { get; set; }
        public string? نوعالخطأ { get; set; }
        public string? شرحمختصر { get; set; }
        public int Id { get; set; }
    }
}
