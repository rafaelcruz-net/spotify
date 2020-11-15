﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodersAcademyBootcamp.ViewModel
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Photo { get; set; }

        public List<FavoriteMusicViewModel> FavoriteMusics { get; set; }
    }
}
