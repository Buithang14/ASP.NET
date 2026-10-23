namespace Day2_Bui_Ngoc_Thang_KTPMK22A.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string StudentCode { get; set; } = string.Empty;
        public string ClassName { get; set; } = string.Empty;
        public double Gpa { get; set; }
        public string Major { get; set; } = string.Empty;
    }
}
