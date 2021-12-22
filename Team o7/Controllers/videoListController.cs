using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jaj.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Data.Entity.Infrastructure;
using Microsoft.AspNet.Identity;

namespace jaj.Controllers
{
    public class videoListController : Controller
    {

        


        DbBaza db = new DbBaza();

        


        // GET: videoList
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                string username = User.Identity.GetUserName();
                var user1 = db.userInfo.FirstOrDefault(x => x.Username == username);
                ViewData["taggovi"] = user1.FavTag;
            }
            List<video> videolist = new List<video>();
  
            using (DbBaza db = new DbBaza())
            {
                videolist = db.videoFile.ToList();
            }
            
            return View(videolist);
        }

        [HttpGet]
        public ActionResult videoPage(int id)
        {
            video videoModel = new video();

            using (DbBaza db = new DbBaza())
            {
                videoModel = db.videoFile.Where(x => x.videoID == id).FirstOrDefault();
            }

            return View(videoModel);
        }

        public ActionResult Search(string naziv)
        {


            List<video> videji = new List<video>();

            using (DbBaza db = new DbBaza())
            {
                videji = db.videoFile.ToList();
            }

            if (!String.IsNullOrWhiteSpace(naziv))
            {
                videji = videji.Where(x => x.videoName.ToUpper().Contains(naziv.ToUpper())).ToList();
            }
            return View(videji);
        }

    }
}