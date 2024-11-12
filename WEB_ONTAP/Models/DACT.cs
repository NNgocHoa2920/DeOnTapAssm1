namespace WEB_ONTAP.Models
{
    public class DACT
    {
        public Guid Id { get; set; }
        //khóa ngoại
        //
        public Guid? NhanVienID { get; set; }
        public string? DuAnID {  get; set; }
        public NhanVien? NhanVien { get; set; }
        public DuAn? DuAn { get; set; }
    }
}
