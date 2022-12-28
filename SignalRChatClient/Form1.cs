using Microsoft.AspNetCore.SignalR.Client;

namespace SignalRChatClient
{
    public partial class Form1 : Form
    {
        HubConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new HubConnectionBuilder()
               .WithUrl("https://localhost:7142/ChatHub")
               .WithAutomaticReconnect()
               .Build();
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            connection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                this.Invoke((Delegate)(() =>
                {
                    var newMessage = $"{user}: {message}";
                    messagesList.Items.Add(newMessage);
                }));
            });

            try
            {
                await connection.StartAsync();
                messagesList.Items.Add("Connection started");
                connectButton.Enabled = false;
                sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                messagesList.Items.Add(ex.Message);
            }
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                await connection.InvokeAsync("SendMessage",
                    userTextBox.Text, messageTextBox.Text);
            }
            catch (Exception ex)
            {
                messagesList.Items.Add(ex.Message);
            }
        }
    }
}