﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FluffySpoon.Templates
{
    public interface IFluffySpoonTemplateRenderer
    {
        Task<string> RenderAsync(string name, params Controller[] controllers);
    }
}