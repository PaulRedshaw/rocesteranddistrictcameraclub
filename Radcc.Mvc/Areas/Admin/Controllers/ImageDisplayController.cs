﻿using System.Web.Mvc;

namespace Radcc.Mvc.Areas.Admin.Controllers
{
    public class ImageDisplayController : AdminController
    {
        // GET: Admin/ImageDisplay
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Index(FormCollection fc, HttpPostedFileBase file)
        //{
        //    tbl_details tbl = new tbl_details();
        //    var allowedExtensions = new[] {  
        //    ".Jpg", ".png", ".jpg", "jpeg"  
        //};
        //    tbl.Id = fc["Id"].ToString();
        //    tbl.Image_url = file.ToString(); //getting complete url  
        //    tbl.Name = fc["Name"].ToString();
        //    var fileName = Path.GetFileName(file.FileName); //getting only file name(ex-ganesh.jpg)  
        //    var ext = Path.GetExtension(file.FileName); //getting the extension(ex-.jpg)  
        //    if (allowedExtensions.Contains(ext)) //check what type of extension  
        //    {
        //        string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension  
        //        string myfile = name + "_" + tbl.Id + ext; //appending the name with id  
        //        // store the file inside ~/project folder(Img)  
        //        var path = Path.Combine(Server.MapPath("~/Img"), myfile);
        //        tbl.Image_url = path;
        //        obj.tbl_details.Add(tbl);
        //        obj.SaveChanges();
        //        file.SaveAs(path);
        //    }
        //    else
        //    {
        //        ViewBag.message = "Please choose only Image file";
        //    }
        //    return View();
        //}  
    }
}