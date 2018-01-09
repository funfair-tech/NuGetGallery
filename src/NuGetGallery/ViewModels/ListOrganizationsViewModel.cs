// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuGetGallery
{
    public class ListOrganizationsViewModel
    {
        public IEnumerable<ListOrganizationsItemViewModel> Organizations { get; }

        public ListOrganizationsViewModel(User currentUser, IPackageService packageService)
        {
            // Organizations = currentUser.Organizations.Select(m => new ListOrganizationsItemViewModel(m.Organization, packageService));
            Organizations = new[]
            {
                new ListOrganizationsItemViewModel(new Organization { Username = "howdy", EmailAddress = "asdf@asdf.com", Members = new Membership[] { null, null } }, 3),
                new ListOrganizationsItemViewModel(new Organization { Username = "fff", EmailAddress = "ff2@gffff.com", Members = new Membership[] { null, null, null } }, 2)
            };
        }
    }
}