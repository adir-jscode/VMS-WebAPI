using BusinessLogicLayer.DTOs;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Mapper
{
    public class VolunteerMapper : IMapper<Volunteers, VoluenteerDTO>
    {
        public Volunteers Map(VoluenteerDTO obj)
        {
            //var name = obj.FirstName.Trim() + " " + obj.LastName.Trim();
            //var address = obj.HouseNo.Trim() + " " + obj.Street.Trim() + " " + obj.City.Trim() + " " + obj.PostalCode.Trim();
            return new Volunteers
            {
                Id = obj.Id,
                Name = obj.Name,
                Address = obj.Address,
                Email = obj.Email,
                Phone = obj.Phone,
                
                Availability = obj.Availability,
                //Skills = obj.Skills,
                CreatedAt = obj.CreatedAt

            };
        }

        public VoluenteerDTO Map(Volunteers obj)
        {
            return new VoluenteerDTO
            {
                Id = obj.Id,
                Name = obj.Name,
                Email = obj.Email,
                Phone = obj.Phone,
                Address = obj.Address,
                Availability = obj.Availability,
                //Skills = obj.Skills,
                CreatedAt = obj.CreatedAt
            };
        }

        public List<VoluenteerDTO> Map(List<Volunteers> obj)
        {
            var volunteers = new List<VoluenteerDTO>();
            foreach (var volunteer in obj)
            {
                volunteers.Add(Map(volunteer));
            }
            return volunteers;
        }
    }
}
