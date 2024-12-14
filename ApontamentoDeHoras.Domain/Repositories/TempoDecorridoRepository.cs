using ApontamentoDeHoras.Domain.Models;
using ApontamentoDeHoras.Domain.Data;
using System.Collections.Generic;
using System.Linq;

namespace ApontamentoDeHoras.Domain.Repositories
{
    public class TempoDecorridoRepository
    {
        private readonly AppDbContext _context;

        public TempoDecorridoRepository()
        {
            _context = new AppDbContext();
        }

        public void Add(TempoDecorrido tempo)
        {
            _context.Tempos.Add(tempo);
            _context.SaveChanges();
        }

        public List<TempoDecorrido> GetAll()
        {
            return _context.Tempos.ToList();
        }
    }
}