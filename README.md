# LMS



SEMESTER PROJECT
Progress Report
Library Management System (LMS)
A Desktop Application for Managing Books, Students & Borrowing Records

Class:  BSCS-B (2nd Semester)
Report Date:  June 10, 2026
 1. Project Introduction
The Library Management System (LMS) is a desktop application developed using C# and Windows Forms (WinForms). It is designed to digitize and automate the core operations of a university or institutional library, replacing manual paper-based workflows.

The application is built on .NET 10.0 and uses Microsoft SQL Server Express (via the Microsoft.Data.SqlClient package) as its database backend. A shared static ClassDB class manages the SQL connection across all forms, providing a consistent data access layer throughout the project.

The system provides a secure, role-based interface for library administrators to manage books, registered students, and the full borrowing lifecycle, from issuing books to tracking returns.

Key Objectives:
•	Centralized management of book inventory with full CRUD operations.
•	Student registration and record-keeping indexed by enrollment number.
•	Streamlined book issuance with a business rule enforcing a maximum of 3 books per student at any time.
•	Book return processing that restores inventory quantity automatically.
•	A complete audit log showing all issued and returned book records across all students.
•	Secure login and admin authentication before granting dashboard access.
•	A splash screen on startup for a polished user experience.

2. Implemented Modules
2.1  Splash Screen
Status: Fully Implemented
The SplashScreen form is the first thing that appears when the application launches. It displays the project name and a progress bar that fills over approximately 3 seconds. Once the progress bar reaches 100%, the splash hides itself and opens Form1 (the Login screen) automatically. This gives the application a professional startup feel.

Features:
•	Timer-driven progress bar with an interval of 30ms, incrementing by 1 each tick.
•	Automatically transitions to the Login form when loading is complete.
•	FormBorderStyle set to None and StartPosition set to CenterScreen for a clean, borderless appearance.
 
2.2  Login Module
Status: Fully Implemented
The Login form (Form1) is the entry point of the main application after the splash screen. It authenticates administrators by checking credentials against the login table in SQL Server before granting access to the dashboard.

Features:
•	Username and password fields with placeholder text that clears on mouse enter.
•	Password field uses PasswordChar = '*' for masked input.
•	Credentials validated via a parameterized SELECT query against the login table.
•	On successful login, the Dashboard is opened and the login form is hidden.
•	Invalid credentials display a warning message box.
 
2.3  Admin Dashboard
Status: Fully Implemented
After a successful login, the administrator is directed to the Admin Dashboard. This is the central hub of the application, providing access to all modules through a top navigation menu strip.

Navigation menu items and their linked forms:
•	Books → Add New Book (Addbook form), View Books (ViewBook form).
•	Students → Add Student (AddStudent form), View Student Info (VeiwStudentInformation form).
•	Issue Books → IssueBooks form.
•	Return Books → ReturnBook form.
•	Complete Book Details → BookDetails form.
•	Exit → Prompts confirmation before calling Application.Exit().
 
2.4  Add Books Module
Status: Fully Implemented
The Addbook form allows the administrator to add new books to the library inventory. A BookID is auto-generated on load by counting existing records in the Books table and formatting the result as B001, B002, and so on.

Input fields with validation:
•	Book Name, Author Name, Publisher — text fields, each validated as non-empty before saving.
•	Book Price and Book Quantity — validated as non-empty.
•	Book Purchase Date — DateTimePicker defaulting to today's date.
•	Save button inserts the record via a parameterized INSERT INTO Books query.
•	All fields are cleared after a successful save so another book can be entered immediately.
•	Cancel button shows a confirmation dialog before discarding unsaved data and closing.
 
2.5  View / Edit Books Module
Status: Fully Implemented
The ViewBook screen loads all books into a DataGridView on form load. A hidden RawId column holds the actual integer BookId for use in UPDATE and DELETE operations, while a formatted BookId column (B001, B002, etc.) is displayed to the user.

Features:
•	Live search bar filters books by name as the administrator types (LIKE query).
•	Double-clicking a row populates the edit panel below the grid with that book's details.
•	Update button runs a parameterized UPDATE Books WHERE BookId = @bookid using the hidden RawId.
•	After a successful update, the grid reloads and the previously edited row is re-selected automatically.
•	Delete button runs DELETE FROM Books WHERE BookId = @bookid with an OKCancel confirmation.
•	Refresh button reloads all books and clears the edit fields.
•	Grid columns displayed: BookId (formatted), BookName, AuthorName, Publisher, BookPrice, BookQuantity, DateAdded.
 
2.6  Add Student Module
Status: Fully Implemented
The AddStudent form allows the administrator to register new students into the system. All fields are individually validated before the record is committed to the Students table.

Input fields:
•	Student Name, Enrollment Number, Department, Semester, Contact Number, Email Address.
•	Each field is validated as non-empty with a specific warning message if left blank.
•	A parameterized INSERT INTO Students query saves the record, including the current date as DateAdded.
•	All fields are cleared after a successful save. Refresh button also clears all fields manually.
•	Exit button shows a confirmation dialog before closing.
 
2.7  View / Edit Student Information Module
Status: Fully Implemented
The VeiwStudentInformation form loads all student records into a DataGridView on startup. The administrator can search by enrollment number, click a row to populate the edit fields, and then update or delete the record.

