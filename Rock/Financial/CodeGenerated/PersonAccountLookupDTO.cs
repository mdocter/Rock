//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Serialization;

using Rock.Data;

namespace Rock.Financial
{
    /// <summary>
    /// Data Transfer Object for PersonAccountLookup object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class PersonAccountLookupDto : IDto
    {
        /// <summary />
        [DataMember]
        public int? PersonId { get; set; }

        /// <summary />
        [DataMember]
        public string Account { get; set; }

        /// <summary />
        [DataMember]
        public int Id { get; set; }

        /// <summary />
        [DataMember]
        public Guid Guid { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public PersonAccountLookupDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="personAccountLookup"></param>
        public PersonAccountLookupDto ( PersonAccountLookup personAccountLookup )
        {
            CopyFromModel( personAccountLookup );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public virtual Dictionary<string, object> ToDictionary()
        {
            var dictionary = new Dictionary<string, object>();
            dictionary.Add( "PersonId", this.PersonId );
            dictionary.Add( "Account", this.Account );
            dictionary.Add( "Id", this.Id );
            dictionary.Add( "Guid", this.Guid );
            return dictionary;
        }

        /// <summary>
        /// Creates a dynamic object.
        /// </summary>
        /// <returns></returns>
        public virtual dynamic ToDynamic()
        {
            dynamic expando = new ExpandoObject();
            expando.PersonId = this.PersonId;
            expando.Account = this.Account;
            expando.Id = this.Id;
            expando.Guid = this.Guid;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyFromModel( IEntity model )
        {
            if ( model is PersonAccountLookup )
            {
                var personAccountLookup = (PersonAccountLookup)model;
                this.PersonId = personAccountLookup.PersonId;
                this.Account = personAccountLookup.Account;
                this.Id = personAccountLookup.Id;
                this.Guid = personAccountLookup.Guid;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyToModel ( IEntity model )
        {
            if ( model is PersonAccountLookup )
            {
                var personAccountLookup = (PersonAccountLookup)model;
                personAccountLookup.PersonId = this.PersonId;
                personAccountLookup.Account = this.Account;
                personAccountLookup.Id = this.Id;
                personAccountLookup.Guid = this.Guid;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class PersonAccountLookupDtoExtension
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static PersonAccountLookup ToModel( this PersonAccountLookupDto value )
        {
            PersonAccountLookup result = new PersonAccountLookup();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<PersonAccountLookup> ToModel( this List<PersonAccountLookupDto> value )
        {
            List<PersonAccountLookup> result = new List<PersonAccountLookup>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<PersonAccountLookupDto> ToDto( this List<PersonAccountLookup> value )
        {
            List<PersonAccountLookupDto> result = new List<PersonAccountLookupDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static PersonAccountLookupDto ToDto( this PersonAccountLookup value )
        {
            return new PersonAccountLookupDto( value );
        }

    }
}