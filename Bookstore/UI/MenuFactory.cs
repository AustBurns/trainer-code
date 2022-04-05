// using DL;

// namespace UI;
// public static class MenuFactory
// {
//     public static IMenu gotoMenu(string menuString)
//     {
//         menuString = menuString.ToLower();
//         string connectionString = File.ReadAllText("connectionString.txt");
//         IRepository repo = new DBRepository(connectionString); 
//         switch (menuString)
//         {
//             case "main":
//                 return new MainMenu();
            
//             case "SearchBooks":
//                 return new SearchBooks(_bl);

//             case "UserHistory":
//                 return new UserHistory(_bl);

//             case "CreateNewAccount":
//                 return new CreateNewAccount(_bl);
            
//             default:
//                 return new MainMenu();
//         }
//     }
// }