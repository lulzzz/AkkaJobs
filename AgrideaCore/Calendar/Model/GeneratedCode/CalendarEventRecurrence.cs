/////////////////////////////////////////////////////////////////////////////////
//                                                                             //
// <auto-generated>                                                            //
// Date=? Machine=? User=?                                                     //
// Copyright (c) 2010-2011 Agridea, All Rights Reserved                        //
// </auto-generated>                                                           //
//                                                                             //
/////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
//using System.Data.Entity.SqlServer;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using Agridea;
using Agridea.Calendar;
using Agridea.DataRepository;
using Agridea.Diagnostics.Contracts;
using Agridea.Diagnostics.Logging;
using Agridea.Metadata;
using Agridea.News;
using Agridea.Security;
using Agridea.Service;
using Agridea.Web.UI;

namespace Agridea.Calendar
{
    [Reference]
    [Serializable]
    public partial class CalendarEventRecurrence : PocoBase, IEquatable<CalendarEventRecurrence>
    {
        #region Primitive Properties
        [Discriminant]
        public virtual int Code { get; set;}
        public virtual string Description { get; set;}

        #endregion

     
        #region Navigation Properties
        //None(no navigation property)
        #endregion

     
        #region Initialization
        public void CopyTo(CalendarEventRecurrence other)
        {
            other.Code = Code;
            other.Description = Description;
        }
        #endregion

     
        #region Identity
        public override string ToString()
        {
            return string.Format("[{0} Code='{1}' Description='{2}']",
                base.ToString(),
                Code,
                Description);
        }
        public override int GetHashCode() { return base.GetHashCode(); }
    	public string NaturalKey()
    	{ 
    	    return 
                Code.ToString();
        }
        public override bool Equals(object other)
        {
            return Equals(other as CalendarEventRecurrence);
        }
        public bool Equals(CalendarEventRecurrence other)
        {
            if (object.ReferenceEquals(other, null)) return false;
            if (object.ReferenceEquals(this, other)) return true;
            if (!Id.Equals(other.Id)) return false;
            if (!Id.Equals(0) && Id.Equals(other.Id)) return true;
            return Code == other.Code;
        } 

        #endregion

     
    }
}
