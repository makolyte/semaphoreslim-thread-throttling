using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingExample
{

    public partial class frmGroceryStore : Form
    {
        private Control control;
        private SemaphoreSlim checkoutLanes;
        private int totalShoppers = 0;
        private Random random = new Random();
        public frmGroceryStore()
        {
            InitializeComponent();
            control = txtLog; //this can be any control

            int numberOfLanesOpen = (int)numLanesOpen.Value;

            checkoutLanes = new SemaphoreSlim(numberOfLanesOpen);
        }
        
        private void Log(string msg)
        {
            string m = $"{DateTime.Now.ToString("H:mm:ss.fffff")}\t{msg}\n";
            control.BeginInvoke((MethodInvoker)delegate ()
            {
                txtLog.AppendText(m);
                txtLog.ScrollToCaret();
            });
        }
        
        private void btnSendToCheckout_Click(object sender, EventArgs e)
        {

            SendShoppersToCheckout((int)numShoppers.Value);
        }
        private void SendShoppersToCheckout(int numberOfShoppers)
        {
            for (int i = 1; i <= numberOfShoppers; i++)
            {
                var shopper = new Shopper()
                {
                    Items = random.Next(5, 15),
                    Number = totalShoppers++
                };

                Task.Run(async () =>
                {
                    await Checkout(shopper);
                });
            }
        }
        private async Task Checkout(Shopper s)
        {
            Log($"Shopper {s.Number} is waiting to checkout with {s.Items} item(s)");

            await checkoutLanes.WaitAsync();

            var timeToCheckout = TimeSpan.FromSeconds(1 * s.Items);

            Log($"Shopper {s.Number} is now checking out. This will take {timeToCheckout.TotalSeconds} seconds");

            await Task.Delay(timeToCheckout);

            Log($"Shopper {s.Number} finished checking out");

            checkoutLanes.Release();

        }

        private void btnOpenNewLane_Click(object sender, EventArgs e)
        {
            Log("Opening a new lane!");
            checkoutLanes.Release(1);
            numLanesOpen.Value++;
        }
    }
}
