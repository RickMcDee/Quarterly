# Quarterly
Reduce the pain while working with quarters in .NET

[![NuGet version (Quarterly)](https://img.shields.io/nuget/v/Quarterly.svg?style=flat-square)](https://www.nuget.org/packages/Quarterly/)

## Usage

```cs
var currentQuarter = DateTime.Now.GetQuarter();
```
or
```cs
var currentQuarter = Quarterly.GetQuarterFromDateTime(DateTime.Now);
```

## Methods
|Name | Description | Inputtype | Returntype |
| ----------- | ----------- | ----------- | ----------- |
| GetQuarter | Returns the current quarter | - | int |
| GetQuarterFromDateTime | Returns the current quarter | DateTime | int |
| GetQuarterStart | Returns the startdate of the provided quarter | - | DateTime |
| GetQuarterStartFromDateTime | Returns the startdate of the provided quarter | DateTime | DateTime |
| GetQuarterEnd | Returns the enddate of the provided quarter | - | DateTime |
| GetQuarterEndFromDateTime | Returns the enddate of the provided quarter | DateTime | DateTime |
| GetDayInQuarter | Returns number of the provided day in the provided quarter | - | int |
| GetDayInQuarterFromDateTime | Returns number of the provided day in the provided quarter | DateTime | int |
