NAME: SANJNA RANI
STUDENT ID:0769043
TOPIC:  SanjnaBookShop
1.	It’s a 9th of november 2021. 
2.	10:00”o clock in the morning.
3.	 my topic is SanjnaBookShop
4.	(10:02AM)Now first I create a new folder name SanjnaBookShop in the visiual studio code 2019 according to the given toutorial.
5.	(10:03AM)The whole project devided into deferent parts
6.	First part is Setting up the projects……………..lets start 
7.	Chose new project and select ASP.NET Core App (Model-View-Controller)
8.	(10:15AM),Setting up some settings in the beging as change the Authentication as Individual user accounts 
9.	Also I enabled razor runtime compoliation(10:15 AM)
10.	After recheck the changes I hit the create key(10:16 AM)
11.	Its taking time to build up………………………………(10:16 AM)
12.	Finialy, whole file and folders are shown as per tutorials…. (10:17 AM)
13.	 After looking and understanding the whole code everything is same as mentioned(10:19 AM)
14.	 (10:20AM,) Working good till now………………………I am happy 
15.	Now its time to login git repostory .(10:21 AM)
16.	I clicked Git and create new repostory . (10:22 AM)
17.	 The dialog box open and aked me to enter my githug access.
18.	 Login success.
19.	 Rerspostory logged succesful. Yepppppp.
20.	Now time to setting up the project .
21.	Again read carefull the code and worrking on design change .
22.	10:30AM, To to it the provided scripts link and style sheets link are placed into layout.cs.
23.	And open browser and visted bootswatch site .
24.	And chose theme and download its bootstrap.cs file .(10:32AM)
25.	The file is replaced with orignal 
26.	Also replaced the css file as mentioned and theme has been changed 
27.	Yep worked. 
28.	It’s a 10:38 AM now ,I take a 10mintes break ,
29.	Now its 11AM,  I am working on to add projects to my main projects
30.	According to the tutorial there are three projects have to added:
31.	SanjansBookStoredataAccess, SanjansBookStoreModify and SanjansBookStoreUtility
32.	(11:13AM)To use it I followed add new project and I renamed it as given according the slides.
33.	(11:20 AM), 9 nov 2021
34.	 I add package Microsoft.EntityFrameworkCore.Relational 
35.	Microsoft.EntityFrameworkCore.Relational
36.	Ohhhh nooooo  Got an error  
37.	Microsoft.EntityFrameworkCore.Relational : 
38.	The term 'Microsoft.EntityFrameworkCore.Relational' is not recognized as the name of a cmdlet, function, script file, or operable program. Check the spelling of the name, or if a path was included, verify that the path is correct and try again. At line:1 char:1 + Microsoft.EntityFrameworkCore.Relational + ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ + CategoryInfo : ObjectNotFound: (Microsoft.EntityFrameworkCore.Relational:String) [], CommandN
39.	(11:27 AM )Ohh I got my error after sturggling 5 mintues, I forgot to write install-package before the directory. Shitt my mistake……
40.	Now I carefully write the code and install the directories.
41.	Install-Package Microsoft.EntityFrameworkCore.Relational
42.	
43.	It’s a 11:30AM , added a another enityies
44.	Microsoft.EntityFrameworkCore.SqlServer
45.	Adding another package  again got error for mis type , 
46.	Microsoft.EntityFrameworkCore.SqlServer.

47.	Install-Package Identity.EntityFramworkCore.SqlServer 

48.	Install-Package :

