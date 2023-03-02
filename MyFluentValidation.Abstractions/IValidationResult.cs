namespace MyFluentValidation.Abstractions
{
    public interface IValidationResult
    {
        IList<IValidationFailure> Errors { get; set; }

        public bool IsValid { get; }
    }
}
