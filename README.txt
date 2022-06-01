# Jumper Word Guessing Game
Jumper is a game in which the player seeks to solve a puzzle by
guessing the letters of a secret word one at a time.

## Getting Started
---
Make sure you have dotnet 6.0 or newer installed on your machine. Open 
a terminal and browse to the project's root folder. Start the program 
by running the following commands.
```
dotnet build
dotnet run 
```
You can also run the program from an IDE like Visual Studio Code. 
Start your IDE and open the project folder. Select "Run and Debug" on 
the Activity Bar. Next, select the project you'd like to run from the 
drop down list at the top of the Side Bar. Lastly, click the green 
arrow or "start debugging" button.

## Project Structure
---
The project files and folders are organized as follows:
```
root                         (project root folder)
+-- Program.cs               (program entry point)   
+-- Game                     (source code folder)
+-- Director.cs              (file for Director class)
+-- Jumper.cs                (file for Jumper class)
+-- Word.cs                  (file for Word class)
+-- TerminalService.cs       (file for TerminalService class)
+-- README.md                (general info)
+-- unit03-jumper.csproj    (dotnet project file)
```

## Required Technologies
---
* dotnet 6.0

## Authors
---
* Jon Connell (con18013@byui.edu)