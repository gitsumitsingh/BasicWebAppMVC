using BasicWebCore.Data;
using BasicWebCore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

//string strCon1 = builder.Configuration.GetConnectionString("MongoDbConnection");
//string strCon2 = builder.Services.Configure<DbConfiguration>(builder.Configuration.GetSection("MongoDbConnection"));
//DbConfiguration mongoDbConfiguration = new DbConfiguration();
//builder.Configuration.GetSection("MongoDbConnection").Bind(mongoDbConfiguration);
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
