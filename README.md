![Icon](https://raw.githubusercontent.com/ryuzakyl/Nhtsa.SDK/refs/heads/master/assets/images/nhtsa-brand.webp)

**NHTSA unofficial .NET Client SDK**

> .NET SDK providing easy access to the NHTSA's APIs (Vehicle, Recalls, etc.). This NuGet package enables developers to
> retrieve vehicle safety information, recalls, complaints data, etc.

[![NuGet](https://img.shields.io/nuget/v/Nhtsa.SDK?logo=nuget)](https://www.nuget.org/packages/Nhtsa.SDK/)
[![License](https://img.shields.io/:license-MIT-blue.svg)](https://opensource.org/licenses/mit-license.php)

## Installation

The package can be obtained from [NuGet](https://www.nuget.org/packages/Nhtsa.SDK).

Package Manager (PM):
```pwsh
> Install-Package Nhtsa.SDK
```

CMD:
```cmd
> dotnet add package Nhtsa.SDK
```

Bash:
```bash
$ dotnet add package Nhtsa.SDK
```

## Usage

We can interact with NHTSA APIs as follows:
```csharp
using OneOf;

using Nhtsa.SDK.Errors;
using Nhtsa.SDK.Clients.Vehicles;
using Nhtsa.SDK.Models.Vehicles;

// get all Makes from the Vehicles API
VehiclesClient vc = new VehiclesClient();
OneOf<GetAllMakesResponse, ApiError> result = await vc.GetAllMakesAsync();
```

## Goals

- Easily interact with NHTSA APIs data (recalls, complaints, safety ratings) via simple .NET SDK clients.
- Enable seamless integration of NHTSA in potential APIs and CLI applications.


