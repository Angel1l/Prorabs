using System;
using System.Windows;
using Сафари.Commands;
using Сафари.Data.DataWorker.ForUsers;
using Сафари.Data.Models.MaterialsModels;
using Сафари.ViewModels.MainModels;
using Сафари.Views;
using Сафари.Views.ViewForUsers;

namespace Сафари.ViewModels.ForUsers
{
    public class UsersVM : SideProperties
    {
        public static string UsersLogin { get; set; }
        public string UsersPassword { get; set; }
        public string login { get; set; } = "";
        public string password { get; set; } = "";
        public string password2 { get; set; } = "";
        public string email { get; set; } = "";
        public static Materials SelectedMaterial { get; set; }       
        public string Login { get; set; }
        public string Password { get; set; }


        private RelayCommand enterToProgramm;
        public RelayCommand EnterToProgramm
        {

            get
            {

                return enterToProgramm ?? (new RelayCommand(obj =>
                {                   
                        if (UsersLogin.Length == 0 || UsersPassword.Length == 0)
                        {

                            var User = DataUsers.findUser(UsersLogin, UsersPassword);

                            if (User != null)
                            {

                                var usermainWindow = new UserMainWindow();
                                usermainWindow.Show();
                                var window = Application.Current.Windows[0];
                                if (window != null)
                                    window.Close();


                            }
                            else
                            {
                                MessageBoxResult result = MessageBox.Show("Логін або пароль не вірний");
                            }
                        }
                        else
                        {
                            var User = DataUsers.findUser(UsersLogin, UsersPassword);

                            if (User != null)
                            {

                                var usermainWindow = new UserMainWindow();
                                usermainWindow.Show();
                                var window = Application.Current.Windows[0];
                                if (window != null)
                                    window.Close();


                            }
                            else
                            {
                                MessageBoxResult result = MessageBox.Show("Логін або пароль не вірний, створіть аккаунт!");
                            }
                        }                                      
                }));           
            }
        }
       

        private RelayCommand addUsersToDatabase;
        public RelayCommand AddUsersToDatabase
        {

            get
            {
                return addUsersToDatabase ?? (new RelayCommand(obj =>
                {

                    if (login.Length > 0 && password == password2 &&
                    email.Contains("@") && email.Contains(".") && email.Length > 0)
                    {
                        DataUsers.addUser(login, password, email);
                        var mainuserWindow = new MainUserWindow();
                        mainuserWindow.Show();
                        var window = Application.Current.Windows[0];
                        if (window != null)
                            window.Close();
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Something incorrect");
                    }

                }));
            }

        }
    }
}
