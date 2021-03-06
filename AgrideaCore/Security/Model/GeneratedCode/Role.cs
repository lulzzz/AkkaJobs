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
    [Reference]
    [Serializable]
    public partial class Role : PocoBase, IEquatable<Role>
    {
        #region Primitive Properties
        public virtual bool CanAccessAllFarms { get; set;}
        public virtual string Description { get; set;}
        public virtual bool IsWebApi { get; set;}
        [Discriminant]
        [MaxLength(128)]
        public virtual string Name { get; set;}

        #endregion

     
        #region Navigation Properties
    
        private IList<Permission> permissionList_;
        public virtual IList<Permission> PermissionList //Role 1<==>* Permission
        {
            get { return permissionList_ ?? (permissionList_ = new List<Permission>()); }
            set { permissionList_ = value;}
        }   
    
        private IList<UserRole> userRoleList_;
        public virtual IList<UserRole> UserRoleList //Role 1<==>* UserRole
        {
            get { return userRoleList_ ?? (userRoleList_ = new List<UserRole>()); }
            set { userRoleList_ = value;}
        }   

        #endregion

     
        #region Initialization
        public void CopyTo(Role other)
        {
            other.CanAccessAllFarms = CanAccessAllFarms;
            other.Description = Description;
            other.IsWebApi = IsWebApi;
            other.Name = Name;
        }
        #endregion

     
        #region Identity
        public override string ToString()
        {
            return string.Format("[{0} CanAccessAllFarms='{1}' Description='{2}' IsWebApi='{3}' Name='{4}' PermissionList.Count='{5}' UserRoleList.Count='{6}']",
                base.ToString(),
                CanAccessAllFarms,
                Description,
                IsWebApi,
                Name,
                PermissionList.Count,
                UserRoleList.Count);
        }
        public override int GetHashCode() { return base.GetHashCode(); }
    	public string NaturalKey()
    	{ 
    	    return 
                Name;
        }
        public override bool Equals(object other)
        {
            return Equals(other as Role);
        }
        public bool Equals(Role other)
        {
            if (object.ReferenceEquals(other, null)) return false;
            if (object.ReferenceEquals(this, other)) return true;
            if (!Id.Equals(other.Id)) return false;
            if (!Id.Equals(0) && Id.Equals(other.Id)) return true;
            return Name == other.Name;
        } 

        #endregion

     
    }
}
