using System;
namespace webapi.Models
{
    public class ResponseModel
    {
        public string? UserId { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public string? CSRF_TOKEN { get; set; }
    }
    public class RequestModel
    {
        public string Message { get; set; } = null!;
        public string __RequestVerificationToken { get; set; } = null!;


    }

    public static class Utils
    {
        public static string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}

