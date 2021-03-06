﻿using DogGo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        List<Dog> GetAllDogs();
        List<Dog> GetDogsByOwnerId(int id);
        void AddDog(Dog dog);
        void DeleteDog(int dogId);
        void UpdateDog(Dog dog);
        Dog GetDogById(int id);
        List<Dog> GetDogsByEmployedWalkerId(int walkerId);
    }
}