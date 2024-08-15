namespace webapi.MyModels
{
    public class Khachhang
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Diachi { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
    
        public ICollection<DonHang> DonHangs { get; set; }
    }
}
