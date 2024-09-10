using EtecWebAPI.Context;
using EtecWebAPI.Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EtecContext>();   

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapPost("curso/adicionar", (EtecContext context, Curso curso) =>
{
    context.CursoSet.Add(curso);
    context.SaveChanges();

    return Results.Created("created", "Curso registrado com sucesso!");

});

app.MapPut("curso/atualizar", (EtecContext ctx, Curso curso) =>
{
    ctx.CursoSet.Update(curso);
    ctx.SaveChanges();
    return Results.Ok("Curso Atualizado com sucesso.");
});
app.MapGet("curso/listar", (EtecContext ctx) =>
{
    var cursos = ctx.CursoSet.ToList();
});
app.Run();