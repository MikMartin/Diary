using Diary.Api;
using Diary.Api.Interfaces;
using Diary.Api.Managers;
using Diary.Data;
using Diary.Data.Interfaces;
using Diary.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("LocalDiaryConnectionM");

builder.Services.AddDbContext<NoteDbContext>(options =>
    options.UseSqlServer(connectionString)
        .UseLazyLoadingProxies()
        .ConfigureWarnings(x => x.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning)));

builder.Services.AddScoped<INoteRepository, NoteRepository>();

builder.Services.AddScoped<INoteManager, NoteManager>();

builder.Services.AddAutoMapper(typeof(AutomapperConfigurationProfile));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
