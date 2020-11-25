# SystemGlobalServices
A web service based on daily data on Central Bank exchange rates (https://www.cbr-xml-daily.ru/daily_json.js) using ASP.Net Core, which implements 2 API methods:  
GET /currencies - should return a list of currency rates using pagination  
GET /currency/ - should return the currency rate for the passed private currency
