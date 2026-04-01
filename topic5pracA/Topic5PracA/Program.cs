
static void main()
    {
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

    }

main();