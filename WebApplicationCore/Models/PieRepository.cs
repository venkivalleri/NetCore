﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbcontext;

        public PieRepository(AppDbContext appDbcontext)
        {
            _appDbcontext = appDbcontext;
        }
        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _appDbcontext.Pies.Include(c => c.Category);
            }
        } 

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _appDbcontext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbcontext.Pies.FirstOrDefault(p => p.PieId==pieId);
        }
    }
}
