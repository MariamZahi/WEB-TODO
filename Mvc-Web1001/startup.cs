services.AddDbContext<AddDbContext>(options=>
options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});