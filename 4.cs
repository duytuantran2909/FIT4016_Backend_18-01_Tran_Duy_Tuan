using System; 
 
// TODO 1: Định nghĩa Lớp SinhVien 
 
class SinhVien 
 
{ 
 
    // TODO 2: Khai báo các properties (thuộc tính) 
 
    public string hoTen { 
        get; 
        set; 
        } 
 
    public int Tuoi { 
        get; 
        set; 
        } 
    public double Diem { 
        get; 
        set; 
        } 
 
     
 
    // TODO 3: Viết Constructor (hàm khởi tạo) 
 
    // Hàm này được gọi khi tạo một đối tượng SinhVien mới 
 
    // Constructor có tên giống hệt tên lớp 
 
    public SinhVien(string hoTen, int Tuoi, double Diem) 
 
    { 
        this.hoTen=hoTen;
        this.Tuoi=Tuoi;
        this.Diem=Diem;
        // (Viết code khởi tạo của bạn tại đây) 
 
        // Gợi ý: HoTen = hoTen; Tuoi = tuoi; Diem = diem; 
 
    } 
 
     
 
    // TODO 4: Viết Method XepLoai() để trả về xếp loại 
 
    public string XepLoai() 
 
    { 
        if(this.Diem>=8.5)
            return "GIOI";
        else if(this.Diem>=7.0)
            return "Kha";
        else if(this.Diem>=5.5)
            return "TRUNG BINH";
        else 
            return "YEU";
        // (Viết code của bạn tại đây) 
 
        // Gợi ý: Sử dụng this.Diem để truy cập điểm của sinh viên 
 
    } 
 
     
 
    // TODO 5: Viết Method HienThiThongTin() để in thông tin sinh viên 
 
    public void HienThiThongTin() 
 
    { 
 
        Console.WriteLine($"Ten: {hoTen}, Tuoi: {Tuoi}, Điem: {Diem}, Xep loai: {XepLoai()}");     } 
 
} 
 
class Program 
 
{ 
 
    static void Main() 
 
    { 
 
        Console.WriteLine("===Quan ly sinh vien ===\n"); 
 
         
 
        // TODO 6: Tạo các đối tượng SinhVien 
 
        // Gợi ý: SinhVien sv1 = new SinhVien("Nguyễn Văn A", 20, 8.5); 
 
        SinhVien sv1 = new SinhVien("Nguyen Van A", 20, 8.5); 
 
        SinhVien sv2 = new SinhVien("Tran Thi B", 21, 7.2); 
 
        SinhVien sv3 = new SinhVien("Le Van C", 19, 5.8); 
 
         
 
        // TODO 7: Gọi method HienThiThongTin() để in thông tin 
 
        sv1.HienThiThongTin(); 
 
        sv2.HienThiThongTin(); 
 
        sv3.HienThiThongTin(); 
 
         
 
        // TODO 8: (Tùy chọn) Tính trung bình điểm của 3 sinh viên 
 
        double diemTB = (sv1.Diem + sv2.Diem + sv3.Diem) / 3; 
 
        Console.WriteLine($"\nDiem Trung Binh: {diemTB:F2}"); 
    } 
 
} 