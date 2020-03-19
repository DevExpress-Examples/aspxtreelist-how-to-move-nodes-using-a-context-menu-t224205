﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Northwind")>  _
Partial Public Class NorthwindDataClassesDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertEmployee(instance As Employee)
    End Sub
  Partial Private Sub UpdateEmployee(instance As Employee)
    End Sub
  Partial Private Sub DeleteEmployee(instance As Employee)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("NorthwindConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Employees() As System.Data.Linq.Table(Of Employee)
		Get
			Return Me.GetTable(Of Employee)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Employees")>  _
Partial Public Class Employee
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _EmployeeID As Integer
	
	Private _LastName As String
	
	Private _FirstName As String
	
	Private _Title As String
	
	Private _TitleOfCourtesy As String
	
	Private _BirthDate As System.Nullable(Of Date)
	
	Private _HireDate As System.Nullable(Of Date)
	
	Private _Address As String
	
	Private _City As String
	
	Private _Region As String
	
	Private _PostalCode As String
	
	Private _Country As String
	
	Private _HomePhone As String
	
	Private _Extension As String
	
	Private _Photo As System.Data.Linq.Binary
	
	Private _Notes As String
	
	Private _ReportsTo As System.Nullable(Of Integer)
	
	Private _PhotoPath As String
	
	Private _Employees As EntitySet(Of Employee)
	
	Private _Employee1 As EntityRef(Of Employee)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnEmployeeIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnEmployeeIDChanged()
    End Sub
    Partial Private Sub OnLastNameChanging(value As String)
    End Sub
    Partial Private Sub OnLastNameChanged()
    End Sub
    Partial Private Sub OnFirstNameChanging(value As String)
    End Sub
    Partial Private Sub OnFirstNameChanged()
    End Sub
    Partial Private Sub OnTitleChanging(value As String)
    End Sub
    Partial Private Sub OnTitleChanged()
    End Sub
    Partial Private Sub OnTitleOfCourtesyChanging(value As String)
    End Sub
    Partial Private Sub OnTitleOfCourtesyChanged()
    End Sub
    Partial Private Sub OnBirthDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnBirthDateChanged()
    End Sub
    Partial Private Sub OnHireDateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnHireDateChanged()
    End Sub
    Partial Private Sub OnAddressChanging(value As String)
    End Sub
    Partial Private Sub OnAddressChanged()
    End Sub
    Partial Private Sub OnCityChanging(value As String)
    End Sub
    Partial Private Sub OnCityChanged()
    End Sub
    Partial Private Sub OnRegionChanging(value As String)
    End Sub
    Partial Private Sub OnRegionChanged()
    End Sub
    Partial Private Sub OnPostalCodeChanging(value As String)
    End Sub
    Partial Private Sub OnPostalCodeChanged()
    End Sub
    Partial Private Sub OnCountryChanging(value As String)
    End Sub
    Partial Private Sub OnCountryChanged()
    End Sub
    Partial Private Sub OnHomePhoneChanging(value As String)
    End Sub
    Partial Private Sub OnHomePhoneChanged()
    End Sub
    Partial Private Sub OnExtensionChanging(value As String)
    End Sub
    Partial Private Sub OnExtensionChanged()
    End Sub
    Partial Private Sub OnPhotoChanging(value As System.Data.Linq.Binary)
    End Sub
    Partial Private Sub OnPhotoChanged()
    End Sub
    Partial Private Sub OnNotesChanging(value As String)
    End Sub
    Partial Private Sub OnNotesChanged()
    End Sub
    Partial Private Sub OnReportsToChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnReportsToChanged()
    End Sub
    Partial Private Sub OnPhotoPathChanging(value As String)
    End Sub
    Partial Private Sub OnPhotoPathChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Employees = New EntitySet(Of Employee)(AddressOf Me.attach_Employees, AddressOf Me.detach_Employees)
		Me._Employee1 = CType(Nothing, EntityRef(Of Employee))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EmployeeID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property EmployeeID() As Integer
		Get
			Return Me._EmployeeID
		End Get
		Set
			If ((Me._EmployeeID = value)  _
						= false) Then
				Me.OnEmployeeIDChanging(value)
				Me.SendPropertyChanging
				Me._EmployeeID = value
				Me.SendPropertyChanged("EmployeeID")
				Me.OnEmployeeIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LastName", DbType:="NVarChar(20) NOT NULL", CanBeNull:=false)>  _
	Public Property LastName() As String
		Get
			Return Me._LastName
		End Get
		Set
			If (String.Equals(Me._LastName, value) = false) Then
				Me.OnLastNameChanging(value)
				Me.SendPropertyChanging
				Me._LastName = value
				Me.SendPropertyChanged("LastName")
				Me.OnLastNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FirstName", DbType:="NVarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property FirstName() As String
		Get
			Return Me._FirstName
		End Get
		Set
			If (String.Equals(Me._FirstName, value) = false) Then
				Me.OnFirstNameChanging(value)
				Me.SendPropertyChanging
				Me._FirstName = value
				Me.SendPropertyChanged("FirstName")
				Me.OnFirstNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Title", DbType:="NVarChar(30)")>  _
	Public Property Title() As String
		Get
			Return Me._Title
		End Get
		Set
			If (String.Equals(Me._Title, value) = false) Then
				Me.OnTitleChanging(value)
				Me.SendPropertyChanging
				Me._Title = value
				Me.SendPropertyChanged("Title")
				Me.OnTitleChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TitleOfCourtesy", DbType:="NVarChar(25)")>  _
	Public Property TitleOfCourtesy() As String
		Get
			Return Me._TitleOfCourtesy
		End Get
		Set
			If (String.Equals(Me._TitleOfCourtesy, value) = false) Then
				Me.OnTitleOfCourtesyChanging(value)
				Me.SendPropertyChanging
				Me._TitleOfCourtesy = value
				Me.SendPropertyChanged("TitleOfCourtesy")
				Me.OnTitleOfCourtesyChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BirthDate", DbType:="DateTime")>  _
	Public Property BirthDate() As System.Nullable(Of Date)
		Get
			Return Me._BirthDate
		End Get
		Set
			If (Me._BirthDate.Equals(value) = false) Then
				Me.OnBirthDateChanging(value)
				Me.SendPropertyChanging
				Me._BirthDate = value
				Me.SendPropertyChanged("BirthDate")
				Me.OnBirthDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_HireDate", DbType:="DateTime")>  _
	Public Property HireDate() As System.Nullable(Of Date)
		Get
			Return Me._HireDate
		End Get
		Set
			If (Me._HireDate.Equals(value) = false) Then
				Me.OnHireDateChanging(value)
				Me.SendPropertyChanging
				Me._HireDate = value
				Me.SendPropertyChanged("HireDate")
				Me.OnHireDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="NVarChar(60)")>  _
	Public Property Address() As String
		Get
			Return Me._Address
		End Get
		Set
			If (String.Equals(Me._Address, value) = false) Then
				Me.OnAddressChanging(value)
				Me.SendPropertyChanging
				Me._Address = value
				Me.SendPropertyChanged("Address")
				Me.OnAddressChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_City", DbType:="NVarChar(15)")>  _
	Public Property City() As String
		Get
			Return Me._City
		End Get
		Set
			If (String.Equals(Me._City, value) = false) Then
				Me.OnCityChanging(value)
				Me.SendPropertyChanging
				Me._City = value
				Me.SendPropertyChanged("City")
				Me.OnCityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Region", DbType:="NVarChar(15)")>  _
	Public Property Region() As String
		Get
			Return Me._Region
		End Get
		Set
			If (String.Equals(Me._Region, value) = false) Then
				Me.OnRegionChanging(value)
				Me.SendPropertyChanging
				Me._Region = value
				Me.SendPropertyChanged("Region")
				Me.OnRegionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PostalCode", DbType:="NVarChar(10)")>  _
	Public Property PostalCode() As String
		Get
			Return Me._PostalCode
		End Get
		Set
			If (String.Equals(Me._PostalCode, value) = false) Then
				Me.OnPostalCodeChanging(value)
				Me.SendPropertyChanging
				Me._PostalCode = value
				Me.SendPropertyChanged("PostalCode")
				Me.OnPostalCodeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Country", DbType:="NVarChar(15)")>  _
	Public Property Country() As String
		Get
			Return Me._Country
		End Get
		Set
			If (String.Equals(Me._Country, value) = false) Then
				Me.OnCountryChanging(value)
				Me.SendPropertyChanging
				Me._Country = value
				Me.SendPropertyChanged("Country")
				Me.OnCountryChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_HomePhone", DbType:="NVarChar(24)")>  _
	Public Property HomePhone() As String
		Get
			Return Me._HomePhone
		End Get
		Set
			If (String.Equals(Me._HomePhone, value) = false) Then
				Me.OnHomePhoneChanging(value)
				Me.SendPropertyChanging
				Me._HomePhone = value
				Me.SendPropertyChanged("HomePhone")
				Me.OnHomePhoneChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Extension", DbType:="NVarChar(4)")>  _
	Public Property Extension() As String
		Get
			Return Me._Extension
		End Get
		Set
			If (String.Equals(Me._Extension, value) = false) Then
				Me.OnExtensionChanging(value)
				Me.SendPropertyChanging
				Me._Extension = value
				Me.SendPropertyChanged("Extension")
				Me.OnExtensionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Photo", DbType:="Image", CanBeNull:=true, UpdateCheck:=UpdateCheck.Never)>  _
	Public Property Photo() As System.Data.Linq.Binary
		Get
			Return Me._Photo
		End Get
		Set
			If (Object.Equals(Me._Photo, value) = false) Then
				Me.OnPhotoChanging(value)
				Me.SendPropertyChanging
				Me._Photo = value
				Me.SendPropertyChanged("Photo")
				Me.OnPhotoChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Notes", DbType:="NText", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property Notes() As String
		Get
			Return Me._Notes
		End Get
		Set
			If (String.Equals(Me._Notes, value) = false) Then
				Me.OnNotesChanging(value)
				Me.SendPropertyChanging
				Me._Notes = value
				Me.SendPropertyChanged("Notes")
				Me.OnNotesChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ReportsTo", DbType:="Int")>  _
	Public Property ReportsTo() As System.Nullable(Of Integer)
		Get
			Return Me._ReportsTo
		End Get
		Set
			If (Me._ReportsTo.Equals(value) = false) Then
				If Me._Employee1.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnReportsToChanging(value)
				Me.SendPropertyChanging
				Me._ReportsTo = value
				Me.SendPropertyChanged("ReportsTo")
				Me.OnReportsToChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PhotoPath", DbType:="NVarChar(255)")>  _
	Public Property PhotoPath() As String
		Get
			Return Me._PhotoPath
		End Get
		Set
			If (String.Equals(Me._PhotoPath, value) = false) Then
				Me.OnPhotoPathChanging(value)
				Me.SendPropertyChanging
				Me._PhotoPath = value
				Me.SendPropertyChanged("PhotoPath")
				Me.OnPhotoPathChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Employee_Employee", Storage:="_Employees", ThisKey:="EmployeeID", OtherKey:="ReportsTo")>  _
	Public Property Employees() As EntitySet(Of Employee)
		Get
			Return Me._Employees
		End Get
		Set
			Me._Employees.Assign(value)
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Employee_Employee", Storage:="_Employee1", ThisKey:="ReportsTo", OtherKey:="EmployeeID", IsForeignKey:=true)>  _
	Public Property Employee1() As Employee
		Get
			Return Me._Employee1.Entity
		End Get
		Set
			Dim previousValue As Employee = Me._Employee1.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Employee1.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Employee1.Entity = Nothing
					previousValue.Employees.Remove(Me)
				End If
				Me._Employee1.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Employees.Add(Me)
					Me._ReportsTo = value.EmployeeID
				Else
					Me._ReportsTo = CType(Nothing, Nullable(Of Integer))
				End If
				Me.SendPropertyChanged("Employee1")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Employees(ByVal entity As Employee)
		Me.SendPropertyChanging
		entity.Employee1 = Me
	End Sub
	
	Private Sub detach_Employees(ByVal entity As Employee)
		Me.SendPropertyChanging
		entity.Employee1 = Nothing
	End Sub
End Class
