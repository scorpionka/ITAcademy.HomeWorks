using System.Collections.Generic;

namespace HW_12
{
    public interface IMotorcycleRepository
    {
        IEnumerable<Motorcycle> GetMotorcycles();
        Motorcycle GetMotorcycleByID(int motorcycleID);
        void CreateMotorcycle(Motorcycle motorcycle);
        void DeleteMotorcycle(int motorcycleID);
        void UpdateMotorcycle(Motorcycle motorcycle);
    }
}