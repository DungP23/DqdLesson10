//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DqdLesson10.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KetQua
    {
        public string MaSv { get; set; }
        public string MaMh { get; set; }
        public Nullable<int> Diem { get; set; }
    
        public virtual MonHoc MonHoc { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
