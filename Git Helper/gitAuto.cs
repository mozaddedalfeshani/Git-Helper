using System;
using System.IO;
using System.Windows.Forms;

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
            // when user click this button it will run git add . and git commit -m {value will collect from commitInput  } and git push
            string path = pathValue.Text;
            string commitMessage = commitInput.Text;

            if (Directory.Exists(path + "\\.git"))
            {
                try
                {
                    // Run git commands using ProcessStartInfo
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };
                    System.Diagnostics.Process process = new System.Diagnostics.Process { StartInfo = startInfo };
                    process.Start();
                    // Navigate to the Git repository directory
                    process.StandardInput.WriteLine("cd " + path);
                    process.StandardInput.WriteLine("git add .");
                    process.StandardInput.WriteLine("git commit -m \"" + commitMessage + "\"");
                    process.StandardInput.WriteLine("git push");
                    // Inform the user
                    MessageBox.Show("Git repository updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
