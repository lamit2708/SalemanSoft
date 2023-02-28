using VSoft.Company.QUE.Question.Business.Dto.Data;
using VSoft.Company.QUE.Question.Data.Entity.Models;

namespace VSoft.Company.QUE.Question.Business.Dto.Extension.Methods;

public static class QuestionDtoMethods
{
    public static MQuestionEntity GetEntity(this QuestionDto src, bool isForUpdate)
    {
        return new MQuestionEntity()
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
