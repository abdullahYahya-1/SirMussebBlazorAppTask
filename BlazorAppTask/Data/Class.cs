using System.ComponentModel.DataAnnotations;

namespace BlazorAppTask.Data
{
    public class Class
    {
        [Key]
        public int Cid { get; set; }
        public string Name { get; set; }
        public string RoomNumber { get; set; }
        public int FacultyID { get; set; }
    }
}
