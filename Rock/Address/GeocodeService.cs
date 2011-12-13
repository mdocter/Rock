﻿//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Collections.Generic;

namespace Rock.Address
{
    /// <summary>
    /// Abstract class that Geocoding Service classes should derive from.  
    /// <example>
    /// The derived class should define the following type attributes
    /// </example>
    /// <code>
    ///     [Description("<i>description of service</i>")]
    ///     [Export( typeof( StandardizeService ) )]
    ///     [ExportMetadata( "ServiceName", "<i>Name of Service</i>" )]
    /// </code>
    /// <example>
    /// The derived class can also optionally define one or more property type attributes
    /// </example>
    /// <code>
    ///     [Rock.Attribute.Property( 1, "License Key", "The Required License Key" )]
    /// </code>
    /// <example>
    /// To get the value of a property, the derived class can use the AttributeValues property
    /// </example>
    /// <code>
    ///     string licenseKey = AttributeValues["LicenseKey"].Value;
    /// </code>
    /// </summary>
    [Rock.Attribute.Property( 0, "Order", "The order that this service should be used (priority)" )]
    [Rock.Attribute.Property( 0, "Active", "Active", "Should Service be used?", "False", "Rock", "Rock.FieldTypes.Boolean" )]
    public abstract class GeocodeService : Rock.Attribute.IHasAttributes
    {
        /// <summary>
        /// Gets the id.  The id is a unique value generated by the framework when the class is loaded by the GeocodeContainer
        /// </summary>
        public int Id { get { return 0; } }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <remarks>
        /// The attributes returned by this property will not contain attribute values.
        /// To get values, the AttributeValues property should be used
        /// </remarks>
        /// <value>
        /// The attributes.
        /// </value>
        public List<Rock.Web.Cache.Attribute> Attributes { get; set; }

        /// <summary>
        /// Gets or sets the attribute values.
        /// </summary>
        /// <value>
        /// The attribute values in the format of Dictionary[Attribute Key, KeyValuePair[Attribute Name, Attribute Value]]
        /// </value>
        public Dictionary<string, KeyValuePair<string, string>> AttributeValues { get; set; }

        /// <summary>
        /// Gets the order. 
        /// </summary>
        public int Order
        {
            get
            {
                int order = 0;
                if ( AttributeValues.ContainsKey( "Order" ) )
                    if ( !( Int32.TryParse( AttributeValues["Order"].Value, out order ) ) )
                        order = 0;
                return order;
            }
        }

        /// <summary>
        /// Abstract method for geocoding the specified address.  Derived classes should implement
        /// this method to geocode the address.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <param name="result">The result code unique to the service.</param>
        /// <returns>
        /// True/False value of whether the address was standardized succesfully
        /// </returns>
        public abstract bool Geocode( Rock.CRM.Address address, out string result );

        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodeService"/> class.
        /// </summary>
        public GeocodeService()
        {
            // Load the attributes
            Rock.Attribute.Helper.LoadAttributes( this );
        }
    }

    /// <summary>
    /// Metadata interface used by the MEF import/export signatures
    /// </summary>
    public interface IGeocodeServiceData
    {
        /// <summary>
        /// The name of the service
        /// </summary>
        string ServiceName { get; }
    }
}
