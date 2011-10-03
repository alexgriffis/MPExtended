﻿#region Copyright (C) 2011 MPExtended
// Copyright (C) 2011 MPExtended Developers, http://mpextended.codeplex.com/
// 
// MPExtended is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// MPExtended is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with MPExtended. If not, see <http://www.gnu.org/licenses/>.
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using MPExtended.Services.MediaAccessService.Interfaces;
using MPExtended.Services.MediaAccessService.Interfaces.Picture;
using MPExtended.Services.MediaAccessService.Interfaces.Shared;

namespace MPExtended.PlugIns.MAS.MPPictures
{
    [Export(typeof(IPictureLibrary))]
    [ExportMetadata("Database", "MPPictures")]
    [ExportMetadata("Version", "1.0.0.0")]
    public class MPPictures : IPictureLibrary
    {
        private IPluginData data;

        [ImportingConstructor]
        public MPPictures(IPluginData data)
        {
            this.data = data;
        }

        public IEnumerable<WebPictureBasic> GetAllPicturesBasic()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebPictureDetailed> GetAllPicturesDetailed()
        {
            throw new NotImplementedException();
        }

        public WebPictureDetailed GetPictureDetailed(string pictureId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebCategory> GetAllPictureCategoriesBasic()
        {
            throw new NotImplementedException();
        }

        public DirectoryInfo GetSourceRootDirectory()
        {
            throw new NotImplementedException();
        }


        public Stream GetPicture(string pictureId)
        {
            throw new NotImplementedException();
        }

        public bool IsLocalFile(string path)
        {
            throw new NotImplementedException();
        }

        public Stream GetFile(string path)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<WebCategory> GetSubCategoriesBasicById(string categoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebPictureBasic> GetPicturesBasicByCategory(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebPictureDetailed> GetPicturesDetailedByCategory(string id)
        {
            throw new NotImplementedException();
        }

        public WebFileInfo GetFileInfo(string path)
        {
            throw new NotImplementedException();
        }
    }
}