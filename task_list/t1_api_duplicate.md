# [] Sao chép module mẫu

-copy CTM\Customer --> USR\User
-Xóa tất cả thư mục bin và obj bên trong
-Mở folder lên D:\workspace\SalemanSoft\SaleManSoft\Code\company\PRO\Product
Search obj và bin
Delete all

# [] Rename 
-Rename Tên thư mục theo cấu trúc (Thư mục).(File)
--Mở powershell, nhảy đến thư mục của module mới:
cd D:\workspace\SalemanSoft\git\Code\company\USR\User\
--Chạy câu lệnh đổi tên cho CTM
Get-ChildItem -Recurse | Where-Object {$_.Name -cmatch "CTM"} | Rename-Item -NewName { $_.name -creplace 'CTM', 'PRO'} -verbose
--Chạy câu lệnh đổi tên cho Product
Get-ChildItem -Recurse | Where-Object {$_.Name -cmatch "Customer"} | Rename-Item -NewName { $_.name -creplace 'Customer', 'Product'} -verbose

--Đổi tên trong nội dung của file code bằng visual studio code
+Mở visual studio code
+Mở thư mục D:\workspace\SalemanSoft\git\Code\company\USR\User
+Chọn phân biệt hoa thường (VERY IMPORTANT)
+Thay CTM => USR
+Thay Customer =>User
+Thay customer=> user
+Replace all



# [] Làm việc tầng DATA

+Vào Data>D:\workspace\SalemanSoft\git\Code\company\USR\User\data

+Chạy câu lệnh đọc database để biến thành entity cho bảng user
Scaffold-DbContext 'Data Source=localhost;Initial Catalog=crmdb;User ID=root;Password=root' MySql.EntityFrameworkCore -Tables User
Scaffold-DbContext 'Data Source=103.15.50.87;Initial Catalog=crmdb;USER ID=root;Password=PtKHDjkgJDRn8BAb' MySql.EntityFrameworkCore -Tables ProductFeature

+Trong visual studio IDE, chọn Vsoft.Comapny.USR.User.Data.Migrate.Real
Set as startup project

+Mở package manager Console> Chọn default project: Vsoft.Company.USR.User.Data.Migrate.Real

# [] Code sinh ra bảng User trong Vsoft.Company.USR.User.Data.Migrate.Real 
+Copy thuộc tính từ VSoft.Company.USR.User.Data.Migrate.Real\User.cs vào VSoft.Company.USR.User.Data.Entity>MUserEntity.cs
+Nếu id kiểu long hay int thì sửa lớp kế thừa IIdEntity<int> hay IIdEntity<long>

# [] Copy code từ Vsoft.Company.USR.User.Data.Migrate.Real>CrmDbContext.cs
Sang VSoft.Company.USR.User.Data.Db\Contexts\UserDbContext.cs 
Theo cấu trúc tương tự;

# [] Delete Migrations and Files that generated by code
- [] VSoft.Company.USR.User.Data.Migrate.Real\Migrations
- [] VSoft.Company.USR.User.Data.Migrate.Real\CrmdbContext.cs
- [] VSoft.Company.USR.User.Data.Migrate.Real\ProductFeature.cs

# [] Build Project

	
# [] Recreate Migration
+Delete migration folder
+Tạo lại migration
+Mở package manager Console> Run add-migration InitUser
+Comment code been trong hàm Up() và Down() từ file migration được sinh ra
+chạy package manager console>update-database
+Mở lại comment từ hàm Up() và Down() ở trên;

# [] Làm việc tầng Repository
+Build và sửa lỗi cho các field
+Chạy UnitTest cho các hàm create, update, delete
+Kiểm tra với table trong database

# [] Làm việc với Business
+Mở VSoft.Company.USR.User.Business.Dto>UserDto.cs
+Copy từ VSoft.Company.USR.User.Data.Entity>MUserEntity.cs => Lấy các thuộc tính của Entity, chép vào UserDto
+Chỉnh lại code trong VSoft.Company.USR.User.Business.Dto.Extension> UserDtoMethods.cs, UserEntityMethods.cs
+Build và chạy code trong UnitTest cho chức năng: create, update, delete;

# [] Làm việc với tầng API
Build
Chọn VSoft.Company.USR.User.Api.UnitTest.Real> Set Startup Project;
Run

# [] Làm việc tầng Client
+Chọn Client.UnitTest.Real, Set Start Up Project
+Double click vào Project UnitTest, copy reference vào UnitTest.Real
 <ItemGroup>
    <Reference Include="VegunSoft.Framework.Api.DtoClient.UnitTest">
      <HintPath>..\..\..\..\..\..\..\..\Library\DNet\Product\vgsoft-library-dnet-common\ApiDtoClient\VegunSoft.Framework.Api.DtoClient.UnitTest.dll</HintPath>
    </Reference>
    <Reference Include="VegunSoft.Framework.Business.Dto">
      <HintPath>..\..\..\..\..\..\..\..\Library\DNet\Product\vgsoft-library-dnet-common\Business\VegunSoft.Framework.Business.Dto.dll</HintPath>
    </Reference>
    <Reference Include="VegunSoft.Framework.Business.UnitTest">
      <HintPath>..\..\..\..\..\..\..\..\Library\DNet\Product\vgsoft-library-dnet-common\Business\VegunSoft.Framework.Business.UnitTest.dll</HintPath>
    </Reference>
    <Reference Include="VSoft.Company.PRC.ProductCategory.Business.Dto">
      <HintPath>..\..\..\..\..\..\..\SaleManSoftAPILib\dotnet\company\CTM\ProductCategory\bus\VSoft.Company.PRC.ProductCategory.Business.Dto.dll</HintPath>
    </Reference>
  </ItemGroup>

+Copy Mẫu MgmtTest.cs vào file UnitTest1.cs
+Add inherit, add reference, add using;
+Run API
+Run Client, call API to test