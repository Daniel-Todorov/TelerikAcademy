//1. Research how to create a MongoDB database in Mongolab(http://mongolab.com )

//2. Create a chat database in MongoLab.
// The database should keep messages
// Each message has a text, date and an embedded field user
// Users have username

//3. Create a Chat client, using the Chat MongoDB database
// When the client starts, it asks for username
// Without password
// Logged-in users can see 
// All posts, since they have logged in
// History of all posts
// Logged-in users can post message
// Create a simple WPF application for the client

namespace _12.MongoDBAndDotNet
{
    using _12.MongoDBAndDotNet.DatabaseModels;
    using System;
    using System.Collections.ObjectModel;
    using System.Timers;
    using System.Windows;
    using System.Windows.Media;

    public partial class MainWindow : Window
    {
        private DatabaseInteractor databaseInteractor = new DatabaseInteractor();
        private Timer timer;
        private ObservableCollection<Message> lastTwentyMessages;

        public string UserName { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            innerUsername.Visibility = Visibility.Collapsed;
            logoutButton.Visibility = Visibility.Collapsed;
            messageBox.Visibility = Visibility.Collapsed;
            innerUsername.Visibility = Visibility.Collapsed;
            messageToSend.Visibility = Visibility.Collapsed;
            sendButton.Visibility = Visibility.Collapsed;

            this.loginButton.Background = Brushes.Green;
            this.logoutButton.Background = Brushes.Red;
            this.sendButton.Background = Brushes.Green;
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            string userName = username.Text;

            if (Validator.IsValidUsername(userName))
            {
                this.UserName = username.Text;

                this.loginButton.Visibility = Visibility.Collapsed;
                this.usernameText.Visibility = Visibility.Collapsed;
                this.username.Visibility = Visibility.Collapsed;
                
                this.innerUsername.Visibility = Visibility.Visible;
                this.logoutButton.Visibility = Visibility.Visible;
                this.messageBox.Visibility = Visibility.Visible;
                this.innerUsername.Visibility = Visibility.Visible;
                this.innerUsername.Text = "Username: " + userName;
                this.messageToSend.Visibility = Visibility.Visible;
                this.sendButton.Visibility = Visibility.Visible;

                this.timer = new Timer(3000);
                this.timer.Elapsed += new ElapsedEventHandler(RefreshMessages);
                this.timer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Username can not be empty or with less than 3 characters.");
            }
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.UserName = null;
            this.timer.Enabled = false;

            this.loginButton.Visibility = Visibility.Visible;
            this.usernameText.Visibility = Visibility.Visible;
            this.username.Visibility = Visibility.Visible;
            
            this.innerUsername.Visibility = Visibility.Collapsed;
            this.logoutButton.Visibility = Visibility.Collapsed;
            this.messageBox.Visibility = Visibility.Collapsed;
            this.innerUsername.Visibility = Visibility.Collapsed;
            this.messageToSend.Visibility = Visibility.Collapsed;
            this.sendButton.Visibility = Visibility.Collapsed;
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            string message = messageToSend.Text;

            if (Validator.IsValidMessage(message))
            {
                this.messageToSend.Text = string.Empty;
                this.databaseInteractor.AddPost(message, this.UserName);
            }
            else
            {
                MessageBox.Show("You can't send empty messages.");
            }
        }

        private void RefreshMessages(object sender, ElapsedEventArgs e)
        {
            this.lastTwentyMessages = this.databaseInteractor.GetPosts();

            App.Current.Dispatcher.Invoke((Action)delegate
            {
                this.messageBox.ItemsSource = this.lastTwentyMessages;
            });
        }
    }
}
