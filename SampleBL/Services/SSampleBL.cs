﻿using SampleBL.Interface;
using SampleCL;
using SampleCL.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleBL.Services
{
    public class SSampleBL : ISampleBL
    {
        private ISampleRL sample;

        public SSampleBL(ISampleRL sample)
        {
            this.sample = sample;
        }
        public string Return_Name(Sample model)
        {
            return this.sample.Return_Name(model);
        }
    }
}
