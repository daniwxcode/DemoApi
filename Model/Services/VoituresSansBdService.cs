using Model.Contracts;
using Model.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public class VoituresSansBdService : IVoitures
    {
        private List<Voiture> _Store;

        public VoituresSansBdService()
        {
            _Store = new List<Voiture>();
        }

        public List<Voiture> AllVoitures() => _Store;

        public Voiture FindVoiture(int id) => _Store.FirstOrDefault(p => p.Id == id);
        public void DeleteVoiture(Voiture v) => _Store.Remove(FindVoiture(v.Id));

        void IVoitures.AddVoiture(Voiture v) => _Store.Add(v);
       
    }
}
