using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("PhongHoc_LopHoc")]
    public class PhongHoc_LopHocEntity: Entity
    {
        [ForeignKey("LopHoc")]
        public string maLopHoc { get; set; }
        public virtual LopHocEntity? LopHoc { get; set; }


        [ForeignKey("PhongHoc")]
        public string maPhong { get; set; }
        public virtual PhongHocEntity? PhongHoc { get; set; }
    }
}
