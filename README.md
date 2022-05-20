# Title
#### By _**Marcus Lorenzo**_
---


| **_Overview_:** |
|---|

**Summary goes here**

**Notes:** anything extra to mention.


#### Technologies Used:
![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![image](https://img.shields.io/badge/MySQL-005C84?style=for-the-badge&logo=mysql&logoColor=white)
![image](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)  ![image](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![image](https://img.shields.io/badge/GIT-E44C30?style=for-the-badge&logo=git&logoColor=white)

---


| **_Description_:** |
|---|

##### **My primary objectives** outside of the prompt were:


---

| **_Setup & Installation_:** |
|---|

|   via CLI   |
|---|
| Download install Git Bash (Windows), use the terminal in your text editor, or open Terminal(Mac) 
| Open Git Bash or Terminal and type: `cd desktop` 
| Next, clone `https://github.com/marcusanthonylorenzo/` 
| Once completed, open this new directory in your text editor
| In the root directory, create a file called `appsettings.json`.
| Inside this file write:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=inventory_site;uid=root;pwd=epicodus;"
  }
}
```
**Save and you are ready to go!**

 
|  MySQL Setup  |
|---|
| In your MySQL Workbench, click Connect to Database, Stored Connection:  Local instance 3306
**Must match the `Port=3306;` in the `"DefaultConnection"` query inside your `appsettings.json` file.**
| In **Schemas Navigator** in the Navigator bar on the left, right-click and select "Create Schema".
| The name of the new Schema **must match the `database={new_schema_name};` in the `"DefaultConnection"` query inside your `appsettings.json` file.**
| Once loaded, go to your new Schema tree in the Navigator bar on the left, click down to Tables, right click "Create Table".
| Your details should look like this:

[Image of applied tables here]

#### Running Tests:
- To view tests via MSTest, in your CLI type `dotnet test`.

#### Known Bugs:
* None at present time.

---

| **_Design Plan_ (Specs):** |
|---|
#### Create:
- [ ] List item
- [ ] List item
- [ ] List item

#### Objects, Properties:

#### Collections/Groupings:
- none at present moment.

#### Behaviours/Interactivity:

---
| **_License_:** |
|---|

[MIT]()

Copyright (c) 2022 _Marcus Lorenzo_


#### Thanks for viewing!
