**Initial Setup/Design Decisions -- Needs to be done ASAP**

1.  **Create initial repos/files**

    a.  **GitHub Repo -- Yenny**

        i.  Sam will save this file in the repo

    b.  **ASP.NET webAPI setup -- Mike, Omar, & Samaja + Steve & Ron for
        salt/pepper stuff**

        i.  **Create the models**

        ii. **CORS Policies needed**

            1.  SQL case sensitive

            2.  What about the "bad CORS policy?" Copy & paste this in.
                🡨allows React app to hit the API

        iii. **EF Core with migrations (see below for tables needed)**

        iv. **Folder structure -- put a dummy file in each folder**

            1.  0\. Models & DTOs

            2.  1\. Controller Layer

            3.  2\. Service Layer

                a.  Interfaces

            4.  3\. Data Access Layer

                a.  Interfaces

                b.  Data Context

    c.  Create the initial React App

        i.  Folder structure (just a starting point)

            1.  Components

                a.  NavBar (across the top)

                b.  Log In Screen

                c.  Logged In Screen

                d.  Leave Management

                e.  Performance Management

                f.  Employee Management (Managers)

                g.  My Profile

            2.  CSS file we can all import (use Bootstrap template?)

2.  **Version Control**

    a.  Each team

        i.  Has its own branch for the feature they're assigned

    b.  Pushing to main -- how do we want to handle this?

3.  **Testing**

    a.  Each team handles validation (in front end and backend) of their
        feature, including coming up with what to validate

4.  **Models/Tables Needed**

    a.  Use Entity Relationship Diagram

        i.  New Table:

            1.  Encryption

                a.  Salt

        ii. All IDs should be Guids

    b.  Sam's Notes:

        i.  Employee

            1.  First Name

            2.  Last Name

            3.  Employee ID

            4.  Address

                a.  Street

                b.  2^nd^ Line

                c.  City

                d.  State

                e.  Zip

            5.  Email address

            6.  Manager ID

            7.  Birthday

        ii. Manager -- **child of employee? -OR- employee type indicator
            field?**

            1.  Everything in employee

            2.  List of employee IDs

        iii. Leave Requests

             1.  Employee ID

             2.  Start Date

             3.  End Date

             4.  Leave Type

             5.  Manager ID

             6.  Manager Approval Status

        iv. Leave Balances

            1.  Employee Id

            2.  Leave Type

            3.  Leave Balance

        v.  Goals

            1.  Employee Id

            2.  Goal Id

            3.  Goal description

            4.  Goal weight

            5.  Deadline

            6.  Self Rating by Goal

            7.  Manager Rating by Goal

        vi. Company Holidays

5.  **Other decisions/considerations**

    a.  CSS styling/overall look of the front-end

        i.  Way to handle this: 1 person from each team be the styling
            expert so we have uniformity across the whole web app front
            end

    b.  DevOps

    c.  Testing -- any kind of cross-app testing plan & execution

    d.  Scrum process

        i.  When to demo to each other? Good to have deadlines for this
            so we're not cramming at the end -- maybe aim to demo on
            6/28, 7/2, and 7/5?

        ii. Do we want to use boards? Think it'd be helpful, but some
            folks might think it's too much admin

**Features/Teams**

1.  **Leave Management**

    a.  Employee:

        i.  CREATE/POST: Apply for leave/leaves

            1.  View manager's name while applying for leave

        ii. READ: Get details about applied leaves

        iii. \*\*Get holiday data

        iv. \*\* Get email notification when leave is approved or
            rejected

    b.  Manager:

        i.  For themselves/as an employee: All tasks in "Employee"
            section

        ii. For their team/as a manager:

            1.  UPDATE: Approve/reject leave

            2.  Get email notification when an employee applies for
                leave

            3.  [Interact with a dummy API to update a payroll service
                for changes in paid or unpaid leave]{.mark}

                a.  This may include endpoints to update payroll records
                    based on approved leaves

                b.  The dummy service will periodically send error
                    status codes, requiring proper handling of HTTP
                    status codes

2.  **Employee Management**

    a.  Employee:

        i.  Log in

            1.  Passwords should be encrypted using appropriate hashing
                algorithm

        ii. Change password

        iii. Request a forgotten password (which will be sent to their
             registered email)

        iv. Edit basic profile information like phone number and address

        v.  View birthday and work anniversaries "of the employees"? --
            maybe just view their own? Or their coworkers? Or none?

    b.  Manager:

        i.  For themselves/as an employee: All tasks in the "Employee"
            section

        ii. For their team/as a manager:

            1.  View birthdays and work anniversaries of everyone that
                reports to them

            2.  See the list of employees who report to me

3.  **Performance Reviews**

    a.  Employee:

        i.  Enter the performance review document with deliverables,
            achievements, and areas of improvement in a textual form

        ii. Get notified when the manager provides feedback for the
            performance review

    b.  Manager:

        i.  For themselves/as an employee: All tasks in "Employee"
            section

        ii. For their team/as a manager:

            1.  Review and provide feedback and score for the
                self-performance review provided by the employees who
                report to this manager

            2.  Get an email notification when an employee submits the
                performance review

            3.  Include reports representing the results of the
                performance reviews for their team

4.  **Goal Setting -- merge with 3**

    a.  Employee:

        i.  Create the goals and targets for the year

        ii. Each goal and target will have a deadline and a weight

    b.  Manager:

        i.  For themselves/as an employee: All tasks in the "Employee"
            section

        ii. For their team/as a manager: N/A

