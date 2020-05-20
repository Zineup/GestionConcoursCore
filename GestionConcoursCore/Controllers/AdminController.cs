﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestionConcoursCore.Models;
using Microsoft.AspNetCore.Http;
using GestionConcoursCore.Services;
using GestionConcoursCore.Data;

namespace GestionConcoursCore.Controllers
{
    public class AdminController : Controller
    {
        private ISearch3Service search;
        private ICorbeil3Service corbeil;
        private ISelectionService selection;
        private IPreselectionService preselec;

        public AdminController(ISearch3Service search,ICorbeil3Service corbeil,ISelectionService selection, IPreselectionService preselec)
        {
            this.search = search;
            this.corbeil = corbeil;
            this.selection = selection;
            this.preselec = preselec;
        }

        public IActionResult Index()
        {
            if (isAdmin())
            {
                return View();
            }
            return RedirectToAction("Login", "AdminAuth");

        }

        /*################################################  DEBUT  RECHERCHE  ################################################ */

        public IActionResult Recherche3()
        {
            if (isAdmin())
            {
                var x = search.generalSearch(3);
                return View(x);
            }
            return RedirectToAction("Login", "AdminAuth");
        }

        public IActionResult Recherche4()
        {
            if (isAdmin())
            {
                var x = search.generalSearch(4);
                return View(x);
            }
            return RedirectToAction("Login", "AdminAuth");
        }

        public IActionResult Corbeil3()
        {
            if (isAdmin())
            {
                var x = corbeil.afficheCorbeil(3);
                return View(x);
            }
            return RedirectToAction("Login", "AdminAuth");
        }

        public IActionResult Corbeil4()
        {
            if (isAdmin())
            {
                var x = corbeil.afficheCorbeil(4);
                return View(x);
            }
            return RedirectToAction("Login", "AdminAuth");
        }

        public JsonResult RestoreStudent(string cne, int Niveau)
        {
            var x = corbeil.restoreCorbeil(cne, Niveau);
            return Json(x);
        }
       
        public JsonResult SearchCriteria(string Criteria, string Key, string Diplome, string Filiere, int Niveau)
        {
            var x = search.specifiedSearch(Criteria, Key, Diplome, Filiere, Niveau);
            return Json(x);
        }

        public JsonResult SearchCriteriaCorb(string Criteria, string Key, string Diplome, string Filiere, int Niveau)
        {
            var x = corbeil.searchCriteria(Criteria, Key, Diplome, Filiere, Niveau);
            return Json(x);
        }

        //delete candidat
        public JsonResult deleteStudent(string cne, int Niveau)
        {
            var x = search.deleteCandidat(cne, Niveau);
            return Json(x);
        }

        public JsonResult conformeStudent(string cne, int Niveau)
        {
            var x = search.conformCandidat(cne, Niveau);
            return Json(x);
        }

        /*###################################################  FIN  RECHERCHE  ############################################# */

        /*#################################################  DEBUT  PRESELECTION  ############################################# */

        public IActionResult Preselection3()
        {
            if (isAdmin())
            {
                return View();
            }

            return RedirectToAction("Login", "AdminAuth");
        }

        public IActionResult Preselection4()
        {
            if (isAdmin())
            {
                return View();
            }

            return RedirectToAction("Login", "AdminAuth");
        }

        public JsonResult CalculerPreselec4(string fil, string diplome, int Cs1, int Cs2, int Cs3, int Cs4, int Cs5, int Cs6, int Cbac, string seuil, int niv)
        {
            ConfigurationPreselection conf = new ConfigurationPreselection()
            {
                Filiere = fil,
                TypeDiplome = diplome,
                CoeffBac = Cbac,
                CoeffS1 = Cs1,
                CoeffS2 = Cs2,
                CoeffS3 = Cs3,
                CoeffS4 = Cs4,
                CoeffS5 = Cs5,
                CoeffS6 = Cs6,
                NoteSeuil = Convert.ToDouble(seuil.Replace(".", ","))
            };

            preselec.setConfig(conf, niv);
            preselec.calculerPreselec(niv, fil, diplome);
            var x = preselec.getConvoques(niv, fil, diplome);

            return Json(x);
        }

