<h1 align="center"> <img width="900" height="450" src="https://coding-assets.s3-us-west-2.amazonaws.com/hero_images/pokemon.jpg">


**<h1 align="center">Pokedex</h1>**
### By Tristan Emmerson, James Henager, Taylor Phillips, Allison Sadin and Noel Kirkland

## Description
<p>Pokédex is a comprehensive API and web application to list and display all of the original 151 Pokémon. Pokemon can be browsed in order of Pokédex number or by their Pokémon Type. Each Pokémon entry in the API contains details about that Pokémon; including it's stats, image and average physical characteristics.</p>

## Project goals
  For this project we had the following goals for our minimum viable product:
  * A Pokemon class, a PokeType class, and a User class
  * Full crud functionality
  * Seeded data for all 151 Pokemon
  * Seeded data for all 13 Pokemon types
  * Fully functional API
  * Full user interface

  Some of our stretch goals were:
  * A MyTeam feature that would allow the user to add specific Pokemon to their own collection
  * Identity authentication
  * Search bar functionality
  * Pokemon silhouette guessing game
  * Publish project online

## User Stories

* As a Pokemon Master, I need to be able to navigate to the Pokedex home index page.

* As a Pokemon Master, I need to be able to navigate to a Pokemon index page, so that I can see all recorded Pokemon.

* As a Pokemon Master, I need to be able to click on a specific Pokemon, so that I can see that Pokemon's details, and it's associated type.

* As a Pokemon Master, I need to be able to navigate to a types index page, so that I can see all Pokemon types.

* As a Pokemon Master, I need to be able to click on a specific type, so that I can see that type's details, and it's associated Pokemon.

## Setup/Installation Requirements

* _Install the .NET framework_
  1. _This program utilizes .NET version 3.1, and requires [this framework to be pre-installed](https://dotnet.microsoft.com/download/dotnet-core/3.1)_

* _Install and configure MySQL_
  1. _This program utilizes MySQL Community Server version 8.0.15 and requires [this to be pre-installed](https://dev.mysql.com/downloads/file/?id=484914). Click the link at the bottom that reads "No thanks, just start my download"_
  2. _Use Legacy Password Encryption and set password to "epicodus"_
  3. _Click "Finish_

* _Download this application from GitHub_
  1. _Open the following web address in your browser: **`https://github.com/tmemmerson`**_
  2. _Click on the button labeled_ Repositories
  3. _Navigate into the **`Pokedex.Solution`** repository and click the green button labeled "Clone or download" and download the zip to your computer_

* _Install the MySQL database_
  1. _Open the downloaded application in a text editor ([V.S. Code preferred](https://code.visualstudio.com/))_
  2. _Open a new terminal in your text editor (Ctrl+\` in V.S. Code) and run command `> echo 'export PATH="$PATH:/usr/local/mysql/bin"' >> ~/.zprofile`_
  3. _Enter the command `> source ~/.zprofile` to confirm MsSQL has been installed_

* _Run the application_
  1. _In the terminal, navigate to the API directory by running the command `> cd Pokedex`_
  2. _Now that we are in the Pokedex directory you will run the command `> dotnet restore`_
  3. _Once you see the Obj folder pop up in the directory you will run the command `> dotnet ef database update`_
  4. _Once your terminal has finished loading you will run the command `> dotnet run`_
  5. _Now that we have the API running, run the following command to return to the root directory `> cd ..`_
  6. _Navigate to the client directory by running the command `> cd PokedexClient`_
  7. _Now that we are in the PokedexClient directory you will run another restore`> dotnet restore`_
  8. _Lastly, you will need to run the following command `> dotnet run`_

* _Use the application_
  1. Visit the URL http://localhost:5003 in your preferred browser and have fun!

## Known Bugs
<p>No Known bugs as of 8/25/20</p>

## Support and Contact Details
<p>For any questions or concerns, please feel free to contact a member of our team:</p>

* James Henager - jameschenager@gmail.com
* Noel Kirkland - noelkirkland@gmail.com
* Allison Sadin - aesadin@gmail.com
* Taylor Phillips - taylorphillips133@gmail.com
* Tristan Emmerson - tristan@stickerslug.com

## Technologies Used

* ASP.net Core
* C#

# Contributors

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/allison-sadin.jpeg' width='160px;'/><br /><sub><b>Allison Sadin</b></sub>](https://www.linkedin.com/in/allison-sadin-pdx/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/james-henager.jpeg' width='160px;'/><br /><sub><b>James Henager</b></sub>](https://www.linkedin.com/in/james-henager/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/noel-kirkland.jpeg' width='160px;'/><br /><sub><b>Noel Kirkland</b></sub>](https://www.linkedin.com/in/noel-kirkland/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/taylor-phillips.jpeg' width='160px;'/><br /><sub><b>Taylor Phillips</b></sub>](https://www.linkedin.com/in/taylorphillipsportland/)<br />

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/tristan-emmerson.jpeg' width='160px;'/><br /><sub><b>Tristan Emmerson</b></sub>](https://www.linkedin.com/in/tristan-emmerson/)<br />



### License
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Tristan Emmerson, James Henager, Taylor Phillips, Allison Sadin, and Noel Kirkland_**



<!-- Tasks:

API
X Create Pokemon Model
X Create PokeTypes Model
X Create User Model
X Create PokemonTypes Model
X Create UserPokemon Model
X Make GET PokemonController
X Make GET PokeTypesController
X Make get, post, put and delete for UsersController

Client
X Create UsersController
x Create Model for ApiHelper
X Create views folders for Pokemon, Type and User(X)


X Create Home view and controller
X Create Register ViewModel
X Create Login ViewModel
X Create Views for Pokemon
X Create Views for Type (index, details)
X Create Views for User (index, details, create, update, delete)


Thursday

X Clean up/update readme
X clean up commented out code/unused files
X Update arrows
X Delegate presentation roles
X Spruce up the home index
X arrange pokemon index in rows
X add units to weight and height
X increase card height ~20 px
X Center pokemon index and name?

Roles:
Explanation of API/ technologies used - James/Tristan
Website walk through  - James/Tristan
Eplaination of styles, formatting, layout - Taylor
Explanation of TeamWork Method, moral, communication - Allison
Explanation of what we wanted to get done, and how we got to where we are now - Noel -->