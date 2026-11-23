# Program Specification

*Copied from the SDU SE OOP Sønderborg 2026 Workshop handout (Sprint 2).*

Sønderborg's library aims to launch a digital platform to manage and share its diverse digital media collection. The system should support multiple types of media, including:

- **E-books** with information about their title, author, language, number of pages, year of publication and ISBN. Users can view, download and read them.
- **Movies** with information about their title, director, genres, release year, language and duration. Users can watch and download them.
- **Songs** with information about their title, composer, singer, genre, file type, duration and language. Users can play and download them.
- **Video-games** with information about their title, genre, publisher, release year and supported platforms. Users can download, play and eventually complete them.
- **Apps** with information about their title, version, publisher, supported platforms and file size. Users can download and execute them.
- **Podcasts** with information about their title, release year, host(s), guest(s), episode number and language. Users can download and listen to an episode and complete it.
- **Images** with information about their title, resolution, file format, file size and date taken. Users can download and display an image.

Users should be able to borrow all media items, and only users who have borrowed an item may rate it.

The system must also support three categories of users: Admin, Employee and Borrower. For each of these the system needs to know the name, age and social security number. As a starting point, user authentication is not required. However on startup, the program should ask the user to identify their role.

- **Borrower** interact with the collection by listing items by type, selecting and previewing details, rating items, and performing actions specific to the media type.
- **Employee** is responsible for managing the collection with the ability to add or remove media items.
- **Admin** has all of an Employee's rights and can additionally manage Borrowers and Employees. Management covers viewing, creating, deleting, updating the personal information of users.

The supported actions should be made available to all user categories in a clear and structured way.

The console interface should guide the user with clear instructions and validate all inputs. Errors or invalid actions should not pass this filter. The design should anticipate growth through extensibility, ensuring that new media types or user roles can be added without disrupting existing functionality.
