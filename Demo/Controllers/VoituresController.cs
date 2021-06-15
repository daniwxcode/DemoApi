using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Model.Contracts;
using Model.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoituresController : ControllerBase
    {
        private IVoitures _voitureStore;

        public VoituresController(IVoitures service)
        {
            this._voitureStore = service;
        }

        [HttpGet]
        public IEnumerable<Voiture> GetVoitures() => _voitureStore.AllVoitures();

        [HttpGet("{id}")]
        public Voiture GetVoitures(int id) => _voitureStore.FindVoiture(id);

        [HttpPost]
        public void AddVoiture([FromBody]Voiture v) => _voitureStore.AddVoiture(v);

        [HttpDelete("{id}")]
        public void DeleteVoiture(int id) => _voitureStore.DeleteVoiture(_voitureStore.FindVoiture(id));

    }
}
