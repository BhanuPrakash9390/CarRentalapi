using CarRentalapi.Context;
using CarRentalapi.Models;
using System.Linq;

namespace CarRentalapi.Service
{
    public class StatesServices
    {
        private readonly MyDbContext _context;

        public StatesServices(MyDbContext context)
        {
            _context = context;
        }

        public List<States> GetAllStates()
        {
            return _context.States.ToList();
        }

        public States GetStateById(int id)
        {
            return _context.States.FirstOrDefault(s => s.StatesId == id);
        }

        public void AddState(States state)
        {
            _context.States.Add(state);
            _context.SaveChanges();
        }

        public void DeleteState(int id)
        {
            var state = _context.States.FirstOrDefault(s => s.StatesId == id);
            if (state != null)
            {
                _context.States.Remove(state);
                _context.SaveChanges();
            }
        }

        public States UpdateState(States state)
        {
            var existingState = _context.States.FirstOrDefault(s => s.StatesId == state.StatesId);
            if (existingState != null)
            {
                existingState.StatesName = state.StatesName;
                _context.SaveChanges();
            }
            return existingState;
        }
    }
}
