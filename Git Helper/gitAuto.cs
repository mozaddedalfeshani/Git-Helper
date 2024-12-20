using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using KeyAuth;


namespace Git_Helper
{
    public partial class gitAuto : Form
    {
        public gitAuto()
        {
            InitializeComponent();
            // Initially, you can leave this empty or display a message.
            
            branchName.Text = "Select a folder to check if it's a Git repository.";
        }
        string pathPublic = "";
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            // Hide the form when the control box is clicked (close button)
            this.Hide();
        }

        private void gitAuto_Load(object sender, EventArgs e)
        {
            // Placeholder for any functionality when the form loads
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            // Placeholder for any functionality when this label is clicked
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            // Placeholder for any functionality when this label is clicked
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Open folder browser and select folder path
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected folder path
                string selectedPath = folderBrowserDialog.SelectedPath;
                pathValue.Text = selectedPath;
                pathPublic = selectedPath;

                // Check if the selected folder is a Git repository
                if (Directory.Exists(selectedPath + "\\.git"))
                {
                    try
                    {
                        // Read the HEAD file to get the current branch name
                        string[] lines = File.ReadAllLines(selectedPath + "\\.git\\HEAD");

                        // Extract the branch name from the ref in the HEAD file
                        string branch = lines[0].Replace("ref: refs/heads/", "");

                        // Set the branch name in the label
                        branchName.Text = "Branch: " + branch;
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions (e.g., file not found, etc.)
                        MessageBox.Show("Error reading Git HEAD file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // If the folder is not a Git repo
                    branchName.Text = "Not a Git repository";
                }
            }
        }

        private void gitUpdate_Click(object sender, EventArgs e)
        {
            string path = pathPublic.ToString();
            MessageBox.Show(path);

            string commitMessage = commitInput.Text;

            if (string.IsNullOrEmpty(commitMessage))
            {
                MessageBox.Show("Please provide a commit message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Directory.Exists(path + "\\.git"))
            {
                try
                {
                    // Run git commands using ProcessStartInfo
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "cmd.exe", // Open cmd.exe
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true, // Capture error output
                        UseShellExecute = false,
                        CreateNoWindow = true, // No window for cmd to show up
                        WorkingDirectory = path // Set the working directory to the Git repo
                    };

                    System.Diagnostics.Process process = new System.Diagnostics.Process { StartInfo = startInfo };
                    process.Start();

                    // Run the git commands (add files and commit)
                    process.StandardInput.WriteLine("git add .");
                    process.StandardInput.WriteLine($"git commit -m \"{commitMessage}\"");

                    // Close the input stream
                    process.StandardInput.Close();

                    // Wait for the process to exit (ensure commands are complete)
                    string output = process.StandardOutput.ReadToEnd();
                    string errorOutput = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    // Display output or error
                    if (!string.IsNullOrEmpty(output))
                    {
                        //MessageBox.Show("Git output: " + output, "Git Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (!string.IsNullOrEmpty(errorOutput))
                    {
                        MessageBox.Show("Error during Git update: " + errorOutput, "Git Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Inform the user that the Git commands were successful
                        MessageBox.Show("Git repository updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., file not found, etc.)
                    MessageBox.Show("Error updating Git repository: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If the folder is not a Git repo
                MessageBox.Show("Selected folder is not a Git repository.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pushtogit_Click(object sender, EventArgs e)
        {
            // get path 
            string path = pathPublic.ToString();
            MessageBox.Show(path);

            // open cmd and cd path and run command git push -f
            if (Directory.Exists(path + "\\.git"))
            {
                try
                {
                    // Run git commands using ProcessStartInfo
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "cmd.exe", // Open cmd.exe
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true, // Capture error output
                        UseShellExecute = false,
                        CreateNoWindow = true, // No window for cmd to show up
                        WorkingDirectory = path // Set the working directory to the Git repo
                    };
                    System.Diagnostics.Process process = new System.Diagnostics.Process { StartInfo = startInfo };
                    process.Start();
                    // Run the git commands (add files and commit)
                    process.StandardInput.WriteLine("git push -f");
                    // Close the input stream
                    process.StandardInput.Close();
                    // Wait for the process to exit (ensure commands are complete)
                    string output = process.StandardOutput.ReadToEnd();
                    string errorOutput = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    // Display output or error
                    if (!string.IsNullOrEmpty(output))
                    {
                        //MessageBox.Show("Git output: " + output, "Git Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //if (!string.IsNullOrEmpty(errorOutput))
                    //{
                    //    MessageBox.Show("Error during Git update: " + errorOutput, "Git Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    else
                    {
                        // Inform the user that the Git commands were successful
                        MessageBox.Show("Git repository updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions (e.g., file not found, etc.)
                    MessageBox.Show("Error updating Git repository: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If the folder is not a Git repo
                MessageBox.Show("Selected folder is not a Git repository.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void guna2HtmlLabel2_Click_1(object sender, EventArgs e)
        {

        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            

            try
            {
                // Check if the folder exists
                if (!Directory.Exists(pathPublic))
                {
                    MessageBox.Show("The specified path does not exist.");
                    return;
                }

                // Prepare the process start info
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WorkingDirectory = pathPublic,
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                
                using (Process process = new Process { StartInfo = startInfo })
                {
                    process.Start();

                    using (StreamWriter writer = process.StandardInput)
                    {
                        if (writer.BaseStream.CanWrite)
                        {
                            // Check if a remote URL exists
                            writer.WriteLine("git config --get remote.origin.url");
                        }
                    }

                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    if (!string.IsNullOrWhiteSpace(output))
                    {
                        // Remote URL exists, display it in the remoteUrl input field
                        remoteUrl.Text = "Already Remote URL Exist";
                        MessageBox.Show("Existing remote URL found and displayed.");
                        // run command to cmd to set remote url 
                        process.Start();
                        using (StreamWriter writer = process.StandardInput)
                        {
                            if (writer.BaseStream.CanWrite)
                            {
                                // Check if a remote URL exists
                                writer.WriteLine("git remote set-url origin " + remoteUrl.Text);
                            }
                        }

                        string output1 = process.StandardOutput.ReadToEnd();
                        process.WaitForExit();
                        MessageBox.Show("Remote URL updated successfully.");
                        remoteUrl.Text = $"New URL: {remoteUrl}";


                    }
                    else
                    {
                        // No remote URL exists, prompt user to enter one
                        MessageBox.Show("No existing remote URL found. Please enter a new remote URL.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