Features:
•	Live enrollment number search filters the grid in real time.
•	Clicking a grid row auto-fills all edit fields with .Trim() applied to remove whitespace.
•	Update button runs a parameterized UPDATE Students WHERE Enrollment = @enrollment. Connection state is explicitly checked and closed before reopening to prevent stale connection issues.
•	Delete button runs DELETE FROM Students WHERE Enrollment = @enrollment with a YesNo confirmation. Shows a 'Not Found' message if 0 rows are affected.
•	Refresh button clears the search filter and reloads all records.
•	Fields managed: StudentID, Name, Enrollment, Department, Semester, Contact, Email.
 
2.8  Issue Books Module
Status: Fully Implemented
The IssueBooks form enables the librarian to issue a book to a registered student. The student details are fetched from the database by searching their enrollment number, and the desired book is selected from a dropdown populated with available titles.

Key features:
•	Enrollment number search auto-populates Student Name, Department, Semester, Contact, and Email fields.
•	Book Name dropdown is loaded with books where BookQuantity > 0 only, so out-of-stock books never appear.
•	Before issuing, a COUNT query checks the IssuedBooks table for records WHERE Status = 'Issued' for that student. If the count is 3 or more, issuance is blocked with a 'Maximum limit reached' warning.
•	On successful issue, a record is inserted into IssuedBooks with Status = 'Issued', and BookQuantity in the Books table is decremented by 1.
•	The book dropdown refreshes automatically after each successful issuance.
•	Issue Date picker defaults to today's date.
 
2.9  Return Books Module
Status: Fully Implemented
The ReturnBook form processes book returns. The administrator searches by enrollment number to load that student's currently issued books. Double-clicking a row in the grid populates the return form fields.

Key features:
•	Grid loads only records WHERE Status = 'Issued' for the searched enrollment, ordered by IssueDate descending.
•	Double-clicking a row fills Book Name and Issue Date fields for confirmation.
•	Return button runs UPDATE IssuedBooks SET Status = 'Returned', ReturnDate = @returndate WHERE EnrollmentNo = @enrollment AND BookName = @bookname AND Status = 'Issued'.
•	On successful return, BookQuantity in the Books table is incremented by 1.
•	The grid refreshes automatically after a return to reflect the updated issued list.
•	Grid columns: Book Name, Book Issue Date, Book Return Date, Status.
 
2.10  Complete Book Details Module
Status: Fully Implemented
The BookDetails form is a read-only report screen. It loads all records from the IssuedBooks table on startup and displays them in a DataGridView, giving the administrator a complete audit trail of every book issuance and return across all students.

Grid columns:
•	IssueId, EnrollmentNo, StudentName, Department, Semester, BookName, IssueDate, ReturnDate.
•	AutoGenerateColumns is set to false; columns are defined manually in the Designer for consistent display.
•	When the form is closed, the application checks if the Dashboard is still open. If not, it re-opens the Dashboard automatically so navigation is never lost.

  3. Technology Stack
The following technologies and tools were used in the development of this project:

Component	Technology / Tool
Programming Language	C# (.NET 10.0-windows)
UI Framework	Windows Forms (WinForms)
Database	Microsoft SQL Server Express (SQLEXPRESS)
Data Access	Microsoft.Data.SqlClient (NuGet package)
IDE	Visual Studio 2022
Report Date	June 10, 2026


4. Database Structure
The application uses a SQL Server Express database named LMS on the local instance. The database consists of four core tables:

login
Stores administrator credentials. Columns: Name, Pass. Used by the Login form to authenticate admin access.

Books
Stores the library's book inventory. Columns: BookId (identity, PK), BookName, AuthorName, Publisher, BookPrice, BookQuantity, DateAdded. BookQuantity is decremented on issuance and incremented on return.

Students
Stores registered student records. Columns: StudentID (identity, PK), Name, Enrollment (unique), Department, Semester, Contact, Email, DateAdded. Enrollment is the key used to look up students across all other forms.

IssuedBooks
Stores all book issuance and return transactions. Columns: IssueId (identity, PK), EnrollmentNo, StudentName, StudentEmail, StudentContact, Semester, Department, BookName, IssueDate, ReturnDate (nullable), Status ('Issued' or 'Returned'). This table serves as the complete audit log for the system.

5. Current Development Status
The following summarizes the implementation progress of each module as of the report date:

Module	Status	Completion
Splash Screen	Complete	100%
Login	Complete	100%
Admin Dashboard	Complete	100%
Add Books	Complete	100%
View / Edit Books	Complete	100%
Add Students	Complete	100%
View / Edit Students	Complete	100%
Issue Books	Complete	100%
Return Books	Complete	100%
Complete Book Details	Complete	100%
Dashboard Stats Cards	In Progress	100%


6. Conclusion
The Library Management System has been substantially completed. All core modules, including the Splash Screen, Login, Admin Dashboard, Book Management (Add, View, Edit, Delete), Student Management, Book Issuance, Book Returns, and the Complete Book Details report, are fully implemented and functional.

The application successfully enforces key business rules such as limiting each student to a maximum of three simultaneously issued books. Inventory is kept accurate automatically: book quantity decreases on issuance and is restored on return. The connection management layer was refined during development to ensure reliable database operations across all forms.

The remaining work involves populating the Admin Dashboard with live statistical cards showing counts of total books, issued books, registered students, and other metrics, which are currently at approximately 60% completion. No major blockers are anticipated, and the project is on track for full submission within the deadline.
