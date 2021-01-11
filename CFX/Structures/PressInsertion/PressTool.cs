/*
Copyright 2018 TE Connectivity

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
-------------------------------------------------------------------------
*/
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures.PressInsertion
{
    /// <summary>
    /// Represents a type of tool used in press insertion operations
    /// </summary>
    public class PressTool : Tool
    {

        /// <summary>
        /// The x dimension of the tool used for the pressing operation
        /// </summary>
        public double ToolDimensionX
        {
            get;
            set;
        }//ToolDimensionX
        /// <summary>
        /// The y dimension of the tool used for the pressing operation
        /// </summary>
        public double ToolDimensionY
        {
            get;
            set;
        }//ToolDimensionY

        /// <summary>
        /// The z dimension of the tool used for the pressing operation
        /// </summary>
        public double ToolDimensionZ
        {
            get;
            set;
        }//ToolDimensionZ

        /// <summary>
        /// The clearance dimension of the tool used for the pressing operation
        /// </summary>
        public double ToolClearanceDimension
        {
            get;
            set;
        }//ToolClearanceDimension
    }//PressTool
}
