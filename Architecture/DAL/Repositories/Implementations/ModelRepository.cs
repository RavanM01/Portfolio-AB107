using Core.Entities;
using DAL.Context;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Implementations
{
    public class ModelRepository:Repository<Model>,IModelRepository
    {
        public ModelRepository(AppDBContext dBContext):base(dBContext) { }
    }
}
