namespace VegunSoft.Framework.UI.Data.Dvo.Response
{
    public class MDvoResponse
    {
        public virtual string? Code { get; set; }

        public virtual bool IsSuccess { get; set; }

        public virtual string? Message { get; set; }

        public virtual DateTime? DateTime { get; set; }

        public virtual string? FunctionName { get; set; }
    }

    public class MDvoResponse<TDto> : MDvoResponse
    {
        public virtual TDto? Data { get; set; }
    }
}
