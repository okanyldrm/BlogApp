﻿using BlogApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Language :IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Image_Url { get; set; }

    }
}