49.	 Unable to find package 'Identity.EntityFramworkCore' At line:1 char:1 + Install-Package Identity.EntityFramworkCore + ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ + CategoryInfo : NotSpecified: (:) [Install-Package], Exception + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackageCommand Time Elapsed: 00:00:00.5876561
50.	 Its (11:45AM) and got my error and fixed the error and now its worked.
51.	There are also some errors shown in the screen but I am fixing it 
52.	Fixing………………………………trying…trying….trying……..
53.	Again intall new 
54.	Spend 14 mintues to fix the error but Not worked till,
55.	Feel bad because not get my solution , for that decided to take a break for my lunch.
56.	Im back after one hour finesh my lunch , its 1PM agin start my work on project. 
57.	(12:03AM)Here I find some new solution to add autometically added namespaces and fix the error.
58.	Yep work………..finally
59.	Deleted all the class1 file from three new projects that are added
60.	Done.
61.	Marked projects references 
62.	Changed the name space in error.htmls file
63.	Build project not it not build show some error 
64.	Cant understand what I missed 
65.	Still not find 
66.	I am stuck here……………………… done for the today .
67.	(10 November Morning at 11AM.)
68.	Again start with new vibes but with same errors.
69.	 Today I start with review the all code again to find my error. Can’t get any solution …..
70.	Spend my whole day to fix my error but can’t get any solution .
71.	(2021-22-07),( 11:28 ) Sunday morning
72.	I start my assignment Again and follwed the same line1 to line 58, still here everything runing smooth. 
73.	after continuesly work on the assignment , I feel tired, so time to take a 15 mintues break to freshup.
74.	Its (12PM), Coming from break with energy to finish the project 
75.	Same I followind the futhersteps
76.	 Again line59  no throught delete the defulted class1.cs in the all project. 
77.	(12:10 Pm), build the project. 
78.	Next step move to the SanjnasBookStore.Model->Shared and than modify the Error.cshtml .
79.	(12:30PM), rename the models folder to ViewModels folder as well as modify the namespace of ErrorModels.cs folder to Models.ViewModels. perfect. 
80.	Build the project………..taking time to build…………….wao its work 
81.	Take a 5mintue break for the drink.
82.	(12:40Pm), now time to modify the main startup.cs file , cut the same amount of code as given in the tutorial , I did not found any error  while running the project . my project work good.
83.	 (1PM ), now in the utitly project  created a new class named with SD.cs. and do some changes in the class properities , like write public static in front of the class name.
84.	After this add the projrct refrences to the main project by using the all three projects.
85.	. Futher, in the DataAccess project selected sanjnasBookStore.Models and . SanjnasBookStore.Utility name.
86.	Now right click on the area then add a new customer area.
87.	Did some Change in the rought in startup.cs like the one outline in the ScaffoldingReadMe.txt.
88.	(1:20PM), click to the HomeController.cs file than Area file under Customer  and controller folder and delete the data and Models folder.
89.	  Open the HomeController under the View folder and do some changes under the namespace by writing the   [Area(“Customer”)].
90.	(2PM, 07 Nov 2021)
91.	The master page defined in the viewStart under the Views, now copy the viewImport and viewstart to customer Area. Open the viewStart.cshtml file and reflect the new path  which is : “Layout = “~/View/Shared/Layout.cshtml”; ”
92.	Run the project . its working .
93.	(2:13PM),
94.	Add one more Admin Area under the Area folder. Add the perfect view file and delete the data folder and models folder. As well as delete the Controller folder too.
95.	 Update all this info to the github.
96.	Finally done the part1 of the assignment ,after facing so much difficulties and red error  , I am happy

