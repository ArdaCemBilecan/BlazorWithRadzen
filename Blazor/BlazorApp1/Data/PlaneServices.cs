using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class PlaneServices
    {
       private readonly AppDbcontext _context;
        public PlaneServices(AppDbcontext context)
        {
            _context = context;
        }

        public async Task<List<Plane>> GetPlaneAsync()
        {
            return await _context.Planes.ToListAsync();
        }

        public async Task<Plane> AddPlaneAsync(Plane plane)
        {
            try
            {
                _context.Planes.Add(plane);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return plane;
        }

        public async Task<Plane> UpdatePlaneAsync(Plane plane)
        {
            try
            {
                var productExist = _context.Planes.FirstOrDefault(p => p.Id == plane.Id);
                if (productExist != null)
                {
                    _context.Update(plane);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return plane;
        }

        public async Task DeletePlaneAsync(Plane plane)
        {
            try
            {
                _context.Planes.Remove(plane);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
