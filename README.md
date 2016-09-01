# Sightstone.AspNet
The official sightstone website

Connect to league of legends, launch your game and play your way. No need to use the client. Requires league of legends to be installed and up to date.

# Security
If you do not think our server is secure enough, you are free to use the source code for your own server. If you do this, you are not allowed to post the url to your website anywhere.

The source code is changed when pushed to the server. This is because we do not want to compromise the database containing all the login information. The only things that is changed will be     
```html 
<add name="DefaultConnection" connectionString="Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-Sightstone.AspNet-20160827065244.mdf;Initial Catalog=aspnet-Sightstone.AspNet-20160827065244;Integrated Security=True" providerName="System.Data.SqlClient" />
```
in the Web.Config file and the
```cs
public ApplicationDbContext() : base("DefaultConnection", false)
```
in the IdentityModels class. Please understand that this is only done for privacy reasons.

# Screen shots
```cs
//TODO
```
