# _PierreTreats_

#### _C# ASP.NET MCV w/ MySQL Project for Epicodus, October 23th, 2020_

#### By _** Daniel Schaaf **_

## Description

This Project was to show Authorizations and many to many Database relationships. Pierre Came back for his third webpage redesign so he can show off his new business entity inside of his Bakery business. 


###Brainstorming


 
### Specs
| Spec | |  |
| :-------------     | :------------- | :------------- |
|  1.  Create Treats and Flavor classes | | |
|  2.  Create Controllers for Treats, Flavors |  |  |
|  3.  Build the views for Treats and Controllers| ||
|  4.  Build Home Controllers for Index |  |  |
|  5.  Build Home Views for Index |  |  |
|  6.  Build Account Controller
|  7.  build ManageUserController
|  8.  build Application User.cs class
|  9.  build the View Models for the Authorization classes
|  10.  Add Links to Authorization Class and HTML |  |  |
|  11.  Add CSS and Styling |  |  |


## Setup/Installation Requirements

### Project from GitHub
* Download option
  * Download files from GitHub repository by click Code and Download Zip
  * Extract files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * Make Treats,Flavors and Orders

* Cloning options
  * For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  * Place files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * Make Treats and flavors.

### Database Setup

*setup with database update
* run dotnet ef database update and it will build out your database.

* Setup with SQL Import
  * MySQL
    * In the Navigator > Administration window, select Data Import/Restore.
    * In Import Options select Import from Self-Contained File.
    * Navigate to daniel_schaaf.sql.
    * Under Default Schema to be Imported To, select the New button.
      * Enter 'daniel_schaaf' as the name of your database.
      * Click Ok.
    * Click Start Import.
  * Go to appsettings.json and change the password if needed.

## Known Bugs


also user cant delete order

## Technologies Used

Main Programs
* MySQL
* C# / ASP.NET Core a
* MVC
* CSS
* Bootstrap


### Other Links
[Daniel's GitHub](https://github.com/dschaaf89)

### License

Copyright (c) 2020 **_{ Daniel Schaaf}_**
Licensed under MIT
