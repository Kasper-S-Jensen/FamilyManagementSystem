using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment02_WebAPI.Models;
using Assignment02_WebAPI.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Assignment02_WebAPI.Repository.Impl
{
    public class FamilyRepositoryImpl : IFamilyRepository
    {
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            using (FamilyDBContext context = new FamilyDBContext())
            {
                IList<Adult> adults = await context.Adults
                    .Include(adult => adult.Job)
                   .ToListAsync();
                return adults;
            }
        }

        public async Task<IEnumerable<Family>> GetFamiliesAsync()
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

        public async Task AddAdultAsync(Family family)
        {
            Adult toAdd = new Adult();
            foreach (var adult in family.Adults)
            {
                toAdd = adult;
            }

            Console.WriteLine(toAdd.Job.Salary + " now title "+toAdd.Job.JobTitle);
            using (FamilyDBContext context = new FamilyDBContext())
            {
                Family chosenFamily = await GetFamilyAsync(family.StreetName, family.HouseNumber);
                if (chosenFamily.Adults.Count == 2)
                {
                    throw new Exception("Family already has max number of adults");
                }

                Family existingFamily = await context.Families.FirstOrDefaultAsync(family1 =>
                    family1.HouseNumber == family.HouseNumber && family1.StreetName.Equals(family.StreetName));
                existingFamily.Adults.Add(toAdd);
                
                await context.Adults.AddAsync(toAdd);
                await context.SaveChangesAsync();
            }
            
        }

        public async Task RemoveAdultAsync(int ID)
        {
            Adult toRemove = null;
            using (FamilyDBContext context = new FamilyDBContext())
            {
                foreach (var family in context.Families)
                {
                    toRemove = context.Adults.FirstOrDefault(a => a.Id == ID);

                    if (toRemove != null)
                    {
                        family.Adults.Remove(toRemove);
                        break;
                    }
                }

                 context.Adults.Remove(toRemove);
                 await context.SaveChangesAsync();
            }
        }

        public async Task RemoveFamilyAsync(string streetName, int houseNumber)
        {
            using (FamilyDBContext context = new FamilyDBContext())
            {
                Family familyToRemove = await context.Families.FirstOrDefaultAsync(f =>
                    f.StreetName.Equals(streetName) && f.HouseNumber == houseNumber);
                if (familyToRemove != null)
                {
                    context.Families.Remove(familyToRemove);
                    await context.SaveChangesAsync();
                }
            }
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

        public async Task<Family> GetFamilyAsync(string streetName, int houseNumber)
        {
            using (FamilyDBContext context = new FamilyDBContext())
            {
                return await context.Families.Include(f => f.Adults).ThenInclude(a => a.Job).Include(f => f.Children)
                    .ThenInclude(c => c.Pets).Include(f => f.Children).ThenInclude(c => c.Interests)
                    .Include(f => f.Pets)
                    .FirstOrDefaultAsync(f =>
                        f.StreetName.Equals(streetName) && f.HouseNumber == houseNumber);
            }
        }
    }
}