## High-level Requirements

### 1. Minimum Viable Product

A web browser accessible application that provides basic functions for managing and tracking a Software Development Life Cycle (SDLC). User will be able to create, read, update and delete (CRUD) tasks that are stored in a database accessible through the application. There will be two levels of user access for actioning and accessing task details. The application will also provide authentication/authorization of users through a login function.

####      1.1 Product Functionality

1. The application shall be accessible worldwide via a registered web address from the users web browser.
2. The web application will utilize a web server/service provider to host the web site.
3. The application will utilize a database that implements CRUD operations through the web site.

4. The system shall allow a user with appropriate privileges the ability to add and remove users from the database. 

5. The system shall be able to generate job tickets that are stored in the database.

6. The system shall have the ability to assign attributes to job tickets including: development stage, task deadline, priority level and individual(s) assigned to the task.

7. The system shall be able to sort job tickets by development stage, task deadline, priority level, and individual assigned.

####      1.2 Login Authentication

1. The user shall be able to sign up for a new account as a means to access the application.
2. For users with existing accounts, they will be able to login with existing user name and password.
3. Users will be given the ability to reset login information utilizing the email account they created their original login with.

####      1.3 Dashboard

1. Upon login, user will be presented with a dashboard that displays information tailored to their user role (Tier 1 or Tier 2).
2. Tier 1 users dashboard will display overall project status.
3. Tier 2 users dashboard will display tasks assigned to their account.

### 2. Fully Viable Product

In addition to the minimum viable product requirements, third party plug-in's for login and User Interface (UI) will be incorporated to provide a more refined User Experience (UX). This will decrease time 

#### 	  2.1 Product Functionality

1. Provide access security utilizing third party plugin Auth0.
2. Utilize front-end toolkit Bootstrap for consistent GUI experience across all application/web pages.
3. Schedule sprints with a start date and end date.
4. Assign specific tasks to completed in a scheduled sprint.

### 3. Stretch Features

#### 	  3.1 Options For Future Functionality

1. Send workers an email when they are assigned a job task
2. Send workers a text message when they are assigned a job task
3. Send project manager an email when a task is marked complete by a worker
4. Send project manager a text when a task is marked complete by a worker
5. Provide workers and project managers the option to receive email or text notifications
6. Fully integrated with Azure
7. Provide ability to create additional user access levels beyond Tier 1 and Tier 2.
8. Functionality for users to provide feedback during/after a sprint as a task to document accomplishments, challenges, and ideas for improvement.
9. Dark mode!

####      3.2 Edge Computing Functionality

1. Create mobile application that synchronizes with the web application to provide consistent project state in both web browser and application formats.
2. Ability to function without an internet connection. When device connects to the internet, information is synchronized with the central database.

