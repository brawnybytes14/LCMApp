using LCMApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LCMApp.ViewModels
{
    public class LCMViewModel
    {
        public History History { get; set; }
        public List<AlgorithmType> AlgorithmTypes { get; set; }
    }
}
