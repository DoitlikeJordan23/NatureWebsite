using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace MyWebAPI;

public class MyWebAPIContext : DbContext
{
    public DbSet<ArticleURLListing>? ArticleURLListing { get; set; }
    public DbSet<ArticleID>? ArticleID { get; set; }
    public DbSet<Newsletter>? Newsletter { get; set; }
    public DbSet<SocialMedia>? SocialMedia { get; set; }
    public DbSet<PageTranslate>? PageTranslate { get; set; }
    public DbSet<PageTranslateList>? PageTranslateList { get; set; }
    public DbSet<NewAccount>? NewAccount { get; set; }
    public DbSet<SignIn>? SignIn { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
    }
}

public class ArticleURLListing
{
  public string? url { get; set; }
  public string? title { get; set; }
  public string? description { get; set; }
  public string? image { get; set; }
  public int date { get; set; }
  public string? author { get; set; }
  public string? category { get; set; }
  public string? tags { get; set; }
  public string? content { get; set; }
}

public class ArticleID
{
    public string? id { get; set; }
}

public class Newsletter
{
    public string? Email { get; set; }
}

public class SocialMedia
{
    public SocialMedia(string facebook, string twitter, string instagram, string translate, string youtube) 
        {
          this.Facebook = facebook;
          this.Twitter = twitter;
          this.Instagram = instagram;
          this.Translate = translate;
          this.Youtube = youtube;
   
        }
    public string Facebook { get; set; }
    public string Twitter { get; set; }

    public string Instagram { get; set; }

    public string Translate { get; set; }

    public string Youtube { get; set; }

}

public class PageTranslate
{
    public string? Page { get; set; }
    public string? Language { get; set; }
    public string? Translate { get; set; }
}

public class PageTranslateList
{
  public PageTranslateList(List<PageTranslate> pageTranslate)
  {
    PageTranslate = pageTranslate;
  }

  public List<PageTranslate> PageTranslate { get; set; }
}

public class NewAccount
{
  public string? Email { get; set; }
  public string? Password { get; set; }
  public string? FirstName { get; set; }
  public string? LastName { get; set; }

  public string? Country { get; set; }
}

public class SignIn
{
  public SignIn(string email) => this.Email = email;
  public string Email { get; set; }
  public string? Password { get; set; }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
