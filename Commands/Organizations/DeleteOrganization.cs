﻿using System;
using Warden.Messages.Commands;

namespace Warden.Messages.Commands.Organizations
{
    public class DeleteOrganization : IAuthenticatedCommand
    {
        public Request Request { get; set; }
        public string UserId { get; set; }
        public Guid Id { get; set; }
    }
}