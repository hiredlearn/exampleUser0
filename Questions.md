
**1. Why did you create ASP.NET Identity tables in SQL Server?**    
It enables us to create relationships between other newly created tables and to record the track of information.
  
**2. Why there are 2 contexts?**    
There are 2 contexts in applications; 
one is for authentication and other is created by Entity Framework to interact wit databases.
  
**3. What technique of Entity Framework did you adopt and why?**     
There are 2 ways to use Entity Framework; i)- Code First ii)- Database First. 
Both approaches are equally adoptable but code first gives us more grip over code 
and we do not have to interact with the database for changes.
  
**4. Why didn’t you introduce Areas and why are they typically used?**    
This is a small sample application and does not require Areas to be used. 
If we have different big modules in applications we should introduce Areas to manage our code more efficiently.
  
**5. What is the purpose of the AppStart folder?**     
The App Start Folder contains basic starting information of the application e.g: 
on which page application will land on start.
  
**6. Can you change Entity Framework classes on your own, (yes or no)? Explain.**     
No, we cannot change auto generate classes of Entity Framework. 
If we need to change something we have to create change migration 
and on executing our auto-generated classes would get updated automatically. 