97.	PART B START 
98.	(8:40 PM:  8November 2021)
99.	part B has began… and working on Database. First I checked the project to confirm the exsisting project to error free and build success. 
100.	(8:42 PM): review the appsetting.json file and add database name in the json file as giving in tutorial  
101.	(8:46 PM):  While adding  Add-Migration AddDefaultMigration by using NuGet Package manager. 
102.	(8:47 PM) Got an error which is: Your target project 'SanjnasBookStore' doesn't match your migrations assembly 'SanjnasBooks.DataAccess'. Either change your target project or change your migrations assembly. Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("SanjnasBookStore")). By default, the migrations assembly is the assembly containing the DbContext. 
103.	(8:47: PM): I find the error reason. And I change and select the correct project as default 
104.	Again I run the package and it worked ………………………….woaaaa
105.	(8:55 PM): The migration is completed and data base is update  by the following command:
106.	 Update-databse
107.	 (8:49 PM): after the database upadation I review the SQL server in Obejct Explore carefully and run the application.
108.	 I am taking dinner break………………….
109.	(9:28 PM): lets start next step…
110.	I create a new class file under SanjnasBooks.Models named as Category.cs
111.	New code has added in tho class file as per given.
112.	(9:35 PM): now time to add antother migration package by PM Console
113.	Add-migration AddCategoryTodb  is it worked… 
114.	There is a small update in the file ApplicationdbContent.cs  
115.	To check its working again add the build command to check error is any
116.	(9: 40 PM): waooo work fine and smooth without error….. happy 
117.	(9: 45 PM): lets began next step which is add Repository but first taking a coffee break 
118.	 So begen the futher part with Repository 
119.	After creating the Category.cs file and than it added into the ApplicationdbContext with some modification functionality example getting a record in the DataAccess priject.
120.	Under the DataAccess project add a new Repository folder as well as  one more folder Irepository under the Repository folder.
121.	(10:PM) (8 Nov 2021)
122.	UNDER the Irepository folder added a new item of interface and names  it Irepository.cs, modify it according to the given inductions.
123.	So, right click on the Repository folder to add a new class repository.cs.
124.	Include the using statements according the code and right click on the error than click the potential fixes and cluck on the implement interface.
125.	 Change the code according to the given file repository. It work perfect without any error.
126.	Now created a individual repository for the Category under the main repository folder as same for Icategoryreposotory.cs under the Irepostotory folder.
127.	Done for the today. Its 10:23Pm on the night. 8nov2021.
128.	DATE: (9 Nov 2021)
129.	(9:30 AM ), morning time
130.	Start with slide 8 , continues the last day work.
131.	Open the categoryRepositiry.cs file and do some changes on it , according to the instruction I added a new using statements on the file.
132.	(9:40 Am)
133.	Open the Icategoryrepository.cs file and modfiy the file as per the tutorial. Like implement the interface to update. Complete all the code and fixed all the error as per the commands and it take almost 25 mintues to write the code.
134.	 In the Irepository folder added new interface name ISP_Call.cs,  and add a dapper   using the Nuget package.
135.	Added new class under the repository folder ISP_Call. Did small modification in the class and implement the interface on the file. Further , add the connection to the database with additional using statements.
136.	Update the implementation of ISP_Call interface.
137.	Now add the wrapper for unit of work
138.	(10:21 Am), morning time with fresh mind
139.	Again add a new interface under the Irepository folder name it IunitofWork.cs. 
140.	Inside the Repository folder create/add a new class UnitOfWork. 
141.	Did some modification inside the class las per the given code I copy all the code as per the instruction and add a new using statements too in the file to remove the error.
142.	Wao I complete the whole project just startup.cs file pending .
143.	Done for the today , need to focus on the another assignments too.
144.	(10 nov 11AM)
145.	Just left with startup.cs file to complete the project.
146.	Let open the file first , ohh there is only one line to write on this file which is :
147.	Services.addScoped<IunitOfwork, unitOfWork>();
148.	I write this line on the file but got an error oh no 
149.	I show that the name sapce UnitOfWork is missing,,,,,,,
150.	Spending 15mintues to solve the erroe but did not get any good solution ,
151.	Still finding……………solution
152.	Take a break 
153.	After coming from the break a check code again and I found my silly mistake that I donot use the using statement ,,, now all error resolve finally.
154.	Done with Part2 (1)
155.	(12 novmber 2021) ( 10AM), morning time
156.	Now continue the assignment’s part 2, category CRDU(10:02AM)
157.	With in a Admin->Controller create a new MVC  controller inside it as   CategoryController.cs. write the all provided code as per the tutorial and solve the error by using statements.(10:07AM)
158.	After that add a new category folder inside the View folder and further category folder added a View->razor view . then one new slide open fille the file name->Index and path of the file(10:15Am)
159.	The new Index.cshtml file open I posted the given code(Index.cshtml) into the file.(10:25AM)
160.	(10:34AM)  now it’s a time to press the ISS Express button to check the output. Wao  finally see good result after so many time.
161.	(10:38AM) add the new folder category under the view folder .
162.	(10:40AM) in the Layout.cshtml file to modify the category code to display the catogry in the home page. 
163.	(11:00AM) now  edit the code in the layout page first I commant out the category navigation bar in the layout.cshtml file because I only need a category in the dropdown. So I enter a new code  in the dropdown menu.
164.	(11:10AM)  time to check the dropdown in the project so run the project and see the changes. Finally good thinks happen with me :)
165.	(11:00AM) morning,  need a time to prepare my breakfast.
166.	(13 november)
167.	(11:00AM): cannot spend more time to ASP assignement because I ha ve to focuse on the another assignment because that is also important as asp.
168.	(11:00AM) modigy the Index.cshtml file with latest icon through Font AWEsome website which has a large collection of icon. So I choose my own icon.
169.	(11:13AM) after choosing my own icon I pasted it on the Index.cshtm file.
170.	 (11:12AM) now I insert the category.js file which was given by the Andrew in the assignment folder. That file insert into the wwwroot folder under the js folder.
171.	(11:30AM) after checking all , I delete the bottom icon code of Index.cshtml file and pasted a @section code .
172.	(11:36AM) now it’s a time to finally fetch my desire outcome after facing the numbered of error . I click the ISS Express  button . 
173.	(11:37AM) yyyyyyyyyyuuuuuuuuuuuuuupppppppppppppppppppppppppppppppppppp
174.	(11:38AM) finally got my final output. Still donnot get any default database entey in the category file.
175.	 Done finally with part2 code.



