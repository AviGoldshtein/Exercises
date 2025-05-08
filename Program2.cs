// #1
// 	הם צריכים לדעת כמה מקום להקצות, אם לא נעשה זאת יהיה שגיאה בזמן ריצה.


// #2
// 2.	הסוג int: מכיל מספר, הסוג string: מכיל מחרוזת של מספרים. הint לוקח הרבה פחות מקום בזיכרון מהstring.


// #3
// 3.	הכל ימשיך כרגיל, כי הקלט בכל מקרה מגיע כstring.


// #4
// 4.	יכול לחסוך שגיאות בזמן שהמשתמש כבר משתמש בזה.


// #5
// 5.	Int: מקבל מספר שלם. Double: מקבל גם שברי מספרים. Float: זה כמו double אבל לוקח פחות מקום ויכול להגיע למספר קטן יותר מdouble.  Decimal: יותר גדול מdouble.


// #6
// 6.	הזיכרון מנוהל ומנוצל יותר טוב, כי הוא יודע מראש כמה זיכרון להקצות לכל משתנה.


// #7
// 7.	כשמנסים לחבר בין שני סוגי משתנים פייתון יתן לזה להתחיל לרוץ, וסי שארפ יעצור את זה בזמן.


// #8
//int num_1, num_2;
//Console.WriteLine("enter first number");
//num_1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("enter second number");
//num_2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("the resolt is: " + (num_1 * num_2));


// #9
//string age =  "30" ;
//int ageNum = Convert.ToInt32(age);


// #10
//////////////////////////////////////


// #11
// כי ספרה בסטרינג היא לא באמת הספרה אלא סמל עם ערך אסקי מספרי שמייצג את אותה ספרה.


// #12
// אם אני מצפה לקבל מספר לא שלם. אם אני יכין במקום זה אינט אני יכול לאבד שבר של מספר.


// #13
// שפחות ניתן להתבלבל בין מה אמור המשתנה לקבל.


// #14
// בגלל שהשפה בנויה בoop אז זה מאוד נוח לבנות ככה אפליקציות.


// #15
// יש מצבים בהם אני מצפה לקלט מסוים ואני לא ירצה שימיר דברים לא צפוים, המרה מדויקת ולא אוטומטית טובה יותר כך שאני 


// #26
//int x = 5;


// #27
//string name = "avi";
//Console.WriteLine("hello " + name);


// #28
//int x = 5;
//int y = 15;
//int resolt = x + y;


// #29
//double x = 15;
//double y = 15;
//Console.WriteLine((x + y) / 2);




// #30
//Console.WriteLine("enter a blessing");
//string input = Console.ReadLine();
//Console.WriteLine("the length of the blessing is: " + (input.Length) + " chars");


// #31
//Console.WriteLine("enter your name");
//string name = Console.ReadLine();
//Console.WriteLine("neter your age");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine($"hi {name} you will be {age + 5} years in 5 years from now");


// #32
//Console.WriteLine("enter a string");
//string str = Console.ReadLine();
//Console.WriteLine("enter a number");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine(str);
//}


// #33
//double sum = 0;
//for (int i=0; i<3; i++)
//{
//    int num = int.Parse(Console.ReadLine());
//    sum += num;
//}
//sum /= 3;
//Console.WriteLine(sum);


// #34
//Console.WriteLine("enter some string");
//Console.WriteLine(Console.ReadLine().ToUpper());


// #35
//Console.WriteLine("how old are you");
//int age = int.Parse(Console.ReadLine());
//if (age >= 18)
//{
//    Console.WriteLine("welcome, you can enter the club");
//} else
//{
//    Console.WriteLine("sorry, you can't enter the club");
//}


// #36
//string str_number = "58";
//int int_number = int.Parse(str_number);
//Console.WriteLine(int_number.GetType());
//Console.WriteLine(int_number);


