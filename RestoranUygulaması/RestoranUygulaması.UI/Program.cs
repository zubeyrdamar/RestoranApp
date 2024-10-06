using RestoranUygulamas�.Business;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Session servisini ekleyin
builder.Services.AddDistributedMemoryCache(); // In-memory cache kullan�l�r
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Oturumun zaman a��m�
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true; // GDPR gereksinimleri i�in �nemli
});

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

// Session middleware'i ekleyin
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
