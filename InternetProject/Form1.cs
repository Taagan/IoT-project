using MQTTnet;
using MQTTnet.Client.Options;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.ExtendedAuthenticationExchange;
using MQTTnet.Client.Publishing;
using MQTTnet.Client.Receiving;
using MQTTnet.Client.Subscribing;
using MQTTnet.Client.Unsubscribing;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetProject
{
    public partial class Form1 : Form
    {
        private static IManagedMqttClient client;
        string url = "hairdresser.cloudmqtt.com";
        string user = "ioyixfdx";
        string password = "DbnczQ9NC224";
        int port = 15591;
        string myString = "string";
        string payload;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            Task connect = ConnectAsync(url, user, password, port, false);
            client.UseConnectedHandler(e =>
            {
                Console.WriteLine("Connected successfully with MQTT Brokers.");
                MessageBox.Show("Connected successfully with MQTT Brokers");
            });
            client.UseDisconnectedHandler(e =>
            {
                Console.WriteLine("Disconnected from MQTT Brokers.");
            });

            //should change this to seperate than pub
            Task sub = SubscribeAsync("Grupp4OUT", 1);
            RecieveHandler();
        }

        public static async Task ConnectAsync(string uRL, string user, string password, int port, bool sSLPort)
        {
            string clientId = Guid.NewGuid().ToString();
            string mqttURI = uRL;
            string mqttUser = user;
            string mqttPassword = password;
            int mqttPort = port;
            bool mqttSecure = sSLPort;

          var messageBuilder = new MqttClientOptionsBuilder()
            .WithClientId(clientId)
            .WithCredentials(mqttUser, mqttPassword)
            .WithTcpServer(mqttURI, mqttPort)
            .WithCleanSession();

            var options = mqttSecure
              ? messageBuilder
                .WithTls()
                .Build()
              : messageBuilder
                .Build();

            var managedOptions = new ManagedMqttClientOptionsBuilder()
              .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
              .WithClientOptions(options)
              .Build();

            client = new MqttFactory().CreateManagedMqttClient();

            await client.StartAsync(managedOptions);
        }



        /// <summary>
        /// Publish Message.
        /// </summary>
        /// <param name="topic">Topic.</param>
        /// <param name="payload">Payload.</param>
        /// <param name="retainFlag">Retain flag.</param>
        /// <param name="qos">Quality of Service.</param>
        /// <returns>Task.</returns>
        public static async Task PublishAsync(string topic, string payload, bool retainFlag = true, int qos = 1) =>
        await client.PublishAsync(new MqttApplicationMessageBuilder()
        .WithTopic(topic)
        .WithPayload(payload)
        .WithQualityOfServiceLevel((MQTTnet.Protocol.MqttQualityOfServiceLevel)qos)
        .WithRetainFlag(retainFlag)
        .Build());



        /// <summary>
        /// Subscribe topic.
        /// </summary>
        /// <param name="topic">Topic.</param>
        /// <param name="qos">Quality of Service.</param>
        /// <returns>Task.</returns>
        public static async Task SubscribeAsync(string topic, int qos = 1) =>
        await client.SubscribeAsync(new TopicFilterBuilder()
        .WithTopic(topic)
        .WithQualityOfServiceLevel((MQTTnet.Protocol.MqttQualityOfServiceLevel)qos)
        .Build());


        //should change so that publish and recive are different so that 
        public void RecieveHandler()
        {
            client.UseApplicationMessageReceivedHandler(e =>
            {
                try
                {
                    string topic = e.ApplicationMessage.Topic;
                    //string topic = "Grupp4OUT";
                    if (string.IsNullOrWhiteSpace(topic) == false)
                    {
                        payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                        //Console.WriteLine($"Topic: {topic}. Message Received: {payload}");
                        //MethodInvoker inv = delegate
                        //{
                        //    richtbx.Text = payload;

                        //};
                        //Invoke(inv);
                        //MessageBox.Show($"Topic: {topic}. Message Received: {payload}");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message, ex);
                }
            });
        }

        private void btnRecieveMessage_Click(object sender, EventArgs e)
        {
            MethodInvoker inv = delegate
            {
                richtbx.Text = payload;

            };
            Invoke(inv);
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            //debug purpose
            Task Pub = PublishAsync("Grupp4OUT", tbxPublish.Text, true, 1);
            //RecieveHandler();
        }

        private void brightSlider_Scroll(object sender, EventArgs e)
        {
            string change = "";
            for(int i = 0; i < 10; i++)
            {
                if(brightSlider.Value == i)
                {
                    //lägg ändra brighnes arduino kod här
                    change = i+ "";
                    tbxBrightness.Text = (i * 10) + 10 + "%";
                }
            }
            Task Pub = PublishAsync("Grupp4IN", change, true, 1);
        }

        private void checkboxONOFF_CheckedChanged(object sender, EventArgs e)
        {
            string change = "";
            if(checkboxONOFF.Checked == true)
            {
                //light på och av här
                change = "o";
            }
            else
            {
                change = "f";
            }
            Task Pub = PublishAsync("Grupp4IN", change, true, 1);
        }

        private void tbxBrightness_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboBox1.SelectedItem.ToString();
            string change = "";
            switch (temp)
            {
                case "WHITE":
                    change = "w";
                    break;

                case "RED":
                    change = "r";
                    break;

                case "YELLOW":
                    change = "y";
                    break;

                case "BLUE":
                    change = "b";
                    break;

                case "GREEN":
                    change = "g";
                    break;

                case "ORANGE":
                    change = "a";
                    break;

                case "PURPLE":
                    change = "p";
                    break;

                default:
                    break;

            }
            Task Pub = PublishAsync("Grupp4IN", change, true, 1);
        }

        private void checkboxSensor_CheckedChanged(object sender, EventArgs e)
        {
            string change = "";
            if (checkboxSensor.Checked)
            {
                change = "s";
            }
            else
            {
                change = "x";
            }
            Task Pub = PublishAsync("Grupp4IN", change, true, 1);

            if (rbtnAway.Checked)
            {
                change = "u";
            }
            else if (rbtnWithin.Checked)
            {
                change = "i";
            }
            else
            {
                change = "i";
            }
            Task Pub2 = PublishAsync("Grupp4IN", change, true, 1);
        }

        private void rbtnAway_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string change = "";
            string change2 = "";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                if(checkedListBox1.GetItemText(checkedListBox1.CheckedItems[i]) == "Rave")
                {
                    change = "k";
                }
                else if(change == "")
                {
                    change = "j";
                }
                if (checkedListBox1.GetItemText(checkedListBox1.CheckedItems[i]) == "Rainbow")
                {
                    change2 = "l";
                }
                else if(change2 == "")
                {
                    change2 = "h";
                }
            }
            Task Pub = PublishAsync("Grupp4IN", change, true, 1);
            
            Task Pub2 = PublishAsync("Grupp4IN", change2, true, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = Int32.Parse(timecbx.SelectedItem.ToString()) * 60;
            timer.Tick += new EventHandler(Turnoff);
            timer.Start();
        }
        private void Turnoff(object f, EventArgs e)
        {
            string change = "f";
            Task Pub = PublishAsync("Grupp4IN", change, true, 1);
            timer.Stop();
        }

    }
}
