# Access-AppSettings-RemoteApiCall

## ApiClient Project
- class library project
- appsettings.json
- CallStudentApiService 
  - constructor is getting values from appsettings.json for [UserName, Password & BaseUrl]
  - GetAllStudents_RemoteApiCall() method verifies if UserName and Password values are valid then calls [Remote-Api] and receives List of Student and returns otherwise returns empty List of Student

## BusinessCore Project
- class library project
- StudentService class calls ApiClient project's GetAllStudents_RemoteApiCall() method and runs any business process on received List of Student
- return this List of Student received from ApiClient [Remote-Api]

## StartupBusinessCore Project
- console project
- starting up BusinessCore Project
- displays List of Student received from BusinessCore Project