// #37
//string str1 = Console.ReadLine();
//string str2 = Console.ReadLine();
//if (str1 == str2)
//{
//    Console.WriteLine("the strings are equal");
//}
//else
//{
//    Console.WriteLine("the strings are'nt equal");
//}


// #38
//int num = Convert.ToInt32(Console.ReadLine());
//if (num % 2 == 0)
//{
//    Console.WriteLine("the number is equal");
//}
//else
//{
//    Console.WriteLine("the number is not equal");
//}


// #39
//string name = Console.ReadLine();
//if (char.Parse(name.Substring(0,1)) == 'A')
//{
//    Console.WriteLine("the first letter is 'A'");
//}
//else
//{
//    Console.WriteLine("the first letter is not 'A'");
//}


// #40
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine(num * num);


// #41
//double hight_cm = int.Parse(Console.ReadLine());
//double hight_enc = hight_cm * 2.53;
//Console.WriteLine($"the hight in cm is: {hight_cm}, and in enches: {hight_enc} ");


// #42
//string input = (Console.ReadLine());
//if (int.TryParse(input, out int a))
//{
//    Console.WriteLine($"the input {a} is a number");
//}
//else
//{
//    Console.WriteLine($"the input {input} is not a number");
//}


// #43
//Console.WriteLine("enter the shape\n" +
//    "1. rectangel\n" +
//    "2. triangel");
//string shape = Console.ReadLine();
//Console.WriteLine("enter tow numbers");
//int num_1 = int.Parse(Console.ReadLine());
//int num_2 = int.Parse(Console.ReadLine());
//switch (shape)
//{
//    case "1":
//        Console.WriteLine("This is shape rectangel");
//        Console.WriteLine($"The surface is {num_1 * num_2}");
//        break;
//    case "2":
//        Console.WriteLine("This is shape triangel");
//        Console.WriteLine($" the hight is {num_1}, and the base is {num_2}");
//        break;
//    default:
//        Console.WriteLine("Unknown shape");
//        break;
//}


// #44
//string fullname = Console.ReadLine();
//int family_start = fullname.IndexOf(' ') + 1;
//Console.WriteLine(fullname.Substring(family_start));


// #45 //////////////////////////////////
//int i = 1;
//bool it_is = false;
//int ribua = 2;
//int based = 2;
//int num = Convert.ToInt32(Console.ReadLine());

//if (num == 1)
//{
//    Console.WriteLine($"the number '1' is -1 component ..-");
//}

//while (based <= Math.Sqrt(num))
//{
//    if (ribua == num)
//    {
//        it_is = true;
//        break;
//    }
//    ribua *= based;
//    Console.WriteLine(ribua); //for debug
//    i++;
//    if (ribua > num)
//    {
//        based++;
//        Console.WriteLine($"//////////////////////////// {based}"); //for debug
//        if (Math.Sqrt(based) == (int)Math.Sqrt(based))
//        {
//            based++;
//            Console.WriteLine($"//////////////////////////// {based}"); //for debug
//        }
//        ribua = based;
//        i = 1;
//    }
//}
//if (it_is)
//{
//    Console.WriteLine($"the number '{num}' is # {based} component {i} #");
//}
//else
//{
//    Console.WriteLine($"the number '{num}' is not ribua");
//}








































//string maybe = "is";
//int num = int.Parse(Console.ReadLine());
//double sqrt_num = Math.Sqrt(num);
//int ribua = 1;
//while (ribua <= num)
//{
//    if (ribua == num)
//    {
//        maybe = "is not";
//        break;
//    }
//    ribua *= ribua;
//}





//for (int i = 1; i < sqrt_num; i++)
//{
//    if (sqrt_num / 2 == 0)
//    {
//        maybe = "is not";
//    }
//}

//Console.WriteLine($"the number {maybe} a prime number");









































//using System.Runtime.InteropServices;

//int a = Console.Read();
//Console.WriteLine(a);
//Console.WriteLine(Marshal.SizeOf(a));




