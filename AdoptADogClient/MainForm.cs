using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedLibrary;
using System.ServiceModel;


namespace AdoptADogClient
{
    public partial class frmMain : Form
    {
        // Keeps track of all your dogs created
        public static List<Dog> myDogs = new List<Dog>();

        public frmMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// method InitializeGUI()
        /// Description: This sets up the GUI for the first time when
        /// the form loads. 
        /// </summary>
        private void InitializeGUI()
        {
            // Clear Input Controls
            txtName.Text = string.Empty;
            numAge.Value = 1;
            cmbBreed.Text = string.Empty;
            cmbGender.Text = string.Empty;

            // Clear Output Controls
            lstDogs.Items.Clear();

        } // end of InitializeGUI()

        /// <summary>
        /// Adopt a Dog!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdoptADog_Click(object sender, EventArgs e)
        {
            // Validate the Input
            if(!ValidateInput())
            {
                MessageBox.Show("Please Enter Dog Details", "Error");
                return;
            }

            // Assemble the Dog Attributes from the Form
            string name = txtName.Text;
            int age = (int)numAge.Value;
            DogBreed breed = (DogBreed)Enum.Parse(typeof(DogBreed),cmbBreed.Text);
            GenderType gender = (GenderType)Enum.Parse(typeof(GenderType), cmbGender.Text);

            // Make a ChannelFactory Proxy to the Service
            using (ChannelFactory<IAdoptADogService> cf = new ChannelFactory<IAdoptADogService>("BasicHttpBinding_IAdoptADogService"))
            {
                cf.Open();
                IAdoptADogService proxy = cf.CreateChannel();

                if (proxy != null)
                {
                    // Call the Service
                    Dog dog = proxy.AdoptADog(name, breed, gender, age);

                    // Add to the Master Cat List
                    myDogs.Add(dog);
                }
                else
                {
                    Debug.WriteLine("Proxy is Null");
                }

            }
            
            // Update the GUI
            UpdateGUI();

        } // end of method

        /// <summary>
        /// Validate the User Form Inputs
        /// </summary>
        /// <returns>True if Valid, False Otherwise</returns>
        public bool ValidateInput()
        {
            if(String.IsNullOrEmpty(txtName.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(cmbBreed.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(cmbGender.Text))
            {
                return false;
            }

            return true;

        } // end of method

        /// <summary>
        /// Update the GUI with the List of Dogs
        /// </summary>
        private void UpdateGUI()
        {
            lstDogs.Items.Clear();
            
            if (myDogs.Count != 0)
            {
                foreach (Dog dog in myDogs)
                {
                    string str = String.Format("{0}",dog.Name);
                    lstDogs.Items.Add(str);
                }
            } 

        } // end of UpdateGUI()

        /// <summary>
        /// Select List Box Item Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstDogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstDogs.SelectedIndex;

            // Object has not been initialized
            if ((selectedIndex < 0) || (myDogs.Count == 0))
                return;

            Dog dog = myDogs[selectedIndex];

            // if not null
            if (dog != null)
            {
                txtName.Text = dog.Name;
                numAge.Value = dog.Age;
                cmbBreed.Text = dog.Breed.ToString();
                cmbGender.Text = dog.Gender.ToString();
                picDog.Image = dog.Photo;
            }
        } // end of method

    } // end of class
} // end of namespace
