// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsEoMonthRequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsEoMonthRequestBody
    {
    
        /// <summary>
        /// Gets or sets StartDate.
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken StartDate { get; set; }
    
        /// <summary>
        /// Gets or sets Months.
        /// </summary>
        [DataMember(Name = "months", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Months { get; set; }
    
    }
}
