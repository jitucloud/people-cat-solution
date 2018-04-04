# people-cat-solution

# Highlights of solution and approach taken
		Dependency Injection by AutoFac
		OWIN Hosting
		Attribute Routing
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