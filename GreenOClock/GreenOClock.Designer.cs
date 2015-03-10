﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("GreenOClockModel", "ActivityTags", "Activity", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GreenOClock.Activity), "Tag", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GreenOClock.Tag))]
[assembly: EdmRelationshipAttribute("GreenOClockModel", "UserActivities", "Activity", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GreenOClock.Activity), "Users", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GreenOClock.User))]
[assembly: EdmRelationshipAttribute("GreenOClockModel", "UserTags", "Tag", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GreenOClock.Tag), "Users", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GreenOClock.User))]

#endregion

namespace GreenOClock
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class GreenOClockEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new GreenOClockEntities object using the connection string found in the 'GreenOClockEntities' section of the application configuration file.
        /// </summary>
        public GreenOClockEntities() : base("name=GreenOClockEntities", "GreenOClockEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new GreenOClockEntities object.
        /// </summary>
        public GreenOClockEntities(string connectionString) : base(connectionString, "GreenOClockEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new GreenOClockEntities object.
        /// </summary>
        public GreenOClockEntities(EntityConnection connection) : base(connection, "GreenOClockEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Activity> Activities
        {
            get
            {
                if ((_Activities == null))
                {
                    _Activities = base.CreateObjectSet<Activity>("Activities");
                }
                return _Activities;
            }
        }
        private ObjectSet<Activity> _Activities;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<sysdiagram> sysdiagrams
        {
            get
            {
                if ((_sysdiagrams == null))
                {
                    _sysdiagrams = base.CreateObjectSet<sysdiagram>("sysdiagrams");
                }
                return _sysdiagrams;
            }
        }
        private ObjectSet<sysdiagram> _sysdiagrams;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Tag> Tags
        {
            get
            {
                if ((_Tags == null))
                {
                    _Tags = base.CreateObjectSet<Tag>("Tags");
                }
                return _Tags;
            }
        }
        private ObjectSet<Tag> _Tags;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Activities EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToActivities(Activity activity)
        {
            base.AddObject("Activities", activity);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the sysdiagrams EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTosysdiagrams(sysdiagram sysdiagram)
        {
            base.AddObject("sysdiagrams", sysdiagram);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tags EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTags(Tag tag)
        {
            base.AddObject("Tags", tag);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="GreenOClockModel", Name="Activity")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Activity : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Activity object.
        /// </summary>
        /// <param name="activityId">Initial value of the ActivityId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Activity CreateActivity(global::System.Int32 activityId, global::System.String name)
        {
            Activity activity = new Activity();
            activity.ActivityId = activityId;
            activity.Name = name;
            return activity;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ActivityId
        {
            get
            {
                return _ActivityId;
            }
            set
            {
                if (_ActivityId != value)
                {
                    OnActivityIdChanging(value);
                    ReportPropertyChanging("ActivityId");
                    _ActivityId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ActivityId");
                    OnActivityIdChanged();
                }
            }
        }
        private global::System.Int32 _ActivityId;
        partial void OnActivityIdChanging(global::System.Int32 value);
        partial void OnActivityIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> StartTime
        {
            get
            {
                return _StartTime;
            }
            set
            {
                OnStartTimeChanging(value);
                ReportPropertyChanging("StartTime");
                _StartTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StartTime");
                OnStartTimeChanged();
            }
        }
        private Nullable<global::System.DateTime> _StartTime;
        partial void OnStartTimeChanging(Nullable<global::System.DateTime> value);
        partial void OnStartTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> EndTime
        {
            get
            {
                return _EndTime;
            }
            set
            {
                OnEndTimeChanging(value);
                ReportPropertyChanging("EndTime");
                _EndTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EndTime");
                OnEndTimeChanged();
            }
        }
        private Nullable<global::System.DateTime> _EndTime;
        partial void OnEndTimeChanging(Nullable<global::System.DateTime> value);
        partial void OnEndTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> TotalTime
        {
            get
            {
                return _TotalTime;
            }
            set
            {
                OnTotalTimeChanging(value);
                ReportPropertyChanging("TotalTime");
                _TotalTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TotalTime");
                OnTotalTimeChanged();
            }
        }
        private Nullable<global::System.Int32> _TotalTime;
        partial void OnTotalTimeChanging(Nullable<global::System.Int32> value);
        partial void OnTotalTimeChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GreenOClockModel", "ActivityTags", "Tag")]
        public EntityCollection<Tag> Tags
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Tag>("GreenOClockModel.ActivityTags", "Tag");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Tag>("GreenOClockModel.ActivityTags", "Tag", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GreenOClockModel", "UserActivities", "Users")]
        public EntityCollection<User> Users
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<User>("GreenOClockModel.UserActivities", "Users");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<User>("GreenOClockModel.UserActivities", "Users", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="GreenOClockModel", Name="sysdiagram")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class sysdiagram : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new sysdiagram object.
        /// </summary>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="principal_id">Initial value of the principal_id property.</param>
        /// <param name="diagram_id">Initial value of the diagram_id property.</param>
        public static sysdiagram Createsysdiagram(global::System.String name, global::System.Int32 principal_id, global::System.Int32 diagram_id)
        {
            sysdiagram sysdiagram = new sysdiagram();
            sysdiagram.name = name;
            sysdiagram.principal_id = principal_id;
            sysdiagram.diagram_id = diagram_id;
            return sysdiagram;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 principal_id
        {
            get
            {
                return _principal_id;
            }
            set
            {
                Onprincipal_idChanging(value);
                ReportPropertyChanging("principal_id");
                _principal_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("principal_id");
                Onprincipal_idChanged();
            }
        }
        private global::System.Int32 _principal_id;
        partial void Onprincipal_idChanging(global::System.Int32 value);
        partial void Onprincipal_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 diagram_id
        {
            get
            {
                return _diagram_id;
            }
            set
            {
                if (_diagram_id != value)
                {
                    Ondiagram_idChanging(value);
                    ReportPropertyChanging("diagram_id");
                    _diagram_id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("diagram_id");
                    Ondiagram_idChanged();
                }
            }
        }
        private global::System.Int32 _diagram_id;
        partial void Ondiagram_idChanging(global::System.Int32 value);
        partial void Ondiagram_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> version
        {
            get
            {
                return _version;
            }
            set
            {
                OnversionChanging(value);
                ReportPropertyChanging("version");
                _version = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("version");
                OnversionChanged();
            }
        }
        private Nullable<global::System.Int32> _version;
        partial void OnversionChanging(Nullable<global::System.Int32> value);
        partial void OnversionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] definition
        {
            get
            {
                return StructuralObject.GetValidValue(_definition);
            }
            set
            {
                OndefinitionChanging(value);
                ReportPropertyChanging("definition");
                _definition = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("definition");
                OndefinitionChanged();
            }
        }
        private global::System.Byte[] _definition;
        partial void OndefinitionChanging(global::System.Byte[] value);
        partial void OndefinitionChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="GreenOClockModel", Name="Tag")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Tag : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Tag object.
        /// </summary>
        /// <param name="tagId">Initial value of the TagId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Tag CreateTag(global::System.Int32 tagId, global::System.String name)
        {
            Tag tag = new Tag();
            tag.TagId = tagId;
            tag.Name = name;
            return tag;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TagId
        {
            get
            {
                return _TagId;
            }
            set
            {
                if (_TagId != value)
                {
                    OnTagIdChanging(value);
                    ReportPropertyChanging("TagId");
                    _TagId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("TagId");
                    OnTagIdChanged();
                }
            }
        }
        private global::System.Int32 _TagId;
        partial void OnTagIdChanging(global::System.Int32 value);
        partial void OnTagIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GreenOClockModel", "ActivityTags", "Activity")]
        public EntityCollection<Activity> Activities
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Activity>("GreenOClockModel.ActivityTags", "Activity");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Activity>("GreenOClockModel.ActivityTags", "Activity", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GreenOClockModel", "UserTags", "Users")]
        public EntityCollection<User> Users
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<User>("GreenOClockModel.UserTags", "Users");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<User>("GreenOClockModel.UserTags", "Users", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="GreenOClockModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="userName">Initial value of the UserName property.</param>
        /// <param name="passWord">Initial value of the PassWord property.</param>
        public static User CreateUser(global::System.Int32 userId, global::System.String userName, global::System.String passWord)
        {
            User user = new User();
            user.UserId = userId;
            user.UserName = userName;
            user.PassWord = passWord;
            return user;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if (_UserId != value)
                {
                    OnUserIdChanging(value);
                    ReportPropertyChanging("UserId");
                    _UserId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("UserId");
                    OnUserIdChanged();
                }
            }
        }
        private global::System.Int32 _UserId;
        partial void OnUserIdChanging(global::System.Int32 value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PassWord
        {
            get
            {
                return _PassWord;
            }
            set
            {
                OnPassWordChanging(value);
                ReportPropertyChanging("PassWord");
                _PassWord = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PassWord");
                OnPassWordChanged();
            }
        }
        private global::System.String _PassWord;
        partial void OnPassWordChanging(global::System.String value);
        partial void OnPassWordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GreenOClockModel", "UserActivities", "Activity")]
        public EntityCollection<Activity> Activities
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Activity>("GreenOClockModel.UserActivities", "Activity");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Activity>("GreenOClockModel.UserActivities", "Activity", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GreenOClockModel", "UserTags", "Tag")]
        public EntityCollection<Tag> Tags
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Tag>("GreenOClockModel.UserTags", "Tag");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Tag>("GreenOClockModel.UserTags", "Tag", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}