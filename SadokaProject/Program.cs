using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Languagy_project.BLL;
using Languagy_project.Data;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;
using EmailService;
using Microsoft.AspNetCore.Localization;
using Azure;
using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();

builder.Services.AddLocalization();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddMvc();
   
builder.Services.AddDbContext<LanguagyDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataConnection"));
});

builder.Services.AddSingleton(builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>());

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddCors();

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<LanguagyDbContext>()
  .AddTokenProvider<DataProtectorTokenProvider<IdentityUser>>(TokenOptions.DefaultProvider);

//start Add Transient
builder.Services.AddTransient<IEmailSender, EmailSender>();

builder.Services.AddTransient<IHeaderRep, HeaderRep>();
builder.Services.AddTransient<IWelcomeRep, WelcomeRep>();

builder.Services.AddTransient<IThemeRep, ThemeRep>();
builder.Services.AddTransient<IFeaturesRep, FeaturesRep>();

builder.Services.AddTransient<IPartnersRep, PartnersRep>();
builder.Services.AddTransient<IMembersRep, MembersRep>();

builder.Services.AddTransient<IQuestionsRep, QuestionsRep>();
builder.Services.AddTransient<IContactUsRep, ContactUsRep>();

builder.Services.AddTransient<ISubscriptionsRep, SubscriptionsRep>();
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {

            new CultureInfo("en-US"),
            new CultureInfo("de-DE"),
            new CultureInfo("ar-SA"),
            new CultureInfo("es-ES"),
            new CultureInfo("fr-FR"),
            new CultureInfo("it-IT"),
            new CultureInfo("fl-FL"),
            new CultureInfo("tr-TR"),
            new CultureInfo("fi-FI"),
            new CultureInfo("ro-RO"),
            new CultureInfo("fr-CH"),
        };

    //options.DefaultRequestCulture = new RequestCulture(culture: supportedCultures[0], uiCulture: supportedCultures[0]);
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

var app = builder.Build();



//End Add Scoped

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
//localization

var supportedCultures = new[] {"en-US", "ar-SA", "de-DE"  ,
                                "es-ES","fr-FR","it-IT","fi-FI","tr-TR","ro-RO","fr-CH"};
var localizationOptions = new RequestLocalizationOptions()
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Sadoka}/{action=Index}/{id?}");

app.Run();
