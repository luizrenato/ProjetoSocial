﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjetoSocial.Models;

namespace ProjetoSocial.Repository.Animal
{
    public class AnimalRepository : IAnimal
    {
        private ProjetoSocialEntities DBcontext;
        public AnimalRepository(ProjetoSocialEntities objempcontext)
        {
            DBcontext = objempcontext;
        }

        public void InsertAnimal(Models.Animal Animal)
        {
            DBcontext.Animal.Add(Animal);
            Save();
        }

        public IEnumerable<Models.Animal> GetAnimals()
        {
            return DBcontext.Animal.ToList();
        }

        public Models.Animal GetAnimalByID(int AnimalId)
        {
            return DBcontext.Animal.Find(AnimalId);
        }

        public void UpdateAnimal(Models.Animal Animal)
        {
            DBcontext.Entry(Animal).State = EntityState.Modified;
            Save();
        }

        public void DeleteAnimal(int AnimalId)
        {
            Models.Animal ani = DBcontext.Animal.Find(AnimalId);
            if (ani != null)
            {
                DBcontext.Animal.Remove(ani);
                Save();
            }
        }

        public void Save()
        {
            DBcontext.SaveChanges();
        }
    }
}