//string  aaa = "abc";
//string aaa2 = "kkk";
//Console.WriteLine(aaa2.Equals(aaa));
//Console.WriteLine(aaa == aaa2);

//string aaa3 = aaa.Substring(0,3);
//Console.WriteLine(aaa3);

//aaa3 = aaa.Replace("a", "p");
//Console.WriteLine(aaa3);

//aaa3 = aaa.Remove(0,3);



















//int age, hight; ;
//string color_hair, profetion;
//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine("entar your age");
//    age = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("enter your hight");
//    hight = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("enter color of hair (black/broun/..)");
//    color_hair = Console.ReadLine();
//    Console.WriteLine("enter profetion (doctor/maneger/..)");
//    profetion = Console.ReadLine();

//    if (age < 51 && age > 24 && (color_hair == "black" || color_hair == "broun") && hight > 169 && hight < 186 && (profetion == "doctor" || profetion == "maneger"))
//    {
//        Console.WriteLine($"this man is the spy\n" +
//            $"his age is: {age}\n" +
//            $"his hight is: {hight}\n" +
//            $"his color of hair is: {color_hair}\n" +
//            $"his profetion is: {profetion}");
//        break;
//    }
//}





//string path = "C:\\Users\\a0548\\source\\repos\\ConsoleApp6\\ConsoleApp6\\passwords_55.txt";
//string content = File.ReadAllText(path);
//Console.WriteLine(content);











////////////////////////////////////////////////////////////////////////////


// #1
//Console.WriteLine(Convert.ToInt32(Console.ReadLine()) > 0 ? "positive" : "negetive");


// #2
//int num_1 = int.Parse(Console.ReadLine());
//int num_2 = int.Parse(Console.ReadLine());
//Console.WriteLine(num_1 > num_2 ? num_1 : num_2);


// #3
//int grade = Convert.ToInt32(Console.ReadLine());
//if (grade > 90)
//{
//    Console.WriteLine("grate");
//} else if (grade > 75)
//{
//    Console.WriteLine("very good");
//}
//else
//{
//    Console.WriteLine("you have to be better");
//}


// #4
//int day_n = Convert.ToInt32(Console.ReadLine());
//switch (day_n)
//{
//    case 1:
//        Console.WriteLine("sunday");
//        break;
//    case 2:
//        Console.WriteLine("munday");
//        break;
//    case 3:
//        Console.WriteLine("tusday");
//        break;
//    case 4:
//        Console.WriteLine("wendnsday");
//        break;
//    case 5:
//        Console.WriteLine("thursday");
//        break;
//    case 6:
//        Console.WriteLine("friday");
//        break;
//    case 7:
//        Console.WriteLine("saterday");
//        break;
//    default:
//        Console.WriteLine("invalid input");
//        break;

//}


// #5
//int temperture = Convert.ToInt32(Console.ReadLine());
//if (temperture > 30)
//{
//    Console.WriteLine("hot");
//}else if (temperture > 20)
//{
//    Console.WriteLine("warm");
//} else
//{
//    Console.WriteLine("cold");
//}


// #6
//int age = Convert.ToInt32(Console.ReadLine());
//Console.Write(age >= 17 ? "you are" : "you are not");
//Console.WriteLine(" aloud to get a licens");


// #7
//Console.WriteLine(Convert.ToInt32(Console.ReadLine()) % 2 == 0 ? "it is zogi" : "it is not zugi");


// #8
//string input = Console.ReadLine();
//char first_letter = input[0];
//Console.WriteLine(char.IsUpper(first_letter) ? "big char": char.IsUpper(first_letter) ? "lower char" : "not a char");


// #9
//int sum = Convert.ToInt32(Console.ReadLine());
//int hanacha = sum > 500 ? 10 : sum > 100 ? 5 : 0;
//Console.WriteLine(sum - (sum*(hanacha / 100)));


