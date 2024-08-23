using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: SuppressMessage(
    "Interoperability",
    "CA1416:Validate platform compatibility",
    Justification = "This code is intended to run on Windows only.")]
namespace PasswordChanger
{
    internal class GlobalSuppressions
    {
    }
}
