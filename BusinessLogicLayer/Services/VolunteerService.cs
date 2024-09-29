using BusinessLogicLayer.DTOs;
using BusinessLogicLayer.Mapper;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class VolunteerService
    {
        public static VolunteerMapper volunteerMapper = new VolunteerMapper();
        public static List<VoluenteerDTO> Get()
        {
            var data = DataAccessFactory.VolunteersData().GetAll();
            var allVolunteer = volunteerMapper.Map(data);
            return allVolunteer;
        }

        public static VoluenteerDTO Get(int id)
        {
            var data = DataAccessFactory.VolunteersData().GetById(id);
            var volunteer = volunteerMapper.Map(data);
            return volunteer;
        }

        public static VoluenteerDTO Create(VoluenteerDTO volunteer)
        {
            var data = volunteerMapper.Map(volunteer);
            var createdVolunteer = DataAccessFactory.VolunteersData().Create(data);
            return volunteerMapper.Map(createdVolunteer);
        }

        public static VoluenteerDTO Update(VoluenteerDTO volunteer)
        {
            var data = volunteerMapper.Map(volunteer);
            var updatedVolunteer = DataAccessFactory.VolunteersData().Update(data);
            return volunteerMapper.Map(updatedVolunteer);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.VolunteersData().Delete(id);
        }

        public static List<VoluenteerDTO> Filter(string keyword)
        {
            var data = DataAccessFactory.VolunteersData().Filter(keyword);
            var filteredVolunteers = volunteerMapper.Map(data);
            return filteredVolunteers;
        }

        public static VoluenteerDTO Search(string name)
        {
            var data = DataAccessFactory.VolunteersData().Search(name);
            var volunteer = volunteerMapper.Map(data);
            return volunteer;
        }
    }
}
