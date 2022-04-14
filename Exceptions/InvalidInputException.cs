/* Class to handle exceptions due to invalid inputs
 *
 */

using System;

namespace CashRegister.Exceptions
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(String message) : base(message) {}
    }
}