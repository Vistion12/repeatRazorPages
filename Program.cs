var builder = WebApplication.CreateBuilder(args);

ConfigureServices(builder.Services);
var app = builder.Build();
Configure(app, app.Environment);
app.Run();
void ConfigureServices(IServiceCollection services)
{
    services.AddRazorPages();
}
void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    if (!env.IsDevelopment())
    {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
    }
    app.UseHttpsRedirection();

    app.UseDefaultFiles();
    app.UseStaticFiles();

    app.UseRouting();
    app.UseEndpoints(x =>
    {
        //x.MapGet("/hello", () => "hello world");
        x.MapRazorPages();
    });
    
}
    

    