// #10
//Console.WriteLine("1. conect\n" +
//    "2. register\n" +
//    "3. exit");
//int input = Convert.ToInt32(Console.ReadLine());
//switch (input)
//{
//    case 1:
//        Console.WriteLine("conecting");
//        break;
//    case 2:
//        Console.WriteLine("registering");
//        break;
//    case 3:
//        Console.WriteLine("exiting");
//        break;
//    default:
//        Console.WriteLine("somthint went wrong");
//        break;
//}


// #11
//int birthday_year = Convert.ToInt32(Console.ReadLine());
//int age = 2025 - birthday_year;
//string stage = age <= 13 ? "boy" : age <= 17 ? "naar" : "adolt";
//Console.WriteLine(stage);


// #12
//int num_1 = Convert.ToInt32(Console.ReadLine());
//int num_2 = Convert.ToInt32(Console.ReadLine());
//int num_3 = Convert.ToInt32(Console.ReadLine());
//if (num_1 > num_2)
//{
//    if (num_1 > num_3)
//    {
//        Console.WriteLine("num 1");
//    }
//    else
//    {
//        Console.WriteLine("num 3");
//    }
//}
//else
//{
//    if (num_2 > num_3)
//    {
//        Console.WriteLine("num 2");
//    }
//    else
//    {
//        Console.WriteLine("num 3");
//    }
//}


// #13
//int num = Convert.ToInt32(Console.ReadLine());
//if (num %3 == 0 && num % 5 == 0)
//{
//    Console.WriteLine("fizzbuzz");
//}
//else if (num %3 == 0)
//{
//    Console.WriteLine("fizz");
//}
//else if (num % 5 == 0)
//{
//    Console.WriteLine("buzz");
//}
//else
//{
//    Console.WriteLine(num);
//}


// #14
//int time = Convert.ToInt32(Console.ReadLine());
//string say = time > 23 || time < 0 ? "not valid" : time > 22 || time < 5 ? "good night" : time < 12 ? "good morning" : time < 19 ? "good meadday" : "good night" ;
//Console.WriteLine(say);


// #15
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(num >= 50 && num <= 100 ? "is in range" : "is out of range");


// #16
//Console.WriteLine("enter (red/yello/green)");
//string color = Console.ReadLine();
//switch (color)
//{
//    case "red":
//        Console.WriteLine(color);
//        break;
//    case "yello":
//        Console.WriteLine(color);
//        break;
//    case "green":
//        Console.WriteLine(color);
//        break;
//        default:
//        Console.WriteLine("not valid");
//        break;
//}


// #17
//string saved_name = "avi";
//int saved_password = 208521419;
//string name = Console.ReadLine();
//int password = Convert.ToInt32(Console.ReadLine());
//if (name == saved_name && password == saved_password)
//{
//    Console.WriteLine($"welcom {name}");
//}
//else
//{
//    Console.WriteLine("it is not right");
//}


// #18
//double num = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(num != (int)num ? "not a round number" : num < 0 ? "negetive" : "positive");






















//////////////////////////  תרגול שיקוי קסמים  /////////////////////////////////////////
//int temperature = 78;
//int toxicity = 40;
//int colorCode = 5;
//int glowLevel = 6;

//int baseScore = (100 - toxicity) + glowLevel * 3 - Math.Abs(colorCode - 7) * 2;

//bool is_muzlach = baseScore > 80 ? true : false;
//bool is_mesucan = temperature > 90 || toxicity > 70 ? true : false;
//bool is_nadir = colorCode == 7 && glowLevel > 7 ? true : false;
//bool is_for_public_use = is_muzlach && !is_mesucan ? true : false;








///////////////////////////   loops  ////////////////////////////////

// #1
//for (int i=1; i<6; i++)
//{
//    Console.WriteLine(i);
//}


//#2
//for (int i = 2; i < 11; i += 2)
//{
//    Console.WriteLine(i);
//}

//int i = 2;
//while (i < 11)
//{
//    Console.WriteLine(i);
//    i += 2;
//}


// #3
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(n >= 0 ? "yes" : "no");


