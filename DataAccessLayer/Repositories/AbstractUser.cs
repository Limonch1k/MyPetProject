using AutoMapper;
using DataAccessLayer.DataModel;
using DataAccessLayer.Interface;
using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public abstract class AbstractUser<T> : IDataManipulationAsync<T> where T : DataUser
    {
        private KotelContext _context { get; set; }
        private IMapper _mapper { get; set; }

        public AbstractUser(KotelContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task Create(T item)
        {
            var user = _mapper.Map<User>(item);
            await _context.Users.AddAsync(user);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var users = await  _context.Users.ToListAsync();
            var DataUsers = _mapper.Map<IEnumerable<T>>(users);
            return DataUsers;
            
        }

        public async Task<T> FindEntityByIdAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null) 
            {
                throw new Exception("nothing");
            }

            var DataUsers = _mapper.Map<T>(user);

            return _mapper.Map<T>(user);
        }

        public async Task UpdateAsync(int id, T item)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null) 
            {
                throw new Exception("nothing");
            }
            user = _mapper.Map<User>(item);
        }

        public async Task CreateAsync(T item)
        {
            var user = _mapper.Map<User>(item);
            await _context.Users.AddAsync(user);
        }

        public async Task DeleteAsync(T item)
        {
            var user = await _context.Users.FindAsync(item.Id);
            if (user is null) 
            {
                throw new Exception("I do nothing");
            }
            _context.Users.Remove(user);
        }

        public async Task DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }


    }
}
