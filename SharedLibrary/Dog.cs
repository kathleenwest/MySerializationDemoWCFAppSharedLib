using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    [Serializable]
    [KnownType(typeof(DogBreed))]
    [KnownType(typeof(GenderType))]
    [KnownType(typeof(Bitmap))]
    public class Dog : ISerializable 
    {
        #region PropertiesFields

        /// <summary>
        /// Name of Dog
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Breed of Dog
        /// </summary>
        public DogBreed Breed { get; set; }

        /// <summary>
        /// Gender of Dog
        /// </summary>
        public GenderType Gender { get; set; }

        /// <summary>
        /// Age of Dog
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Photo of the Dog
        /// </summary>
        public Bitmap Photo { get; set; }

        #endregion PropertiesFields

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Dog() : this("Spot", DogBreed.Beagle, GenderType.Female, 1)
        {

        } // end of method

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        public Dog(string name, DogBreed breed, GenderType gender, int age)
        {
            Name = name;
            Breed = breed;
            Gender = gender;
            Age = age;

            // Photo
            Assembly asm = Assembly.GetExecutingAssembly();
            string path1 = "SharedLibrary.photos.";
            string path2 = Breed.ToString();
            string filepath = path1 + path2 + ".jpg";
            Photo = new Bitmap(asm.GetManifestResourceStream(filepath));

        } // end of constructor

        #region SerializationMethods

        /// <summary>
        /// Constructor for Deserialization
        /// </summary>
        /// <param name="info">The Serialized object to be deserialized</param>
        /// <param name="context">context for the steam</param>
        public Dog(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Breed = (DogBreed) info.GetValue("Breed", typeof(Enum));
            Gender = (GenderType) info.GetValue("Gender", typeof(Enum));
            Age = info.GetInt32("Age");
            Photo = (Bitmap) info.GetValue("Photo", typeof(Bitmap));
        } // end of method

        /// <summary>
        /// GetObjectData
        /// Serializes the data into a Data Dictionary SerializationObject
        /// </summary>
        /// <param name="info">The object to be serialized</param>
        /// <param name="context">context for the steam</param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name, typeof(string));
            info.AddValue("Breed", Breed, typeof(Enum));
            info.AddValue("Gender", Gender, typeof(Enum));
            info.AddValue("Age", Age, typeof(Int32));
            info.AddValue("Photo", Photo, typeof(Bitmap));
        } // end of method

        #endregion SerializationMethods

        #region Serialization Callbacks
        [OnDeserialized]
        private void OnDeserialized(StreamingContext ctx)
        {
            // Template to Do Stuff         
            
        }

        [OnDeserializing]
        private void OnDeserializing(StreamingContext ctx)
        {
            // Template to Do Stuff  
        }

        [OnSerialized]
        private void OnSerialized(StreamingContext ctx)
        {
            // Template to Do Stuff  
        }

        [OnSerializing]
        private void OnSerializing(StreamingContext ctx)
        {
            // Template to Do Stuff  
        }

        #endregion Serialization Callbacks

    } // end of class

    #region enums

    /// <summary>
    /// List of Dog Breeds
    /// </summary>
    public enum DogBreed
    {
        Labrador_Retriever = 0,
        Pug = 1,
        Siberian_Husky = 2,
        Bulldog = 3,
        Beagle = 4
    } // end of enum

    /// <summary>
    /// List of Gender Types
    /// </summary
    public enum GenderType
    {
        Male = 0,
        Female = 1
    } // end of enum

    #endregion enums

} // end of namespace
