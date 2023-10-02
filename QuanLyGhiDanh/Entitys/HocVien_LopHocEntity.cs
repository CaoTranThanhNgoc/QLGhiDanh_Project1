using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Entitys
{
    [Table("HocVien_LopHoc")]
    public class HocVien_LopHocEntity: Entity
    {
        [ForeignKey("LopHoc")]
        public string maLopHoc { get; set; }
        public virtual LopHocEntity? LopHoc { get; set; }


        [ForeignKey("HocVien")]
        public string maHocVien { get; set; }
        public virtual HocVienEntity? HocVien { get; set; }

        [ForeignKey("BangDiem")]
        public string maDiem { get; set; }
        public virtual BangDiemEntity? BangDiem { get; set; }

        [ForeignKey("HocPhi")]
        public string maPhieuHocPhi { get; set; }
        public virtual HocPhiEntity? HocPhi { get; set; }
    }
}
