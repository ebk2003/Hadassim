﻿using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface ICovidBll
    {

        public List<CovidDto> getAll();
        public List<CovidDto> getById(string id);
    }
}
