using Model.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Contracts
{
    public interface IVoitures
    {
        public List<Voiture> AllVoitures();
        public Voiture FindVoiture(int id);
        public void AddVoiture(Voiture v);
        public void DeleteVoiture(Voiture v);

    }
}
