**<h1 align = "center">Safer Spaces**

<br>

<h4 align = "center">
  <a href="#requirements">Requirements</a> •
  <a href="#setup">Setup</a> •
  <a href="#technologies-used">Technologies</a> •
  <a href="#known-bugs">Known Bugs</a> •  
  <a href="#license">License</a></h4>

<br>

## **ABOUT**

- This program will provide the user with
- The API will list the available cats and dogs at the shelter.

## **INSTALL NOTES**

navigate to desired directory for where your project will go
git clone url
add workspace
cd SaferSpaces
dotnet restore
dotnet build
create a new terminal
cd into SaferSpaces
dotnet ef database update
dotnet watch run

open postman
click the + symbol in the middle of the page

TO GET AN ITEM
Set your request to type "GET"
http://localhost:5000/api/animals/ (for index of all)
or
http://localhost:5000/api/animals/id (for specific animal details)
Hit Send
or
http://localhost:5000/api/animals/Page?pageNumber=2&PageSize=5 (to limit number of displayed animals)

TO ADD AN ITEM
Set your request to type "POST"
http://localhost:5000/api/animals/
Select Body Tab
Select Raw Radio Button
Select JSON from dropdown
Write your addition to the database in the following format
{
"Name" = "your value",
"Species" = "your value",
"Age" = "your value",
"Gender" = "your value",

}

TO EDIT AN ITEM
Make a GET request for the id you wish to edit
http://localhost:5000/api/animals/id
You can select the returned item data and paste that into your request body section for editing.
Once you have completed your edits.
Set your request to Put
Hit Send

To DELETE AN ITEM
Set your route in Postman to the id you wish to delete
Set your request to Delete
Hit Send

## **REQUIREMENTS**

- Install [Git v2.62.2+](https://git-scm.com/downloads/)
- Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
- Install [Visual Studio Code](https://code.visualstudio.com/)
- Install [MySql Workbench](https://www.mysql.com/products/workbench/)

#### Step: **You need to update your username and password in the appsettings.json file.**

_by default these are set to user:root and an empty password. if you are unsure, refer to the settings for your MySqlWorkbench._

![appsettings](https://coding-assets.s3-us-west-2.amazonaws.com/img/app-settings.png)

## **SETUP**

copy this url to clone this project to your local system:

```html
https://github.com/RichterBros/AnimalShelterApi.Solution.git
```

<br>

Once copied, select "Clone Repository" from within VSCode & paste the copied link as shown in the image below.

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif 'Cloning from Github within VSCode')

<br>

With the project open to the root directory, navigate to the production directory with the following commands in your terminal.

```js
cd AnimalShelter
```

```js
dotnet restore
```

```js
dotnet build
```

```js
dotnet ef database update
```

Your application is now built, as well as the requisite database for this application. Now we run the program with...

```js
dotnet watch run
```

<br>

## **Note on Pagination**

The Animal Shelter API returns a defaulit of 5 results per page at a time with a maximum of 5.

To modify this, use the query parameters "limit" and "start" to alter the response results displayed. The "limit" parameter will specify how many results will be displayed, and the "start" parameter will specify which element in the response the liimit should start counting.
<br>

## **TECHNOLOGIES USED**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>

## **KNOWN BUGS**

_**None as of:** 8/21/2020_

<br>

## **LICENSE**

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **Brittany*Lindgren_Mariel Hamson_Jason Khan_Erich Richter.***
