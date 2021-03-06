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

namespace Agridea.Security
{
    [Serializable]
    public partial class UserRole : PocoBase, IEquatable<UserRole>
    {
        #region Primitive Properties
        public virtual string Comment { get; set;}
        public virtual Nullable<System.DateTime> CommitmentDate { get; set;}
        public virtual FarmGroup FarmGroup { get; set;}

        #endregion

     
        #region Navigation Properties
        [Discriminant]
        public virtual Role Role  { get; set; } //UserRole *<==>1 Role
        [Discriminant]
        public virtual User User  { get; set; } //UserRole *<==>1 User

        #endregion

     
        #region Initialization
        public void CopyTo(UserRole other)
        {
            other.Comment = Comment;
            other.CommitmentDate = CommitmentDate;
            other.FarmGroup = FarmGroup;
        }
        #endregion

     
        #region Identity
        public override string ToString()
        {
            return string.Format("[{0} Comment='{1}' CommitmentDate='{2}' FarmGroup='{3}' Role.Name='{4}' User.UserName='{5}']",
                base.ToString(),
                Comment,
                CommitmentDate,
                FarmGroup,
                Role == null ? "@null" : string.Format("{0}", Role.Name),
                User == null ? "@null" : string.Format("{0}", User.UserName));
        }
        public override int GetHashCode() { return base.GetHashCode(); }
    	public string NaturalKey()
    	{ 
    	    return 
                Role.Name + 
                User.UserName;
        }
        public override bool Equals(object other)
        {
            return Equals(other as UserRole);
        }
        public bool Equals(UserRole other)
        {
            if (object.ReferenceEquals(other, null)) return false;
            if (object.ReferenceEquals(this, other)) return true;
            if (!Id.Equals(other.Id)) return false;
            if (!Id.Equals(0) && Id.Equals(other.Id)) return true;
            return Role == other.Role &&
                   User == other.User;
        } 

        #endregion

     
    }
}
