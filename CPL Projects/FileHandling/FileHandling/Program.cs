using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class FileHandling
    {
        /*                                                      NOTES
         
         System.TO namespace is used in file handling. Is namespace ma filing kelya bhot si classes hain msln FileStream , Binary Reader, Binary Writer , Stream , Text Reader , Text Writer , File and FileSystemInfo etc in ma kuch abstract classes hain to kuch derived. Yeh sb classes objects banati hain jin ka multiple parameterized constructors hota hain.

                                                                FILE CLASS

        1) Systen.IO.File class ke zarya jis ma hum in methods ka istemaal kr ke file handling krta hain:
                 Operation      |                                    Kaam

            1. Likhna (Write)   |    Diya gaya text poori file mein likh deta hai. Agar file maujood ho toh purane content 
            2. Padhna (Read)    |    Poori file ke content ko ek hi string mein padh leta hai.
            3. Jodna (Append)   |    Content ko file ke aakhir mein jod deta hai.
            4. Delete File      |    It delete the whole file from the system.

                                                 GENERAL SYNTAX OF METHODS

        string filePath = "MeriPehliFile.txt";

        1. File.WriteAllText(<filePath>, contentToWrite ...);
        2. File.AppendAllText(<filePath>, additionalContent ...);
        3. string readContent = File.ReadAllText(<filePath>);
           Console.WriteLine(readContent);
        4. File.Delete(<filePath>)

        Yaad rahe agar current directory ma yeh file pehla sa moujood ho gi to yeh us ma changes kr dainga lekin agar current directory ma woh file moujood nahi ho gi to yeh khud current direcctory main yeh file create kr dega our us ma sb changes kr dainga.


                                                          STREAM CLASS
         
        2) StreamReader aur StreamWriter Classes (Behtar Tareeqa)
         
         Note: Jb hum stream classes use krta hain to yeh file open kri hain to hmain unhain band bhi krna hota ha file.Close(); ya file.Dispose(); methods sa. lekin agr hum apna yeh operations using block ke andar krain to using ki body end hona ke baad file automatically close ho jaati ha.

           Stream classes ma hum pehla ek object banata hain our phir us ke attributes/methods ka istemaal kr ka file handling krta hain.

        1. 

                                         Stream classes use krna ka tariqa

        1.using (StreamWriter writer = new StreamWriter(filePath))
            {

             1. writer.Write("Hello");              //(Text likhta hai, lekin new line add nahi karta.)
             2. writer.WriteLine("Hello World");    //(Text likhta hai aur uske baad ek new line (Enter) add karta hai.)
             3. writer.Flush();                     //(Jo kuch bhi aap na likha ha usa fouri tour pr file ma save krwana kalya)
        
             //    Jab aap writer.WriteLine("data"); likhte hain, toh data fori tor par aapki Hard Disk par save nahi hota. C# performance barqarar rakhne ke liye data ko pehle temporary memory area mein jama karta hai jise "Buffer" kehte hain.

             //    Buffer data ko ikattha karta rehta hai, aur jab buffer bhar jata hai, ya jab program khatam   hota   hai, tab data ek saath disk par bheja jata hai.

             //   Flush() Ka Kaam Flush() method is buffer mein mojood pending data ko zabardasti kehta hai ke "Abhi ke abhi   disk   par save ho jao, buffer ke bharne ka intezar mat karo".
    
            }
            
        2. using (StreamReader reader = new StreamReader(filePath))
            {

             1. string line = reader.ReadLine();       //(File se ek poori line read karta hai aur cursor agli line par le jata hai.)
                  Console.WriteLine(line);
             2. string fullText = reader.ReadToEnd();  //(Shuru se akhir tak poori file ek hi string mein read kar leta hai.)
                  Console.WriteLine(fullText); 
             3. int charCode = reader.Read();          //(Single character ya characters ka block read karta hai.)
                  Console.WriteLine(charCode);

            }
        Note: .ReadLine() & .Read() uses internal cursor / position pointer in beginning it is at the start of the file and then we read file file by using any method that cursor moves forward respectively.

                                    string content = File.ReadAllText(path, Encoding.UTF8);

         File.ReadAllText() method ke do versions hote hain (jinko C# mein "overloads" kehte hain):Ek version sirf path leta hai (File.ReadAllText(path)).Doosra version path aur encoding dono leta hai (File.ReadAllText(path, Encoding.UTF8)).
        Yeh Encoding Kya Cheez Hai?
           Computer sirf numbers samajhta hai (0s aur 1s). Jab hum file mein text save karte hain, toh har character (jaise 'A', '!', 'اردو') ko ek specific number assignment di jaati hai. Iss assignment ke tareeqay ko Encoding kehte hain.
           Encoding.UTF8: Yeh data store karne ka aaj ke daur ka sab se standard aur aam tareeqa hai. Yeh duniya ki zyada tar zubanon (English, Urdu, Chinese, Emoji waghera) ko support karta hai.

                                 string content = File.ReadAllText(path, Encoding.UTF8);

        Iss line ka matlab hai:
            "Jao, iss path wali file ko parho, aur usay parhte waqt yeh samjho ke woh file UTF8 format mein likhi hui hai, aur us content ko string mein convert karke mujhe de do."


                                                           BUFFER

        1. Buffer Kya Hai? (The Waiting Area)
       Buffer darasal RAM (Memory) ka ek chota sa hissa hota hai jo data ko "aarzi" (temporarily) taur par pakar kar rakhta hai.Asaan Misal: Sochiye aap ek ghar bana rahe hain aur eentein (bricks) ek jagah se dusri jagah le jani hain.Aap ek-ek eent utha kar nahi bhagte, balki ek "Rehri" (Wheelbarrow) ka istemal karte hain.Wo Rehri (Wheelbarrow) aapka Buffer hai.Aap pehle eentein utha kar Rehri mein rakhte hain (Buffer mein daalna), aur phir Rehri ko le ja kar deewar ke paas khali kar dete hain.
















         
         */











        /*
         Lab Tasks/Practical Work

1. Design a program of Student in which you have to take information of 10 Student. Information
includes (Student_id, name, date of birth, email, residential address, job title, salary ... etc.) and save all the records in a txt file using StreamWriter.*/



        // This is the one way to do this program. In this way input is taken by using arrays.


        //public static void Main(string[] args)
        //{

        //    int[] Student_id = new int[10];
        //    string[] name = new string[10];
        //    DateTime[] dob = new DateTime[10];
        //    string[] email = new string[10];
        //    string[] resaddres = new string[10];
        //    string[] jobtitle = new string[10];
        //    decimal[] salary = new decimal[10];

        //    try
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine($"Please enter the student {i + 1} id:");
        //            Student_id[i] = int.Parse(Console.ReadLine());
        //            Console.WriteLine($"Please enter the student {i + 1} name:");
        //            name[i] = Console.ReadLine();
        //            Console.WriteLine($"Please enter the student {i + 1} date of birth:");
        //            dob[i] = DateTime.Parse(Console.ReadLine());
        //            Console.WriteLine($"Please enter the student {i + 1} email:");
        //            email[i] = Console.ReadLine();
        //            Console.WriteLine($"Please enter the student {i + 1} residential address:");
        //            resaddres[i] = Console.ReadLine();
        //            Console.WriteLine($"Please enter the student {i + 1} Job Title:");
        //            jobtitle[i] = Console.ReadLine();
        //            Console.WriteLine($"Please enter the student {i + 1} salary:");
        //            salary[i] = decimal.Parse(Console.ReadLine());
        //        }
        //        string file = "student.txt";
        //        using (StreamWriter records = new StreamWriter(file))
        //        {
        //            records.WriteLine("StudentId,Name,DateOfBirth,Email,ResidentialAddress,JobTitle,Salary");
        //            for (int i = 0; i < 10; i++)
        //            {
        //                records.WriteLine($"{Student_id[i]},{name[i]},{dob[i]},{email[i]},{resaddres[i]},{jobtitle[i]},{salary[i]}");
        //            }
        //            records.Flush();
        //        }

        //    }
        //    catch (System.Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally { Console.WriteLine("The program of saving the student data in txt file is completed"); }

        //}

        // There 2nd way to write this program means taking input by using fields not arrays which is a part of object oriented programming which we learn in next semester.


        /*
        2. Design a C# program that reads from a pre-existing file containing the following grocery data:

        item_id,item_name,manufacturing_date,expiration_date,quantity,price
        101,Apple,2024-01-05,2024-02-10,50,0.5
        102,Banana,2024-01-07,2024-02-15,100,0.2
        103,Orange,2024-01-12,2024-03-01,80,0.6
        104,Bread,2024-01-02,2024-01-15,30,1.5
        105,Milk,2024-01-10,2024-01-20,25,2.0
        106,Butter,2023-12-20,2024-02-01,40,3.5
        107,Cheese,2023-12-25,2024-02-05,60,4.0
        108,Rice,2024-01-01,2024-06-01,100,1.2
        109,Pasta,2024-01-15,2024-04-01,75,1.8
        110,Sugar,2024-01-03,2025-01-03,200,0.9       

        The program will perform the following operations using StreamReader, based on the function
        selected by the user:
        a. Print the name and price of the grocery item based on the item_id given by the user.
        b. Print the total number of grocery items.
        c. Print the total quantity of all grocery items.                 */


        //public static void Main(string[] args)
        //{
        //    string file = "D:\\HP\\VS Projects\\CPL Projects\\FileHandling\\FileHandling\\Task2.txt";
        //    string[] allRecords = null; // Array jismein saari lines store hongi
        //    int recordCount = 0; // Records ki tadad

        //    try
        //    {
        //        // --- STEP 1: COUNTING LINES TO DETERMINE ARRAY SIZE ---
        //        // Hum file ko ek baar padh kar records ki tadad maloom karenge.
        //        recordCount = File.ReadAllLines(file).Length;

        //        // Header (pehli line) ko count mein shamil nahi karna
        //        recordCount -= 1;

        //        if (recordCount <= 0)
        //        {
        //            Console.WriteLine("Error: File khali hai ya koi data records maujood nahi hai.");
        //            return;
        //        }

        //        // Array ko recordCount size ke mutabiq banana
        //        allRecords = new string[recordCount];

        //        // --- STEP 2: LOADING DATA INTO ARRAY USING STREAMREADER ---
        //        using (StreamReader data = new StreamReader(file))
        //        {
        //            // Header (pehli line) ko padh kar skip kar dena
        //            data.ReadLine();

        //            string line;
        //            int index = 0;

        //            while ((line = data.ReadLine()) != null && index < recordCount)
        //            {
        //                if (!string.IsNullOrWhiteSpace(line))
        //                {
        //                    allRecords[index] = line;
        //                    index++;
        //                }
        //            }
        //        } // StreamReader band ho jayega

        //        Console.WriteLine($"{allRecords.Length} records are successfully loaded from the file.");

        //        // --- USER INTERACTION PHASE ---
        //        bool keepRunning = true;
        //        while (keepRunning)
        //        {
        //            Console.WriteLine("--- Select The Operations ---");
        //            Console.WriteLine("a. Get the price by using Item ID.");
        //            Console.WriteLine("b. Print total count of groccery items.");
        //            Console.WriteLine("c. Print the total quantity of all items.");
        //            Console.WriteLine("x. End the program.");
        //            Console.Write("Your Selection: ");

        //            string choice = Console.ReadLine()?.ToLower();

        //            switch (choice)
        //            {
        //                case "a":
        //                    // Operation a: Item ID se Naam aur Price maloom karna
        //                    SearchItemById(allRecords);
        //                    break;
        //                case "b":
        //                    // Operation b: Total number of grocery items
        //                    Console.WriteLine($"Total Unique Grocery Items ki tadad (Count): {allRecords.Length}");
        //                    break;
        //                case "c":
        //                    // Operation c: Tamam items ki total quantity print karna
        //                    CalculateTotalQuantity(allRecords);
        //                    break;
        //                case "x":
        //                    keepRunning = false;
        //                    break;
        //                default:
        //                    Console.WriteLine("Galat selection. Barahe karam sahi option chunein.");
        //                    break;
        //            }
        //        }
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        Console.WriteLine($"Error: File '{file}' maujood nahi hai. Barahe karam check karein.");
        //    }
        //    catch (System.Exception ex)
        //    {
        //        Console.WriteLine($"Aam Error: Koi masla hua: {ex.Message}");
        //    }

        //    Console.WriteLine("--- Program Mukammal Hua ---");
        //}

        //// Function for Operation a (Item ID search)
        //private static void SearchItemById(string[] records)
        //{
        //    Console.Write("Item ID darj karein: ");
        //    if (int.TryParse(Console.ReadLine(), out int searchId))
        //    {
        //        bool found = false;
        //        // Array par loop chala rahe hain
        //        for (int i = 0; i < records.Length; i++)
        //        {
        //            string line = records[i];
        //            string[] values = line.Split(',');

        //            if (values.Length >= 6 && int.TryParse(values[0], out int itemId))
        //            {
        //                if (itemId == searchId)
        //                {
        //                    Console.WriteLine($"   Item Details (ID: {searchId})");
        //                    Console.WriteLine($"   Name: {values[1]}"); // Index 1 par item_name hai
        //                    Console.WriteLine($"   Price: ${values[5]}"); // Index 5 par price hai
        //                    found = true;
        //                    break;
        //                }
        //            }
        //        }

        //        if (!found)
        //        {
        //            Console.WriteLine($"    Item ID {searchId} ka koi record nahi mila.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Galat Item ID format.");
        //    }
        //}

        //// Function for Operation c (Total Quantity)
        //private static void CalculateTotalQuantity(string[] records)
        //{
        //    int totalQuantity = 0;

        //    // Array par loop chala rahe hain
        //    for (int i = 0; i < records.Length; i++)
        //    {
        //        string line = records[i];
        //        string[] values = line.Split(',');

        //        // Quantity Index 4 par hai
        //        if (values.Length >= 5 && int.TryParse(values[4], out int quantity))
        //        {
        //            totalQuantity += quantity;
        //        }
        //    }

        //    Console.WriteLine($"    Tamam Grocery Items ki Total Quantity: {totalQuantity}");
        //}
















        /*
        3. Write a C# program that collects data for multiple countries, including country name, country code (ISO code), population, capital city, official languages, GDP, and time zone. For each country, the program will create a new text file named after the country (e.g., USA.txt, Germany.txt), and the information will be saved using StreamWriter.
         The program will present the user with two options:
        a. The user can input data for a specific country, and the program will create a new text file for that country.
        b. The user can search for a country by its name, and the program will display important details such as the population, capital city, and GDP from the corresponding file using Stream Reader.
                 */




        //        public static void Main(string[] args)
        //        {
        //            bool keepRunning = true;

        //            Console.WriteLine("--- Global Country Data Manager ---");

        //            while (keepRunning)
        //            {
        //                Console.WriteLine("-------------------------------------");
        //                Console.WriteLine("Please Select an Option:");
        //                Console.WriteLine("a. Enter New Country Data (Write to File)");
        //                Console.WriteLine("b. Search Country Data (Read from File)");
        //                Console.WriteLine("x. Exit Program");
        //                Console.Write("Your selection: ");

        //                string choice = Console.ReadLine()?.ToLower();
        //                // here ? is Null-Conditional Operator which checks is the choice is null or not so that the .tolower() method error na throw kra.
        //                switch (choice)
        //                {
        //                    case "a":
        //                        InputAndSaveCountryData();
        //                        break;
        //                    case "b":
        //                        SearchAndDisplayCountryData();
        //                        break;
        //                    case "x":
        //                        keepRunning = false;
        //                        break;
        //                    default:
        //                        Console.WriteLine("Invalid Option. Please Try Again.");
        //                        break;
        //                }
        //            }

        //            Console.WriteLine("--- Program Completed ---");
        //        }

        //        // A. Function: Take country data from the user and save it to a file
        //        private static void InputAndSaveCountryData()
        //        {
        //            // 1. Array for collecting data (7 fields)
        //            // [CountryName, CountryCode, Population, CapitalCity, OfficialLanguages, GDP, TimeZone]
        //            string[] countryData = new string[7];

        //            Console.WriteLine("--- New Country Information ---");

        //            // Input gathering
        //            Console.Write("1. Country Name: ");
        //            countryData[0] = Console.ReadLine();

        //            Console.Write("2. Country Code (ISO): ");
        //            countryData[1] = Console.ReadLine();

        //            Console.Write("3. Population: ");
        //            countryData[2] = Console.ReadLine();

        //            Console.Write("4. Capital City: ");
        //            countryData[3] = Console.ReadLine();

        //            Console.Write("5. Official Languages: ");
        //            countryData[4] = Console.ReadLine();

        //            Console.Write("6. GDP (in Billions): ");
        //            countryData[5] = Console.ReadLine();

        //            Console.Write("7. Time Zone: ");
        //            countryData[6] = Console.ReadLine();

        //            // Creating File Path: (e.g., USA.txt)
        //            string fileName = $"{countryData[0]}.txt";

        //            try
        //            {
        //                // Using StreamWriter to write data to the file
        //                using (StreamWriter writer = new StreamWriter(fileName))
        //                {
        //                    // Writing the Header
        //                    writer.WriteLine("Field,Value");

        //                    // Writing each array element line by line
        //                    writer.WriteLine($"Country Name,{countryData[0]}");
        //                    writer.WriteLine($"Country Code,{countryData[1]}");
        //                    writer.WriteLine($"Population,{countryData[2]}");
        //                    writer.WriteLine($"Capital City,{countryData[3]}");
        //                    writer.WriteLine($"Official Languages,{countryData[4]}");
        //                    writer.WriteLine($"GDP,{countryData[5]}");
        //                    writer.WriteLine($"Time Zone,{countryData[6]}");
        //                }
        //                // The file will be automatically closed here by the 'using' block

        //                Console.WriteLine($"Success: Data saved to '{fileName}'.");
        //            }
        //            catch (IOException ex)
        //            {
        //                Console.WriteLine($"File Error: An IO issue occurred while saving data: {ex.Message}");
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine($"General Error: {ex.Message}");
        //            }
        //        }

        //        // B. Function: Read and display country data from the file
        //        private static void SearchAndDisplayCountryData()
        //        {
        //            Console.Write("Please Enter the Country Name to Search: ");
        //            string searchName = Console.ReadLine();

        //            string fileName = $"{searchName}.txt";

        //            try
        //            {
        //                // Using StreamReader to read data from the file
        //                using (StreamReader reader = new StreamReader(fileName))
        //                {
        //                    string line;
        //                    Console.WriteLine($"Search Result for {searchName} ---");

        //                    // Skipping the Header (first line)
        //                    reader.ReadLine();

        //                    // Array to store the required details (for display only)
        //                    string[] detailsArray = new string[3];
        //                    int detailIndex = 0;

        //                    while ((line = reader.ReadLine()) != null)
        //                    {
        //                        // Splitting the data into Field and Value (using Comma separator)
        //                        string[] parts = line.Split(',');

        //                        if (parts.Length >= 2)
        //                        {
        //                            string field = parts[0].Trim();
        //                            string value = parts[1].Trim();

        //                            // Displaying only the essential details
        //                            if (field == "Population" || field == "Capital City" || field == "GDP")
        //                            {
        //                                // Storing the output
        //                                detailsArray[detailIndex] = $"{field}: {value}";
        //                                detailIndex++;
        //                            }
        //                        }
        //                    }

        //                    // Displaying the results from the temporary array
        //                    if (detailIndex > 0)
        //                    {
        //                        for (int i = 0; i < detailIndex; i++)
        //                        {
        //                            Console.WriteLine($"   {detailsArray[i]}");
        //                        }
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("File found, but essential information was not located.");
        //                    }
        //                }
        //            }
        //            catch (FileNotFoundException)
        //            {
        //                // If the file does not exist
        //                Console.WriteLine($"Error: The file for country '{searchName}' ({fileName}) does not exist.");
        //                Console.WriteLine("Please enter its data first using Option 'a'.");
        //            }
        //            catch (IOException ex)
        //            {
        //                Console.WriteLine($"IO Error: An issue occurred while reading data: {ex.Message}");
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine($"General Error: {ex.Message}");
        //            }
        //        }
        //    }
        //}


        //                            EASY & SIMPLE ALTERNATIVE PROGRAMS FOR Q2 & Q3


        /*
        2. Design a C# program that reads from a pre-existing file containing the following grocery data:

        item_id,item_name,manufacturing_date,expiration_date,quantity,price
        101,Apple,2024-01-05,2024-02-10,50,0.5
        102,Banana,2024-01-07,2024-02-15,100,0.2
        103,Orange,2024-01-12,2024-03-01,80,0.6
        104,Bread,2024-01-02,2024-01-15,30,1.5
        105,Milk,2024-01-10,2024-01-20,25,2.0
        106,Butter,2023-12-20,2024-02-01,40,3.5
        107,Cheese,2023-12-25,2024-02-05,60,4.0
        108,Rice,2024-01-01,2024-06-01,100,1.2
        109,Pasta,2024-01-15,2024-04-01,75,1.8
        110,Sugar,2024-01-03,2025-01-03,200,0.9       

        The program will perform the following operations using StreamReader, based on the function
        selected by the user:
        a. Print the name and price of the grocery item based on the item_id given by the user.
        b. Print the total number of grocery items.
        c. Print the total quantity of all grocery items.                 */



        //  public static void Main(string[] args)
        //  {
        //      string file = "simple2.txt";
        //
        //      Console.WriteLine("Please enter the item id :");
        //      int id = int.Parse(Console.ReadLine());
        //
        //      using (StreamReader record = new StreamReader(file, Encoding.UTF8)
        //      {
        //         
        //      }
        //
        //  }
        //



        //static void Main(string[] args)
        //{
        //    string path = "simple2.txt";

        //    Console.WriteLine("1. Item name aur price by item_id");
        //    Console.WriteLine("2. Total grocery items");
        //    Console.WriteLine("3. Total quantity of all items");
        //    Console.Write("Choice enter karo: ");
        //    int choice = int.Parse(Console.ReadLine());

        //    StreamReader reader = new StreamReader(path , Encoding.UTF8);

        //    string line = reader.ReadLine(); // header skip

        //    int totalItems = 0;
        //    int totalQuantity = 0;

        //    if (choice == 1)
        //    {
        //        Console.Write("Item ID enter karo: ");
        //        string searchId = Console.ReadLine();

        //        bool found = false;

        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            string[] data = line.Split(',');

        //            if (data[0] == searchId)
        //            {
        //                Console.WriteLine("Item Name: " + data[1]);
        //                Console.WriteLine("Price: " + data[5]);
        //                found = true;
        //                break;
        //            }
        //        }

        //        if (!found)
        //            Console.WriteLine("Item nahi mila");
        //    }

        //    else if (choice == 2)
        //    {
        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            totalItems++;
        //        }

        //        Console.WriteLine("Total grocery items: " + totalItems);
        //    }

        //    else if (choice == 3)
        //    {
        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            string[] data = line.Split(',');
        //            totalQuantity += int.Parse(data[4]);
        //        }

        //        Console.WriteLine("Total quantity: " + totalQuantity);
        //    }

        //    else
        //    {
        //        Console.WriteLine("Invalid choice");
        //    }

        //    reader.Close();
        //}





        /*
       3. Write a C# program that collects data for multiple countries, including country name, country code (ISO code), population, capital city, official languages, GDP, and time zone. For each country, the program will create a new text file named after the country (e.g., USA.txt, Germany.txt), and the information will be saved using StreamWriter.
        The program will present the user with two options:
       a. The user can input data for a specific country, and the program will create a new text file for that country.
       b. The user can search for a country by its name, and the program will display important details such as the population, capital city, and GDP from the corresponding file using Stream Reader.
                */



        //static void Main()
        //{
        //    Console.WriteLine("1. New country ka data enter karo");
        //    Console.WriteLine("2. Country search karo");
        //    Console.Write("Choice enter karo: ");
        //    int choice = int.Parse(Console.ReadLine());

        //    if (choice == 1)
        //    {
        //        Console.Write("Country Name: ");
        //        string name = Console.ReadLine();

        //        Console.Write("Country Code (ISO): ");
        //        string code = Console.ReadLine();

        //        Console.Write("Population: ");
        //        string population = Console.ReadLine();

        //        Console.Write("Capital City: ");
        //        string capital = Console.ReadLine();

        //        Console.Write("Official Languages: ");
        //        string languages = Console.ReadLine();

        //        Console.Write("GDP: ");
        //        string gdp = Console.ReadLine();

        //        Console.Write("Time Zone: ");
        //        string timezone = Console.ReadLine();

        //        string fileName = name + ".txt";

        //        StreamWriter writer = new StreamWriter(fileName);

        //        writer.WriteLine("Country Name: " + name);
        //        writer.WriteLine("Country Code: " + code);
        //        writer.WriteLine("Population: " + population);
        //        writer.WriteLine("Capital City: " + capital);
        //        writer.WriteLine("Official Languages: " + languages);
        //        writer.WriteLine("GDP: " + gdp);
        //        writer.WriteLine("Time Zone: " + timezone);

        //        writer.Close();

        //        Console.WriteLine("File successfully create ho gayi ✔");
        //    }

        //    else if (choice == 2)
        //    {
        //        Console.Write("Country name enter karo: ");
        //        string searchName = Console.ReadLine();

        //        string fileName = searchName + ".txt";

        //        if (File.Exists(fileName))
        //        {
        //            StreamReader reader = new StreamReader(fileName);

        //            string line;
        //            Console.WriteLine("Country Details:");

        //            while ((line = reader.ReadLine()) != null)
        //            {
        //                if (line.StartsWith("Population") ||
        //                    line.StartsWith("Capital City") ||
        //                    line.StartsWith("GDP"))
        //                {
        //                    Console.WriteLine(line);
        //                }
        //            }

        //            reader.Close();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Country file nahi mili ❌");
        //        }
        //    }

        //    else
        //    {
        //        Console.WriteLine("Invalid choice");
        //    }
        //}












    }
}
