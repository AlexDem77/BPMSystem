using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BpmApp.Models.PositionModels;
using BpmApp.Db.Infrastructure;
using BpmApp.Db.Entities;

namespace BpmApp.Infrastructure.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly BpmContext _bpmContext;

        public PositionRepository(BpmContext bpmContext)
        {
            _bpmContext = bpmContext;
        }

        public IEnumerable<PositionModel> GetAll()
        {
            var result = _bpmContext
                .Positions
                .Select(p => new PositionModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Title = p.Title
                })
                .ToList();

            return result;
        }

        public PositionModel Upsert(CreatePositionModel model)
        {
            var position = _bpmContext.Positions.SingleOrDefault(p => p.Name == model.Name && p.Title == model.Title);
            if (position is null)
            {
                position = new Position
                {
                    Name = model.Name,
                    Title = model.Title
                };
                _bpmContext.Positions.Add(position);
                _bpmContext.SaveChanges();
            }

            return new PositionModel
            {
                Id = position.Id,
                Name = position.Name,
                Title = position.Title
            };
        }
    }
}
