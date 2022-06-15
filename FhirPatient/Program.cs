using FhirPatient.Models;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/fhirpatient", () =>
{
    var fhirPatient = new Patient(Guid.NewGuid(), "Nick", "Sittinger");
    return fhirPatient;
});

app.Run();