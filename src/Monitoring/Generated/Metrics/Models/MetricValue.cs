// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models
{
    /// <summary>
    /// Represents a metric value.
    /// </summary>
    public partial class MetricValue
    {
        private string _annotation;
        
        /// <summary>
        /// Specifies annotation for the metric.
        /// </summary>
        public string Annotation
        {
            get { return this._annotation; }
            set { this._annotation = value; }
        }
        
        private double? _average;
        
        /// <summary>
        /// Specifies the average value in the time interval.
        /// </summary>
        public double? Average
        {
            get { return this._average; }
            set { this._average = value; }
        }
        
        private int? _count;
        
        /// <summary>
        /// Specifies the sample count in the time interval. Can be used to
        /// determine the number of values that contributed to the average
        /// value.
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }
        
        private double? _maximum;
        
        /// <summary>
        /// Specifies the maximum value in the time interval.
        /// </summary>
        public double? Maximum
        {
            get { return this._maximum; }
            set { this._maximum = value; }
        }
        
        private double? _minimum;
        
        /// <summary>
        /// Specifies the minimum value in the time interval.
        /// </summary>
        public double? Minimum
        {
            get { return this._minimum; }
            set { this._minimum = value; }
        }
        
        private DateTime _timestamp;
        
        /// <summary>
        /// The timestamp for the metric value.
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }
        
        private double? _total;
        
        /// <summary>
        /// Specifies the total value in the time interval.
        /// </summary>
        public double? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MetricValue class.
        /// </summary>
        public MetricValue()
        {
        }
    }
}
