using System;
namespace Chapter3{
    class ParttimeEmployee:Employee{
        public override void TaoHopDong(){
            base.TaoHopDong();
            soHopDong = "HDPT: " + maNV + ngayVaoLam.ToShortDateString();
        }
    }
}