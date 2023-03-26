// See https://aka.ms/new-console-template for more information
using BaoVe;
using System.Collections.Generic;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
List<SERVICE> srv = new List<SERVICE>();
List<SinhVienUDPM> svud =   new List<SinhVienUDPM>();
void Menu()
{
    Console.WriteLine();
    Console.WriteLine("- 1. Nhập.");
    Console.WriteLine();
    Console.WriteLine("- 2.Xuất."); 
    Console.WriteLine();
    Console.WriteLine("- 3.Xuất dssv có tuổi từ 50 trở lên.");
    Console.WriteLine();
    Console.WriteLine("- 4. Tìm sv theo mã.");
    Console.WriteLine();
    Console.WriteLine("- 5. Kế thừa. ");
    Console.WriteLine();
}

int number = default;
SERVICE SVV = new SERVICE();

do
{
    Menu();
    Console.WriteLine("- Mời bạn chọn chức năng: ");
    number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (number)
    {
        case 1:
            Console.WriteLine("- bạn đã chọn chức năng 1; ");
            Console.WriteLine();
            try
            {
                SVV.Nhap();
            }catch (Exception ex)
            {
                Console.WriteLine("- Lỗi của bạn là: {ex");
                Console.WriteLine();
            }
            break;
        case 2:
            Console.WriteLine("- bạn đã chọn chức năng 2, ");
            Console.WriteLine();
            try
            {
                SVV.Xuat();
            }
            catch (Exception ex)
            {
                Console.WriteLine("- Lỗi của bạn là: {ex");
                Console.WriteLine();
            }
            break;
        case 3:
            Console.WriteLine("- bạn đã chọn chức năng 3. ");
            Console.WriteLine();
            try
            {
                SVV.Tuoi();
            }
            catch (Exception ex)
            {
                Console.WriteLine("- Lỗi của bạn là: {ex");
                Console.WriteLine();
            }
            break;
        case 4:
            Console.WriteLine("- bạn đã chọn chức năng 4. ");
            Console.WriteLine();
            try
            {
                SVV.Search();
            }
            catch (Exception ex)
            {
                Console.WriteLine("- Lỗi của bạn là: {ex");
                Console.WriteLine();
            }
            break;
        case 5:
            Console.WriteLine("- bạn đã chọn chức năng 5. ");
            Console.WriteLine();
            try
            {
                SinhVienUDPM SVUD  = new SinhVienUDPM("ph123", "NguyenVanA", 2003, 8.5, 9.1);

                SVUD.Export();
            }
            catch (Exception ex)
            {
                Console.WriteLine("- Lỗi của bạn là: {ex");
                Console.WriteLine();
            }
            break;
        default:
            Console.WriteLine("- Vui lòng nhập lại.");
            Console.WriteLine();
            break;
    }
} while (number != 0);