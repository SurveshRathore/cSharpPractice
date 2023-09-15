using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasic
{
    public class CustomException:Exception
    {
        /// <summary>
        /// These are the custom  exception types
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_CLASS,
            NOT_FOUND,
            NO_SUCH_METHOD,
            NOT_SUPPORTED,
            NOT_IMPLEMENTED,
            INVALID_OPERATIONS,
            INVALID_INPUT
        }

        public ExceptionType Type { get; set; }

        public CustomException (ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }

        /// <summary>
        /// initializing in constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="Message"></param>
        public CustomException(string? message) : base(message)
        {
        }
    }
}
