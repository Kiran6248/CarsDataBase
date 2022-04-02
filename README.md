# Bowman Car Hire
## A Car Data base app to do CRUD functionality using c#
### This project is created in Visual Studio 2022. Windows App Form is used to make the app.

### Name of the Project - CarsDataBase

### Front page of the App
![car](https://user-images.githubusercontent.com/70952736/161056014-bf866fd6-5b01-4832-a7dd-c7f98615dea5.PNG)

### UI of the App

#### Backgground colour - Granny Apple(192,255,192), #c0ffc0
#### Font name of heading - Comic Sans from Google fonts
#### Font Size - 18

### Labels and Textboxes on the Car data pages
#### Font Name- Segoe UI
#### Font Size - 11

### Buttons on front page
#### size - 92,44
#### Font Size - 11
#### Background Colour - Granny Apple

### Features on Front page of App
1.  Tooltip with every textbox and checkbox
2.  Tab index functionality
3.  Buttons to Update, Add, Delete, Cancel, Search, Exit.
4.  Buttons to Get records as accordingly. First, Previous, Next and Last.
5.  A textbox to show the entry number of datatable, in the form of n of nn.

### Search page of the App
![search](https://user-images.githubusercontent.com/70952736/161056192-ebb0725a-2e86-4148-99dc-acbe0818a6f0.PNG)

### Features on the Search Page
1.  It has 2 ComboBoxes, one Textbox and one DataGrid View.
2.  The Datagrid is connected with database and loaded the contents with its load
3.  The search function runs by selecting fields in comboboxes and entering in Textbox.
4.  Close button closes the Search form and opens Car Data Form.

### The Database of the App
![data](https://user-images.githubusercontent.com/70952736/161056379-5e4fa071-a8df-4379-a554-9fad5a1c3b07.PNG)

#### The Database is created locally in Visual Studio and connected with the project by (localdb)\mssqllocaldb
#### The name of the database is "Hire"

### Project Barriers and solution
1. First project barrier was to show £ symbol on the app, as after displaying this the Add and Update functions showed error. 
    The SubString() method is used for the RentalPerDay argument to handle this.
2. The search function was not working for enhine size, one error handler is added to handle that.
3. The data display in the default datatable was not according to the project requirement, so DataTableCellAlignment is used to manage that.
