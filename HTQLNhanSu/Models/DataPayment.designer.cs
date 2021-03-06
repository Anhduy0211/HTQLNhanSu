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

namespace HTQLNhanSu.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="employeeat")]
	public partial class DataPaymentDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertpayment(payment instance);
    partial void Updatepayment(payment instance);
    partial void Deletepayment(payment instance);
    #endregion
		
		public DataPaymentDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["employeeatConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataPaymentDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataPaymentDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataPaymentDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataPaymentDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<payment> payments
		{
			get
			{
				return this.GetTable<payment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.payment")]
	public partial class payment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _Name;
		
		private string _Position;
		
		private int _Workingdays;
		
		private int _Bonus;
		
		private int _Salary;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPositionChanging(string value);
    partial void OnPositionChanged();
    partial void OnWorkingdaysChanging(int value);
    partial void OnWorkingdaysChanged();
    partial void OnBonusChanging(int value);
    partial void OnBonusChanged();
    partial void OnSalaryChanging(int value);
    partial void OnSalaryChanged();
    #endregion
		
		public payment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this.OnPositionChanging(value);
					this.SendPropertyChanging();
					this._Position = value;
					this.SendPropertyChanged("Position");
					this.OnPositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Workingdays", DbType="Int NOT NULL")]
		public int Workingdays
		{
			get
			{
				return this._Workingdays;
			}
			set
			{
				if ((this._Workingdays != value))
				{
					this.OnWorkingdaysChanging(value);
					this.SendPropertyChanging();
					this._Workingdays = value;
					this.SendPropertyChanged("Workingdays");
					this.OnWorkingdaysChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bonus", DbType="Int NOT NULL")]
		public int Bonus
		{
			get
			{
				return this._Bonus;
			}
			set
			{
				if ((this._Bonus != value))
				{
					this.OnBonusChanging(value);
					this.SendPropertyChanging();
					this._Bonus = value;
					this.SendPropertyChanged("Bonus");
					this.OnBonusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int NOT NULL")]
		public int Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
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
