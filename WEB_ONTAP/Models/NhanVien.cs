namespace WEB_ONTAP.Models
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Tuoi {  get; set; }
        public string GioiTinh {  get; set; }
        //cấu hình 1-n
        public ICollection<DACT> DACTs { get; set; }
    }
}
