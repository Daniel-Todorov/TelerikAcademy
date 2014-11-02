

GENERAL:

The database from MS SQL Server has been detached. Please, attach it to check the diagram.

The diagram from MySQL Workbench is saved as separate file - UniversityMySQLDiagram.mwb. Double click should be able to open it in Workbench and let you check the diagram itself.



EXPLANATIONS:

1. The universities are stored in a table with ID as primary key and name.

2. Faculties are stored in a table with ID as primary key and name.
- becase each university can have multiple faculties but typically one faculty cannot belong to multiple universities the relation is one to many (the university ID is a foreign key to the culumn UniversityID in Faculties).

3. Departments are stored in a table with ID as pirmary key and name.
- because each faculty can have multiple departments but typically one department cannot belong to multiple faculties the relationship is one to many (the faculty ID is a foreign key to the column FacultyID in Departments).

4. Students are stored in a table with ID as primary key and name.
- the problem says that each student belongs to a faculty so the relation is one to many (the faculty ID is a foreign key to the colum FacultyID in Students).

5. Courses are stored in a table with ID as primary key and name.
- the problem says that a student can belong to several course and each course consists of several students so the relationship is many to many (implemented with a third table StudentsCourses where the corresponding IDs are foreign keys.
- each department can have several courses so the relation is one to many (the departmentID is a foreign key to the column DepartmentID in Courses).
- each professor can have several courses so the relation is one to many (the professor ID is a foreign key to the ProfessorID column in Courses).

6. Academic titles are stored in a table with ID as primary key and name.
- the problem states that a professor can have a set of titles (several titles) and its logical to assume that several professors can have the same title so the relationship is many to many (implemented with a third table ProfessorsAcademicTitles where the corresponding IDs are foreign keys).