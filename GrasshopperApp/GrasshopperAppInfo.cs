﻿using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace GrasshopperApp
{
    public class GrasshopperAppInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "GrasshopperApp";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("244620d5-7806-462f-8f3d-f216715c2eda");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
