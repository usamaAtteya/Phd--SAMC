// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.DateTimeResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSchedulingTime
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSchedulingTime : IPersistEntity
	{
		IfcLabel? @Name { get;  set; }
		IfcDataOriginEnum? @DataOrigin { get;  set; }
		IfcLabel? @UserDefinedDataOrigin { get;  set; }
	
	}
}

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IfcSchedulingTime", 1263)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSchedulingTime : PersistEntity, IIfcSchedulingTime, IEquatable<@IfcSchedulingTime>
	{
		#region IIfcSchedulingTime explicit implementation
		IfcLabel? IIfcSchedulingTime.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcDataOriginEnum? IIfcSchedulingTime.DataOrigin { 
 
			get { return @DataOrigin; } 
			set { DataOrigin = value;}
		}	
		IfcLabel? IIfcSchedulingTime.UserDefinedDataOrigin { 
 
			get { return @UserDefinedDataOrigin; } 
			set { UserDefinedDataOrigin = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSchedulingTime(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcDataOriginEnum? _dataOrigin;
		private IfcLabel? _userDefinedDataOrigin;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 2)]
		public IfcDataOriginEnum? @DataOrigin 
		{ 
			get 
			{
				if(_activated) return _dataOrigin;
				Activate();
				return _dataOrigin;
			} 
			set
			{
				SetValue( v =>  _dataOrigin = v, _dataOrigin, value,  "DataOrigin", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcLabel? @UserDefinedDataOrigin 
		{ 
			get 
			{
				if(_activated) return _userDefinedDataOrigin;
				Activate();
				return _userDefinedDataOrigin;
			} 
			set
			{
				SetValue( v =>  _userDefinedDataOrigin = v, _userDefinedDataOrigin, value,  "UserDefinedDataOrigin", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
                    _dataOrigin = (IfcDataOriginEnum) System.Enum.Parse(typeof (IfcDataOriginEnum), value.EnumVal, true);
					return;
				case 2: 
					_userDefinedDataOrigin = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSchedulingTime other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}