// #4
//while (true)
//{
//    string input = Console.ReadLine();
//    if (input == "exit")
//    {
//        break;
//    }
//}


// #5
//for (int i=0; i<10; i++)
//{
//    Console.WriteLine("you can access");
//}


// #6
//for (int i=1; i<21; i++)
//{
//    if (i % 3 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}


// #7
//int i = 5;
//while (i > 0)
//{
//    Console.WriteLine(i);
//    i--;
//}


// #8
//for (int i=1; i<11; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine($"{i} is zugi");
//    }
//    else
//    {
//        Console.WriteLine($"{i} is not zugi");
//    }
//}


// #9
//Console.WriteLine(Console.ReadLine() == "8200" ? "safe" : "not safe");


// #10
//string name = "";
//while (name != "admin")
//{
//    name = Console.ReadLine();
//}


// #11
//int how_much = 0;
//for (int i=1; i<101; i++)
//{
//    if (i % 7 == 0)
//    {
//        how_much += 1;
//    }
//}
//Console.WriteLine(how_much);


// #12
//string password = Console.ReadLine();
//if (password.Length == 8)
//{
//    Console.WriteLine("yes");
//}


// #13
//string input = Console.ReadLine();
//for (int i = 0; i < input.Length; i++)
//{
//    if (Char.IsLetter(input[i]))
//    {
//        Console.WriteLine(input[i]);
//    }
//}


// #14
//string password;
//do
//{
//    password = Console.ReadLine();
//}
//while (password.Length != 8);


// #15
//for (int i = 3; i < 100; i++)
//{
//    bool is_it = true;
//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            is_it = false;
//            break;
//        }
//    }
//    if (is_it)
//    {
//        Console.WriteLine($"{i} is rishoni");
//    }
//}


// #16
//string saved_password = "1234";
//bool succes = false;
//for (int i=0; i<3; i++)
//{
//    string password = Console.ReadLine();
//    if (password == saved_password)
//    {
//        succes = true;
//        break;
//    }
//}
//if (succes)
//{
//    Console.WriteLine("welcome");
//}
//else
//{
//    Console.WriteLine("more then three");
//}


// #17
//int somOfNums = 0;
//string input = Console.ReadLine();
//foreach (char chr in input)
//{
//    if (char.IsNumber(chr)) somOfNums++;
//}
//Console.WriteLine($"the sum of nums is: {somOfNums}");


// #18
//for (int i=0; i<=50; i++)
//{
//    if (i % 10 == 0) Console.WriteLine(i);
//}


// #19
//int sum = 0;
//int input;
//while (true)
//{
//    input = Convert.ToInt32(Console.ReadLine());
//    if (input > 0)
//    {
//        sum += input;
//    }
//    else
//    {
//        break;
//    }
//}
//Console.WriteLine(sum);


// #20
//string output = "";
//string num = Console.ReadLine();
//for (int i=0; i <num.Length; i++)
//{
//    output += "*";
//}
//Console.WriteLine(output);


// #21
//bool running = true;
//while (running)
//{
//    Console.WriteLine("enter your darga\n" +
//        "1. sgan mishne\n" +
//        "2. segen\n" +
//        "3. seren\n" +
//        "4. rav seren\n" +
//        "5. sgan aluf\n" +
//        "6. exit\n");
//    string input = Console.ReadLine();
//    if (input == "6")
//    {
//        Console.WriteLine("by");
//        running = false;
//    }
//    else
//    {
//        Console.WriteLine($"you have {6 - (Convert.ToInt32(input))} dargot to ramatcal");
//    }
//}


// #22
//string saved_name = "avi";
//string saved_passworde = "1234";
//string name = Console.ReadLine();
//string password = Console.ReadLine();
//if (name == saved_name && password == saved_passworde) Console.WriteLine("welcome");


// #23
Random generator = new Random();
int password = generator.Next(99999, 1000000);
Console.WriteLine(password);







