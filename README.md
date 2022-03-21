# BlueSquare-TechnicalTest
This is the Blue Square Technical Test. Please ensure that you read the entire document before getting started. Feel free to ask any questions if you are unsure on anything below.
## Scenario
A customer has a web-based solution for creating, managing and closing repair jobs for the business. The system is archaic and they don’t have the skills in-house to integrate it with other solutions, but we have access to their database.
They want to keep the system in place as the cost to change is too high, but would like us to build a solution to help them better manage the repair jobs, communication with the end-user and part management.
You have been assigned the task of building this solution and the integration which is via RESTful API. You have been tasked with building the API integration.

## Requirements
- Your solution should be serverless and use micro-services (e.g. AWS Lambda)
- It needs to routinely check for new jobs in the client DB and then uploaded to MongoDB (example schema for both DBs can be found below) 
- Full job details should be written to MongoDB
- An API is required for us to update the job status within our db
- A notification by SMS should be sent to the user using Vonage's API. It should update the customer when we receive their job, and when jobs are complete
- Our SMS system should utilise Vonage's API and their documentation can be found here - https://developer.nexmo.com/use-cases/private-sms-communication

## Client MySQL Database schema – Table = Jobs

Field name       | Type
---------------- | ----------------
job_id           | Int (PK)
job_type         | Varchar
job_status       | Varchar
client_firstname | Varchar
client_lastname  | Varchar
client_postcode  | Varchar
client_mobile    | Varchar
product_sku      | Varchar
product_type     | Varchar

## Mongo Collection – This can be assumed as however you like. You just need to write JSON to the collection.

```json

{
  "jobs": [
    {
      "job_id": "00123",
      "job_date": "2022-03-21",
      "job_type": "Repair",
      "job_status": "New",
      "customer": {
        "client_firstname": "John",
        "client_lastname": "Smith",
        "client_postcode": "SG13 7TZ",
        "client_mobile": "+447770 123456"
      },
      "product": {
        "product_id": "123",
        "product_type": "spider catcher"
      },
      "updates": [
      	{
	  "timestamp": "2022-03-21 10:00:00",
	  "status": "New"
	}
      ]
    }
  ]
}

```

## Expectations
Fork the repo and commit/push any code to the repository before the deadline. 
Please provide a series of scripts or snippets that will perform the following tasks in a micro-service environment;

- Routinely check for and collect new jobs from the client db
- Write job data to the Mongo DB
- Trigger and compose SMS messages using Vonage's API 
- API to update the job status in our Mongo DB (The documentation to our API can be found in the adjacent file) 
- Job_status can be:
  * NEW - Job created in client system
  * OPENED - Job added to our db and sms sent to user
  * JOB COMPLETED - Client work completed
  * CLOSED - Customer SMS sent
- You do not need to create any databases or a vonage account. You do not need to deploy this code.
- You may find that the requirements or information given is incomplete, feel free to alter or expand on them as you see fit and mention these in a committed text file.
- You are not required to fully complete this task, but be prepared to explain what happened and how you attempted to solve it
- Feel free to contact me if you have any questions

GOOD LUCK!
