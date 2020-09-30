using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Chapter3
{
    class SinhVien: IComparable<SinhVien>{
        public int maSV{get; set; }
        public string hoTen{get; set;}
        public double diemTB{get; set;}

        public int CompareTo(SinhVien obj) => obj.diemTB.CompareTo(this.diemTB);
    }
    class SinhVien_sortByName : IComparer<SinhVien>
    {
        public int Compare( SinhVien x,  SinhVien y) => x.hoTen.CompareTo(y.hoTen);
    }
    class SinhVien_sortMarktoName : IComparer<SinhVien>
    {
        public int Compare( SinhVien x,  SinhVien y){
            int temp = x.diemTB.CompareTo(y.diemTB);
            if (temp==0)
                return x.hoTen.CompareTo(y.hoTen);
            return temp;
        }
    }
}