        public JsonResult CalculerPreselec(string fil, string diplome, int Cs1, int Cs2, int Cs3, int Cs4, int Cbac, string seuil, int niv)
        {
            ConfigurationPreselection conf = new ConfigurationPreselection()
            {
                Filiere = fil,
                TypeDiplome = diplome,
                CoeffBac = Cbac,
                CoeffS1 = Cs1,
                CoeffS2 = Cs2,
                CoeffS3 = Cs3,
                CoeffS4 = Cs4,
                NoteSeuil = Convert.ToDouble(seuil.Replace(".", ","))
            };

            preselec.setConfig(conf, niv);

            preselec.calculerPreselec(niv, fil, diplome);
            var x = preselec.getConvoques(niv, fil, diplome);

            return Json(x);
        }

        public JsonResult GetConfig(string fil, string diplome)
        {
            ConfigurationPreselection list = preselec.getConfig(fil, diplome);
            return Json(list);
        }

        public JsonResult GetConvoquets(string fil, string diplome, int niv)
        {
            var list = preselec.getConvoques(niv, fil, diplome);
            return Json(list);
        }

        public JsonResult GetPourcentage(string fil, string diplome, int niv)
        {
            var list = preselec.getPourcentage(niv, fil, diplome);
            return Json(list);
        }

        /*#################################################  FIN  PRESELECTION  ############################################# */

        public IActionResult Statistique3()
        {
            return View();
        }

        public IActionResult Statistique4()
        {
            return View();
        }

        public IActionResult Correction3()
        {
            return View();
        }

        public IActionResult Correction4()
        {
            return View();
        }

        /*###################################################  DEBUT  SELECTION  ############################################# */
        public IActionResult Selection3()
        {
            return View();
        }

        public IActionResult Selection4()
        {
            return View();
        }

        public IActionResult ListeFinale3()
        {
            return View();
        }

        public IActionResult ListFinale4()
        {
            return View();
        }

        public JsonResult GetConfigurationSelectiona()
        {
            return Json("shut");
        }

        public JsonResult SearchCriteriah(string Criteria, string Key, string Diplome, string Filiere, int Niveau)
        {
            var x = search.specifiedSearch(Criteria, Key, Diplome, Filiere, Niveau);
            return Json(x);
        }
        public JsonResult GetConfigurationSelection(string filiere, int nv)
        {
            
            var data = selection.getConfigurationSelection(filiere, nv);

            return Json(data);
        }

        public JsonResult SetConfigurationSelection(string f, int cs, int np, int la, double nm, int cm, string cl, string nv)
        {
            ConfigurationSelection conf = new ConfigurationSelection();

            conf.Filiere = f;
            conf.CoeffMath = cm;
            conf.CoeffSpecialite = cs;
            conf.NbrPlace = np;
            conf.NoteMin = nm;
            conf.NbrPlaceListAtt = la;
            conf.TypeClassement = cl;
            conf.Niveau = nv;

            selection.updateConfigurationSelection(conf);
            if (nv == "3")
            {
                selection.calculeNoteGlobale(f);
            }

            var data = selection.selectStudents(f, nv);
            return Json(data);
        }

        public JsonResult GetListePrincipal(string filiere)
        {
            var data = selection.getListPrincipale(filiere);
            return Json(data);
        }


        public JsonResult GetListeAttente(string filiere)
        {
            var data = selection.getListAttente(filiere);
            return Json(data);
        }

        public JsonResult GetListePrincipalSup(string filiere)
        {
            var data = selection.getListPrincipaleSup(filiere);
            return Json(data);
        }

        public JsonResult GetListeAttenteSup(string filiere)
        {
            var data = selection.getListAttenteSup(filiere);
            return Json(data);
        }

        /*###################################################  FIN  SELECTION  ############################################# */

        public IActionResult Statistique3ApresConcours()
        {
            return View();
        }

        public IActionResult Statistique4ApresConcours()
        {
            return View();
        }

        public IActionResult FichierScanne3()
        {
            return View();
        }

        public IActionResult FichierScanne4()
        {
            return View();
        }

        public IActionResult Enregistrement()
        {
            return View();
        }

        public IActionResult EnregistrementCin()
        {
            return View();
        }


        /*###################################################  DEBUT  EPREUVE  ############################################# */

        public IActionResult Epreuve()
        {
            return View();
        }

        /*public JsonResult UploadEpreuve(UploadModel epr)
        {
            var result = epreuve.uploadEpreuve(epr);
            return Json(result, JsonRequestBehavior.AllowGet);
        }*/

        /*###################################################  FIN  EPREUVE  ############################################# */


        private bool isAdmin()
        {
            string admin = HttpContext.Session.GetString("admin");
            if (admin != null)
            {
                if (admin.Equals("true"))
                { return true; }
            }
            return false;
        }

    }
}
