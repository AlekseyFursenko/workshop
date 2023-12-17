using System.Dynamic;

var data = new HttpClient()
.GetStringAsync("http://localhost:5050/api/Contact/GetAllContact")
.Result;

System.Console.WriteLine(data);

dynamic c = new ExpandoObject();

c[0].phones[0]
c.fdvbfgdb = 1231;

System.Console.WriteLine(c.fdvbfgdb);