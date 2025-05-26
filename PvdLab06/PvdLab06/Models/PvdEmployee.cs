using System;

namespace PvdLab06.Models
{
    public class PvdEmployee
    {
        public string PvdId { get; set; }          // Mã nhân viên
        public string PvdName { get; set; }        // Tên nhân viên
        public DateTime PvdBirthDay { get; set; }  // Ngày sinh
        public string PvdEmail { get; set; }       // Email
        public string PvdPhone { get; set; }       // Số điện thoại
        public decimal PvdSalary { get; set; }     // Lương
        public bool PvdStatus { get; set; }        // Trạng thái (true: đang làm việc, false: nghỉ việc)
    }
}
