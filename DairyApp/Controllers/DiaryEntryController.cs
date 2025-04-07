using DairyApp.Data;
using DairyApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DairyApp.Controllers
{
	public class DiaryEntryController : Controller
	{
		private readonly ApplicationDbContext _db;

	

		public DiaryEntryController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();
			return View(objDiaryEntryList);

		}


		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(DiaryEntry obj)
		{
			if(obj!=null && obj.Title.Length<3)
			{
				ModelState.AddModelError("Title", "Title must be at least 3 characters long");
			}
			if(ModelState.IsValid)
			{
				_db.DiaryEntries.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(obj);
		}



		[HttpGet]
		public IActionResult Edit(int? id)
		{


			if(id == null || id == 0)
			{
				return NotFound();
			}
			

			DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);
	
			if (diaryEntry == null)
			{
 				return NotFound();
			}
			
			return View(diaryEntry);
		}



		[HttpPost]
		public IActionResult Edit(DiaryEntry obj)
		{
			if (obj != null && obj.Title.Length < 3)
			{
				ModelState.AddModelError("Title", "Title must be at least 3 characters long");
			}
			if (ModelState.IsValid)
			{
				_db.DiaryEntries.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(obj);
		}




		[HttpGet]
		public IActionResult Delete(int? id)
		{


			if (id == null || id == 0)
			{
				return NotFound();
			}


			DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

			if (diaryEntry == null)
			{
				return NotFound();
			}

			return View(diaryEntry);
		}


		[HttpPost]
		public IActionResult Delete(DiaryEntry obj)
		{
			
			
				_db.DiaryEntries.Remove(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			
			
		}

	}
}
