﻿namespace Zavrsni.TeamOps.Features.Projects.Models
{
    public class AddUserToProjectModel
    {
        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid OwnerId { get; set; }
    }
}
