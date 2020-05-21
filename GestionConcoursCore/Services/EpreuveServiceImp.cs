﻿using GestionConcoursCore.Data;
using GestionConcoursCore.Models;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace GestionConcoursCore.Services
{
    public class EpreuveServiceImp : IEpreuveService
    {
        GestionConcourCoreDbContext db;
        private readonly IHostingEnvironment hostingEnvironment;

        public EpreuveServiceImp(GestionConcourCoreDbContext db, IHostingEnvironment hostingEnvironment)
        {
            this.db = db;
            this.hostingEnvironment = hostingEnvironment;
        }

        public int Upload(UploadModel model)
        {
            int msg = 0;
            string uniqueFileName = null;
            
            if (model.fichier != null)
            {
                try
                {
                    //se positionner dans le dossier
                    string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "epreuves");
                    //make a unique filename
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.fichier.FileName;
                    //définir le chemin complet
                    string filePath = Path.Combine(uploadFolder, uniqueFileName);
                    //upload dans le fichier epreuve
                    model.fichier.CopyTo(new FileStream(filePath, FileMode.Create));
                    //Inserer le name dans la bd
                    Epreuves epreuve = new Epreuves
                    {
                        Matiere = model.matiere,
                        Annee = model.annee,
                        NomFichier = uniqueFileName
                    };

                    db.Add(epreuve);
                    db.SaveChanges();

                    msg = 1;

                } catch (Exception ex)
                {
                    
                }
            }
            
            return msg;
            
        }
    }
}
