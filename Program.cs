using ContactM.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure Swagger for API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register ContactService for dependency injection
builder.Services.AddScoped<IContactService, ContactService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Uncomment the following line to enforce HTTPS redirection
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
