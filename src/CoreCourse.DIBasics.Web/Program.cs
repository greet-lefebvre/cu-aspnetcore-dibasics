using CoreCourse.DIBasics.Core.CoffeeSystem;
using CoreCourse.DIBasics.Web.CoffeeWeb;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

int CoffeeSettings = builder.Configuration.GetSection("CoffeeSettings").Get<int>();

switch (CoffeeSettings)
{
    case 1: //1 == The app needs coffee with cream and sugar
        builder.Services.AddTransient<ICreamer, Cream>();
        builder.Services.AddTransient<ISweetener, Sugar>();
        break;
    case 2: //2 == The app needs coffee with milk and honey
        builder.Services.AddTransient<ICreamer, Milk>();
        builder.Services.AddTransient<ISweetener, Honey>();
        break;
    case 3: //3 == The app needs coffee with liquor
        builder.Services.AddTransient<ICreamer, Whiskey>();
        builder.Services.AddTransient<ISweetener, Sugar>();
        break;
    case 4: //4 == The app needs "Random" implementations of creamers and sweeteners
        builder.Services.AddTransient<ICreamer, RandomCreamer>();
        builder.Services.AddTransient<ISweetener, RandomSweetener>();
        break;

}

builder.Services.AddTransient<ICoffeeCup, CoffeeCup>();

var random = new Random();
builder.Services.AddSingleton<Random>(random);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
