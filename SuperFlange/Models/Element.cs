using SuperFlange.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace SuperFlange.Models
{
    public class Element : ElementBase
    {
        public Material Material { get; set; }
        public List<Point> Points { get; set; }

        protected Element()
        {
            Material = new Material();
        }
    }
}
