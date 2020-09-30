using System;
namespace Chapter3{
    class Employee{
        protected string maNV, hoTen;
        protected string soHopDong;
        protected DateTime ngayVaoLam;
        public Employee(){
            maNV = hoTen = soHopDong = "";
            ngayVaoLam = new DateTime(2001, 10, 31);
        }
        public Employee(string maNV, string hoTen, string soHopDong, DateTime ngayVaoLam){
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.soHopDong = soHopDong;
            this.ngayVaoLam = ngayVaoLam;
        }
        public virtual void Nhap(){
            Console.WriteLine("Ma nhan vien: " + maNV);
            Console.WriteLine("Ho ten: " + hoTen);
            Console.WriteLine("So hop dong: " + soHopDong);
            Console.WriteLine("Ngay vao lam: " + ngayVaoLam.ToString());
        }
        public virtual void TaoHopDong(){
            soHopDong = "HD: " + maNV + ngayVaoLam.ToShortDateString();
        }
    }
}