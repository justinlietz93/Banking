﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKL.Banking.BL.Models
{
    public class MySettings
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        private string customerXMLFileName;

        public string CustomerXMLFileName
        {
            get { return customerXMLFileName; }
            set { customerXMLFileName = value; }
        }



    }
}
