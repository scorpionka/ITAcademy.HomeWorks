using System;
using System.Collections.Generic;
using System.Text;

namespace HW_12
{
    public interface IMotorcycleRepository : IDisposable
    {
        IEnumerable<Motorcycle> GetMotorcycles();
        Motorcycle GetMotorcycleByID(int motorcycleID);
        void CreateMotorcycle(Motorcycle motorcycle);
        void DeleteMotorcycle(int motorcycleID);
        void UpdateMotorcycle(Motorcycle motorcycle);
        void Save();
    }
}
