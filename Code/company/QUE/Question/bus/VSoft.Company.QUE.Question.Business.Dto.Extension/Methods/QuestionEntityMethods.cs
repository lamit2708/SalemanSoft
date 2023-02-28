using VSoft.Company.QUE.Question.Business.Dto.Data;
using VSoft.Company.QUE.Question.Data.Entity.Models;

namespace VSoft.Company.QUE.Question.Business.entity.Extension.Methods;

public static class QuestionEntityMethods
{
    public static QuestionDto GetDto(this MQuestionEntity src)
    {
        return new QuestionDto()
        {
            Id = src.Id,
            Name = src.Name,
            Phone = src.Phone,
            Email = src.Email,
            Address = src.Address,
            Gender = src.Gender,
            PriorityId = src.PriorityId,
            QuestionInfoId = src.QuestionInfoId,
            IsBought = src.IsBought,
        };
    }
}
