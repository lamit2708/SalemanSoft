# Thêm module vào Main.UI.WebApp ở những file sau

- [] Main.UI.WebApp\wwwroot\appsettings.json
- [] Main.UI.WebApp\Program.cs
- [] Main.UI.WebApp\App.razor
- [] Main.UI.WebApp\Shared\NavMenu.razor

# Thêm dll vào Main.UI.WebApp 

- [] Copy đoạn code sau, chú ý thay thế tên PRF, ProductFeature phù hợp rồi thêm vào project

<Reference Include="VSoft.Company.UI.PRF.ProductFeature.View.Module">
    <HintPath>..\..\..\..\..\..\..\SaleManSoftUILib\dotnet\company\PRF\ProductFeature\client\VSoft.Company.UI.PRF.ProductFeature.View.Module.dll</HintPath>
</Reference>
<Reference Include="VSoft.Company.UI.PRF.ProductFeature.View.Main.Page">
    <HintPath>..\..\..\..\..\..\..\SaleManSoftUILib\dotnet\company\PRF\ProductFeature\client\VSoft.Company.UI.PRF.ProductFeature.View.Main.Page.dll</HintPath>
</Reference>
<Reference Include="VSoft.Company.UI.PRF.ProductFeature.View.Main.Cpn">
    <HintPath>..\..\..\..\..\..\..\SaleManSoftUILib\dotnet\company\PRF\ProductFeature\client\VSoft.Company.UI.PRF.ProductFeature.View.Main.Cpn.dll</HintPath>
</Reference>
<Reference Include="VSoft.Company.UI.PRF.ProductFeature.View.Main.Cpn.Code">
    <HintPath>..\..\..\..\..\..\..\SaleManSoftUILib\dotnet\company\PRF\ProductFeature\client\VSoft.Company.UI.PRF.ProductFeature.View.Main.Cpn.Code.dll</HintPath>
</Reference>
<Reference Include="VSoft.Company.UI.PRF.ProductFeature.Data.DVO">
    <HintPath>..\..\..\..\..\..\..\SaleManSoftUILib\dotnet\company\PRF\ProductFeature\data\VSoft.Company.UI.PRF.ProductFeature.Data.DVO.dll</HintPath>
</Reference>
<Reference Include="VSoft.Company.PRF.ProductFeature.Client">
    <HintPath>..\..\..\..\..\..\..\SaleManSoftAPILib\dotnet\company\PRF\ProductFeature\client\VSoft.Company.PRF.ProductFeature.Client.dll</HintPath>
</Reference>
<Reference Include="VSoft.Company.PRF.ProductFeature.Business.Dto">
    <HintPath>..\..\..\..\..\..\..\SaleManSoftAPILib\dotnet\company\PRF\ProductFeature\bus\VSoft.Company.PRF.ProductFeature.Business.Dto.dll</HintPath>
</Reference>
<Reference Include="VSoft.Company.UI.PRF.ProductFeature.View.Main.Cpn.Code.Provider">
    <HintPath>..\..\..\..\..\..\..\SaleManSoftUILib\dotnet\company\PRF\ProductFeature\client\VSoft.Company.UI.PRF.ProductFeature.View.Main.Cpn.Code.Provider.dll</HintPath>
</Reference>
<Reference Include="VSoft.Company.UI.PRF.ProductFeature.Business.Service">
    <HintPath>..\..\..\..\..\..\..\SaleManSoftUILib\dotnet\company\PRF\ProductFeature\business\VSoft.Company.UI.PRF.ProductFeature.Business.Service.dll</HintPath>
</Reference>
<Reference Include="VSoft.Company.UI.PRF.ProductFeature.Business.Service.Provider">
    <HintPath>..\..\..\..\..\..\..\SaleManSoftUILib\dotnet\company\PRF\ProductFeature\business\VSoft.Company.UI.PRF.ProductFeature.Business.Service.Provider.dll</HintPath>
</Reference>
<Reference Include="VSoft.Company.UI.PRF.ProductFeature.Data.DVO.Extension">
    <HintPath>..\..\..\..\..\..\..\SaleManSoftUILib\dotnet\company\PRF\ProductFeature\data\VSoft.Company.UI.PRF.ProductFeature.Data.DVO.Extension.dll</HintPath>
</Reference>
<Reference Include="VSoft.Company.PRF.ProductFeature.Client.Provider">
    <HintPath>..\..\..\..\..\..\..\SaleManSoftAPILib\dotnet\company\PRF\ProductFeature\client\VSoft.Company.PRF.ProductFeature.Client.Provider.dll</HintPath>
</Reference>