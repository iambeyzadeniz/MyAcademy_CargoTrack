using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoTrack.DTO.DTOs.BranchDtos;

namespace CargoTrack.DTO.DTOs.CityDtos
{
    public class ResultCityDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<ResultBranchDto> Branches { get; set; }
    }
}
