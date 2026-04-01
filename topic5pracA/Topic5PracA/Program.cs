
static void main()
    {
        /*
        // array section
        Console.WriteLine("og list:");
        string[] StringName = ["liam", "charlie", "devlyn", "james", "leon", "arthur", "chris", "david", "john", "rizzler"];
        foreach (string i in StringName)
        {
            Console.WriteLine(i);
        }
        int SmallSize = 0;
        string smallName = "";
        int bigSize = 0;
        string bigName = "";
        bool first = true;
        foreach (string i in StringName)
        {
            if (first == true)
            {
                SmallSize = i.Length;
                smallName = i;
                first = false;
            }
            else if (i.Length > bigSize)
            {
                bigSize = i.Length;
                bigName = i;
            }
            else if (i.Length < SmallSize)
            {
                SmallSize = i.Length;
                smallName = i;
            }
        }
        Console.WriteLine("small and big:");
        Console.WriteLine("small");
        Console.WriteLine(smallName);
        Console.WriteLine("big");
        Console.WriteLine(bigName);

        Console.WriteLine("sorted list:");
        Array.Sort(StringName);
        foreach (string i in StringName)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("reversed list:");
        Array.Reverse(StringName);
        foreach (string i in StringName)
        {
            Console.WriteLine(i);
        }
        */
        
        //list section
        string[] StringName = ["liam", "charlie", "devlyn", "james", "leon", "arthur", "chris", "david", "john", "rizzler"];    

        var ListNames = new List<string> {"liam", "charlie", "devlyn", "james", "leon", "arthur", "chris", "david", "john", "rizzler"};
        ListNames.Add("sneh");
        ListNames.Remove("chris");
        ListNames.Insert(1, "gooner");
        string[] extranames = {"donald", "dom", "lewis"};
        ListNames.AddRange(extranames);
        string inputName = Console.ReadLine();
        int tally = 0;
        foreach (string i in ListNames)
    {
        if (i == inputName)
        {
            Console.WriteLine($"index number {tally} for {ListNames[tally]}");
        }
        tally += 1;
    }
    string inputPartName = Console.ReadLine();
    foreach (string i in ListNames)
    {
        if (i.Contains(inputPartName) == true)
        {
            Console.WriteLine(i);
        }
    }
    int total = 0;
    foreach (string i in ListNames)
    {
        total += i.Length;
    }
    Console.WriteLine(total);

    List<string> stringList = new List<string>(StringName);
    ListNames.AddRange(stringList);
    
    }

main();