# Personal Portfolio

#### Joshua Fairchild, August 25th, 2017

## Description

This website is meant to act as a portfolio of my work (as well as demonstrating API calls using RestSharp). The application contains a landing page, an "About me" page, as well as a project section that displays a few of my projects. These projects are gathered by requesting my most-starred repositories from the GitHub API.

## Prerequisites

You will need the following software properly installed on your computer.

* [Visual Studio 2015](https://www.visualstudio.com/vs/older-downloads/)

## Installation/Database Setup

* Clone this repository.

  `$ git clone https://github.com/joshuafairchild1/PortfolioDotnet`


* In Visual Studio, open `PortfolioDotnet.sln` and create a file called `EnvironmentVariables` within the `Models` directory. Add the following code:

  ```
  namespace PortfolioDotnet.Models
  {
      public class EnvironmentVariables
      {
          public static string GitHubUserAgent = "joshuafairchild1";
      }
  }

  /* note that the string value can be substituted for a different GitHub
  username to view their repositories instead of mine */

  ```

* You can now view the application by pressing Ctrl + F5 in Visual Studio, you will be navigated to the application in your web browser.


## Built With

* C#
* ASP.NET Core MVC
* CSS
* [RestSharp](http://restsharp.org/)
* [Materialize](http://materializecss.com/)
* [Particles.js](https://github.com/VincentGarreau/particles.js/)

## License

This project is licensed under the MIT License

Copyright (c) Joshua Fairchild, 2017
