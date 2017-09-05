using System;
using System.Collections.Generic;

namespace DinosaursWithApi.Models
{
    public class DinoAPIModel
    {
        public int ID { get; set; }
        public string DinoName { get; set; }
        public string DinoSize { get; set; }
        public string DinoHabitats { get; set; }

        public DinoAPIModel()
        {

        }

        public List<DinoAPIModel> DinoListGetter()
        {
            var DinoList = new List<DinoAPIModel>();
            var Triceratops = new DinoAPIModel{
                ID = 1,
                DinoName = "Triceratops",
                DinoSize = "Medium-Large",
                DinoHabitats = "Plains"
            };

            var TRex = new DinoAPIModel{
                ID = 2,
                DinoName = "T-Rex",
                DinoSize = "Large",
                DinoHabitats = "Plains"
            };

            var Stegosaurus = new DinoAPIModel{
                ID = 3,
                DinoName = "Stegosaurus",
                DinoSize = "Medium-Large",
                DinoHabitats = "Plains"
            };
            DinoList.Add(Triceratops);
            DinoList.Add(TRex);
            DinoList.Add(Stegosaurus);
            return DinoList;
        }
    }
}