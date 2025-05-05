Implemented role base logic. Role based view, Admin sees admin content user sees user content, cant access unauthorized.

Admin user created automaticly. Add to json secrets:

Here is example:
 "IdentitySeedSettings": {
     "AdminEmail": "admin@admin.com",
     "AdminPassword": "Password123124421@@@,
     "Roles": [ "Admin", "User" ] (can add more but not needed for this project)
 }

Password should match login criteria otherwise will not bee seeded. ( Lost a fun load of time because of that :))))) ).
Migration should happen automaticaly, therfore database creation when empty, just make sure mssql and sql server managment studio is installed since it uses local db.
Open project in visual studio  and hit this ![image](https://github.com/user-attachments/assets/06d379c2-37d2-4b13-b64c-79e99a8edf17)

To create standart user just use registration system.

In future - adde more llogic to product table.
CRUD functionality, should be easy to seperate betwwen user and admin using authorization rules. As example right now only admin can view pricvacy page.
Unit tests - seperate project, make sure they have good eneough coverage about 80% fluent assertion, just not the newest since it is paid not just one test for VAT mocking GET POST.....
Error handling, 
Resx files for texts.

More comments <summary><summary> again time thing...
It is what it is and its not great.



