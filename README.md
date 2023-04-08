# pra-project-cgmv
VUA ALGEBRA
******************

4 Colleagues creating a college project 

The project revolves around creating a simplified professor/course/notification tracker for a college institution.

The app has a login page with input validation.
Depending on the users assigned role, after successful login he gets presented with his own specific main menu screen.

Two possible user roles - ADMIN, PROFESSOR

Admin users - can do basic CRUD on: professors, courses, notification

Professor users - can do basic CRUD on notifications

//

Each entity (professor, course, notification) has some required information for valid input.
Professors get added to courses in a relation professor - course : 1 - n
Professors can do CRUD on notifications for courses they are assigned to
