using System;
using System.Collections.Generic;

namespace HW_12
{
    public class MotorcycleRepository : IMotorcycleRepository, IDisposable
    {
        private MotoContext context;

        public MotorcycleRepository(MotoContext context)
        {
            this.context = context;
        }

        public IEnumerable<Motorcycle> GetStudents()
        {
            return context.Motorcycles.ToList();
        }

        public Motorcycle GetMotorcycleByID(int id)
        {
            return context.Motorcycles.Find(id);
        }

        public void InsertMotorcycle(Motorcycle student)
        {
            context.Motorcycles.Add(student);
        }

        public void DeleteMotorcycle(int motorcycleID)
        {
            Motorcycle motorcycle = context.Motorcycles.Find(motorcycleID);
            context.Motorcycles.Remove(motorcycle);
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            context.Entry(motorcycle).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
