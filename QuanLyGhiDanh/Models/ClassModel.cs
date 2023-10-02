using System.ComponentModel.DataAnnotations;

namespace QuanLyGhiDanh.Models
{
    public class ClassModel
    {
        [Key]
        public string idClass { get; set; }       
        public string nameClass { get; set; }
        public int quantityStudent { get; set; }
        public int tuitionClass { get; set; }
        public string descriptionClass { get; set; }
        public string imageClass { get; set; }

        // niên khóa
        // khoa-khối



    }
}
