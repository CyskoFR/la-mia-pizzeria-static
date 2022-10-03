//Dobbiamo realizzare un’applicazione web che ci aiuti a gestire la nostra pizzeria.
//Abbiamo bisogno di creare la nostra prima pagina (index) dove mostriamo tutte le pizze che prepariamo.
//Una pizza avrà le seguenti informazioni :
//un nome
//una descrizione
//una foto
//un prezzo
//Modifichiamo quindi la view Index.cshtml generata in automatico da .Net Core scrivendo l’html che serve a noi per mostrare l’elenco delle pizze (possiamo creare una tabella con bootstrap o una qualche grafica a nostro piacimento che mostri l’elenco delle pizze...proviamo un po’ di creatività se vogliamo!)
//Piccolo suggerimento : ricordatevi di inserire il seguente codice all’inizio della vostra view @ { Layout = null; }

//------------------------------

//Esercizi con Razor: Create un nuovo controller di nome Esercizi per implementare le richieste nel file che vi allego. Ovviamente non dovrete realizzarle dentro il controller ma dovrete creare l’apposita vista (per esempio Index) dove inserirete il codice delle soluzioni.
//Esercizio Layout: Create un nuovo layout e inserite al suo interno il codice che secondo voi definisce lo scheletro dell’applicazione e che dovrà essere utilizzato in altre pagine future del vostro progetto. In questo caso quindi, se avete seguito l’esercizio precedente dovreste trovarvi con la vostra vista Index senza layout (Layout = null) che dovrà quindi essere rimossa per dare spazio a questa nuova versione e struttura del progetto.

//1.Dichiarare una variabile valorizzandola con il nostro nome.
//Dichiarare un'altra variabile valorizzandola con il nostro cognome.
//Stampare il nostro nome e cognome all'interno di un tag h2.
//2. Creare una funzione che stampa la somma dei numeri che vanno da 1 a n (con n passato come parametro - n incluso)
//Stampare dentro uno span il risultato.
//3. Contare quante volte la lettera a è presente nalla frase "nel mezzo del cammin di nostra vita" e stampare questo valore in pagina
//4. Creare una List<int> di 20 numeri interi (generati random da 1 a 90, 1 e 90 inclusi) e mostrare in pagina solo i numeri compresi tra 20 e 70
//5. Stampare in pagina la data e l'ora attuale (usando la classe DateTime) con il formato anno-mese-giorno ore:minuti:secondi
//6. Partendo dalla data di oggi (usando la classe DateTime) stampare in pagina
//a.la data di 7 giorni fa
//b.che giorno della settimana è oggi (il risultato dovrà essere il nome del giorno (Lunedì, Martedì, ...)
//c.che giorno della settimana sarà nello stesso giorno e mese di oggi ma tra un anno (il risultato dovrà essere il nome del giorno (Lunedì, Martedì, ...)


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
