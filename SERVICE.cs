using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoVe
{
    public class SERVICE
    {
        List<SinhVien> sv = new List<SinhVien>();

        public void Nhap()
        {
            string choose = default;

            do
            {
                SinhVien SV = new SinhVien();

                SV.Import();

                sv.Add(SV);

                Console.WriteLine("- Bạn có muốn nhập tiếp không? (y/n");
                choose = Console.ReadLine();
                Console.WriteLine();
            } while (choose != "n");
        }

        public void Xuat()
        {
            foreach (var xuat in sv)
            {
                xuat.Export();
            }
        }

        public void Tuoi()
        {
            foreach (var tuoi in sv)
            {
                if (tuoi.Age >50)
                {
                    tuoi.Export();
                }
                else
                {
                    Console.WriteLine("- Không có tuổi phù hợp với điều kiện.");
                }
            }
        }

        public void Search()
        {
            Console.WriteLine("- Nhập mã sinh viên bạn muốn tìm kiếm: ");
            string ID = Console.ReadLine();
            Console.WriteLine();
            foreach (var search in sv)
            {
                if (search.maSV == ID)
                {
                    search.Export();
                    break;
                }
                else
                {
                    Console.WriteLine("- Không có sinh viên bạn muốn tìm ");
                    break;
                }
            }
        }

    }
}
