﻿using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Api.Cfg.Routes;
using VSoft.Company.CTM.Customer.Business.Dto.Request;
using VSoft.Company.CTM.Customer.Business.Dto.Response;
using VSoft.Company.CTM.Customer.Client.Models;
using VSoft.Company.CTM.Customer.Client.Services;

namespace VSoft.Company.CTM.Customer.Client.Provider.Services;

public class CustomerClient : ApiDtoClientJSon<ICustomerClient, MCustomerClient>, ICustomerClient
{
    public CustomerClient(IConfigurationRoot configuration, MCustomerClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(ICustomerControllerPath.Customer);

    public Task<CustomerFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, CustomerFindDtoResponse>(relativePath, request);
    }

    public Task<CustomerFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, CustomerFindRangeDtoResponse>(relativePath, request);
    }

    public Task<CustomerInsertDtoResponse> CreateAsync(CustomerInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerActionName.CreateOne));
        return PostAsync<CustomerInsertDtoRequest, CustomerInsertDtoResponse>(relativePath, request);
    }

    public Task<CustomerInsertRangeDtoResponse> CreateRangeAsync(CustomerInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerActionName.CreateRange));
        return PostAsync<CustomerInsertRangeDtoRequest, CustomerInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<CustomerUpdateDtoResponse> UpdateAsync(CustomerUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerActionName.UpdateOne));
        return PutAsync<CustomerUpdateDtoRequest, CustomerUpdateDtoResponse>(relativePath, request);
    }

    public Task<CustomerUpdateRangeDtoResponse> UpdateRangeAsync(CustomerUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerActionName.UpdateRange));
        return PutAsync<CustomerUpdateRangeDtoRequest, CustomerUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<CustomerDeleteDtoResponse> DeleteAsync(CustomerDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerActionName.DeleteOne));
        return DeleteAsync<CustomerDeleteDtoRequest, CustomerDeleteDtoResponse>(relativePath, request);
    }

    public Task<CustomerDeleteRangeDtoResponse> DeleteRangeAsync(CustomerDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerActionName.DeleteRange));
        return DeleteAsync<CustomerDeleteRangeDtoRequest, CustomerDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<CustomerSaveRangeDtoResponse> SaveRangeAsync(CustomerSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(ICustomerActionName.SaveRange));
        return PostAsync<CustomerSaveRangeDtoRequest, CustomerSaveRangeDtoResponse>(relativePath, request);
    }
}