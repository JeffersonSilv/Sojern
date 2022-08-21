
### CompareVersions (Exercise 1)
Compare two version numbers version1 and version2. 
If version1 > version2 return 1
If version1 < version2 return -1
otherwise return 0
You may assume that the version strings are non-empty and contain only digits and the 'dot' character. The 'dot' character does not represent a 
decimal point and is used to separate number sequences. For instance '2.5' is not "two and a half" or "half way to version three", it is the fifth 
second-level revision of the second first-level revision.
Here is an example of version numbers ordering: 0.1 < 1.1 < 1.2 < 1.2.9.9.9.9 < 1.3 < 1.3.4 < 1.10

### Installation
CompareVersinos is running using .net Core 6
Instructions of how to install it: https://dotnet.microsoft.com/en-us/download/dotnet/6.0


### Run the application 
From the project root folder navingate to .\CompareVersions\VersionManager and run the following commands:

	dotnet restore
	dotnet run


### Tests
For unit tests I'm using Xunit version 2.4.1

## Running the tests 
From the project root folder navingate to .\CompareVersions\VersionManager.Tests and run the following commands:

	dotnet test


***********************************************************************************************************************************


### Math Api (Exercise 2)
Implement a web service (in Go, Python, or Java). Feel free to use a framework, if desired.
/min - given list of numbers and a quantifier (how many) provides min number(s)
/max - given list of numbers and a quantifier (how many) provides max number(s)
/avg - given list of numbers calculates their average 
/median - given list of numbers calculates their median
/percentile - given list of numbers and quantifier 'q', compute the qth percentile of the list elements
No need to be concerned with resources, we're assuming there's plenty enough of memory, etc. The percentile should just return one 
number. Use the nearest-rank method. https://en.wikipedia.org/wiki/Percentile#The_nearest-rank_method

### Installation
Math is running using .net Core 6
Instructions of how to install it: https://dotnet.microsoft.com/en-us/download/dotnet/6.0

### Libraries
For the Percentile and Median calculation, I'm using the following library:
-	Mathnet.Numberics version 5.0.0
-	https://github.com/mathnet/mathnet-numerics

### Run the application 
From the project root folder navingate to .\Math\Math.Api
run the following commands:

	dotnet restore
	dotnet run
By default the application will run on the port 3000
eg:

	http://localhost:3000/swagger/index.html

### Tests
For unit tests I'm using Xunit version 2.4.1

## Running the tests 
From the project root folder navingate to .\Math\Math.Tests
run the following commands:

	dotnet test
