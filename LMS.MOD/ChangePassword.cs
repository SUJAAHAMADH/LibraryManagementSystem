namespace LMS.MOD
{
    public class ChangePassword
    {
        public int UserID { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public int CreatedBy { get; set; }
    }
}
