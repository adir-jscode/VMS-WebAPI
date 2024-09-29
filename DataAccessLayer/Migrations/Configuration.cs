namespace DataAccessLayer.Migrations
{
    using DataAccessLayer.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccessLayer.Models.VMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessLayer.Models.VMSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //seed data for the Volunteers table
            // Seeding volunteers
            for (int i = 1; i <= 20; i++)
            {
                context.Volunteers.AddOrUpdate(
                    v => v.Email,
                    new Volunteers
                    {
                        Id = i,
                        Name = "Volunteer" + i,
                        Email = "volunteer" + i + "@gmail.com",
                        Phone = "1234567890",
                        Password = "password",
                        Address = "123 VolunteerSt City 121" + i,
                        //Skills = new List<string> { "Skill1", "Skill2" },
                        Availability = "Weekends",
                        CreatedAt = DateTime.Now
                    }
                );
            }

            //seed data for the Events table
            // Seeding events
            for (int i = 1; i <= 10; i++)
            {
                context.Events.AddOrUpdate(
                                                          e => e.Name,
                                                          new Events
                                                          {
                                                              Id = i,
                                                              Name = "Event" + i,
                                                              Description = "Description" + i,
                                                              StartDateTime = DateTime.Now.AddDays(i),
                                                              EndDateTime = DateTime.Now.AddDays(i + 1),
                                                              Location = "Location" + i,
                                                              CreatedAt = DateTime.Now
                                                          }
                                                          );
            }

            //seed data for the VolenteerEvents table
            //for (int i = 1; i <= 20; i++)
            //{
            //    context.VolenteerEvents.AddOrUpdate(
            //                           ve => ve.VolunteerId,
            //                                              new VolunteerEvents
            //                                              {
            //                                                  Id = i,
            //                                                  VolunteerId = i+1,
            //                                                  EventId = i+31,
            //                                                  AssignedAt = DateTime.Now,
            //                                                  Status = 1

            //                                              }
            //                                                             );
            //}
        }
    }
}
