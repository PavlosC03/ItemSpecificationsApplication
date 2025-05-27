# Creating Your Instance

In order to make the application work, you must have SQL Server Management Studio installed, and you must create a local instance using 'sqllocaldb'.
To create the instance, open your command-line prompt and type: <br/> <br/>
```sqllocaldb create MyInstance```
<br/> <br/>
You may check the status of your instance by typing: <br/> <br/>
```sqllocaldb info MyInstance```
<br/> <br/>
It should look something like this: <br/> <br/>
![image](https://github.com/user-attachments/assets/66658a08-a884-4f53-bc98-14c6f8972903)
<br/> <br/>
You must then start your instance by typing: <br/> <br/>
```sqllocaldb start MyInstance```
<br/> <br/>
To stop and delete the instance, type the following respectively: <br/> <br/>
```sqllocaldb stop MyInstance``` <br/>
```sqllocaldb delete MyInstance``` <br/> <br/>
# Connecting to Your Instance

Open SQL Server Management Studio and connect to the server. In the server name, make sure to add the following: <br/> <br/>
```(localdb)\MyInstance```
<br/> <br/> Click connect. 
<br/> <br/> In the object explorer, right-click on the Databases folder and click 'Attach'. Click the 'Add' button and import the database mdf file.
## The .mdf file is located in the DB folder of the repository.
<br/> Launch the WindowsApp project from Visual Studio.
