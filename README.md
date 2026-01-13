# SchoolManagement

Ứng dụng web ASP.NET Core MVC quản lý sinh viên theo trường học, sử dụng Entity Framework Core và SQL Server Express (hoặc SQLite).

## Công nghệ sử dụng

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server Express (`LAPTOP-PO4NN5AP\SQLEXPRESS`) hoặc SQLite
- Bootstrap (giao diện)

## Cấu trúc chính

- `Models/School.cs`  
  - Thông tin trường: `Id`, `Name`, `Principal`, `Address`, `CreatedAt`, `UpdatedAt`.
- `Models/Student.cs`  
  - Thông tin sinh viên: `Id`, `SchoolId`, `FullName`, `StudentId`, `Email`, `Phone`, `CreatedAt`, `UpdatedAt`.
- `Data/SchoolDbContext.cs`  
  - Kế thừa `DbContext`, khai báo `DbSet<School>`, `DbSet<Student>`, cấu hình quan hệ 1-n, unique, seed dữ liệu mẫu.
- `Controllers/StudentsController.cs`  
  - Chức năng CRUD + phân trang cho sinh viên:
    - `Index` (list + phân trang)
    - `Create` (GET/POST)
    - `Edit` (GET/POST)
    - `Delete` (GET/POST)
- `Views/Students/`  
  - `Index.cshtml`: danh sách sinh viên + phân trang
  - `Create.cshtml`: form tạo mới
  - `Edit.cshtml`: form chỉnh sửa
  - `Delete.cshtml`: xác nhận xóa
- `Views/Shared/_Layout.cshtml`  
  - Layout chung, navbar, footer, Bootstrap.
- `appsettings.json`  
  - Connection string tới database.

## Cấu hình database

### 1. Dùng SQL Server Express

Trong `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=LAPTOP-PO4NN5AP\\SQLEXPRESS;Database=SchoolManagement;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
}

