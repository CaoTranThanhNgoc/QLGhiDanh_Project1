using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("LoaiHocPhi")]
    public class LoaiHocPhiEntity: Entity
    {
        [Key]
        public string maLoaiHocPhi { get; set; }
        public string tenLoaiHocPhi { get; set; }

        [ForeignKey("HocPhi")]
        public string maPhieuHocPhi { get; set; }
        public virtual HocPhiEntity? HocPhi { get; set; }
    }
}
