public class UserController
{
    private IUserViewModel _viewModel;
    private ConsoleView _view;

    public UserController(UserViewModel viewModel, ConsoleView view)
    {
        _viewModel = viewModel;
        _view = view;
    }

    public void Run()
    {
        bool running = true;
        while (running)
        {
            _view.ShowMessage("\n1. Add User\n2. Display Users\n3. Clear Users\n4. Exit");
            string choice = _view.GetUserInput("Choose an option: ");

            switch (choice)
            {
                case "1":
                    AddUser();
                    break;
                case "2":
                    DisplayUsers();
                    break;
                case "3":
                    ClearUsers();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    _view.ShowMessage("Invalid option, try again.");
                    break;
            }
        }
    }

    private void AddUser()
    {
        string name = _view.GetUserInput("Enter user name: ");
        string ageInput = _view.GetUserInput("Enter user age: ");
        
        if (int.TryParse(ageInput, out int age))
        {
            _viewModel.AddUser(name, age);
            _view.ShowMessage("User added successfully.");
        }
        else
        {
            _view.ShowMessage("Invalid age. Please try again.");
        }
    }

    private void DisplayUsers()
    {
        var users = _viewModel.GetUsers();
        _view.DisplayUsers(users);
    }

    private void ClearUsers()
    {
        _viewModel.ClearUsers();
        _view.ShowMessage("All users cleared.");
    }
}