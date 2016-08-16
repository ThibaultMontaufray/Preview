# Droid Database [![Official Site](https://img.shields.io/badge/site-servodroid.com-orange.svg)](http://servodroid.com)

Parsing all sentenses with vocabulary and times. XML file with almost french words. You can add your own database to have your words.

[![Version Status](https://img.shields.io/nuget/v/Manager_Database.svg)](https://www.nuget.org/packages/Manager_Database/)
[![License](https://img.shields.io/github/license/brandondahler/Data.HashFunction.svg)](https://raw.githubusercontent.com/ThibaultMontaufray/Tools4Libraries/master/License)
[![Build Status](https://travis-ci.org/ThibaultMontaufray/Droid-Database.svg?branch=master)](https://travis-ci.org/ThibaultMontaufray/Droid-Database) 
[![Build status](https://ci.appveyor.com/api/projects/status/8ay5ae7x6bpn2v4e?svg=true)](https://ci.appveyor.com/project/ThibaultMontaufray/Droid-database)
[![Build status](https://img.shields.io/jenkins/s/http/servodroid.com:8080/job/CI-Droid-Database.svg?maxAge=2592000)](http://servodroid.com:8080/job/CI-Droid-Database)
[![Jenkins coverage](https://img.shields.io/jenkins/c/http/servodroid.com:8080/CI-Droid-Database.svg?maxAge=2592000?style=flat-square)]()
[![Coverage Status](https://coveralls.io/repos/github/ThibaultMontaufray/Droid-Database/badge.svg?branch=master)](https://coveralls.io/github/ThibaultMontaufray/Droid-Database?branch=master)

# Usage

```csharp
MySqlAdapter.ShowTables();
MySqlAdapter.ExecuteQuery("select * from t_user where name like '%ibo%' group by familly_name");
```
