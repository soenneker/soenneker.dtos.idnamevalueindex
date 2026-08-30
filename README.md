[![](https://img.shields.io/nuget/v/soenneker.dtos.idnamevalueindex.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.idnamevalueindex/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idnamevalueindex/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idnamevalueindex/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.idnamevalueindex.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.idnamevalueindex/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.idnamevalueindex/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.idnamevalueindex/actions/workflows/codeql.yml)

# Soenneker.Dtos.IdNameValueIndex

A small DTO for carrying an identifier, display name, optional value, and optional string index. It supports both `System.Text.Json` and Newtonsoft.Json with the same JSON property names.

## Install

```bash
dotnet add package Soenneker.Dtos.IdNameValueIndex
```

## Usage

```csharp
using Soenneker.Dtos.IdNameValueIndex;

var option = new IdNameValueIndex
{
    Id = "standard",
    Name = "Standard shipping",
    Value = "ground",
    Index = "2"
};
```

The serialized shape is:

```json
{
  "id": "standard",
  "name": "Standard shipping",
  "value": "ground",
  "index": "2"
}
```

`Id` and `Name` are inherited from `IdNamePair`; `Value` is inherited from `IdNameValue`. `Value` and `Index` are nullable. `Index` is a string, so callers can preserve non-numeric or formatted index values without conversion.
