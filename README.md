# C# Mini-Project
We propose to build a "current weather conditions" application for the C# Mini-Project.  The application will consist of a simple GUI which allows the user to enter a ZIP code.  The application will then query the openweathermap.org's API, retrieve the current weather data for the specified location, and then display the information back to the user.  Our choice of application is based on the following: 
* It is simple enough to be completed in the time allowed
* Its functionality could be easily extended (i.e., to provide historical data, graphical display of weather conditions, et cetera) if we have extra time
* It will demonstrate some of C#'s benefits, such as the use of Windows Forms and the .NET framework
* It can be easily broken down for each team member to contribute.

The use of the application should be self-explanatory (the only requirement of the user will be to provide a location, in the form of a ZIP code, when prompted).  We intend to compile into a windows executable, so there should not be any dependencies (other than the ability to launch a windows application).

The expected steps and distribution of tasks to build the application are as follows (subject to change):
1. One team member needs to register for an <a href="https://openweathermap.org/api">openweathermap.org</a> API key.
2. Design a Windows Form to get location input from the user.
3. Query the openweathermap API to retrieve the current weather conditions for the specified location.
4. Parse the API's returned data
5. Display the result to the user
