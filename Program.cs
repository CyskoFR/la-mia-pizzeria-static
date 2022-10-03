//Dobbiamo realizzare un’applicazione web che ci aiuti a gestire la nostra pizzeria.
//Abbiamo bisogno di creare la nostra prima pagina (index) dove mostriamo tutte le pizze che prepariamo.
//Una pizza avrà le seguenti informazioni :
//un nome
//una descrizione
//una foto
//un prezzo
//Modifichiamo quindi la view Index.cshtml generata in automatico da .Net Core scrivendo l’html che serve a noi per mostrare l’elenco delle pizze (possiamo creare una tabella con bootstrap o una qualche grafica a nostro piacimento che mostri l’elenco delle pizze...proviamo un po’ di creatività se vogliamo!)
//Piccolo suggerimento : ricordatevi di inserire il seguente codice all’inizio della vostra view @ { Layout = null; }


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
