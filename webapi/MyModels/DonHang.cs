namespace webapi.MyModels
{
    public class DonHang
    {
        public int Id { get; set; }
        public DateTime NgayDatHang { get; set; }
        public int KhachhangId { get; set; }

        public Khachhang Khachhang { get; set; }
    }
}
