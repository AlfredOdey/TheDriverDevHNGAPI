# HNG12 STAGE-0 THEDRIVERDEVHNGAPI

## Description

This is a simple public API that returns the following information in JSON format:

* My registered email addressed used in the HNG12 Slack workspace.
* The current date and time in ISO 8601 format (UTC).
* The GitHub repository URL of the project.

## Technologies Used

* Backend Framework: ASP.NET Core
* Language: C#
* Hosting: SmarterASP.NET
* CORS Handling: Configured to allow cross-origin requests
* Version Control: GitHub
* Hosting: SmarterASP.NET
* Deployment: FTP
* Response Format: JSON

## API Documentation

### Endpoint:

GET
api/MetaData

Response Format (200 OK)
```json
{
  "email": "alfredmodey@gmail.com",
  "current_DateTime": "2025-01-31T03:53:25.2729500Z",
  "gitHub_URL": "https://github.com/AlfredOdey/TheDriverDevHNGAPI"
}

```

## Setup Instructions

To run this project locally:

1. Clone the repository to your local machine.

	```terminal
	git clone
	https://github.com/AlfredOdey/TheDriverDevHNGAPI.git
	```
2. Open the project in Visual Studio

3. Build the project:
	In Visual Studio, select "Build" then "Build Solution".

4. Run the project.

## Example Usage

Access the API using a browser or any HTTP client like Postman.

* GET
	http://thedriverdev-001-site1.anytempurl.com/api/MetaData
	

## Links

* Live API: http://thedriverdev-001-site1.anytempurl.com/api/MetaData
* GitHub Repo: https://github.com/AlfredOdey/TheDriverDevHNGAPI
* HNG Backend Devlopers (C#): https://hng.tech/hire/csharp-developers

## Author

Alfred Mamman Odey
TheDriverDev
HNG12 Backend Intern