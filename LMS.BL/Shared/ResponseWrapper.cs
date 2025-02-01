namespace LMS.BL.Shared
{
    public class ResponseWrapper
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
