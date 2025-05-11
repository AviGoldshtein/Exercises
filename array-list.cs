


///////////////////////  array / list   /////////////////////////////


///  #1
//List<string> names = new List<string> {"avi", "moshe", "yaakov", "nachman", "shuki"};
//names.Add("yael");
//names.Add("mosh mosh");
//names.Remove("moshe");
//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine($"{i}. {names[i]}");
//}


///  #2
//Dictionary<string, int> myDict = new Dictionary<string,int>();
//myDict["vaiolin"] = 41;
//myDict["clarinet"] = 13;
//myDict["tromp"] = 82;

//myDict["vaiolin"] += 1;

//foreach (var keyVal in myDict)
//{
//    Console.WriteLine(keyVal);
//}


///  #3
//List<Dictionary<string, string>> members = new List<Dictionary<string, string>>();

//Dictionary<string, string> person1 = new Dictionary<string, string>();
//person1["name"] = "avi";
//person1["email"] = "a00@gmail.com";
//person1["status"] = "marrid";
//members.Add(person1);

//Dictionary<string, string> person2 = new Dictionary<string, string>();
//person2["name"] = "moshe";
//person2["email"] = "w30@gmail.com";
//person2["status"] = "single";
//members.Add(person2);

//foreach (var member in members)
//{
//    Console.WriteLine(member["email"]);
//}


///  #4
//List<string> members = new List<string> {"avi", "moshe", "yaakov"};
//string asked_name = Console.ReadLine();
//bool not_found = true;
//for (int i = 0; i < members.Count; i++)
//{
//    if (asked_name == members[i])
//    {
//        not_found = false;
//        Console.WriteLine($"you are in index: {i}");
//        break;
//    }
//}
//if (not_found) Console.WriteLine("username not registered");


///  #5
//List<Dictionary<string, string>> solders = new List<Dictionary<string, string>>();

//Dictionary<string, string> solders1 = new Dictionary<string, string>();
//solders1["name"] = "avi";
//solders1["tool1"] = "";
//solders1["tool2"] = "1";
//solders1["tool3"] = "1";
//solders.Add(solders1);

//Dictionary<string, string> solders2 = new Dictionary<string, string>();
//solders2["name"] = "moshe";
//solders2["tool1"] = "1";
//solders2["tool2"] = "1";
//solders2["tool3"] = "1";
//solders.Add(solders2);

//Dictionary<string, string> solders3 = new Dictionary<string, string>();
//solders3["name"] = "rami";
//solders3["tool1"] = "1";
//solders3["tool2"] = "1";
//solders3["tool3"] = "1";
//solders.Add(solders3);


//foreach(var solder in solders)
//{
//    if (solder["tool1"] == "1" && solder["tool2"] == "1" && solder["tool3"] == "1")
//    {
//        Console.WriteLine($"{solder["name"]} is ready");
//    }
//}
























static void qqq(string _a="sss")
{
    Console.WriteLine("in qqq");
    Console.WriteLine("aaaaaaaaaaaaaa");
    Console.WriteLine(_a);
}




static void abc()
{
    Console.WriteLine("in abc");

}


static void all()
{
    Console.WriteLine("in all");
    abc();
    qqq();
}

all();