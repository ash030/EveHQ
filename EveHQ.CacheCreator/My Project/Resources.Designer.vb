﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("EveHQ.CacheCreator.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to attributeID,attributeGroup
        '''9,1
        '''70,1
        '''283,1
        '''265,2
        '''267,2
        '''268,2
        '''269,2
        '''270,2
        '''263,3
        '''479,3
        '''271,3
        '''272,3
        '''273,3
        '''274,3
        '''482,4
        '''55,4
        '''76,5
        '''79,5
        '''192,5
        '''208,5
        '''209,5
        '''210,5
        '''211,5
        '''552,5
        '''564,5
        '''37,6
        '''819,6
        '''820,6
        '''821,6
        '''822,6
        '''182,7
        '''183,7
        '''184,7
        '''277,7
        '''278,7
        '''279,7
        '''11,8
        '''12,8
        '''13,8
        '''14,8
        '''48,8
        '''101,8
        '''102,8
        '''114,9
        '''116,9
        '''117,9
        '''118,9
        '''51,9
        '''64,9
        '''506,9
        '''507,9
        '''54,10
        '''158,10
        '''193,10
        '''247,10
        '''481,11
        '''252,11
        '''562,11
        '''504,12
        '''103,12
        '''105,12
        '''20,12
        '''6,13
        '''30,13
        '''50,13
        '''73,13
        '''180,14
        '''181,14
        '''275,14
        '''.
        '''</summary>
        Friend ReadOnly Property attributeGroups() As String
            Get
                Return ResourceManager.GetString("attributeGroups", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property certificates() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("certificates", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property iconIDs() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("iconIDs", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to CREATE TABLE invBuildMaterials (
        ''' typeID INTEGER,	--	id of blueprint using this material
        ''' activityID INTEGER,	--	building, copying, etc
        ''' requiredTypeID INTEGER,	--	id of resource used for this activity
        ''' quantity INTEGER,	--	how many of this resource is used
        ''' damagePerJob FLOAT,	--	how much of the resource is expended
        ''' baseMaterial INTEGER,	--	how much is the base material.  0 means unaffected by waste, &gt;=quantity means entirely affected
        ''' PRIMARY KEY (typeID, activityID, requiredTypeID)
        ''');
        '''
        '''INSERT  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property SQLQueries() As String
            Get
                Return ResourceManager.GetString("SQLQueries", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property typeIDs() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("typeIDs", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
    End Module
End Namespace