using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoVe
{
    public  class SinhVienUDPM : SinhVien
    {
        private Double DiemJava;
        public double diemJava
        {
            get { return DiemJava; }
            set { DiemJava = value; }
        }
        private Double DiemC;
        public double diemC
        {
            get { return DiemC; }
            set { DiemC = value; }
        }

        public SinhVienUDPM() { }

        public SinhVienUDPM(string MaSV, string Name, int Year, double DiemJava, double DiemC) : base(MaSV, Name, Year)
        {
            this.DiemJava = DiemJava;
            this.DiemC = DiemC;
        }

        public override void Import()
        {
            base.Import();
            Console.WriteLine("- Nhập điểm java:");
            DiemJava = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("- Nhập điểm C:");
            DiemC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }
        public override void Export()
        {
            base.Export();

            Console.WriteLine($"- Điểm Java là: {DiemJava}");
            Console.WriteLine();

            Console.WriteLine($"- Điểm C là:  {DiemC}");
            Console.WriteLine();
        }


    }
}
