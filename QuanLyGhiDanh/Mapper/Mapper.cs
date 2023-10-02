using AutoMapper;
using QuanLyGhiDanh.Entitys;
using QuanLyGhiDanh.Models;

namespace QuanLyGhiDanh.Mapper
{
    public class Mapper: Profile
    {
        public Mapper()
        {
            BangDiemMapper();
            ChucVuMapper();
            DoanhThuMapper();
            GiangVien_MonHocMapper();
            GiangVienMapper();
            HocPhiMapper();
            HocVien_LopHocMapper();
            HocVienMapper();
            KhoaDaoTaoMapper();
            KhoaKhoiMapper();
            LichGiangDayMapper();
            LichHocMapper();
            LichNghiMapper();
            LienHeMapper();
            LoaiDiem_MonHocMapper();
            LoaiDiemMapper();
            LoaiHocPhiMapper();
            LopHocMapper();
            MonHoc_KhoaDaoTaoMapper();
            MonHoc_LopHocMapper();
            MonHocMapper();
            NguoiDungMapper();
            NhanVienMapper();
            PhanCongGiangDayMapper();
            PhongHoc_LopHocMapper();
            PhongHocMapper();
            PhuCapMapper();
            TinhLuongMapper();
            ToBoMonMapper();

        }
        private void BangDiemMapper()
        {
            //CreateMap<BangDiemModel, BangDiemEntity>().ReverseMap();
            CreateMap<BangDiemEntity, BangDiemModel>().ReverseMap();
        }
        private void ChucVuMapper()
        {
            CreateMap<ChucVuModel, ChucVuEntity>().ReverseMap();
        }
        private void DoanhThuMapper()
        {
            CreateMap<DoanhThuModel, DoanhThuEntity>().ReverseMap();
        }
        private void GiangVien_MonHocMapper()
        {
            CreateMap< GiangVien_MonHocModel, GiangVien_MonHocEntity > ().ReverseMap();
        }
        private void GiangVienMapper()
        {
            CreateMap<GiangVienModel, GiangVienEntity>().ReverseMap();
        }
        private void HocPhiMapper()
        {
            CreateMap<HocPhiModel, HocPhiEntity>().ReverseMap();
        }
        private void HocVien_LopHocMapper()
        {
            CreateMap<HocVien_LopHocModel, HocVien_LopHocEntity>().ReverseMap();
        }
        private void HocVienMapper()
        {
            CreateMap<HocVienModel, HocVienEntity>().ReverseMap();
        }
        private void KhoaDaoTaoMapper()
        {
            CreateMap<KhoaDaoTaoModel, KhoaDaoTaoEntity>().ReverseMap();
        }
        private void KhoaKhoiMapper()
        {
            CreateMap<KhoaKhoiModel, KhoaKhoiEntity>().ReverseMap();
        }
        private void LichGiangDayMapper()
        {
            CreateMap<LichGiangDayModel, LichGiangDayEntity>().ReverseMap();
        }
        private void LichHocMapper()
        {
            CreateMap<LichHocModel, LichHocEntity>().ReverseMap();
        }
        private void LichNghiMapper()
        {
            CreateMap<LichNghiModel, LichNghiEntity>().ReverseMap();
        }
        private void LienHeMapper()
        {
            CreateMap<LienHeModel, LienHeEntity>().ReverseMap();
        }
        private void LoaiDiem_MonHocMapper()
        {
            CreateMap<LoaiDiem_MonHocModel, LoaiDiem_MonHocEntity>().ReverseMap();
        }
        private void LoaiDiemMapper()
        {
            CreateMap<LoaiDiemModel, LoaiDiemEntity>().ReverseMap();
        }
        private void LoaiHocPhiMapper()
        {
            CreateMap<LoaiHocPhiModel, LoaiHocPhiEntity>().ReverseMap();
        }
        private void LopHocMapper()
        {
            CreateMap<LopHocModel, LopHocEntity>().ReverseMap();
        }
        private void MonHoc_KhoaDaoTaoMapper()
        {
            CreateMap<MonHoc_KhoaDaoTaoModel, MonHoc_KhoaDaoTaoEntity>().ReverseMap();
        }
        private void MonHoc_LopHocMapper()
        {
            CreateMap<MonHoc_LopHocModel, MonHoc_LopHocEntity>().ReverseMap();
        }
        private void MonHocMapper()
        {
            CreateMap<MonHocModel, MonHocEntity>().ReverseMap();
        }
        private void NguoiDungMapper()
        {
            CreateMap<NguoiDungModel, NguoiDungEntity>().ReverseMap();
        }
        private void NhanVienMapper()
        {
            CreateMap<NhanVienModel, NhanVienEntity>().ReverseMap();
        }
        private void PhanCongGiangDayMapper()
        {
            CreateMap<PhanCongGiangDayModel, PhanCongGiangDayEntity>().ReverseMap();
        }
        private void PhongHoc_LopHocMapper()
        {
            CreateMap<PhongHoc_LopHocModel, PhongHoc_LopHocEntity>().ReverseMap();
        }
        private void PhongHocMapper()
        {
            CreateMap<PhongHocModel, PhongHocEntity>().ReverseMap();
        }
        private void PhuCapMapper()
        {
            CreateMap<PhuCapModel, PhuCapEntity>().ReverseMap();
        }
        private void TinhLuongMapper()
        {
            CreateMap<TinhLuongModel, TinhLuongEntity>().ReverseMap();
        }
        private void ToBoMonMapper()
        {
            CreateMap<ToBoMonModel, ToBoMonEntity>().ReverseMap();
        }
    }
}
