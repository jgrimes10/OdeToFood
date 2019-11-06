﻿using System.Collections.Generic;
using System.Web.Http;
using OdeToFood.Data.Models;
using OdeToFood.Data.Services;

namespace OdeToFood.Web.Api
{
    public class RestaurantsController : ApiController
    {
        private readonly IRestaurantData _db;

        public RestaurantsController(IRestaurantData db)
        {
            _db = db;
        }
        public IEnumerable<Restaurant> Get()
        {
            var model = _db.GetAll();
            return model;
        }
    }
}
