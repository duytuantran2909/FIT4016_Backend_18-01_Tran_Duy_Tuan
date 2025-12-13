using System; 
 
class Program 
 
{ 
 
    // TODO 1: Viết hàm XepLoai nhận vào điểm và trả về xếp loại (string) 
 
    // Hàm này sẽ thay thế phần if/else ở PHT trước 
 
    static string XepLoai(double diem) 
 
    { 
 
        if (diem >= 8.5)
            return "GIOI";
        else if (diem >= 7)
            return "KHA";
        else if (diem >= 5.5)
            return "TRUNG BINH";
        else
            return "YEU";
    } 
 
     
 
    // TODO 2: Viết hàm TinhTrungBinh nhận vào mảng điểm và trả về trung bình (double) 
 
    static double TinhTrungBinh(double[] diem) 
    { 
        double tongdiem = 0;
        foreach(double d in diem)
        {
            tongdiem+=d;
        }
        return tongdiem/diem.Length;
    } 
 
     
 
    // TODO 3: Viết hàm InBangDiem nhận vào 2 mảng (tên, điểm) 
 
    // Hàm này không có kiểu trả về (void), chỉ in ra thôi 
 
    static void InBangDiem(string[] ten, double[] diem) 
 
    { 
        for(int i = 0; i < ten.Length; i++)
        {
            Console.WriteLine("Ten: "+ten[i]+", Diem: "+diem[i]+", Xep loai: "+XepLoai(diem[i]));
        }
        // (Viết code của bạn tại đây) 
 
        // Gợi ý: Dùng for để duyệt và gọi hàm XepLoai() 
 
    } 
 
     
 
    static void Main() 
 
    { 
 
        string[] tenSV = { "Nguyen Van A", "Tran Thi B", "Le Van C" }; 
 
        double[] diemSV = { 8.5, 7.2, 5.8 }; 
 
         
 
        Console.WriteLine("=== Chuong trinh Quan ly Sinh vien ===\n"); 
 
         
 
        // TODO 4: Gọi hàm InBangDiem để in bảng điểm 
 
        InBangDiem(tenSV, diemSV); 
 
         
 
        // TODO 5: Gọi hàm TinhTrungBinh và in kết quả 
 
        double trungBinh = TinhTrungBinh(diemSV); 
 
        Console.WriteLine($"\nDiem trung binh lop: {trungBinh:F2}"); 
 
    } 
 
} 