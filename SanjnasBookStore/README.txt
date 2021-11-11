NAME: SANJNA RANI 
STUDENT ID:0769043 
TOPIC: SanjnaBookShop

It’s a 9th of november 2021.

10:00”o clock in the morning.

my topic is SanjnaBookShop

Now first I create a new folder name SanjnaBookShop in the visiual studio code 2019 according to the given toutorial.

The whole project devided into deferent parts

First part is Setting up the projects……………..lets start

Chose new project and select ASP.NET Core App (Model-View-Controller)

10:15AM,Setting up some settings in the beging as change the Authentication as Individual user accounts

Also I enabled razor runtime compoliation

After recheck the changes I hit the create key

Its taking time to build up………………………………

Finialy, whole file and folders are shown as per tutorials…. 

After looking and understanding the whole code everything is same as mentioned

10:20AM, Working good till now………………………I am happy 

Now its time to login git repostory .

I clicked Git and create new repostory .

The dialog box open and aked me to enter my githug access.

Login success.

Rerspostory logged succesful. Yepppppp.

Now time to setting up the project .

Again read carefull the code and worrking on design change .

10:30AM, To to it the provided scripts link and style sheets link are placed into layout.cs.

And open browser and visted bootswatch site .

And chose theme and download its bootstrap.cs file .

The file is replaced with orignal

Also replaced the css file as mentioned and theme has been changed

Yep worked.

It’s a 10:38 AM now ,I take a 10mintes break ,

Now its 11AM, I am working on to add projects to my main projects

According to the tutorial there are three projects have to added:

SanjansBookStoredataAccess, SanjansBookStoreModify and SanjansBookStoreUtility

To use it I followed add new project and I renamed it as given according the slides.

11:20 AM, 9 nov 2021

I add package Microsoft.EntityFrameworkCore.Relational

Microsoft.EntityFrameworkCore.Relational

Ohhhh nooooo Got an error 

Microsoft.EntityFrameworkCore.Relational :

The term 'Microsoft.EntityFrameworkCore.Relational' is not recognized as the name of a cmdlet, function, script file, or operable program. 
Check the spelling of the name, or if a path was included, verify that the path is correct and try again. At line:1 char:1 + Microsoft.EntityFrameworkCore.Relational 
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ + CategoryInfo : ObjectNotFound: (Microsoft.EntityFrameworkCore.Relational:String) [], CommandN

Ohh I got my error after sturggling 5 mintues, I forgot to write install-package before the directory. Shitt my mistake……

Now I carefully write the code and install the directories.

Install-Package Microsoft.EntityFrameworkCore.Relational

It’s a 11:30AM , added a another enityies

Microsoft.EntityFrameworkCore.SqlServer

Adding another package again got error for mis type ,

Microsoft.EntityFrameworkCore.SqlServer.

Install-Package Identity.EntityFramworkCore.SqlServer

Install-Package :

Unable to find package 'Identity.EntityFramworkCore' At line:1 char:1 + Install-Package Identity.EntityFramworkCore + ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ + 
CategoryInfo : NotSpecified: (:) [Install-Package], Exception + FullyQualifiedErrorId : NuGetCmdletUnhandledException,
NuGet.PackageManagement.PowerShellCmdlets.InstallPackageCommand Time Elapsed: 00:00:00.5876561

Its 11:45AM and got my error and fixed the error and now its worked.

There are also some errors shown in the screen but I am fixing it

Fixing………………………………trying…trying….trying……..

Again intall new

Spend 14 mintues to fix the error but Not worked till,

Feel bad because not get my solution , for that decided to take a break for my lunch.

Im back after one hour finesh my lunch , its 1PM agin start my work on project.

Here I find some new solution to add autometically added namespaces and fix the error.

Yep work………..finally

Deleted all the class1 file from three new projects that are added

Done.

Marked projects references

Changed the name space in error.htmls file

Build project not it not build show some error

Cant understand what I missed

Still not find

I am stuck here……………………… done for the today .

10 November Morning at 11AM.

Again start with new vibes but with same errors.

Today I start with review the all code again to find my error. Can’t get any solution …..

Spend my whole day to fix my error but can’t get any solution .

2021-22-07, 11:28 Sunday morning

I start my assignment Again and follwed the same line1 to line 58, still here everything runing smooth.

after continuesly work on the assignment , I feel tired, so time to take a 15 mintues break to freshup.

Its 12PM, Coming from break with energy to finish the project 

Same I followind the futhersteps

Again line59 no throught delete the defulted class1.cs in the all project.

12:10, build the project.

Next step move to the SanjnasBookStore.Model->Shared and than modify the Error.cshtml .

12:30PM, rename the models folder to ViewModels folder as well as modify the namespace of ErrorModels.cs folder to Models.ViewModels. perfect.

Build the project………..taking time to build…………….wao its work 

Take a 5mintue break for the drink.

12:40Pm, now time to modify the main startup.cs file , cut the same amount of code as given in the tutorial , I did not found any error while running the project . my project work good.

