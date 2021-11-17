using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment02_WebAPI.Models;
using Assignment02_WebAPI.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Assignment02_WebAPI.Repository.Impl
{
    public class FamilyRepositoryImpl : IFamilyRepository
    {
        public Task<IList<Adult>> GetAdultsAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<Family>> GetFamiliesAsync()
        {
            using (FamilyDBContext context = new FamilyDBContext())
            {
                IList<Family> families = await context.Families.Include(family => family.Adults)
                    .ThenInclude(adult => adult.Job).Include(family => family.Children)
                    .ThenInclude(child => child.Interests).Include(family => family.Children)
                    .ThenInclude(child => child.Pets).Include(family => family.Pets).ToListAsync();
                return families;
            }
        }

        public Task<IList<Child>> GetChildrenAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task AddFamilyAsync(Family family)
        {
            using (FamilyDBContext context = new FamilyDBContext())
            {
                foreach (var existingFamily in context.Families)
                {
                    if (existingFamily.StreetName.Equals(family.StreetName) &&
                        existingFamily.HouseNumber == family.HouseNumber)
                    {
                        throw new Exception("Family already exists");
                    }
                }

                await context.Families.AddAsync(family);
                await context.SaveChangesAsync();
            }
        }

        public Task AddAdultAsync(Family family)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveAdultAsync(int ID)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveFamilyAsync(string streetName, int houseNumber)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Family family)
        {
            throw new System.NotImplementedException();
        }

        public Task<Adult> GetAdultAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Family> GetFamilyAsync(string streetName, int houseNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}