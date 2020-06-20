using Microsoft.EntityFrameworkCore;
using Negozio.DataAccess.DbModel;
using NegozioDataAccess;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Negozio.DataAccess.Services
{
    public class FilmService : IFilmService
    {
        private readonly NegozioContext _negozioContext;
        public FilmService(NegozioContext negozioContext)
        {
            _negozioContext = negozioContext;
        }
        public async Task<List<Film>> GetFilms()
        {
            try
            {
                var result = await _negozioContext.Film
                    .Include(x => x.FilmRegistas)
                    .ThenInclude(x => x.Regista).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<Film> GetFilm(int id)
        {
            try
            {
                var result = await _negozioContext.Film
                    .Include(x => x.FilmRegistas)
                    .ThenInclude(x => x.Regista)
                    .FirstOrDefaultAsync(x=>x.FilmId == id);
                if (result != null)
                {
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<Film> GetFilmTitolo(string titolo)
        {
            return await _negozioContext.Film.FirstOrDefaultAsync(x => x.Titolo.Trim().ToLower() == titolo.Trim().ToLower());
        }

        public async Task<Negozioo> CheckNegozio(string nome, string luogo)
        {
            var res =  await _negozioContext.Negozioo.
                FirstOrDefaultAsync(x=>x.NomeNegozio.Trim().ToLower() == nome.Trim().ToLower()
                && x.Luogo.Trim().ToLower() == luogo.Trim().ToLower());
            if (res != null)
            {
                return res;
            }
            else
            {
                var toinsert = new Negozioo();
                toinsert.NomeNegozio = nome;
                toinsert.Luogo = luogo;
                 _negozioContext.Add(toinsert);
                await _negozioContext.SaveChangesAsync();
                return await _negozioContext.Negozioo.FirstOrDefaultAsync(x=>x.NomeNegozio == toinsert.NomeNegozio && x.Luogo == toinsert.Luogo);
            }
        }
        public async Task<Regista> CheckRegista (string nome, string cognome)
        {
            var res = await _negozioContext.Regista.FirstOrDefaultAsync(x => x.Nome.Trim().ToLower() == nome.ToLower().Trim() && x.Cognome.Trim().ToLower() == cognome.ToLower().Trim());
            if (res != null)
            {
                return res;
            }
            else
            {
                var toinsert = new Regista();
                toinsert.Nome = nome;
                toinsert.Cognome = cognome;
                _negozioContext.Add(toinsert);
                await _negozioContext.SaveChangesAsync();
                return await _negozioContext.Regista.FirstOrDefaultAsync(x => x.Nome == toinsert.Nome && x.Cognome == toinsert.Cognome);
            }  
         }
        public async Task<bool> AddFilmToDb(Film film)
        {
            try
            {
                _negozioContext.Add(film);
                await _negozioContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
