using Coded.CsharpLab.WebApplication.Models;

namespace Coded.CsharpLab.WebApplication.DataAccess;

/// <summary>
/// This is the main news repository that should be used in the project. Later on we can modify this class to connect to real database.
/// </summary>
public class NewsArticleRepository
{
    
     private static readonly NewsArticle[] NewsArticles = {
            new() {Id = 1, Title = "Tech Giants Lead the Way in AI Development", Description = "An in-depth look at the advancements in AI technology by leading tech companies.", ViewCount = 150, Category = "Technology" },
            new() {Id = 2, Title = "Local Sports Team Wins Championship", Description = "The hometown heroes triumph in a stunning victory against their rivals.", ViewCount = 300, Category = "Sports" },
            new() {Id = 3, Title = "Global Markets React to Economic Shifts", Description = "Market trends showing significant shifts in the global economy.", ViewCount = 200, Category = "Finance" },
            new() {Id = 4, Title = "Breakthrough in Renewable Energy", Description = "New renewable energy sources promise a greener future.", ViewCount = 175, Category = "Environment" },
            new() {Id = 5, Title = "New Culinary Trends Taking Over", Description = "Exploring the latest trends in the culinary world.", ViewCount = 250, Category = "Lifestyle" },
            new() {Id = 6, Title = "Major Advances in Health Technology", Description = "A look into recent groundbreaking health technology developments.", ViewCount = 220, Category = "Health" },
            new() {Id = 7, Title = "Education Systems Adapt to Digital Learning", Description = "How education systems are evolving with digital learning environments.", ViewCount = 180, Category = "Education" },
            new() {Id = 8, Title = "Exploring the Wonders of Space Travel", Description = "The latest achievements and future plans in space exploration.", ViewCount = 400, Category = "Science" },
            new() {Id = 9, Title = "Art and Culture in the Modern World", Description = "A journey through contemporary art and cultural expressions.", ViewCount = 160, Category = "Culture" },
            new() {Id = 10, Title = "The Evolution of Urban Planning", Description = "Urban planning and its impact on modern city life.", ViewCount = 190, Category = "Urban Development" }
        };

     public NewsArticle[] GetAll()
     {
         return NewsArticles;
     }

     public NewsArticle? GetById(int id)
     {
         return id > 10 ? null : NewsArticles.SingleOrDefault(r => r.Id == id);
     }

     public string[] GetCategories()
     {
         return NewsArticles.Select(r => r.Category).Distinct().ToArray();
     }
}