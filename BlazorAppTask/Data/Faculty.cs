using System.ComponentModel.DataAnnotations;

namespace BlazorAppTask.Data
{
    public class Faculty
    {
        [Key]
        public int Fid { get; set; }
        public string Fname { get; set; }
        public int DeptID { get; set; }
        public string Standing { get; set; }
    }
}
