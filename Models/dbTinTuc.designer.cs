﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//hello 
//------------------------------------------------------------------------------

namespace WebApplication1.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLTINTUC")]
	public partial class dbTinTucDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertQuangCao(QuangCao instance);
    partial void UpdateQuangCao(QuangCao instance);
    partial void DeleteQuangCao(QuangCao instance);
    partial void InsertHinhAnh(HinhAnh instance);
    partial void UpdateHinhAnh(HinhAnh instance);
    partial void DeleteHinhAnh(HinhAnh instance);
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertBangTin(BangTin instance);
    partial void UpdateBangTin(BangTin instance);
    partial void DeleteBangTin(BangTin instance);
    partial void InsertLoaiTin(LoaiTin instance);
    partial void UpdateLoaiTin(LoaiTin instance);
    partial void DeleteLoaiTin(LoaiTin instance);
    #endregion
		
		public dbTinTucDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLTINTUCConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbTinTucDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbTinTucDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbTinTucDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbTinTucDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<QuangCao> QuangCaos
		{
			get
			{
				return this.GetTable<QuangCao>();
			}
		}
		
		public System.Data.Linq.Table<HinhAnh> HinhAnhs
		{
			get
			{
				return this.GetTable<HinhAnh>();
			}
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<BangTin> BangTins
		{
			get
			{
				return this.GetTable<BangTin>();
			}
		}
		
		public System.Data.Linq.Table<LoaiTin> LoaiTins
		{
			get
			{
				return this.GetTable<LoaiTin>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QuangCao")]
	public partial class QuangCao : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _QuangCaoID;
		
		private string _UrlHinh;
		
		private int _ViTri;
		
		private System.DateTime _NgayDangLen;
		
		private string _MoTa;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnQuangCaoIDChanging(int value);
    partial void OnQuangCaoIDChanged();
    partial void OnUrlHinhChanging(string value);
    partial void OnUrlHinhChanged();
    partial void OnViTriChanging(int value);
    partial void OnViTriChanged();
    partial void OnNgayDangLenChanging(System.DateTime value);
    partial void OnNgayDangLenChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    #endregion
		
		public QuangCao()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuangCaoID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int QuangCaoID
		{
			get
			{
				return this._QuangCaoID;
			}
			set
			{
				if ((this._QuangCaoID != value))
				{
					this.OnQuangCaoIDChanging(value);
					this.SendPropertyChanging();
					this._QuangCaoID = value;
					this.SendPropertyChanged("QuangCaoID");
					this.OnQuangCaoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrlHinh", DbType="NChar(300) NOT NULL", CanBeNull=false)]
		public string UrlHinh
		{
			get
			{
				return this._UrlHinh;
			}
			set
			{
				if ((this._UrlHinh != value))
				{
					this.OnUrlHinhChanging(value);
					this.SendPropertyChanging();
					this._UrlHinh = value;
					this.SendPropertyChanged("UrlHinh");
					this.OnUrlHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ViTri", DbType="Int NOT NULL")]
		public int ViTri
		{
			get
			{
				return this._ViTri;
			}
			set
			{
				if ((this._ViTri != value))
				{
					this.OnViTriChanging(value);
					this.SendPropertyChanging();
					this._ViTri = value;
					this.SendPropertyChanged("ViTri");
					this.OnViTriChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDangLen", DbType="DateTime NOT NULL")]
		public System.DateTime NgayDangLen
		{
			get
			{
				return this._NgayDangLen;
			}
			set
			{
				if ((this._NgayDangLen != value))
				{
					this.OnNgayDangLenChanging(value);
					this.SendPropertyChanging();
					this._NgayDangLen = value;
					this.SendPropertyChanged("NgayDangLen");
					this.OnNgayDangLenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HinhAnh")]
	public partial class HinhAnh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _HinhAnhID;
		
		private string _UrlHinh;
		
		private System.DateTime _NgayDangHinh;
		
		private string _TuaDe;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHinhAnhIDChanging(int value);
    partial void OnHinhAnhIDChanged();
    partial void OnUrlHinhChanging(string value);
    partial void OnUrlHinhChanged();
    partial void OnNgayDangHinhChanging(System.DateTime value);
    partial void OnNgayDangHinhChanged();
    partial void OnTuaDeChanging(string value);
    partial void OnTuaDeChanged();
    #endregion
		
		public HinhAnh()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhAnhID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int HinhAnhID
		{
			get
			{
				return this._HinhAnhID;
			}
			set
			{
				if ((this._HinhAnhID != value))
				{
					this.OnHinhAnhIDChanging(value);
					this.SendPropertyChanging();
					this._HinhAnhID = value;
					this.SendPropertyChanged("HinhAnhID");
					this.OnHinhAnhIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrlHinh", DbType="NChar(300) NOT NULL", CanBeNull=false)]
		public string UrlHinh
		{
			get
			{
				return this._UrlHinh;
			}
			set
			{
				if ((this._UrlHinh != value))
				{
					this.OnUrlHinhChanging(value);
					this.SendPropertyChanging();
					this._UrlHinh = value;
					this.SendPropertyChanged("UrlHinh");
					this.OnUrlHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDangHinh", DbType="DateTime NOT NULL")]
		public System.DateTime NgayDangHinh
		{
			get
			{
				return this._NgayDangHinh;
			}
			set
			{
				if ((this._NgayDangHinh != value))
				{
					this.OnNgayDangHinhChanging(value);
					this.SendPropertyChanging();
					this._NgayDangHinh = value;
					this.SendPropertyChanged("NgayDangHinh");
					this.OnNgayDangHinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TuaDe", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TuaDe
		{
			get
			{
				return this._TuaDe;
			}
			set
			{
				if ((this._TuaDe != value))
				{
					this.OnTuaDeChanging(value);
					this.SendPropertyChanging();
					this._TuaDe = value;
					this.SendPropertyChanged("TuaDe");
					this.OnTuaDeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaAdmin;
		
		private string _HoTen;
		
		private string _Email;
		
		private string _GioiTinh;
		
		private int _SDT;
		
		private string _AdminID;
		
		private string _Password;
		
		private EntitySet<BangTin> _BangTins;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaAdminChanging(int value);
    partial void OnMaAdminChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnSDTChanging(int value);
    partial void OnSDTChanged();
    partial void OnAdminIDChanging(string value);
    partial void OnAdminIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Admin()
		{
			this._BangTins = new EntitySet<BangTin>(new Action<BangTin>(this.attach_BangTins), new Action<BangTin>(this.detach_BangTins));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaAdmin", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaAdmin
		{
			get
			{
				return this._MaAdmin;
			}
			set
			{
				if ((this._MaAdmin != value))
				{
					this.OnMaAdminChanging(value);
					this.SendPropertyChanging();
					this._MaAdmin = value;
					this.SendPropertyChanged("MaAdmin");
					this.OnMaAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(70) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NChar(40) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NChar(8) NOT NULL", CanBeNull=false)]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="Int NOT NULL")]
		public int SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminID", DbType="NChar(40) NOT NULL", CanBeNull=false)]
		public string AdminID
		{
			get
			{
				return this._AdminID;
			}
			set
			{
				if ((this._AdminID != value))
				{
					this.OnAdminIDChanging(value);
					this.SendPropertyChanging();
					this._AdminID = value;
					this.SendPropertyChanged("AdminID");
					this.OnAdminIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NChar(40) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Admin_BangTin", Storage="_BangTins", ThisKey="MaAdmin", OtherKey="MaAdmin")]
		public EntitySet<BangTin> BangTins
		{
			get
			{
				return this._BangTins;
			}
			set
			{
				this._BangTins.Assign(value);
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
		
		private void attach_BangTins(BangTin entity)
		{
			this.SendPropertyChanging();
			entity.Admin = this;
		}
		
		private void detach_BangTins(BangTin entity)
		{
			this.SendPropertyChanging();
			entity.Admin = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BangTin")]
	public partial class BangTin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BangTinID;
		
		private string _TieuDe;
		
		private System.DateTime _NgayDang;
		
		private string _MoTa;
		
		private string _NoiDung;
		
		private string _AnhBiaTin;
		
		private int _LoaiTinID;
		
		private int _MaAdmin;
		
		private EntityRef<Admin> _Admin;
		
		private EntityRef<LoaiTin> _LoaiTin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBangTinIDChanging(int value);
    partial void OnBangTinIDChanged();
    partial void OnTieuDeChanging(string value);
    partial void OnTieuDeChanged();
    partial void OnNgayDangChanging(System.DateTime value);
    partial void OnNgayDangChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    partial void OnNoiDungChanging(string value);
    partial void OnNoiDungChanged();
    partial void OnAnhBiaTinChanging(string value);
    partial void OnAnhBiaTinChanged();
    partial void OnLoaiTinIDChanging(int value);
    partial void OnLoaiTinIDChanged();
    partial void OnMaAdminChanging(int value);
    partial void OnMaAdminChanged();
    #endregion
		
		public BangTin()
		{
			this._Admin = default(EntityRef<Admin>);
			this._LoaiTin = default(EntityRef<LoaiTin>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BangTinID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BangTinID
		{
			get
			{
				return this._BangTinID;
			}
			set
			{
				if ((this._BangTinID != value))
				{
					this.OnBangTinIDChanging(value);
					this.SendPropertyChanging();
					this._BangTinID = value;
					this.SendPropertyChanged("BangTinID");
					this.OnBangTinIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuDe", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string TieuDe
		{
			get
			{
				return this._TieuDe;
			}
			set
			{
				if ((this._TieuDe != value))
				{
					this.OnTieuDeChanging(value);
					this.SendPropertyChanging();
					this._TieuDe = value;
					this.SendPropertyChanged("TieuDe");
					this.OnTieuDeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDang", DbType="DateTime NOT NULL")]
		public System.DateTime NgayDang
		{
			get
			{
				return this._NgayDang;
			}
			set
			{
				if ((this._NgayDang != value))
				{
					this.OnNgayDangChanging(value);
					this.SendPropertyChanging();
					this._NgayDang = value;
					this.SendPropertyChanged("NgayDang");
					this.OnNgayDangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoiDung", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string NoiDung
		{
			get
			{
				return this._NoiDung;
			}
			set
			{
				if ((this._NoiDung != value))
				{
					this.OnNoiDungChanging(value);
					this.SendPropertyChanging();
					this._NoiDung = value;
					this.SendPropertyChanged("NoiDung");
					this.OnNoiDungChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnhBiaTin", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string AnhBiaTin
		{
			get
			{
				return this._AnhBiaTin;
			}
			set
			{
				if ((this._AnhBiaTin != value))
				{
					this.OnAnhBiaTinChanging(value);
					this.SendPropertyChanging();
					this._AnhBiaTin = value;
					this.SendPropertyChanged("AnhBiaTin");
					this.OnAnhBiaTinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiTinID", DbType="Int NOT NULL")]
		public int LoaiTinID
		{
			get
			{
				return this._LoaiTinID;
			}
			set
			{
				if ((this._LoaiTinID != value))
				{
					if (this._LoaiTin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLoaiTinIDChanging(value);
					this.SendPropertyChanging();
					this._LoaiTinID = value;
					this.SendPropertyChanged("LoaiTinID");
					this.OnLoaiTinIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaAdmin", DbType="Int NOT NULL")]
		public int MaAdmin
		{
			get
			{
				return this._MaAdmin;
			}
			set
			{
				if ((this._MaAdmin != value))
				{
					if (this._Admin.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaAdminChanging(value);
					this.SendPropertyChanging();
					this._MaAdmin = value;
					this.SendPropertyChanged("MaAdmin");
					this.OnMaAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Admin_BangTin", Storage="_Admin", ThisKey="MaAdmin", OtherKey="MaAdmin", IsForeignKey=true)]
		public Admin Admin
		{
			get
			{
				return this._Admin.Entity;
			}
			set
			{
				Admin previousValue = this._Admin.Entity;
				if (((previousValue != value) 
							|| (this._Admin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Admin.Entity = null;
						previousValue.BangTins.Remove(this);
					}
					this._Admin.Entity = value;
					if ((value != null))
					{
						value.BangTins.Add(this);
						this._MaAdmin = value.MaAdmin;
					}
					else
					{
						this._MaAdmin = default(int);
					}
					this.SendPropertyChanged("Admin");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiTin_BangTin", Storage="_LoaiTin", ThisKey="LoaiTinID", OtherKey="LoaiTinID", IsForeignKey=true)]
		public LoaiTin LoaiTin
		{
			get
			{
				return this._LoaiTin.Entity;
			}
			set
			{
				LoaiTin previousValue = this._LoaiTin.Entity;
				if (((previousValue != value) 
							|| (this._LoaiTin.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiTin.Entity = null;
						previousValue.BangTins.Remove(this);
					}
					this._LoaiTin.Entity = value;
					if ((value != null))
					{
						value.BangTins.Add(this);
						this._LoaiTinID = value.LoaiTinID;
					}
					else
					{
						this._LoaiTinID = default(int);
					}
					this.SendPropertyChanged("LoaiTin");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiTin")]
	public partial class LoaiTin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LoaiTinID;
		
		private string _TenLoaiTin;
		
		private EntitySet<BangTin> _BangTins;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLoaiTinIDChanging(int value);
    partial void OnLoaiTinIDChanged();
    partial void OnTenLoaiTinChanging(string value);
    partial void OnTenLoaiTinChanged();
    #endregion
		
		public LoaiTin()
		{
			this._BangTins = new EntitySet<BangTin>(new Action<BangTin>(this.attach_BangTins), new Action<BangTin>(this.detach_BangTins));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiTinID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int LoaiTinID
		{
			get
			{
				return this._LoaiTinID;
			}
			set
			{
				if ((this._LoaiTinID != value))
				{
					this.OnLoaiTinIDChanging(value);
					this.SendPropertyChanging();
					this._LoaiTinID = value;
					this.SendPropertyChanged("LoaiTinID");
					this.OnLoaiTinIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoaiTin", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string TenLoaiTin
		{
			get
			{
				return this._TenLoaiTin;
			}
			set
			{
				if ((this._TenLoaiTin != value))
				{
					this.OnTenLoaiTinChanging(value);
					this.SendPropertyChanging();
					this._TenLoaiTin = value;
					this.SendPropertyChanged("TenLoaiTin");
					this.OnTenLoaiTinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiTin_BangTin", Storage="_BangTins", ThisKey="LoaiTinID", OtherKey="LoaiTinID")]
		public EntitySet<BangTin> BangTins
		{
			get
			{
				return this._BangTins;
			}
			set
			{
				this._BangTins.Assign(value);
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
		
		private void attach_BangTins(BangTin entity)
		{
			this.SendPropertyChanging();
			entity.LoaiTin = this;
		}
		
		private void detach_BangTins(BangTin entity)
		{
			this.SendPropertyChanging();
			entity.LoaiTin = null;
		}
	}
}
#pragma warning restore 1591
