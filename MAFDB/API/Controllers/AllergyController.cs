﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOS;
using BL;
using MAFDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllergyController : ControllerBase
    {

        private IAllergyService _allergyService;

        public AllergyController(IAllergyService allergyService)
        {
            _allergyService = allergyService;
        }
        [HttpGet]
        public IActionResult GetListOfAllergies()
        {
            var allergies = _allergyService.ListOfAllergies();
            if (allergies == null) return NotFound();
            return Ok(allergies);
        }
        //[HttpGet("{id}")]
        //public IActionResult GetAllergyById(long id)
        //{
        //    var allergy = _allergyService.Read;
        //    if (allergy == null) return NotFound();
        //    return allergy;
        //}
    }
}