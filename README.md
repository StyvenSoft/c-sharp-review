# c-sharp-review
C# is one of the most popular programming languages and can be used for a variety of things, including mobile applications, game development, and enterprise software.

## Data Types

Data types specify the type of data that a valid C# variable can hold. 

| Type     | Description                        | Size \(Bits\)   | \.NET Type       | Range                                          |
|----------|------------------------------------|-----------------|------------------|------------------------------------------------|
| sbyte    |                                    | 8               | System\.Sbyte    | \-128 to 127                                   |
| short    |                                    | 16              | System\.Int16    | \-32768 to 32767                               |
| Int      | Whole Number                       | 32              | System\.Int32    | \-231 to 231\-1                                |
| long     | Whole Numner \(Bigger range\)      | 64              | System\.Int64    | \-263 to 263\-1                                |
| byte     |                                    | 8               | System\.byte     | 0 to 255                                       |
| ushort   |                                    | 16              | System\.UInt16   | 0 to 65535                                     |
| float    | Floting point number               | 32              | System\.Single   | ±1\.5 × 10\-45 to ±3\.4 × 1038                 |
| double   | Double presicion \(More accurate\) | 64              | System\.Double   | ±5\.0 × 10\-324 to ±1\.7 × 10308               |
| decimal  | Monetary value                     | 128             | System\.Decimal  | ±1\.0 × 10\-28 to ±7\.9228 × 1028              |
| char     | Single Character                   | 16              | System\.Char     | U \+0000 to U \+ffff                           |
| bool     | Boolean                            |                 | System\.Boolean  | True or False                                  |
| DataTime | Moments in time                    | 8               | System\.DataTime | 0:0:00 on 01/01/0001 to 23:59:59 on 12/31/9999 |
| string   | Sequence of Characters             | 2 per character | System\.String   | N/A                                            |


Download .Net core:

https://dotnet.microsoft.com/download

- Console Application

```sh
dotnet new console -o name_folder
```

```sh
dotnet run
```
