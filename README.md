
# CRUD APPLICATION USING VISUAL STUDIO AND MSSQL DATABASE

Faciliates in understanding and demonstrating about the basic concepts of CREATE,READ,UPDATE AND DELETE.

## PREVIEW

![Screenshot (297)](https://github.com/user-attachments/assets/9f760baa-3fdb-4ef7-867d-68beae1c053d)

## BUILT WITH

Programming Language: C#(.Net Framework)

Database: Microsoft SQL Server

IDE: Visual Studio / VS Code


## FEATURES (BUTTONS)

Insert: Add new user data to the database.

Delete: Remove existing user data based on userid.

Update: Modify details of a selected user.

Search: Search for the existing data from the datagridview 

## SQL QUERY

Table Design

CREATE TABLE [dbo].[GYM1] (
    [MemberID]     INT (50) NULL,
    [MemberName] VARCHAR (50) NOT NULL,
    [Age]   INT NOT NULL,
    [Gender]   VARCHAR (50) NOT NULL,
    [Date]   datetime  NOT NULL,
    [UpdateDate]   datetime  NOT NULL,
    CONSTRAINT [PK_GYM1] PRIMARY KEY CLUSTERED ([MemberID] ASC)
);


Insert

"Insert into GYM1 values
 ('" + int.Parse(textBox1.Text) + "','" 
 + textBox2.Text + "','" 
 + int.Parse(textBox3.Text) + "','" 
 + (comboBox1.Text) 
 + "',getdate(),getdate())", con



Update

update GYM1 set MemberName='" + textBox2.Text 
+ "',Age='" + textBox3.Text 
+ "',Gender='" + comboBox1.Text 
+ "',UpdateDate= '"+DateTime.Parse(dateTimePicker1.Text)+"'
 where MemberID= '"+int.Parse(textBox1.Text)+" ' ", con


Delete

Delete GYM1 where MemberID= '" + int.Parse(textBox1.Text) + "'", con


Search

select * from GYM1 where MemberID= '"+int.Parse(textBox1.Text)+"'", con


## HOW TO RUN IT

1. Download all the necessary files from this repository
2. The database sql script file should be also donwloaded
3. The query should be executed after running the script in the respective database file
4. After running the visual studio, the database connection string should also be updated according to the desired database string found in your server explorer
5. Save and run the project

## TECHNOLOGY

Programming Language: C#

Database: SQL Server

Framework: Windows Forms

UI Components:

- Text Box for entering data.
- Button for response.
- Data Grid View for displaying and managing data

## 🛠 Skills

C#

NET Framework

SQL Server

Windows Forms Development

