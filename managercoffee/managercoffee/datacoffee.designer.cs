﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace managercoffee
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLCF")]
	public partial class datacoffeeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcoffee(coffee instance);
    partial void Updatecoffee(coffee instance);
    partial void Deletecoffee(coffee instance);
    #endregion
		
		public datacoffeeDataContext() : 
				base(global::managercoffee.Properties.Settings.Default.QLCFConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public datacoffeeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public datacoffeeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public datacoffeeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public datacoffeeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<coffee> coffees
		{
			get
			{
				return this.GetTable<coffee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.coffee")]
	public partial class coffee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _name;
		
		private string _taste;
		
		private System.Nullable<System.DateTime> _expire_date;
		
		private System.Nullable<double> _price;
		
		private string _smell;
		
		private string _production_place;
		
		private string _img;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OntasteChanging(string value);
    partial void OntasteChanged();
    partial void Onexpire_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onexpire_dateChanged();
    partial void OnpriceChanging(System.Nullable<double> value);
    partial void OnpriceChanged();
    partial void OnsmellChanging(string value);
    partial void OnsmellChanged();
    partial void Onproduction_placeChanging(string value);
    partial void Onproduction_placeChanged();
    partial void OnimgChanging(string value);
    partial void OnimgChanged();
    #endregion
		
		public coffee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="NVarChar(500) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(500)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_taste", DbType="NVarChar(500)")]
		public string taste
		{
			get
			{
				return this._taste;
			}
			set
			{
				if ((this._taste != value))
				{
					this.OntasteChanging(value);
					this.SendPropertyChanging();
					this._taste = value;
					this.SendPropertyChanged("taste");
					this.OntasteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_expire_date", DbType="Date")]
		public System.Nullable<System.DateTime> expire_date
		{
			get
			{
				return this._expire_date;
			}
			set
			{
				if ((this._expire_date != value))
				{
					this.Onexpire_dateChanging(value);
					this.SendPropertyChanging();
					this._expire_date = value;
					this.SendPropertyChanged("expire_date");
					this.Onexpire_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Float")]
		public System.Nullable<double> price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_smell", DbType="NVarChar(500)")]
		public string smell
		{
			get
			{
				return this._smell;
			}
			set
			{
				if ((this._smell != value))
				{
					this.OnsmellChanging(value);
					this.SendPropertyChanging();
					this._smell = value;
					this.SendPropertyChanged("smell");
					this.OnsmellChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_production_place", DbType="NVarChar(500)")]
		public string production_place
		{
			get
			{
				return this._production_place;
			}
			set
			{
				if ((this._production_place != value))
				{
					this.Onproduction_placeChanging(value);
					this.SendPropertyChanging();
					this._production_place = value;
					this.SendPropertyChanged("production_place");
					this.Onproduction_placeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string img
		{
			get
			{
				return this._img;
			}
			set
			{
				if ((this._img != value))
				{
					this.OnimgChanging(value);
					this.SendPropertyChanging();
					this._img = value;
					this.SendPropertyChanged("img");
					this.OnimgChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
