using System.Collections.Generic;
using Api.Domain.Entities;
using Megaman.Dtos;

namespace Api.App.Services
{
    public interface IRobotServices
    {
         IEnumerable<Robot> SearchAll();

        RobotReadDTO SearchById(int id);
         

    }
}