**\*\* I think Goal Setting should be combined with Performance & given
to a single team, but I don't know what the 4^th^ team would do instead.
Options:**

A.  Could have 3 teams instead of 4

B.  Maybe something with the dummy API idk how complex that is?

C.  Are we gonna have to do something for an admin role? In the doc,
    they only mention admins here:

> ![A close-up of a text Description automatically
> generated](media/image1.png){width="4.001234689413823in"
> height="1.0099792213473315in"}

D.  "Firefighting"

    a.  Late requirements?

    b.  Helping out other teams

E.  Design overall CSS/look of the frontend

F.  Other?

**Feature Teams**

-   **Leave Management**

1.  Marcus

2.  Helen

3.  Phil

4.  Aaron

5.  David

6.  Veda

-   **Employee Management**

1.  Corey

2.  Samantha

3.  Ron

4.  Samaja

5.  Steve

-   **Performance Reviews**

1.  Ross

2.  Mike

3.  Omar

4.  Bradley

5.  Yenny

6.  Josh

7.  Fernando

**Initial Setup**

**Have 1 person do these steps:**

1.  Clone the GitHub repo

    a.  git clone https://github.com/240415-NET/project3.git

2.  Create the gitignore file using this command

    a.  dotnet gitignore

3.  In VS Code

    a.  Run this command to create the API

        i.  dotnet net webapi \--use-controllers -o NameOfYourAPI

    b.  Run two commands for adding packages

        i.  dotnet add package Microsoft.EntityFrameworkCore.SqlServer

        ii. dotnet add package Microsoft.EntityFrameworkCore.Design

    c.  Create the Data folder & the DataContext.cs file inside of it

        i.  Add in this using statement:

            1.  using Miscrosoft.EntityFrameworkCore;

        ii. Create the DataContext class, which will inherit from the
            DbContext class (which comes preloaded with
            Microsoft.EntityFrameworkCore)

            1.  Create a constructor for the class

            2.  Add in your DbSet properties (which will be the table
                names that get generated by EF Core)

    d.  Program.cs

        i.  Read the connection string

            1.  string connectionString =
                File.ReadAllText(@\"../../ConnectionString.txt\");

        ii. Add in the
            Builder.Services.AddDbContext\<NameOfDbContextClassYouCreated\>

            1.  builder.Services.AddDbContext\<DataContext\>(options
                =\>options.UseSqlServer(connectionString));

    e.  Create the models -- ours are User and Activity.

        i.  Label the primary key with the \[Key\] annotation

            1.  Add in using System.ComponentModel.DataAnnotations;

        ii. Add in anything needed to reflect the relationship between
            users & activity

**Everyone else needs to do this part:**

1.  Clone the GitHub repo

    a.  git clone https://github.com/240415-NET/project3.git

2.  Create the connection string file

3.  Run two commands for adding packages

    a.  dotnet add package Microsoft.EntityFrameworkCore.SqlServer

    b.  dotnet add package Microsoft.EntityFrameworkCore.Design

**\
**

**Setting Up Layers & Creating Initial Methods in Each Layer**

1.  **Create the Controller Layer class**

    a.  You can copy the WeatherForecaseController.cs file so you can
        get the using statement, the \[ApiController\] & \[Route\], &
        then change the name of the class so it still inherits from
        ControllerBase. Just delete out the body of the code block for
        the class.

    b.  Add a property for the interface that will be in the next layer
        down (the Service Layer)

    c.  Add a constructor that takes in an object of type interface from
        the Service Layer

        i.  Register the dependency in Program.cs so that an item of
            type IUserService (or whatever you call the Service Layer
            interface) will be passed to this constructor when it's
            called

    d.  Create a method inside of this class

        i.  Before the method signature, include an http verb like
            \[HttpPost\]

        ii. This method will call a method in the Service Layer

2.  **Create Service Layer file and class**

    a.  Have the class implement an interface (in the Service Layer)

    b.  Add a property for the interface that will be in next layer down
        (the Data Layer)

    c.  Add a constructor that takes in an object of type interface from
        the Data Layer

        i.  Register the dependency in Program.cs so that an item of
            type IUserStorage (or whatever you call the Data Layer
            interface) will be passed to this constructor when it's
            called

    d.  Create the method inside of this Service Layer class

        i.  This method will call a method in the Data Layer

3.  **Create the Service Layer interface**

    a.  Copy and paste the method signature from the Service Layer
        method into this interface

4.  **Create the Data Layer file and class**

    a.  Have the class implement an interface (in the Data Layer)

    b.  Include a property for the DbContext (in ActivityTracker, we've
        named ours DataContext)

    c.  Add a constructor that takes in an item of type DataContext

    d.  Create the method inside of this class

        i.  This method will call a method off of the DataContext object

5.  **Create the Data Layer interface**

    a.  Copy and paste the method signature from the Data Layer method
        into this interface

6.  **Run these commands**

    a.  dotnet ef migrations add YourMigrationName

    b.  dotnet ef database update

    c.  dotnet run

**Creating Any Future Methods in These Layers**

1.  **Add the method to the Controller Layer**

    a.  This will call a Service Layer method that we'll create in the
        next step

2.  **Add the method to the Service Layer**

    a.  This will call a Data Layer method that we'll create in the next
        step

3.  **Add the method to the Data Layer**
