Install Docker:
If you haven't already installed Docker, download it from Docker's official website.

Pull PostgreSQL Image:

bash

docker pull postgres

Run PostgreSQL Container:

bash

docker run --name my-postgres -e POSTGRES_PASSWORD=mysecretpassword -d postgres

Pull Adminer Docker Image:

bash

docker pull adminer

Run Adminer Container:

bash

docker run --name my-adminer -p 8080:8080 -d adminer

Access Adminer UI:
Open your web browser and go to http://localhost:8080.

Login to Adminer:

    System: PostgreSQL
    Server: localhost
    Username: postgres
    Password: (Enter the password you set earlier)
    Database: (Leave blank or specify)

Setup Admin User (Optional):

    Log in to Adminer.
    Navigate to Users.
    Add a new user with desired privileges.

Pull and Run pgAdmin Docker Image (Optional):

bash

    docker pull dpage/pgadmin4
    docker run --name my-pgadmin -p 5050:80 -e 'PGADMIN_DEFAULT_EMAIL=user@domain.com' -e 'PGADMIN_DEFAULT_PASSWORD=SuperSecret' -d dpage/pgadmin4

    Access pgAdmin UI (Optional):

    Navigate to http://localhost:5050 in your web browser.
    Log in with the email and password provided during setup.
    Add a new server with the PostgreSQL connection details.