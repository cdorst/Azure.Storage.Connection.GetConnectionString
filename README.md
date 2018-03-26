# Azure.Storage.Connection.GetConnectionString

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-connection-getconnectionstring.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/azure-storage-connection-getconnectionstring)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Connection.GetConnectionString.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Azure.Storage.Connection.GetConnectionString)

## Description

Function returns the AZURE_STORAGE_CONNECTION_STRING environment variable value

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependents

The project below uses this repository as a direct dependency.

Name | Status
---- | ------
[Azure.Storage.Table.GetAzureTable](https://github.com/CDorst./Azure.Storage.Table.GetAzureTable) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst./azure-storage-table-getazuretable.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst./azure-storage-table-getazuretable) [![NuGet package status](https://img.shields.io/nuget/v/CDorst..Azure.Storage.Table.GetAzureTable.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst..Azure.Storage.Table.GetAzureTable)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Azure.Storage.Connection.GetConnectionString](https://www.nuget.org/packages/CDorst.Azure.Storage.Connection.GetConnectionString)

## Version

4.0.4

## Metaproject

Azure.Storage.Connection.GetConnectionString is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

