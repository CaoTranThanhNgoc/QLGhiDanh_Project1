using QuanLyGhiDanh.Entitys;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Models
{
    public class TinhLuongModel
    {
        public string maNhanVien { get; set; }
        public double phanTramLuongGiangVien { get; set; }
        public double thucLanh { get; set; }
        public double tongLuong { get; set; }
    }
}
