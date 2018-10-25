using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _300910377_KAUR__300916412_YANG__Lab2.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using Microsoft.Extensions.Configuration;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime;

namespace _300910377_KAUR__300916412_YANG__Lab2.Controllers
{
    public class MoviesController : Controller
    {
        IConfiguration configuration { get; set; }

        private readonly _300910377_KAUR__300916412_YANG__Lab2Context _context;

        private static string bucketName;
        private IAmazonS3 s3Client;

        private string SUCCESS_UPLOAD = "Movie has been uploaded successfully!";

        private string FAILED_UPLOAD = "Sorry, there was an error uploading your movie. Please try again!";

        public MoviesController(_300910377_KAUR__300916412_YANG__Lab2Context context, IConfiguration conf)
        {
            _context = context;
            configuration = conf;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movie.ToListAsync());
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovieId,MovieName,FileName,Description")] Movie movie, IFormFile FileName)
        {
            if (ModelState.IsValid)
            {
                string uploadFile = UploadMovie(FileName);
                if (uploadFile != null)
                {
                    movie.FileName = uploadFile; //Get name of the file from uploaded file
                    _context.Add(movie);
                    await _context.SaveChangesAsync();

                    ViewData["Message"] = SUCCESS_UPLOAD;
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewData["Message"] = FAILED_UPLOAD;
                    return RedirectToAction(nameof(Create));
                }

            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MovieId,MovieName,FileName,Description")] Movie movie)
        {
            if (id != movie.MovieId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.MovieId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.MovieId == id);
        }

        private string UploadMovie(IFormFile file)
        {

            var fileName = Path.Combine(file.FileName, "_", DateTime.Now.ToString());
            Stream st = file.OpenReadStream();

            var awsOptions = configuration.GetAWSOptions();
            var profileName = awsOptions.Profile;
            bucketName = configuration.GetSection("AWS").GetSection("BucketName").Value;

            CredentialProfile credentialProfile;
            AWSCredentials aWSCredentials;
            CredentialProfileStoreChain chain = new CredentialProfileStoreChain();

            chain.TryGetAWSCredentials(profileName, out aWSCredentials);
            chain.TryGetProfile(profileName, out credentialProfile);


            s3Client = new AmazonS3Client(aWSCredentials, awsOptions.Region);

            TransferUtility fileTransferUtility = new TransferUtility(s3Client);
            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = fileName,
                InputStream = st
            };


            if (file.Length > 0)
            {

                fileTransferUtility.Upload(request);

                return fileName;
            }

            return null;
        }
    }
}
