# Access-AppSettings-RemoteApiCall

## ApiClient Project
- class library project
- appsettings.json
- CallStudentApiService 
  - constructor is getting values from appsettings.json for [UserName, Password & BaseUrl]
  - GetAllStudents_RemoteApiCall() method verifies if UserName and Password values are valid then calls Remote-Api and receives List<Student> and returns otherwise returns empty List<Student>

## BusinessCore Project
- class library project
- StudentService class calls ApiClient project's GetAllStudents_RemoteApiCall() method and run any business process on received students
- return this List<Student> received from ApiClient->remote-api

## StartupBusinessCore Project
- console project
- starting up BusinessCore Project
- displays List<Student> received from BusinessCore Project
