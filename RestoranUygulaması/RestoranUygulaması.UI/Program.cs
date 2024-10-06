using RestoranUygulamasý.Business;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// KullaniciServisi'ni DI sistemine ekleyelim
builder.Services.AddScoped<IKullaniciServisi, KullaniciServisi>();
builder.Services.AddScoped<ISiparisServisi, SiparisServisi>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
