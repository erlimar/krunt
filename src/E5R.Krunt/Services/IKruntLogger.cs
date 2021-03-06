/// <copyright>
/// Copyright (c) Erlimar Silva Campos, E5R Team. All rights reserved.
/// Licensed under the MIT License.
/// See LICENSE in the project root for license information.
/// </copyright>

using System;

namespace E5R.Krunt.Services
{
    public interface IKruntLogger
    {
        void Info(string message);
        void Warning(string message);
        void Error(string message);
    }
}
