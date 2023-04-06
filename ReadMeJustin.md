********************************************************************************************
This ReadMe file explains the logic of the HW Assignment 3: TechJobs MVC related files
********************************************************************************************
JobData.cs
review to show understanding of code----------------------------------------------INCOMPLETE

Jobs.cshtml[x]
TODO #1 - Use a loop to display job results in a table.---------------------------INCOMPLETE

ListController.cs[x]
TODO #2 - Complete the Jobs action method-----------------------------------------INCOMPLETE

SearchController.cs[x]
TODO #3 - Create an action method to process
a search request and render the updated search views.-----------------------------INCOMPLETE

Views=>List=>Index.cshtml[]
Task 3 TODO #2: Complete the View Jobs By Category Table.-------------------------INCOMPLETE

Views=>Search=>Index.cshtml[]
Task 3 TODO #4 - Loop over the search results to display all job fields.----------INCOMPLETE
********************************************************************************************
JobData.cs
********************************************************************************************
A C# ASP.NET MVC application, specifically the implementation of a data access layer for a job search website. It defines a JobData class that provides methods to find and retrieve job postings from a CSV file.

The JobData class contains a static List of Job objects called AllJobs, as well as several other static List objects that represent fields associated with job postings, such as employers, locations, position types, and core competencies.

The **FindAll** method simply returns a new List object containing all the Job objects stored in the AllJobs list. The FindByColumnAndValue method allows the user to search for jobs by a specific field (specified by the column parameter) and a corresponding value (specified by the value parameter). It first calls the LoadData method to ensure that the data has been loaded from the CSV file, and then searches through the AllJobs list to find jobs that match the given criteria.

The GetFieldValue method takes a Job object and a field name as parameters, and returns the value of the corresponding field as a string. The FindByValue method allows the user to search for jobs that contain a specific value in any of the fields associated with a job posting.

The LoadData method reads in the data from the CSV file specified by the DATA_FILE constant, creates new Job, Employer, Location, PositionType, and CoreCompetency objects for each row in the CSV file, and adds them to the appropriate lists. If the data has already been loaded, this method simply returns without doing anything.
********************************************************************************************
Jobs.cshtml
TODO #1 - Use a loop to display job results in a table.---------------------------INCOMPLETE
********************************************************************************************
The code starts by defining a container with a class name container body-content. Then, it displays the value of the **ViewBag.title** variable within an H1 tag.

After that, there are two options for displaying the job results in a table.

The first option, commented out, uses a single table to display all the job results using a loop that iterates through each job in the **ViewBag.jobs**  collection. For each job, a table row is created that displays the job's Id, Name, Employer, Location, Position Type, and Core Competency in separate paragraphs.

The second option uses a table for each job, with the same details but organized in rows and columns. Again, the loop iterates through each job in the ViewBag.jobs collection, and for each job, a new table is created that displays the job's details in separate rows and columns.

Overall, this code snippet is a view that displays a list of job results in a table format using Razor syntax.
********************************************************************************************
ListController.cs
TODO #2 - Complete the Jobs action method-----------------------------------------INCOMPLETE
********************************************************************************************
This is a C# code for an ASP.NET Core MVC application. It includes the following namespaces:

**System:** Provides fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions.
**System.Collections.Generic:** Provides classes and interfaces that support generic collection development.
**System.Linq:** Provides classes and interfaces that support queries that use Language-Integrated Query (LINQ).
**System.Threading.Tasks:** Provides types that simplify the work of writing concurrent and asynchronous code.
**Microsoft.AspNetCore.Mvc:** Provides classes and interfaces that support the development of ASP.NET Core MVC web applications.
The code defines a controller class called **ListController** that inherits from the base **Controller class**. 

Methods:

**Index:** Returns a view that displays a list of jobs. It sets several ViewBag properties to pass data to the view, including ColumnChoices, TableChoices, employers, locations, positionTypes, and skills.
**Jobs:** Returns a view that displays a list of jobs based on the specified column and value parameters.
The ListController also includes two internal static fields:

**ColumnChoices:** A dictionary that maps column names to column display names. It is used to populate a dropdown list in the view.
**TableChoices:** A dictionary that maps column names to lists of JobField objects. It is used to populate a table in the view.
The code uses the **JobData** class to retrieve data about jobs, including employers, locations, position types, and core competencies. The Index method sets ViewBag properties for each of these data types to pass them to the view. The Jobs method is not fully implemented and needs to be completed with additional code to return a view that displays a list of jobs based on the specified column and value parameters.
********************************************************************************************
SearchController.cs
TODO #2 - Complete the Jobs action method-----------------------------------------INCOMPLETE
********************************************************************************************
This is a C# code file for a controller class named SearchController. This controller inherits from the Controller class of the ASP.NET Core MVC framework.

The Index action method returns a view named Index, and sets a ViewBag property named columns with the value of the ColumnChoices dictionary property of the ListController class.
********************************************************************************************
SearchController.cs Task completion explanation
********************************************************************************************
The Results() action method takes in two parameters: searchType and searchTerm, both of which are strings. It creates a local variable called jobs of type List<Job>.

If the searchTerm is empty or if searchType is "all", it calls the FindAll() method from JobData to get all the jobs. Otherwise, it calls FindByColumnAndValue() with the searchType and searchTerm to get jobs that match the search criteria.

The jobs list is then passed to the Results.cshtml view along with the ColumnChoices dictionary from ListController.
********************************************************************************************
Views=>Index.cshtml
TASK 4: DISPLAY SEARCH RESULTS 
TODO #4 - Loop over the search results to display all job fields.
A) Create a loop to display each job passed in from the controller.
B) Put the job results into a set of tables, similar to what you did for the List/Jobs.cshtml view.
********************************************************************************************
