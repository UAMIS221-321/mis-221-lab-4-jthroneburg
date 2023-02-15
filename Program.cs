//start main

int userChoice = GetUserChoice();
while (userChoice != 3) {
    RouteEm(userChoice);
    userChoice = GetUserChoice();
}

//end main

static int GetUserChoice() {
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(userChoice == "1" || userChoice == "2" || userChoice == "3") {
        return int.Parse(userChoice);
    }
    return 0;
}

static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static void RouteEm(int menuChoice) {
    if(menuChoice == 1) {
        PrintFull();
    }
    else if(menuChoice == 2) {
        PrintPartial();
    }
    else if (menuChoice !=3) {
        PrintInvalid();
    } 
}

static void PrintFull() {
    Random rnd = new Random();
    int number = rnd.Next(3,9);
    for (int i = 0; i < number; i++) {
        for (int j = 0; j <= i; j++) {
            System.Console.Write("0");
        }
        System.Console.Write("\n");
    }
     PauseAction();
}

static void PrintPartial() {
    Random rnd = new Random();
    int number = rnd.Next(3,9);
    for (int i = 0; i < number; i++) {
        for (int j = 0; j <= i; j++) {
            int choice = rnd.Next(2);
            if (choice == 0) {
            System.Console.Write("0");
            }
        }
        System.Console.Write("\n");
    }
     PauseAction();
}

static void PrintInvalid() {
    System.Console.WriteLine("Invalid!");
    PauseAction();
}

static void PauseAction() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}