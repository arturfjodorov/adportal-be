﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using adportal_be.Data;
using adportal_be.Models;

namespace adportal_be.Controllers
{
    public class CategoriesController : ApiController
    {

        //Get all categories
        AdPortalDbContext adPortalDbContext = new AdPortalDbContext();

        public IHttpActionResult Get()
        {
            var categories = adPortalDbContext.Categories;
            return Ok(categories);
        }
        //Get category by id
        public IHttpActionResult Get(int id)
        {
            var category = adPortalDbContext.Categories.Find(id);
            if (category == null)
            {
                return BadRequest("No category with such id");
            }
            return Ok(category);
        }

    }
}
