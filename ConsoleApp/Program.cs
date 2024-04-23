

using Newtonsoft.Json;
using UserPropertiesAD;

var res = UserLoginProperties.GetInstance();
res.UserName = "adeleh.m";
Console.WriteLine(JsonConvert.SerializeObject(res.GetProperties(),Formatting.Indented));