using ElevenNote.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.Web.Controllers
{
    public class NotesController : Controller
    {
        // GET: Notes
        public ActionResult Index()
        {
            var Notes = new List<NoteListViewModel>();
            Notes.Add(new NoteListViewModel()
            {
                Id = 1,
                Title = "First!",
                DateCreated = DateTime.UtcNow.AddMonths(-1),
                DateModified = DateTime.UtcNow,
                IsFavorite = false
            });

            var weirdNote = new NoteListViewModel();
            weirdNote.Id = 2;
            weirdNote.Title = "BUmmer";
            weirdNote.DateCreated = DateTime.UtcNow;
            weirdNote.DateModified = null;
            weirdNote.IsFavorite = true;

            Notes.Add(weirdNote);

            Notes.Add(new NoteListViewModel()
            {
                Id = 4,
                Title = "Fourd",
                DateCreated = DateTime.Now,
                DateModified = null,
                IsFavorite = true

            });

            return View(Notes.OrderByDescending(Note => Note.DateCreated));
        }
    }
}