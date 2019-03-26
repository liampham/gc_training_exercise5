﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C1MvcDemo.Models
{
  public class FlexChartModel
  {

    public IDictionary<string, object[]> Settings { get; set; }

    public IDictionary<string, object> DefaultValues { get; set; }

    public IEnumerable<CountryData> CountrySalesData { get; set; }

    public FlexChartModel()
    {

    }
  }
}
