using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace FirstApp.Controllers
{
    public class PersonController:Controller
    {
        static List<Person> people = new List<Person>();

        public PersonController()
        {
            string connectionString = @"Data source = WIN-HFC12JL6G7P\SQLEXPRESS; Initial catalog = Person; Integrated security = true";
            using (IDbConnection db = new SqlConnection(connectionString)) 
            {
                people = db.Query<Person>("SELECT * FROM PERSON").ToList() ;
            }
            
        }
        public IActionResult Index()
        {
            return View(people);
        }
    }
}
