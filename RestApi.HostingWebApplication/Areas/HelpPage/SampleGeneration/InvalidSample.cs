using System;

namespace Jarai.RestApi.HostingWebApplication.Areas.HelpPage.SampleGeneration
{
    /// <summary>
    ///     This represents an invalid sample on the help page. There's a display template named InvalidSample associated with
    ///     this class.
    /// </summary>
    public class InvalidSample
    {
        public InvalidSample(string errorMessage)
        {
            if (errorMessage == null) throw new ArgumentNullException("errorMessage");
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; }

        public override bool Equals(object obj)
        {
            var other = obj as InvalidSample;
            return other != null && ErrorMessage == other.ErrorMessage;
        }

        public override int GetHashCode()
        {
            return ErrorMessage.GetHashCode();
        }

        public override string ToString()
        {
            return ErrorMessage;
        }
    }
}