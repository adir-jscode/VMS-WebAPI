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
            var name = obj.FirstName.Trim() + " " + obj.LastName.Trim();
            var address = obj.HouseNo.Trim() + " " + obj.City.Trim() + " " + obj.PostalCode.Trim();
            return new Volunteers
            {
                Id = obj.Id,
                Name = name,
                Address = address,
                Email = obj.Email,
                Phone = obj.Phone,
                Password = obj.Password,
                Availability = obj.Availability,
                Skills = obj.Skills,
                CreatedAt = obj.CreatedAt

            };
        }

        public VoluenteerDTO Map(Volunteers obj)
        {
            return new VoluenteerDTO
            {
                Id = obj.Id,
                FirstName = obj.Name.Split(' ')[0],
                LastName = obj.Name.Split(' ')[1],
                Email = obj.Email,
                Phone = obj.Phone,
                Password = obj.Password,
                HouseNo = obj.Address.Split(' ')[0],
                City = obj.Address.Split(' ')[1],
                PostalCode = obj.Address.Split(' ')[2],
                Availability = obj.Availability,
                Skills = obj.Skills,
                CreatedAt = obj.CreatedAt
            };
        }

        public List<VoluenteerDTO> Map(List<Volunteers> obj)
        {
            throw new NotImplementedException();
        }
    }
}
