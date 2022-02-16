# palota-func-countries-assessment

Palota Countries API Assessment Exercise

![Palota Logo](https://palota.co.za/assets/images/meta/og-image.png)

**Azure Function App**

## Configuration

The following application settings have to be set to run the function app

| Setting Name            |  Setting Type  | Description                     |
|-------------------------|:--------------:|---------------------------------|
| COUNTRIES_API_URL       | string         | Contries API Base URL           |



These settings should be loaded onto Azure Portal when running on Azure or set inside `local.settings.json` file when running locally.

## Getting Started

[Use this repo as a template](https://github.com/PalotaCompany/palota-func-countries-assessment/generate)  into your own Github account so you can make changes.

*The repository will come with an existing function. You can leave that as is.*

## Assessment Requirements

### Summary
You are required to create a couple of endpoints using functions that query certain information about countries from an external API. The endpoints should have specific paths and return a response in a specific format. There should be error handling on the endpoints.

### External API dependency
This assessment relies on an external API from [restcountries.com](https://restcountries.com/). The API offers multiple endpoints relating to querying rich data about countries.

Please ensure that the base URL of the API is made configurable as an app setting named `COUNTRIES_API_URL`. As opposed to hardcoding the value in the code.

### Endpoints

You need to create new functions covering each of the below endpoints (ensure to name the path as indicated).

| HTTP Verb | Path                          | Description
|-----------|-------------------------------|-------------------------------------------------|
| `GET`     | /countries                    | List all countries                              |
| `GET`     | /countries/{iso3Code}         | Return a single country using the ISO 3 code    |
| `GET`     | /countries/{iso3Code}/borders | List all countries bordering a specific country identified by the ISO 3 code  |
| `GET`     | /continents/{continentName}/countries/ | List all countries in a specific continent identified by its name  |

*N.B.: All successful responses should return status code 200*

### Response Payloads

#### Successful responses

Successful responses will either be a single country or a list of countries (the list may be empty in some cases).

The country object that your API should return is different from the original payload from [restcountries.com](https://restcountries.com/#api-endpoints-v2-response-example). Please ensure to map fields properly.

**Single Country Successful Response**
```json
{
    "name": "South Africa",
    "iso3Code": "ZAF",
    "capital": "Pretoria",
    "subregion": "Southern Africa",
    "region": "Africa",
    "population": 59308690,
    "location": {
        "lattitude": -29.0,
        "longitude": 24.0
    },
    "demonym": "South African",
    "nativeName": "South Africa",
    "numericCode": "710",
    "flag": "https://flagcdn.com/za.svg"
}
```


**List of Countries Successful Response**

*N.B.: In certain cases the list may be empty, most cases it will have multiple items*
```json
[
    {
        "name": "South Africa",
        "iso3Code": "ZAF",
        "capital": "Pretoria",
        "subregion": "Southern Africa",
        "region": "Africa",
        "population": 59308690,
        "location": {
            "lattitude": -29.0,
            "longitude": 24.0
        },
        "demonym": "South African",
        "nativeName": "South Africa",
        "numericCode": "710",
        "flag": "https://flagcdn.com/za.svg"
    }
]
```

#### Error responses

There are two main errors that should be catered for:

1. The country could not be found (via ISO 3 code)
2. The contient could not be found (via continent name)

The payload structure is as follows:
```json
{
    "message": "<error-message>"
}
```

| Scenario | Error Code   | Error Message Example |
|----------|:------------:|------------------|
| Country not found | 404 | `"The country with ISO 3166 Alpha 3 code 'zar' could not be found."` |
| Continent not found| 404 | `"The continent with name 'arica' could not be found."` |


### Assessment Grading Criteria
Below is a high-level overview of the main grading criteria that will be used to grade submissions. 
- Funcional endpoints
- Making use of app setting configuration for base URL (for external API)
- Response payload structure
- Error handling and HTTP response codes
- Code quality (clean code)


## Submission
Once done with the tasks, commit all your code and push it to your own remote github repository. Submit a link to your repo (with relevant branch - ideally main) to the email which will be provided to you separately when the assessment is assigned to you. 

**Important: Make sure your function app compiles and runs locally before submitting**



