using Microsoft.EntityFrameworkCore;
using BasicWebCore.Models.Context;
using BasicWebCore.Models.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//string strCon1 = builder.Configuration.GetConnectionString("MongoConnection");
builder.Services.AddDbContext<MongoDBContext>(opt => opt.UseInMemoryDatabase(builder.Configuration.GetSection("MongoConnection:MongoConnectionString").Value));

//string strCon2 = builder.Services.Configure<DbConfiguration>(builder.Configuration.GetSection("MongoConnection"));
//DbConfiguration mongoDbConfiguration = new DbConfiguration();
//builder.Configuration.GetSection("MongoConnection").Bind(mongoDbConfiguration);
//builder.Services.AddSingleton<DbConfiguration, mongoDbConfiguration>();
builder.Services.AddScoped<IProductService, ProductService>();

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
