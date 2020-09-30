using System;
namespace Chapter3{
    class FulltimeEmployee:Employee{
        public override void TaoHopDong(){
            base.TaoHopDong();
            soHopDong = "HDFT: " + maNV + ngayVaoLam.ToShortDateString();
        }
    }
}