using MyFluentValidation.Abstractions;
using System.Runtime.Serialization;

namespace MyFluentValidation.Implementation.Exceptions
{
    [Serializable]
    public class ValidationException : Exception
    {
        public IList<IValidationFailure>? Errors { get; }

        public ValidationException(IList<IValidationFailure> errors)
            : this(null, errors)
        {
        }

        public ValidationException(string? message, IList<IValidationFailure> errors)
            : this(message, errors, null)
        {
        }

        public ValidationException(string? message, IList<IValidationFailure> errors, Exception? innerException)
            : base(message, innerException)
        {
            Errors = errors;
        }

        public ValidationException()
        {
        }

        public ValidationException(string? message)
            : base(message)
        {
        }

        public ValidationException(string? message, Exception? innerException)
            : base(message, innerException)
        {
        }

        protected ValidationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
            Errors = (IList<IValidationFailure>)serializationInfo.GetValue(nameof(Errors), typeof(IList<IValidationFailure>))!;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue(nameof(Errors), Errors);
        }
    }
}
