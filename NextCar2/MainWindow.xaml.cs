using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NextCar2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Car nextCar;

        public MainWindow()
        {
            InitializeComponent();
            AccuBatteryController accubatteryController = new AccuBatteryController();
            PintuController Pintunya = new PintuController();

            nextCar = new Car();
            engineState.Visibility = Visibility.Hidden;
            var bc = new BrushConverter();
            nextCar.setAccubaterryController(accubatteryController);
            nextCar.SetPintuController(Pintunya);
        }

        private void button_start_Click(object sender, RoutedEventArgs e)
        {
            Boolean powerIsOn = nextCar.powerIsReady();
            Boolean powerIsOff = nextCar.powerIsNotReady();
            Boolean PintuTerkunci = nextCar.PintuIsLocked();
            Boolean PintuTerbuka = nextCar.PintuIsUnLocked();

            if (powerIsOn && PintuTerkunci && this.button_start.Content == "START Engine!")
            {
                this.button_start.Content = "STOP Engine!";
                engineState.Visibility = Visibility.Visible;
                engineState.Content = "Accu and Door are still On!";

                this.nextCar.turnOnPower();
                this.accuState.Content = "Have Power";
                this.button_accu.Content = "ON";

                this.nextCar.lockPintu();
                this.doorState.Content = "Pintu Terkunci";
                this.button_door.Content = "ON";
            }
            else if(powerIsOn && PintuTerkunci && this.button_start.Content == "STOP Engine!")
            {
                this.button_start.Content = "START Engine!";
                engineState.Visibility = Visibility.Visible;
                engineState.Content = "Accu and Door are still On!";

                this.nextCar.turnOfPower();
                this.accuState.Content = "No Power";
                this.button_accu.Content = "OFF";

                this.nextCar.unlockPintu();
                this.doorState.Content = "Pintu Terbuka";
                this.button_door.Content = "OFF";
            }
            else
            {
                this.button_start.Content = "START Engine!";
                engineState.Visibility = Visibility.Visible;
                engineState.Content = "Accu and Door Are Not Ready!";
            }
            
            Console.WriteLine("button start");
        }

        private void button_accu_Click(object sender, RoutedEventArgs e)
        {
            Boolean powerIsOn = nextCar.powerIsReady();
            Boolean powerIsOff = nextCar.powerIsNotReady();
            if (powerIsOn)
            {
                this.nextCar.turnOfPower();
                this.accuState.Content = "No Power";
                this.button_accu.Content = "OFF";
            }
            else
            {
                this.nextCar.turnOnPower();
                this.accuState.Content = "Have Power";
                this.button_accu.Content = "ON";
            }
            if (powerIsOff && button_start.Content == "STOP Engine!")
            {
                this.nextCar.unlockPintu();
                this.doorState.Content = "Pintu Terbuka";
                this.button_door.Content = "OFF";

                this.nextCar.turnOfPower();
                this.accuState.Content = "No Power";
                this.button_accu.Content = "OFF";
                this.button_start.Content = "START Engine!";

            }

            Console.WriteLine("button aki");
        }

        private void button_door_Click(object sender, RoutedEventArgs e)
        {
            Boolean PintuTerkunci = nextCar.PintuIsLocked();
            Boolean PintuTerbuka = nextCar.PintuIsLocked();
            if (PintuTerkunci)
            {
                this.nextCar.unlockPintu();
                this.doorState.Content = "Pintu Terbuka";
                this.button_door.Content = "OFF";
            }
            else
            {
                this.nextCar.lockPintu();
                this.doorState.Content = "Pintu Terkunci";
                this.button_door.Content = "ON";
            }
            if(PintuTerbuka && button_start.Content == "STOP Engine!")
            {
                this.nextCar.unlockPintu();
                this.doorState.Content = "Pintu Terbuka";
                this.button_door.Content = "OFF";
                this.nextCar.turnOfPower();
                this.accuState.Content = "No Power";
                this.button_accu.Content = "OFF";
                this.button_start.Content = "START Engine!";

            }

            Console.WriteLine("button pintu");
        }
    }
}
