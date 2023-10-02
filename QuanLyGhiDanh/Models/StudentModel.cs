using System.ComponentModel.DataAnnotations;

namespace QuanLyGhiDanh.Models
{
    public class StudentModel
    {
        [Key]
        public int idStudent { get; set; }
        public string lastName { get; set; }
        public string nameStudent { get; set; }
        public DateTimeOffset dateOfBirthStudent { get; set; }
        public bool genderStudent { get; set; }
        public string emailStudent { get; set; }
        public int phoneStudent { get; set; }
        public string addressStudent { get; set; }
        public string fullnameParent { get; set; }        
        public string passWordStudent { get; set; }
        public string imageStudent { get; set; }

        // lớp
    }
}
