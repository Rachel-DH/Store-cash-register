using System.Text.Json.Serialization;

namespace BO;


[Serializable]
public class BlIdNotFoundException : Exception
{
    public BlIdNotFoundException(string? message) : base(message) { }

    public BlIdNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }
}
[Serializable]
public class BlIdAlreadyExistsException : Exception
{
    public BlIdAlreadyExistsException(string? message) : base(message) { }

    public BlIdAlreadyExistsException(string? message, Exception? innerException) : base(message, innerException) { }

}
[Serializable]
public class BlNotEnoughInStockException : Exception
{
    public BlNotEnoughInStockException(string? message) : base(message) { }
    public BlNotEnoughInStockException(string? message, Exception? innerException) : base(message, innerException) { }

}
[Serializable]
public class BlCustomerIdNotFoundException : Exception
{
    public BlCustomerIdNotFoundException() { }

    public BlCustomerIdNotFoundException(string? message) : base(message) { }
    
    public BlCustomerIdNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }
}
[Serializable]
public class BlSaleAlreadyExistsException : Exception
{
    public BlSaleAlreadyExistsException() { }
    public BlSaleAlreadyExistsException(string? message) : base(message) { }
    public BlSaleAlreadyExistsException(string? message, Exception? innerException) : base(message, innerException) { }
}

[Serializable]
public class BlCustomerAlreadyExistsException : Exception
{
    public BlCustomerAlreadyExistsException() { }
    public BlCustomerAlreadyExistsException(string? message) : base(message) { }
    public BlCustomerAlreadyExistsException(string? message, Exception? innerException) : base(message, innerException) { }
}

[Serializable]
public class BlProductAlreadyExistsException : Exception
{
    public BlProductAlreadyExistsException() { }
    public BlProductAlreadyExistsException(string? message) : base(message) { }
    public BlProductAlreadyExistsException(string? message, Exception? innerException) : base(message, innerException) { }
}

[Serializable]
public class BlSaleIdNotFoundException : Exception
{
    public BlSaleIdNotFoundException() { }

    public BlSaleIdNotFoundException(string? message) : base(message) { }
    public BlSaleIdNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }
}

[Serializable]
public class BlProductIdNotFoundException : Exception
{
    public BlProductIdNotFoundException() { }
    public BlProductIdNotFoundException(string? message) : base(message) { }
    public BlProductIdNotFoundException(string? message, Exception? innerException) : base(message, innerException) { }
}
