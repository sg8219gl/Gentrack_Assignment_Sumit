1) ==========> what was done

Created 4 Projects  

i)   MeterWebAPI   -  Created a public method as logic  GetTotalMeterReading(string meterName, DateTime readingDate) which accept metername and redingDate as input parameter return total reading on that day as Output of that meter on particulare date.

ii)  MeterDataRepository - This Layer implemented as Repository Pattern which will sit between DAL and BAL to perform CRUD operations. 
using this layer logic can be unit tested without data access logic and the database access code can be reused and centrally managed so easy to implement domain logic.


iii) MeterDataUnitTest  -  Create a Unit Test MeterController_GetTotalMeterReading() which we mock meter data and return total reading of that Meter on that day. It completes in around 120 ms.
 
iv)  MeterFileProcessingAWSBatch - Process .csv files as batch . using AWS batch service which trigger whenever files copied in S3 bucket and process the files and copied on DB.


2) ==========> what wasn't done


i)  Not implemented DAL  which interact with actual DB data with Entity framework.
ii) Not tested MeterFileProcessingAWSBatch process due to permission on AWS and time limitation.


3)==========> what would be done with more time

i)  It is just overview of Architecture level design , we can integrate DAL , Exception handling and test more cases if have more time.
ii) Can think betterway to process the file and store in DB.
