using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoVe
{
    public class SinhVien
    {
        public int Age = default;

        private String MaSV;
        public string maSV
        {
            get { return MaSV; }
            set { MaSV = value; }
        }

        private String Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        private int Year;

        public int year
        {
            get { return Year; }
            set { Year = value; }
        }

        public SinhVien() { }

        public SinhVien(string MaSV, string Name, int Year)
        {
            this.MaSV = MaSV;
            this.Name = Name;
            this.Year = Year;
        }

        public virtual void Import()
        {
            Console.WriteLine("- Nhập ID: ");
            MaSV = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("- Nhập tên: ");
            Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" Nhập năm sinh");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Age = 2022 - Year;
        }

        public virtual void Export()
        {
            Console.WriteLine($"- ID là: {MaSV}");
            Console.WriteLine();
            Console.WriteLine($"- Tên là: {Name}");
            Console.WriteLine();
            Console.WriteLine($"- Năm Sinh là: {Year}");
            Console.WriteLine();
        }
    }
}
