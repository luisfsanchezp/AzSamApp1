var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();   // <-- Necesario para cargar CSS/JS

app.UseRouting();

app.UseAuthorization();

// Rutas
app.MapRazorPages();

app.MapControllers();

app.Run();
