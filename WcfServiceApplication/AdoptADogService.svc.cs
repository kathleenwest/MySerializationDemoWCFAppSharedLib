using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SharedLibrary;

namespace WcfServiceApplication
{
    /// <summary>
    /// AdoptADogService
    /// Implements the IAdoptADogService interface and service
    /// </summary>
    public class AdoptADogService : IAdoptADogService
    {
        /// <summary>
        /// Adopt One Dog - Implementation of Service
        /// Factory Implementation where the service creates a
        /// dog object from the specified parameters and returns
        /// a dog
        /// </summary>
        /// <param name="name">Name (string) of your dog</param>
        /// <param name="breed">Breed (CatBreed) of your dog</param>
        /// <param name="gender">Gender (GenderType) of your dog</param>
        /// <param name="age">Age (int) of your dog</param>
        /// <returns>A Dog object</returns>
        public Dog AdoptADog(string name, DogBreed breed, GenderType gender, int age)
        {
            Dog dog = new Dog(name, breed, gender, age);
            return dog;
        } // end of method

    } // end of class
} // end of namespace
