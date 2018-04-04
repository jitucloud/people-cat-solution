# people-cat-solution

# Highlights of solution and approach taken
		Dependency Injection by AutoFac
		OWIN Hosting
		Attribute Routing
		HTTPClient
		Linq
		Async Controller/Methods
# Folder and Files Structure
		PeopleCAT.API.Online
			Controller
			    CatController
			    PeopleController
			Model
			    Gender
			    People
			    AnimalType
			    Pet
			Manager
			    CatManager
			Interface
		            ICatManager
			Helper
			    ConfigManager
			DataLayer
			    PeopleCatAPIDAL
		PeopleCAT.API.Online.Tests
			Controller
			Manager
			Helper
			DataLayer


Start the PeopleCAT.API.Online 

Go to - http://localhost:61429/api/cats

Expected Result:
{
	"Male":["Garfield","Jim","Max","Tom"],
	"Female":["Garfield","Simba","Tabby"]
}

Dummy endpoint: 
	http://localhost:61429/api/peoples
	http://localhost:61429/api/peoples/{id:int}

Assumption: This endpoint can come under both cat or people and it depends on how we want to maintain it.
