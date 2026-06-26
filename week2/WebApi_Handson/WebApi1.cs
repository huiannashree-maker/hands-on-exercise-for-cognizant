// Inside Startup.cs -> ConfigureServices
services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new Info { Title = "Swagger Demo", Version = "v1" });
});

// Inside Startup.cs -> Configure
app.UseSwagger();
app.UseSwaggerUI(c => {
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Demo");
});