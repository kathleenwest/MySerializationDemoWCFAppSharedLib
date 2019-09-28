using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace SharedLibrary
{
    /// <summary>
    /// IAdoptADogService
    /// Service Interface for the Adopt A Dog Service
    /// </summary>
    [ServiceContract]
    public interface IAdoptADogService
    {
        /// <summary>
        /// Adopt One Dog
        /// Factory Implementation where the service creates a
        /// dog object from the specified parameters and returns
        /// a dog
        /// </summary>
        /// <param name="name">Name (string) of your dog</param>
        /// <param name="breed">Breed (CatBreed) of your dog</param>
        /// <param name="gender">Gender (GenderType) of your dog</param>
        /// <param name="age">Age (int) of your dog</param>
        /// <returns>A Dog object</returns>
        [OperationContract]
        Dog AdoptADog(string name, DogBreed breed, GenderType gender, int age);

    } // end of interface
} // end of namespace
