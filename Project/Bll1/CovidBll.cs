using AutoMapper;
using Dal;
using Dto;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class CovidBll : ICovidBll
    {

        ICovidDal covidDal;
        IMapper mapper;
        //----------------------------------------------------------------------------------

        public CovidBll(ICovidDal covidDal, IMapper mapper)
        {
            this.covidDal = covidDal;
            this.mapper = mapper;
        }
        //----------------------------------------------------------------------------------

        public List<CovidDto> getAll()
        {
            return mapper.Map<List<CovidDto>>(this.covidDal.GetAllCovids());
        }
        //----------------------------------------------------------------------------------
        public List<CovidDto> getById(string id)
        {
            return mapper.Map<List<CovidDto>>(this.covidDal.GetCovidById(id));
        }
        //----------------------------------------------------------------------------------


    }
}
