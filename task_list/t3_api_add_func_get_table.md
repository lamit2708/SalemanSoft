## Repository

- [] Lib\VSoft.Company.CTM.Customer.Repository.Efc.Provider\GetTableByKeySearchAsync()

## Business

- [] Copy VSoft.Company.CTM.Customer.Business.Dto\Request\CustomerTableKeySearchDtoRequest.cs
```C#
    using VegunSoft.Framework.Business.Dto.Request;

    namespace VSoft.Company.CTM.Customer.Business.Dto.Request
    {
        public class CustomerTableKeySearchDtoRequest : MDtoRequestPaging<string>
        {
        }
    }

```
- [] Copy VSoft.Company.CTM.Customer.Business.Dto\Response\CustomerTableKeySearchDtoResponse.cs
```C#
    using VegunSoft.Framework.Business.Dto.Response;
    using VSoft.Company.CTM.Customer.Business.Dto.Data;

    namespace VSoft.Company.CTM.Customer.Business.Dto.Response
    {
        public class CustomerTableKeySearchDtoResponse : MDtoResponsePaging<CustomerDto>
        {
        }
    }

```
- [] Copy VSoft.Company.CTM.Customer.Business.Provider\CustomerMgmtBus.cs\GetTableByKeySearch
```C#
    using VegunSoft.Framework.Business.Dto.Request;
    using VegunSoft.Framework.Business.Dto.Response;
    public async Task<CustomerTableKeySearchDtoResponse> GetTableByKeySearch(CustomerTableKeySearchDtoRequest request)
    {
        var rsRespo = await Repository?.GetTableByKeySearchAsync(request.Data, request.PagingParams);
        var response = new CustomerTableKeySearchDtoResponse();
        if (rsRespo != null)
        {
            response.Data = rsRespo.Items.GetDto().ToArray();
            response.MetaData = rsRespo.MetaData;
            response.IsSuccess = true;
        };
        return response;
    }
```

- [] Add Reference Paging to project VSoft.Company.CTM.Customer.Business.Provider
```C#
    <Reference Include="VegunSoft.Framework.Paging.Provider">
        <HintPath>..\..\..\..\..\..\..\..\Library\DNet\Customer\vgsoft-library-dnet\Paging\VegunSoft.Framework.Paging.Provider.dll</HintPath>
    </Reference>
```

-[] Add code to VSoft.Company.CTM.Customer.Business.Dto.Extension\CustomerEntityMethods.cs
```C#
    public static List<CustomerDto> GetDto(this List<MCustomerEntity> srcs)
    {
        var rs = new List<CustomerDto>();
        if (srcs == null)
            return rs;
        srcs.ForEach(src => rs.Add(src.GetDto()));
        return rs;
    }
```

## Api

- [] VSoft.Company.CTM.Customer.Api.Cfg\ICustomerActionName.cs
```C#
    using VegunSoft.Framework.Api.Route.Bases;

    namespace VSoft.Company.CTM.Customer.Api.Cfg.Routes
    {
        public interface ICustomerActionName: IApiActionName
        {
            string? FindTable { get; set; }
        }
    }

```

- [] VSoft.Company.CTM.Customer.Api.Controller.Base\CustomerBaseController.cs
```C#
    [HttpGet(nameof(ICustomerActionName.FindTable))]
    public async Task<IActionResult> FindTableByKeySearch([FromQuery] CustomerTableKeySearchDtoRequest dtosRequest)
    {
        var res = await Bus.GetTableByKeySearch(dtosRequest);
        return Ok(res);
    }
```

## Client

- []VSoft.Company.CTM.Customer.Client\ICustomerClient.cs\
  * Task<CustomerTableKeySearchDtoResponse> GetTableByKeyword(CustomerTableKeySearchDtoRequest request);

- [] VSoft.Company.CTM.Customer.Client.Provider\CustomerClient.cs
```c#
    public Task<CustomerTableKeySearchDtoResponse> GetTableByKeyword(CustomerTableKeySearchDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerActionName.FindTable));
        var pagingParamName = nameof(request.PagingParams);
        var langCodeName = nameof(request.LangCode);
        var langShowExContent = nameof(request.ShowExContent);
        var langShowExMessage = nameof(request.ShowExMessage);
        var query = new Dictionary<string, string>()
        {
            [$"{pagingParamName}.{nameof(request.PagingParams.PageNumber)}"] = request.PagingParams.PageNumber.ToString(),
            [$"{pagingParamName}.{nameof(request.PagingParams.PageSize)}"] = request.PagingParams.PageSize.ToString(),
        };
        if (request.LangCode != null)
            query.Add(langCodeName, request.LangCode.ToString());
        if (request.ShowExContent != null)
            query.Add(langShowExContent, request.ShowExContent.ToString());
        if (request.ShowExMessage != null)
            query.Add(langShowExMessage, request.ShowExMessage.ToString());
        if (!string.IsNullOrEmpty(request.Data))
            query.Add(nameof(request.Data), request.Data);
        return GetQueryAsync<CustomerTableKeySearchDtoResponse>(relativePath, query);
    }
```