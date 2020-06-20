﻿using Negozio.DataAccess.DbModel;
using Negozio.DataAccess.Services;
using Negozio.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Negozio.Core
{
    public class FilmCore : IFilmCore
    {
        private readonly IFilmService _filmService;
        public FilmCore(IFilmService filmService)
        {
            _filmService = filmService;
        }
        public async Task<RequestFilm> PostFilm(RequestFilm requestFilm)
        {
            var esistefilm = _filmService.GetFilmTitolo(requestFilm.Titolo);
            if (esistefilm == null)
            {
                var daInserire = new Film();
                daInserire.Titolo = requestFilm.Titolo;
                daInserire.Anno = requestFilm.Anno;
                daInserire.Prezzo = requestFilm.Prezzo;
                daInserire.Negozioo = await _filmService.CheckNegozio(requestFilm.NomeNegozio, requestFilm.Luogo);
                daInserire.FilmRegistas = new List<FilmRegista>();
                var tmp = new FilmRegista();
                tmp.Regista = await _filmService.CheckRegista(requestFilm.NomeRegista, requestFilm.CognomeRegista);
                tmp.Film = daInserire;
                daInserire.FilmRegistas.Add(tmp);
                var insert = await _filmService.AddFilmToDb(daInserire);
                if (insert)
                {
                    return requestFilm;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}