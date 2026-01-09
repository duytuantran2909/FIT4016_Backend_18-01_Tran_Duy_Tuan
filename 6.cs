    //TODO 6.1 Lớp Student chứa thông tin và điểm của 1 sinh viên
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }

        // Constructor
        // TODO: Khởi tạo các thuộc tính với validation
        // - StudentId không được rỗng
        // - Name không được rỗng
        // - Score phải từ 0 đến 10
        public Student(string id, string name, double score)
        {
            if(String.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Id không hợp lệ");
            if(String.IsNullOrWhiteSpace(name))
                throw new ArgumentException("tên không hợp lệ");
            if (score <0||score >10)
                throw new ArgumentOutOfRangeException("Điểm không hợp lệ");
            StudentId=id;
            Name=name;
            Score=score;
        }

        // Phương thức in thông tin
        public void Display()
        {
            // TODO: In ra "ID: [StudentId] | Tên: [Name] | Điểm: [Score]"
            Console.WriteLine($"ID: {StudentId}, Tên: {Name}, Điểm: {Score}");
        }

    }
    //6.2 TẠO LỚP StudentManager
    public class StudentManager

    {

        private Student[] students = new Student[50];

        private int count = 0; // Số lượng sinh viên hiện tại

        

        // TODO: Phương thức AddStudent(string id, string name, double score)
        // Thêm sinh viên mới, kiểm tra trùng lặp
        public void AddStudent(String id, String name, double score)
        {
            if (count >= students.Length)
            {
                Console.WriteLine("Danh sách đã đầy");
                return;
            } 
            if(FindStudentById(id)is not null)
            {
                Console.WriteLine("id đã tồn tại");
                return;
            }
            students[count] = new Student(id, name, score);
            count++;
            Console.WriteLine("Thêm thành công!");
        }

        // TODO: Phương thức RemoveStudent(string id)

        // Xóa sinh viên theo ID

            public void RemoveStudent(string id)
        {
            int index = -1;
            for (int i = 0; i < count; i++) {
                if (students[i].StudentId == id) {
                    index = i;
                    break;
                }
            }

            if (index == -1) {
                Console.WriteLine("Không tìm thấy mã sinh viên");
                return;
            }

            // Dồn các sinh viên phía sau lên trước để lấp chỗ trống
            for (int i = index; i < count - 1; i++) {
                students[i] = students[i + 1];
            }
            
            students[count - 1] = null; // Xóa tham chiếu cuối cùng
            count--;
            Console.WriteLine("Xóa thành công!");
        }

        // TODO: Phương thức UpdateScore(string id, double newScore)

        // Cập nhật điểm
        public void UpdateScore(string id, double newScore)
        {
            Student s = FindStudentById(id);
            if (s != null)
            {
                s.Score=newScore;
                Console.WriteLine("Cập nhật điểm thành công");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên");
            }
        }
        

        // TODO: Phương thức GetAverageScore()

        // Tính điểm trung bình

        public double GetAverageScore()
        {
            double total=0;
            for(int i = 0; i < count; i++)
            {
                total+=students[i].Score;
            }
            return total/count;
        }

        // TODO: Phương thức GetMaxScore()

        // Tìm điểm cao nhất
        public double GetMaxScore()
        {
            double max=0;
            for(int i = 0; i < count; i++)
            {
                if (max < students[i].Score)
                {
                    max=students[i].Score;
                }
            }
            return max;
        }

        

        // TODO: Phương thức FindStudentById(string id)

        // Trả về đối tượng Student hoặc null

        public Student FindStudentById(String id)
        {
            for(int i = 0; i < count; i++)
            {
                if (students[i].StudentId == id)
                {
                    return students[i];
                }
            }
                return null;
        }

        // TODO: Phương thức DisplayAllStudents()

        // In danh sách tất cả sinh viên
        public void DisplayAllStudents()
        {
            for(int i = 0; i < count; i++)
            {
                students[i].Display();
            }
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            StudentManager   manager = new StudentManager();
            bool running =  true;
            while (running)
            {
                Console.WriteLine("Hệ thống quản lý sinh viên");
                Console.WriteLine("1.Thêm sinh viên");
                Console.WriteLine("2.Hiển thị danh sách");
                Console.WriteLine("3.Cập nhật điểm");
                Console.WriteLine("4.Xóa sinh viên");
                Console.WriteLine("5.Tính điểm trung bình");
                Console.WriteLine("6.Điểm cao nhất");
                Console.WriteLine("0.Thoát");
            
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Nhập ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Nhập Tên: ");
                        string name = Console.ReadLine();
                        Console.Write("Nhập Điểm: ");
                        double score = double.Parse(Console.ReadLine());
                        
                        manager.AddStudent(id, name, score);
                        break;

                    case "2":
                        Console.WriteLine("\nDANH SÁCH SINH VIÊN:");
                        manager.DisplayAllStudents();
                        break;

                    case "3":
                        Console.Write("Nhập ID sinh viên cần sửa điểm: ");
                        string updateId = Console.ReadLine();
                        Console.Write("Nhập điểm mới: ");
                        double newScore = double.Parse(Console.ReadLine());
                        manager.UpdateScore(updateId, newScore);
                        break;

                    case "4":
                        Console.Write("Nhập ID sinh viên cần xóa: ");
                        string removeId = Console.ReadLine();
                        manager.RemoveStudent(removeId);
                        break;

                    case "5":
                        Console.WriteLine($"Điểm trung bình: {manager.GetAverageScore()}");
                        break;

                    case "6":
                        Console.WriteLine($"Điểm cao nhất: {manager.GetMaxScore()}");
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Đã thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại.");
                        break;
                }
            }
        }
    }