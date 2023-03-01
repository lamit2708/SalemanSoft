﻿using VSoft.Company.DSH.DealStepHistory.Business.Dto.Data;

namespace VSoft.Company.DSH.DealStepHistory.Business.UnitTest.Bases;

public abstract class TestDto
{
    public virtual DealStepHistoryDto GetCreateDto()
    {
        var e = Dto;

        return e;
    }

    public virtual DealStepHistoryDto GetCreateDto(string fullName)
    {
        var e = Dto;
        //e.Name = fullName;
        return e;
    }

    public virtual DealStepHistoryDto GetUpdateDto(int id)
    {
        var e = Dto;
        e.Id = id;
        return e;
    }

    public virtual DealStepHistoryDto GetUpdateDtoFromData(string data)
    {
        var e = Dto;
        var arr = data.Split(" / ");
        e.Id = Convert.ToInt32(arr[0]);
        //e.Name = arr[1];
        return e;
    }

    public virtual DealStepHistoryDto GetUpdateDto(int id, string fullName)
    {
        var e = Dto;
        e.Id = id;
        //e.Name = fullName;
        
        return e;
    }

    protected abstract DealStepHistoryDto Dto { get; }
}
