//using Articles.Web.DataModels;
//using BullsAndCows.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using Microsoft.AspNet.Identity; //-legs you ger the current user!!!
//using BullsAndCows.Models;

//namespace BullsAndCows.Web.Controllers
//{
//    public class ArticlesController : BaseController
//    {
//        public ArticlesController()
//            : this(new BullsAndCowsData())
//        {
//        }

//        public ArticlesController(IBullsAndCowsData data)
//            : base(data)
//        {
//        }

//        //-----------------------------------
//        //-----------------------------------

//        [HttpPost]
//        [Authorize]
//        public IHttpActionResult Create(ArticleDataModel model)
//        {
//            var currentUserID = this.User.Identity.GetUserId();

//            var category = GetCategory(model);
//            var tags = GetTags(model);

//            var article = new Article
//            {
//                UserId = currentUserID,
//                DateCreated = DateTime.Now,
//                Title = model.Title,
//                Content = model.Content,
//                CategoryId = category.Id,
//                Tags = tags,
//            };

//            this.data.Articles.Add(article);
//            this.data.SaveChanges();

//            model.ID = article.Id;
//            model.DateCreated = article.DateCreated;
//            model.Tags = article.Tags.Select(t => t.Name);

//            return Ok(model);
//        }

//        [HttpGet]
//        public IHttpActionResult All()
//        {
//            return this.All(null, 0);
//        }

//        [HttpGet]
//        public IHttpActionResult All(int page)
//        {
//            return this.All(null, page);
//        }

//        [HttpGet]
//        public IHttpActionResult All(string category)
//        {
//            return this.All(category, 0);
//        }

//        [HttpGet]
//        public IHttpActionResult All(string category, int page)
//        {
//            var articles = this.GetAllOrderedByDate()
//                .Where(a => category != null ? a.Category.Name.Equals(category, StringComparison.InvariantCultureIgnoreCase) : true)
//                .Skip(10 * page)
//                .Take(10)
//                .Select(ArticleDataModel.FromArticle).ToList();

//            return Ok(articles);
//        }

//        [HttpGet]
//        [Authorize]
//        public IHttpActionResult Details(int id)
//        {
//            var article = this.data.Articles.Find(id);
//            if (article == null)
//            {
//                return NotFound();
//            }

//            var articleModel = new ArticleDetailsDataModel(article);
//            return Ok(articleModel);
//        }

//        private IQueryable<Article> GetAllOrderedByDate()
//        {
//            return this.data.Articles.All()
//                .OrderBy(a => a.DateCreated);
//        }

//        private Category GetCategory(ArticleDataModel model)
//        {
//            var category = this.data.Categories.All()
//                .FirstOrDefault(c => c.Name == model.Category);

//            if (category == null)
//            {
//                category = new Category { Name = model.Category };
//                this.data.Categories.Add(category);
//            }
//            return category;
//        }

//        private HashSet<Guess> GetTags(ArticleDataModel model)
//        {
//            HashSet<Guess> tags = new HashSet<Guess>();
//            var newTagNames = model.Tags.ToList();
//            var tagsFromTitle = model.Title.Split(' ');
//            newTagNames.AddRange(tagsFromTitle);

//            foreach (var newTagName in newTagNames)
//            {
//                var tag = this.data.Guesses.All()
//                    .FirstOrDefault(t => t.Name == newTagName);
//                if (tag == null)
//                {
//                    tag = new Guess { Name = newTagName };
//                    this.data.Guesses.Add(tag);
//                }

//                tags.Add(tag);
//            }
//            return tags;
//        }
//    }
//}
