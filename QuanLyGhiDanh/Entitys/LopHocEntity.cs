using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("LopHoc")]
    public class LopHocEntity:Entity
    {
        [Key]
        public string maLopHoc { get; set; }
        public string ten { get; set; }
        public int soLuongHocVien { get; set; }
        public int hocPhi { get; set; }
        public string mota { get; set; }
        public string hinhLopHoc { get; set; }
        public virtual ICollection<HocVien_LopHocEntity>? HocVien_LopHocs { get; set; }
        public virtual ICollection<LichHocEntity>? LichHocs { get; set; }
        public virtual ICollection<PhongHoc_LopHocEntity>? PhongHoc_LopHocs { get; set; }
        public virtual ICollection<MonHoc_LopHocEntity>? MonHoc_LopHocs { get; set; }


        [ForeignKey("LichNghi")]
        public string maLich { get; set; }
        public virtual LichNghiEntity? LichNghi { get; set; }

        
    }
}
