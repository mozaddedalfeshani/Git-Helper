using System;
using System.Management;
using System.Windows.Forms;

namespace Git_Helper
{
    public partial class home : Form
    {
        private Timer updateTimer;

        public home()
        {
            InitializeComponent();

            // Set desktopUserName to display the current user's username
            desktopUserName.Text =  Environment.UserName;

            // Initialize and start the timer to update RAM info every 15 seconds
            updateTimer = new Timer();
            updateTimer.Interval = 15000; // 15 seconds
            updateTimer.Tick += UpdateRamInfo;
            updateTimer.Start();

            // Update RAM info immediately on load
            UpdateRamInfo(null, null);
        }

        private string GetTotalRAM()
        {
            var searcher = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory");
            ulong totalCapacity = 0;
            foreach (var item in searcher.Get())
            {
                totalCapacity += (ulong)item["Capacity"];
            }
            int gb = (int)(totalCapacity / (1024 * 1024 * 1024)); // Convert bytes to GB
            return gb.ToString();
            //return (totalCapacity / (1024 * 1024)).ToString(); // Convert bytes to MB
        }

        private string GetUsedRAM()
        {
            var searcher = new ManagementObjectSearcher("SELECT FreePhysicalMemory FROM Win32_OperatingSystem");
            ulong freeMemory = 0;
            foreach (var item in searcher.Get())
            {
                freeMemory += (ulong)item["FreePhysicalMemory"];
            }

            // Get total physical memory
            var totalMemorySearcher = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory");
            ulong totalCapacity = 0;
            foreach (var item in totalMemorySearcher.Get())
            {
                totalCapacity += (ulong)item["Capacity"];
            }

            // Calculate used RAM
            ulong usedMemory = totalCapacity - (freeMemory * 1024); // Convert KB to bytes
            ulong usedMemoryMB = usedMemory / (1024 * 1024); // Convert bytes to MB
            return (usedMemoryMB/1024).ToString(); // Convert bytes to MB
        }

        private void UpdateRamInfo(object sender, EventArgs e)
        {
            // Update the ramInfo label with the used RAM
            string usedRam = GetUsedRAM();
            ramInfo.Text = $"{usedRam} GB / {GetTotalRAM()} GB";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Placeholder for button functionality
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            // Placeholder for label click functionality
        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {
            // Placeholder for label click functionality
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Placeholder for button functionality
        }

        private void scanClean_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Kill the explorer.exe process
                foreach (var process in System.Diagnostics.Process.GetProcessesByName("explorer"))
                {
                    process.Kill();
                    process.WaitForExit(); // Ensure the process is terminated
                }

                // Step 2: Restart explorer.exe and isn't start explorer window

                //System.Diagnostics.Process.Start("explorer.exe");

                // Inform the user
                MessageBox.Show("Windows Explorer has been restarted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors gracefully
                MessageBox.Show($"An error occurred while restarting Windows Explorer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void home_Load(object sender, EventArgs e)
        {
            // Placeholder for form load functionality
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Stop the timer when the form is closed
            if (updateTimer != null)
            {
                updateTimer.Stop();
                updateTimer.Dispose();
            }
        }

        private void ramInfo_Click(object sender, EventArgs e)
        {

        }

        private void discord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/EZTx8AvjR9");
        }

        private void scanClean_Click_1(object sender, EventArgs e)
        {
            gitAuto gitAuto = new gitAuto();
            gitAuto.Show();

        }
    }
}
