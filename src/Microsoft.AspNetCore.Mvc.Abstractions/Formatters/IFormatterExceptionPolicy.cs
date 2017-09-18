// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Mvc.Formatters
{
    /// <summary>
    /// A policy which <see cref="IInputFormatter"/>s can implement to indicate if they want the body model binder
    /// to convert all exceptions to model state errors. By default, all in-built <see cref="IInputFormatter"/>s
    /// implement this interface and have a default value of <see langword="true"/>.
    /// </summary>
    public interface IFormatterExceptionPolicy
    {
        bool HandlesExceptions { get; }
    }
}
