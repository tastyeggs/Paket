﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Paket")>]
[<assembly: AssemblyProductAttribute("Paket")>]
[<assembly: AssemblyCompanyAttribute("Paket team")>]
[<assembly: AssemblyDescriptionAttribute("A dependency manager for .NET with support for NuGet packages and git repositories.")>]
[<assembly: AssemblyVersionAttribute("3.17.0")>]
[<assembly: AssemblyFileVersionAttribute("3.17.0")>]
[<assembly: AssemblyInformationalVersionAttribute("3.17.0-alpha009")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "3.17.0"
    let [<Literal>] InformationalVersion = "3.17.0-alpha009"
