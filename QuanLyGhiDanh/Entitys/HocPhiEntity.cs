using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("HocPhi")]
    public class HocPhiEntity: Entity
    {
        [Key]
        public string maPhieuHocPhi { get; set; }
        public double mucThuHocPhi { get; set; }
        public double giamGia { get; set; }
        public string ghiChu { get; set; }
        public virtual ICollection<HocVien_LopHocEntity>? HocVien_LopHocs { get; set; }
        public virtual ICollection<LoaiHocPhiEntity>? LoaiHocPhis { get; set; }
        
        [ForeignKey("DoanhThu")]
        public string maDoanhThuTheoKy { get; set; }
        public virtual DoanhThuEntity? DoanhThu { get; set; }
    }
}