1PM , now in the utitly project created a new class named with SD.cs. and do some changes in the class properities , like write public static in front of the class name.

After this add the projrct refrences to the main project by using the all three projects.

. Futher, in the DataAccess project selected sanjnasBookStore.Models and . SanjnasBookStore.Utility name.

Now right click on the area then add a new customer area.

Did some Change in the rought in startup.cs like the one outline in the ScaffoldingReadMe.txt.

1:20PM, click to the HomeController.cs file than Area file under Customer and controller folder and delete the data and Models folder.

Open the HomeController under the View folder and do some changes under the namespace by writing the [Area(“Customer”)].

2PM, 07 Nov

The master page defined in the viewStart under the Views, now copy the viewImport and viewstart to customer Area. 
Open the viewStart.cshtml file and reflect the new path which is : “Layout = “~/View/Shared/Layout.cshtml”; ”

Run the project . its working .

2:13PM,

Add one more Admin Area under the Area folder. Add the perfect view file and delete the data folder and models folder. As well as delete the Controller folder too.

Update all this info to the github.

Finally done the part1 of the assignment ,after facing so much difficulties and red error , I am happy

PART B START

8:40 PM: 8November 2021

part B has began… and working on Database. First I checked the project to confirm the exsisting project to error free and build success.

8:42 PM: review the appsetting.json file and add database name in the json file as giving in tutorial

8:46 PM: While adding Add-Migration AddDefaultMigration by using NuGet Package manager.

8:47 PMGot an error which is: Your target project 'SanjnasBookStore' doesn't match your migrations assembly 'SanjnasBooks.DataAccess'. 
Either change your target project or change your migrations assembly. Change your migrations assembly by using DbContextOptionsBuilder.
E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("SanjnasBookStore")). By default, the migrations assembly is the assembly containing the DbContext.

8:47: PM: I find the error reason. And I change and select the correct project as default

Again I run the package and it worked ………………………….woaaaa

8:55 PM: The migration is completed and data base is update  by the following command:

Update-databse
8:49 PM: after the database upadation I review the SQL server in Obejct Explore carefully and run the application.
I am taking dinner break………………….
9:28 PM: lets start next step…

I create a new class file under SanjnasBooks.Models named as Category.cs

New code has added in tho class file as per given.

9:35 PM: now time to add antother migration package by PM Console

Add-migration AddCategoryTodb is it worked… 

There is a small update in the file ApplicationdbContent.cs

To check its working again add the build command to check error is any

9: 40 PM: waooo work fine and smooth without error….. happy 

9: 45 PM: lets began next step which is add Repository but first taking a coffee break

So begen the futher part with Repository 
After creating the Category.cs file and than it added into the ApplicationdbContext with some modification functionality example getting a record in the DataAccess priject.

Under the DataAccess project add a new Repository folder as well as one more folder Irepository under the Repository folder.

10:PM

UNDER the Irepository folder added a new item of interface and names it Irepository.cs, modify it according to the given inductions.

So, right click on the Repository folder to add a new class repository.cs.

Include the using statements according the code and right click on the error than click the potential fixes and cluck on the implement interface.

Change the code according to the given file repository. It work perfect without any error.
Now created a individual repository for the Category under the main repository folder as same for Icategoryreposotory.cs under the Irepostotory folder.

Done for the today. Its 10:23Pm on the night. 8nov2021.

9 Nov 2021

9:30 AM morning time

Start with slide 8 , continues the last day work.

Open the categoryRepositiry.cs file and do some changes on it , according to the instruction I added a new using statements on the file.

9:40 Am

Open the Icategoryrepository.cs file and modfiy the file as per the tutorial. Like implement the interface to update. 
Complete all the code and fixed all the error as per the commands and it take almost 25 mintues to write the code.

In the Irepository folder added new interface name ISP_Call.cs,  and add a dapper   using the Nuget package.
Added new class under the repository folder ISP_Call. Did small modification in the class and implement the interface on the file. Further , 
add the connection to the database with additional using statements.

Update the implementation of ISP_Call interface.

Now add the wrapper for unit of work

10:21 Am, morning time with fresh mind

Again add a new interface under the Irepository folder name it IunitofWork.cs.

Inside the Repository folder create/add a new class UnitOfWork.

Did some modification inside the class las per the given code I copy all the code as per the instruction and add a new using statements too in the file to remove the error.

Wao I complete the whole project just startup.cs file pending .

Done for the today , need to focus on the another assignments too.

10 nov 11AM

Just left with startup.cs file to complete the project.

Let open the file first , ohh there is only one line to write on this file which is :

Services.addScoped<IunitOfwork, unitOfWork>();

I write this line on the file but got an error oh no 

I show that the name sapce UnitOfWork is missing,,,,,,,

Spending 15mintues to solve the erroe but did not get any good solution ,

Still finding……………solution
11 Nov at 10 AM
i start to find the last error to complete the data  , oh i find my silly error , i forget to write the using statement now feel happy.
done with part2.