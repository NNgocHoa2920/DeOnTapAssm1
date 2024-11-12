namespace WEB_ONTAP.Models
{
    public class DuAn
    {
        public string MaDA {  get; set; }
        public string TenDA {  get; set; }
        //cấu hình 1-n vs DACT
        public ICollection<DACT> DACTs { get; set; }

    }
}
