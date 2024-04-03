The project doesn't work.  I spent well over 40 hours on it.  It's 
supposed to be a store with a console app for entering data manually 
and running reports and an API that could be used to enter data via JSON.

Features:
1) It has an API
2) API and ProductBrandDTO methods are asynchronous
3) ProductBrandDTO class uses a SQL query

Instructions:
1) Build the database from migrations files using the Developer Command Prompt, run the following commands:
	set EF_MIGRATIONS=true
	dotnet tool install --global dotnet-ef
	cd FancyFrenchStore.Data
	dotnet ef database update
	set EF_MIGRATIONS=
	exit

2) You can set the solution to run startup both the console app and the API, or you can run them individually.
