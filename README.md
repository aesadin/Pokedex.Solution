<h1 align="center"> <img width="900" height="450" src="https://coding-assets.s3-us-west-2.amazonaws.com/hero_images/pokemon.jpg">


# Pokedex

### By Tristan Emmerson, James Henager, Taylor Phillips, Allison Sadin, and Noel Kirkland

## Description

## User Stories

<!-- MVP: full crud functionality(GET for general users. POST, PUT, DESTROY for specific users), two classes (Pokemon and Type), seeded data for all 151 Pokemon, seeded data for all 13 Types, fully functional API, full ui -->
<!-- Stretch goals: Authentication, Silhouette guessing game, MyTeam creator,  -->

* As a Pokemon Master, I need to be able to create a user profile, So that I can access my user specific information.

* As a Pokemon Master, I need to be able to enter my username and password, so that I can login to the application.

* As a Pokemon Master, I need to be able to go to a Pokemon index page, so that I can see all recorded Pokemon (GET)

* As a Pokemon Master, I need to be able to click on a specific Pokemon, so that I can see that Pokemon's details, and it's associated type(s) (GET {id})

* As a Pokemon Master, I need to be able to go to a types index page, so that I can see all Pokemon types

* As a Pokemon Master, I need to be able to click on a specific type, so that I can see that type's details, and it's associated Pokemon

* As a Pokemon Master, I need to be able to click on a specific Pokemon, so that I can it to my user-pokedex

* As a Pokemaster, I 

## Setup/Installation Requirements

* _Install the .NET framework_
  1. _This program utilizes .NET version 3.1, and requires [this framework to be pre-installed](https://dotnet.microsoft.com/download/dotnet-core/3.1)_

* _Install and configure MySQL_
  1. _This program utilizes MySQL Community Server version 8.0.15 and requires [this to be pre-installed](https://dev.mysql.com/downloads/file/?id=484914). Click the link at the bottom that reads "No thanks, just start my download"_
  2. _Use Legacy Password Encryption and set password to "epicodus"_
  3. _Click "Finish_

* _Download this application from GitHub_
  1. _Open the following web address in your browser: **`https://github.com/aesadin`**_
  2. _Click on the button labeled_ Repositories
  3. _Navigate into the **`Pokedex.Solution`** repository and click the green button labeled "Clone or download" and download the zip to your computer_

* _Install the MySQL database_
  1. _Open the downloaded application in a text editor ([V.S. Code preferred](https://code.visualstudio.com/))_
  2. _Open a new terminal in your text editor (Ctrl+\` in V.S. Code) and run command `> echo 'export PATH="$PATH:/usr/local/mysql/bin"' >> ~/.zprofile`_
  3. _Enter the command `> source ~/.zprofile` to confirm MsSQL has been installed_

* _Run the application_
  1. _In the terminal, navigate to the project directory by running the command `> cd LocalShops`_
  2. _Now that we are in the LocalShops directory you will run the command `> dotnet ef migrations add Demo`_
  3. _Once your terminal has finished loading you will run the command `> dotnet ef database update`_
  4. _Once you see the Migrations directory pop up you can run the command `> dotnet run`_

## Known Bugs

## Support and Contact Details

## Technologies Used

# Contributors

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/taylor-phillips.jpeg' width='160px;'/><br /><sub><b>Taylor Phillips</b></sub>](https://www.linkedin.com/in/taylorphillipsportland/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/allison-sadin.jpeg' width='160px;'/><br /><sub><b>Allison Sadin</b></sub>](https://www.linkedin.com/in/allison-sadin-pdx/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/james-henager.jpeg' width='160px;'/><br /><sub><b>James Henager</b></sub>](https://www.linkedin.com/in/james-henager/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/noel-kirkland.jpeg' width='160px;'/><br /><sub><b>Noel Kirkland</b></sub>](https://www.linkedin.com/in/noel-kirkland/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/tristan-emmerson.jpeg' width='160px;'/><br /><sub><b>Tristan Emmerson</b></sub>](https://www.linkedin.com/in/tristan-emmerson/)<br />

### License
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Tristan Emmerson, James Henager, Taylor Phillips, Allison Sadin, and Noel Kirkland_**