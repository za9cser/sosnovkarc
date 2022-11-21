using OfficeOpenXml;
using SosnovkaRC.Domain.Models.Athletes;
using SosnovkaRC.Repository.Repositories;
using System.Text.RegularExpressions;

namespace SosnovkaRC.BusinessLogic.Services;

public interface IAthletesUtilsService
{
    Athlete[] InitFromFile();
}

public class AthletesUtilsService : IAthletesUtilsService
{
    private readonly IRepository<Athlete> _athletesRepository;

    public AthletesUtilsService(IRepository<Athlete> athletesRepository)
    {
        _athletesRepository = athletesRepository;
    }

    public Athlete[] InitFromFile()
    {
        using var fileStream = new FileStream("../SosnovkaRC.BusinessLogic/sosnovka.xlsx", FileMode.Open);
        using var package = new ExcelPackage(fileStream);
        using var worksheet = package.Workbook.Worksheets[0];
        var cells = worksheet.Cells;

        var athletes = new Athlete[worksheet.Dimension.Rows - 1];

        for (int row = 5, i = 0; row <= worksheet.Dimension.Rows; row++, i++)
        {
            var athlete = new Athlete();
            athletes[i] = athlete;
            athlete.LastName = cells[row, 2].Value!.ToString();
            athlete.FirstName = cells[row, 3].Value!.ToString();
            var date = cells[row, 6].Value?.ToString();
            athlete.DoB = DateTime.TryParse(date, out var d) ? d : default;
            var joiningDate = cells[row, 10].Value!.ToString();
            athlete.JoiningDate = DateTime.Parse(joiningDate);
            var leavingDate = cells[row, 11].Value?.ToString();
            if (leavingDate != null) athlete.LeavingDate = DateTime.Parse(leavingDate);
            var id = Regex.Match(cells[row, 5].Value.ToString(), @"(user|runner)\/\d+").Value;
            athlete.Identifiers.Add(new() { Identifier = id, PlatformId = 1 });
            _athletesRepository.Add(athlete);
        }

        return athletes;
    }
}