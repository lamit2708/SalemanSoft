﻿using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.UCU.UserCustomer.Api.Cfg.Routes;
using VSoft.Company.UCU.UserCustomer.Business.Dto.Request;
using VSoft.Company.UCU.UserCustomer.Business.Dto.Response;
using VSoft.Company.UCU.UserCustomer.Client.Models;
using VSoft.Company.UCU.UserCustomer.Client.Services;

namespace VSoft.Company.UCU.UserCustomer.Client.Provider.Services;

public class UserCustomerClient : ApiDtoClientJSon<IUserCustomerClient, MUserCustomerClient>, IUserCustomerClient
{
    public UserCustomerClient(IConfigurationRoot configuration, MUserCustomerClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IUserCustomerControllerPath.UserCustomer);

    public Task<UserCustomerFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserCustomerActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, UserCustomerFindDtoResponse>(relativePath, request);
    }

    public Task<UserCustomerFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserCustomerActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, UserCustomerFindRangeDtoResponse>(relativePath, request);
    }

    public Task<UserCustomerInsertDtoResponse> CreateAsync(UserCustomerInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserCustomerActionName.CreateOne));
        return PostAsync<UserCustomerInsertDtoRequest, UserCustomerInsertDtoResponse>(relativePath, request);
    }

    public Task<UserCustomerInsertRangeDtoResponse> CreateRangeAsync(UserCustomerInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserCustomerActionName.CreateRange));
        return PostAsync<UserCustomerInsertRangeDtoRequest, UserCustomerInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<UserCustomerUpdateDtoResponse> UpdateAsync(UserCustomerUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserCustomerActionName.UpdateOne));
        return PutAsync<UserCustomerUpdateDtoRequest, UserCustomerUpdateDtoResponse>(relativePath, request);
    }

    public Task<UserCustomerUpdateRangeDtoResponse> UpdateRangeAsync(UserCustomerUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserCustomerActionName.UpdateRange));
        return PutAsync<UserCustomerUpdateRangeDtoRequest, UserCustomerUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<UserCustomerDeleteDtoResponse> DeleteAsync(UserCustomerDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserCustomerActionName.DeleteOne));
        return DeleteAsync<UserCustomerDeleteDtoRequest, UserCustomerDeleteDtoResponse>(relativePath, request);
    }

    public Task<UserCustomerDeleteRangeDtoResponse> DeleteRangeAsync(UserCustomerDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserCustomerActionName.DeleteRange));
        return DeleteAsync<UserCustomerDeleteRangeDtoRequest, UserCustomerDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<UserCustomerSaveRangeDtoResponse> SaveRangeAsync(UserCustomerSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserCustomerActionName.SaveRange));
        return PostAsync<UserCustomerSaveRangeDtoRequest, UserCustomerSaveRangeDtoResponse>(relativePath, request);
    }
}