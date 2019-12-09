namespace SalaryCapGaming.Views.WebViewsModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty( RequestId );
    }
}
