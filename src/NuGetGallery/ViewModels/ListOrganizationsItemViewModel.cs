// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuGetGallery
{
    public class ListOrganizationsItemViewModel
    {
        public string Username { get; }
        public string EmailAddress { get; }
        public int MemberCount { get; }
        public int PackagesCount { get; }

        public ListOrganizationsItemViewModel(Organization organization, IPackageService packageService)
        {
            Username = organization.Username;
            EmailAddress = organization.EmailAddress;
            MemberCount = organization.Members.Count();
            PackagesCount = packageService.FindPackageRegistrationsByOwner(organization).Count();
        }

        public ListOrganizationsItemViewModel(Organization organization, int packagesCount)
        {
            Username = organization.Username;
            EmailAddress = organization.EmailAddress;
            MemberCount = organization.Members.Count();
            PackagesCount = packagesCount;
        }
    }
}