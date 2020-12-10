namespace Tccp.Domain.Errors
{
    public class CustomAPIException
    {
        public CustomAPIException(int statusCode, string message = null, string details = null)
        {
            this.statusCode = statusCode;
            this.message = message;
            this.details = details;
        }

        public int statusCode { get; set; }
        public string message { get; set; }
        public string details { get; set; }
    }
}
