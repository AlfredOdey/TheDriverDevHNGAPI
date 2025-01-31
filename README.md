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