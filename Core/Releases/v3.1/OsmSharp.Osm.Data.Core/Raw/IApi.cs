﻿// OsmSharp - OpenStreetMap tools & library.
// Copyright (C) 2012 Abelshausen Ben
// 
// This file is part of OsmSharp.
// 
// OsmSharp is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// OsmSharp is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with OsmSharp. If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsmSharp.Osm.Core;

namespace OsmSharp.Osm.Data
{
    /// <summary>
    /// Represents a full osm api interface.
    /// 
    /// Used For: OSM Api v0.6.
    /// </summary>
    public interface IApi : IDataSource
    {
        #region User Authentication

        /// <summary>
        /// Authenticates a users; allowing for modifications.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        bool Authenticate(User user, string pass);

        /// <summary>
        /// Returns the authenticated user.
        /// </summary>
        User AuthenticatedUser
        {
            get;
        }

        #endregion
    }
}
