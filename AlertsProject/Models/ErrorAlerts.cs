namespace AlertsProject.Models
{
    public class ErrorAlerts
    {
        public int Id { get; set; }
        public string ErrorCode { get; set; }

        public string Errorname { get; set; }
        public string Description { get; set; }
        public string ErrorType { get; set; }
        public string HelpLink { get; set; }
    }
}
