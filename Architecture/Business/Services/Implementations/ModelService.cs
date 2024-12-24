using AutoMapper;
using Business.DTOs.Model;
using Business.Helpers.Exceptions.Common;
using Business.Helpers.Exceptions.Model;
using Business.Services.Interfaces;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Implementations
{
    public class ModelService : IModelService
    {
        readonly IModelRepository _repo;
        readonly IMapper _mapper;

        public ModelService(IModelRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public GetModelDto GetById(int id)
        {
            if (id <= 0)
            {
                throw new NegativeIdException();
            }
            GetModelDto dto = _mapper.Map<GetModelDto>(_repo.GetbyId(id));
            return dto!=null?dto:throw new ModelNullException();
        }
    }
}
