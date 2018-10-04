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

namespace Agridea
{
    public partial interface IAgrideaService
    {
        #region GetByDiscriminant
        Permission GetByDiscriminants(Permission item);
        Permission GetByDiscriminants(Permission item, IList<Permission> existingItems);
        Role GetByDiscriminants(Role item);
        Role GetByDiscriminants(Role item, IList<Role> existingItems);
        User GetByDiscriminants(User item);
        User GetByDiscriminants(User item, IList<User> existingItems);
        UserRole GetByDiscriminants(UserRole item);
        UserRole GetByDiscriminants(UserRole item, IList<UserRole> existingItems);
        #endregion
    
        #region Insert/Update/Delete SQL commands
        void SqlBulkCopy(IEnumerable<Permission> items);
    	void SqlBulkCopyWithId(IEnumerable<Permission> items);
        void SqlInsert(IEnumerable<Permission> items);
        void SqlUpdate(IEnumerable<Permission> items);
        void SqlBulkCopy(IEnumerable<Role> items);
    	void SqlBulkCopyWithId(IEnumerable<Role> items);
        void SqlInsert(IEnumerable<Role> items);
        void SqlUpdate(IEnumerable<Role> items);
        void SqlBulkCopy(IEnumerable<User> items);
    	void SqlBulkCopyWithId(IEnumerable<User> items);
        void SqlInsert(IEnumerable<User> items);
        void SqlUpdate(IEnumerable<User> items);
        void SqlBulkCopy(IEnumerable<UserRole> items);
    	void SqlBulkCopyWithId(IEnumerable<UserRole> items);
        void SqlInsert(IEnumerable<UserRole> items);
        void SqlUpdate(IEnumerable<UserRole> items);
        #endregion
        
        #region CascadeRemove
        void CascadeRemove(Permission item); 
        void CascadeRemoveRange(IList<Permission> items); 
        void CascadeRemove(Role item); 
        void CascadeRemoveRange(IList<Role> items); 
        void CascadeRemove(User item); 
        void CascadeRemoveRange(IList<User> items); 
        void CascadeRemove(UserRole item); 
        void CascadeRemoveRange(IList<UserRole> items); 
        #endregion
    }
}