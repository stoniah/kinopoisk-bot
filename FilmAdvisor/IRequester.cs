﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmAdvisor
{
    public interface IRequester
    {
        RestResponse Search(IParameters parameters);
    }
}
