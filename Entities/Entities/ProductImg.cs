﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Entities
{
    public partial class Productimg
    {
        public string ProductImgLocation { get; set; }
        public decimal? Pk { get; set; }

        public virtual Shopproduct PkNavigation { get; set; }
    }
}
