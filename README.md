# Overview of your solution

- The application allows you to calculate the amount to be paid for each hour worked by the employees of a company.
The calculation is based on the hours worked based on the day of the week and time of the day, according to the following table:

Monday Friday

00:01 - 09:00 25 USD

09:01 - 18:00 USD 15

18:01 - 00:00 20 USD

Saturday and Sunday

00:01 - 09:00 USD 30

09:01 - 18:00 USD 20

18:01 - 00:00 USD 25



# Application architecture.

The application is based on the MVC architecture which separates the model from the logic so that the implementation is cleaner and easier to modify.
created in a console application type project and implemented with the object-oriented programming language c #.



# Approach and Methodology

The application is developed in a console application project which has a class called UtilityTextFile that handles the .txt file. When executing the application, a file called
fileData.txt on the desktop with the following data sets from which the value to be paid to each employee is calculated.

Data set

RENE = MO10: 00-12: 00, TU10: 00-12: 00, TH01: 00-03: 00, SA14: 00-18: 00, SU20: 00-21: 00;
ASTRID = MO10: 00-12: 00, TH12: 00-14: 00, SU20: 00-21: 00;
BOB = MO10: 00-12: 00;
JOHN = TH12: 00-14: 00;
EMILY = SU20: 00-21: 00, SA01: 00-03: 00


# Dependencies to run the program.
Install the following programs to run the developed application.

Visual Studio 2019 URL: https://visualstudio.microsoft.com/es/thank-you-downloading-visual-studio/?sku=Community&rel=16
.NET Framework 5.0 URL: https://dotnet.microsoft.com/download/dotnet-framework/net48



# Instructions to run the program.

Download the program from GitHub
Inside the folder (AppPayEmpoyees) run the file called AppPayEmpoyees.sln file

In solution explorer right click on the application and then click on the Compile option.

Then run solution by pressing the key combination (Ctrl + F5).

If you have carried out the correct steps, a console will be displayed with the values ​​to be paid to each employee of the company. (The calculation is performed on the data set described above).
