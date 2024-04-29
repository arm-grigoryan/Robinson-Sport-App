﻿using RobinsonSportApp.Data.Entities;

namespace RobinsonSportApp.Core.Managers.Associations.Models
{
    public class AssociationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PresidentFirstName { get; set; }
        public string PresidentLastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumbers { get; set; }
        public string Emails { get; set; }
        public string WebsiteUrl { get; set; }
        public ICollection<AssociationContact> AssociationContacts { get; set; }
    }
}
