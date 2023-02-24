﻿using Microsoft.Extensions.Configuration;
using VegunSoft.Framework.Api.DtoClient.Provider.Services;
using VegunSoft.Framework.Api.DtoClient.Token.Services;
using VegunSoft.Framework.Api.Route.Methods;
using VegunSoft.Framework.Business.Dto.Request;
using VSoft.Company.USR.User.Api.Cfg.Routes;
using VSoft.Company.USR.User.Business.Dto.Request;
using VSoft.Company.USR.User.Business.Dto.Response;
using VSoft.Company.USR.User.Client.Models;
using VSoft.Company.USR.User.Client.Services;

namespace VSoft.Company.USR.User.Client.Provider.Services;

public class UserClient : ApiDtoClientJSon<IUserClient, MUserClient>, IUserClient
{
    public UserClient(IConfigurationRoot configuration, MUserClient clientConfig, ITokenService tokenService) : base(configuration, clientConfig, tokenService)
    {
    }

    public override string Controller { get; } = nameof(IUserControllerPath.User);

    public Task<UserFindDtoResponse> FindAsync(MDtoRequestFindByString request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserActionName.FindOne));
        return GetAsync<MDtoRequestFindByString, UserFindDtoResponse>(relativePath, request);
    }

    public Task<UserFindRangeDtoResponse> FindRangeAsync(MDtoRequestFindRangeByStrings request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserActionName.FindRange));
        return GetAsync<MDtoRequestFindRangeByStrings, UserFindRangeDtoResponse>(relativePath, request);
    }

    public Task<UserInsertDtoResponse> CreateAsync(UserInsertDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserActionName.CreateOne));
        return PostAsync<UserInsertDtoRequest, UserInsertDtoResponse>(relativePath, request);
    }

    public Task<UserInsertRangeDtoResponse> CreateRangeAsync(UserInsertRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserActionName.CreateRange));
        return PostAsync<UserInsertRangeDtoRequest, UserInsertRangeDtoResponse>(relativePath, request);
    }

    public Task<UserUpdateDtoResponse> UpdateAsync(UserUpdateDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserActionName.UpdateOne));
        return PutAsync<UserUpdateDtoRequest, UserUpdateDtoResponse>(relativePath, request);
    }

    public Task<UserUpdateRangeDtoResponse> UpdateRangeAsync(UserUpdateRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserActionName.UpdateRange));
        return PutAsync<UserUpdateRangeDtoRequest, UserUpdateRangeDtoResponse>(relativePath, request);
    }

    public Task<UserDeleteDtoResponse> DeleteAsync(UserDeleteDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserActionName.DeleteOne));
        return DeleteAsync<UserDeleteDtoRequest, UserDeleteDtoResponse>(relativePath, request);
    }

    public Task<UserDeleteRangeDtoResponse> DeleteRangeAsync(UserDeleteRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserActionName.DeleteRange));
        return DeleteAsync<UserDeleteRangeDtoRequest, UserDeleteRangeDtoResponse>(relativePath, request);
    }

    public Task<UserSaveRangeDtoResponse> SaveRangeAsync(UserSaveRangeDtoRequest request)
    {
        var relativePath = Controller.GetApiPath(nameof(IUserActionName.SaveRange));
        return PostAsync<UserSaveRangeDtoRequest, UserSaveRangeDtoResponse>(relativePath, request);
    }
}