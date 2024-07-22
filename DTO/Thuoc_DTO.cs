using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thuoc_DTO
    {
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public decimal DonGia { get; set; }
        public decimal DangGiaBan { get; set; }
        public string HamLuong { get; set; }
        public int DonViTinh { get; set; }
        public string TacDungPhu { get; set; }
        public string NhaSanXuat { get; set; }
        public string NuocSanXuat { get; set; }
        public string HinhAnh { get; set; }
        public string SoLuong { get; set; }
        public string TacDung { get; set; }
        public DateTime NgayApDungDonGia { get; set; }
        public string Lo { get; set; }
        public string BietDuoc { get; set; }
        public int? MaLoaiThuoc { get; set; }
    }
}
