using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("PhongHoc")]
    public class PhongHocEntity: Entity
    {
        [Key]
        public string maPhong { get; set; }
        public string tenPhong { get; set; }        
        public string trangThietBi { get; set; }
        public virtual ICollection<PhongHoc_LopHocEntity>? PhongHoc_LopHocs { get; set; }

    }
}
