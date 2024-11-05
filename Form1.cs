using System;
using System.IO;
using System.Windows.Forms;

namespace BadgeAward
{
    public partial class Form1 : Form
    {
        private int userPoints = 0;
        private string pointsFilePath = "points.txt"; // Path to a local file to store the points

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            // Load the points from the file
            userPoints = ReadPointsFromFile();
            lblPoints.Text = $"{userPoints}";
        }

        private void GivePoints_Click(object sender, EventArgs e)
        {
            userPoints += 5;
            lblPoints.Text = $"{userPoints}";
            UpdatePointsToFile();
            UpdateBadgeImage();
        }

        private void DeductPoints_Click(object sender, EventArgs e)
        {
            if (userPoints >= 5)
            {
                userPoints -= 5;
                lblPoints.Text = $"{userPoints}";
                UpdatePointsToFile();
                UpdateBadgeImage();
            }
            else
            {
                MessageBox.Show("Not enough points to deduct", "Insufficient Points", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateBadgeImage()
        {
            if (userPoints >= 100 && userPoints <= 199)
            {
                BadgeAwardBox1.Image = Properties.Resources.Bronze;
            }
            else if (userPoints >= 200 && userPoints <= 299)
            {
                BadgeAwardBox1.Image = Properties.Resources.Silver;
            }
            else
            {
                BadgeAwardBox1.Image = null;
            }
        }

        private void UpdatePointsToFile()
        {
            try
            {
                File.WriteAllText(pointsFilePath, userPoints.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save points: {ex.Message}");
            }
        }

        private int ReadPointsFromFile()
        {
            try
            {
                if (File.Exists(pointsFilePath))
                {
                    string content = File.ReadAllText(pointsFilePath);
                    if (int.TryParse(content, out int points))
                    {
                        return points;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to read points: {ex.Message}");
            }
            return 0; // Default to 0 if no points file exists or parsing fails
        }
    }
}