# Backend-Developer-Test

Description: As a brand new member of Santo Domingo’s police departments’ software development team, you’re tasked with building a new web service to track incidents that occurred in city’s localities in the last 30 days.

#### List of Incidents
### ``` http://localhost:9677/Incidents1 ```
#
#### List of Localities
### ``` http://localhost:9677/Localities1 ```
#
#### For testing the services


* POST /incidents
###  Samples:
### ``` http://localhost:9677/api/incidents```
#

* GET incidents
### ``` incidents?Skip=0&Take=3&Sort=Asc|Desc```
###  Samples:
###  ``` http://localhost:9677/api/incidents?Skip=0&Take=3&Sort=Asc```
#

* POST /incidents/:incidentId/archive
###  Samples:
### ``` http://localhost:9677/api/incidents/{incidentId}/archive```

#
* GET /localities
* GET /localities?Skip=0&Take=3&Sort=Asc|Desc
###  Samples:
###  ``` http://localhost:9677/api/localities```
###  ``` http://localhost:9677/api/localities?Skip=0&Take=3&Sort=Desc```
#

* GET /localities/:localityId
###  Samples:
###  ``` http://localhost:9677/api/localities/{localityId}```
#

* POST /localities
###  Samples:
###  ``` http://localhost:9677/api/localities```

* For run Unit test, please execute the command:
###  ``` Open Visual Studio 2017 Go to Menu - > Test -> Run -> All Tests``


## Instalation

1. Clone the project

	``` git clone https://github.com/kmacho2018/Backend-Developer-Test.git```

2. Install all the dependencies

	``` SQL Server Express 2017 ```
	#
	``` Microsoft Visual Studio 2017 Enterprise Edition ```
	#
	``` Run scriptdb.sql on SQL DataBase```
	#
	``` Verify ..\Backend-Developer-Test-Version\App.Web\Web.config file and check the connectionString ```

3. Start the project

	```Open Visual Studio  -> Run```

## Thats it

yes, the project's ready!.

## Credits
Created by Juan Camacho  

## License

	Copyright 2018 Juan Camacho
	
	Licensed under the Apache License, Version 2.0 (the "License");
	you may not use this file except in compliance with the License.
	You may obtain a copy of the License at
	
	   http://www.apache.org/licenses/LICENSE-2.0
	
	Unless required by applicable law or agreed to in writing, software
	distributed under the License is distributed on an "AS IS" BASIS,
	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	See the License for the specific language governing permissions and
	limitations under the License.
