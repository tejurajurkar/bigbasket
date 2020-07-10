﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace BigBasket.Resources
{
    class LoginTable
    {
        [PrimaryKey, AutoIncrement, Column("_Id")]

        public int Id { get; set; } // AutoIncrement and set primarykey  

        [MaxLength(25)]

        public string Email { get; set; }

        [MaxLength(15)]

        public string Password { get; set; }
    }
}