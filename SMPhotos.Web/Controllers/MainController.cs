﻿using SMPhotos.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SMPhotos.Web.ViewModel;

namespace SMPhotos.Web.Controllers
{
	public class MainController : Controller
	{
		private readonly IAlbumRepository _albumRepository;
		public MainController(
			IAlbumRepository albumRepository
		)
		{
			_albumRepository = albumRepository;
		}

		// GET: Main
		public ActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public ActionResult albums()
		{
			AlbumListVM viewModel = new AlbumListVM();
			var albums = (IList<Album>)_albumRepository.GetAll();
			viewModel.AllAlbums = AutoMapper.Mapper.Map<IList<AlbumVM>>(albums);
			foreach (var alb in viewModel.AllAlbums)
			{
				alb.PathAlbum = alb.Path + alb.Guid + '/' + alb.Image[0].Name;
			}
			return View(viewModel);
		}

		[HttpGet]
		public ActionResult album(int id)
		{
			var albums = (IList<Album>)_albumRepository.GetAll();
			var album = albums.FirstOrDefault(x => x.Id == id);
			AlbumVM albumVM = AutoMapper.Mapper.Map<AlbumVM>(album);
			albumVM.PathAlbum = albumVM.Path + albumVM.Guid + '/';
			return View(albumVM);
		}
	}
}