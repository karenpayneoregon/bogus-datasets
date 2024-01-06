# Custom Bogus DataSet for NorthWind

## Introduction

[Bogus](https://github.com/bchavez/Bogus) NuGet [package](https://www.nuget.org/packages/Bogus) is fake data generator which can be helpful for populating tables in a database and testing purposes. If a database is not used and Bogus populates list of data each time an application runs, the data is random, never the same. Also, the random data generated by Bogus may not meet a developerís requirements.

For this reason, Bogus can be extended with a DataSet. Normal use of a DataSet is to set the locale for data generation but in this article learn how to use a Bogus DataSet to use realistic data.

The model will be three tables from a modified Microsoft NorthWind database (script is included in source code), Category, Contact and ContactType.

## Article
