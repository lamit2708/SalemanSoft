## Build data

## Build repo

## Build bus

- [x] Copy properties from class Entity (Data Layer) into Dto (Business Layer)
- [x] Copy the sample of Product UnitTest for your module
- [ ] Update the website
- [ ] Contact the media
  * Open UnitTest of repository
  * Copy sample into the UnitTest of Business Layer
  * Build

## Build api

## Build Client

 - [] Copy lớp kế thừa TestProductMgmt
  * Copy từ mẫu VSoft.Company.PRO.Product.Client.UnitTest.Test\MgmtTest.cs
  * public class MgmtTest : TestProductMgmt
  * Áp dụng cho projectVSoft.Company.PRO.Product.Client.UnitTest.Real\UnitTest1.cs
 - [] Copy reference
  * Copy từ mẫu VSoft.Company.PRO.Product.Client.UnitTest.Test.csproj
   <Reference Include="VegunSoft.Framework.Api.DtoClient.UnitTest">
      <HintPath>..\..\..\..\..\..\..\..\Library\DNet\Product\vgsoft-library-dnet-common\ApiDtoClient\VegunSoft.Framework.Api.DtoClient.UnitTest.dll</HintPath>
    </Reference>
    <Reference Include="VegunSoft.Framework.Business.Dto">
      <HintPath>..\..\..\..\..\..\..\..\Library\DNet\Product\vgsoft-library-dnet-common\Business\VegunSoft.Framework.Business.Dto.dll</HintPath>
    </Reference>
    <Reference Include="VegunSoft.Framework.Business.UnitTest">
      <HintPath>..\..\..\..\..\..\..\..\Library\DNet\Product\vgsoft-library-dnet-common\Business\VegunSoft.Framework.Business.UnitTest.dll</HintPath>
    </Reference>
    <Reference Include="VSoft.Company.PRO.Product.Business.Dto">
      <HintPath>..\..\..\..\..\..\..\SaleManSoftAPILib\dotnet\company\PRO\Product\bus\VSoft.Company.PRO.Product.Business.Dto.dll</HintPath>
    </Reference>
  * Áp dụng cho VSoft.Company.PRO.Product.Client.UnitTest.Real.csproj