// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedFacilitiesElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcServiceLifeFactor
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcServiceLifeFactor : IIfcPropertySetDefinition
	{
		IfcServiceLifeFactorTypeEnum @PredefinedType { get;  set; }
		IIfcMeasureValue @UpperValue { get;  set; }
		IIfcMeasureValue @MostUsedValue { get;  set; }
		IIfcMeasureValue @LowerValue { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	[ExpressType("IfcServiceLifeFactor", 770)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcServiceLifeFactor : IfcPropertySetDefinition, IInstantiableEntity, IIfcServiceLifeFactor, IContainsEntityReferences, IEquatable<@IfcServiceLifeFactor>
	{
		#region IIfcServiceLifeFactor explicit implementation
		IfcServiceLifeFactorTypeEnum IIfcServiceLifeFactor.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		IIfcMeasureValue IIfcServiceLifeFactor.UpperValue { 
 
 
			get { return @UpperValue; } 
			set { UpperValue = value as IfcMeasureValue;}
		}	
		IIfcMeasureValue IIfcServiceLifeFactor.MostUsedValue { 
 
 
			get { return @MostUsedValue; } 
			set { MostUsedValue = value as IfcMeasureValue;}
		}	
		IIfcMeasureValue IIfcServiceLifeFactor.LowerValue { 
 
 
			get { return @LowerValue; } 
			set { LowerValue = value as IfcMeasureValue;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcServiceLifeFactor(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcServiceLifeFactorTypeEnum _predefinedType;
		private IfcMeasureValue _upperValue;
		private IfcMeasureValue _mostUsedValue;
		private IfcMeasureValue _lowerValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 8)]
		public IfcServiceLifeFactorTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 9)]
		public IfcMeasureValue @UpperValue 
		{ 
			get 
			{
				if(_activated) return _upperValue;
				Activate();
				return _upperValue;
			} 
			set
			{
				SetValue( v =>  _upperValue = v, _upperValue, value,  "UpperValue", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 10)]
		public IfcMeasureValue @MostUsedValue 
		{ 
			get 
			{
				if(_activated) return _mostUsedValue;
				Activate();
				return _mostUsedValue;
			} 
			set
			{
				SetValue( v =>  _mostUsedValue = v, _mostUsedValue, value,  "MostUsedValue", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 11)]
		public IfcMeasureValue @LowerValue 
		{ 
			get 
			{
				if(_activated) return _lowerValue;
				Activate();
				return _lowerValue;
			} 
			set
			{
				SetValue( v =>  _lowerValue = v, _lowerValue, value,  "LowerValue", 8);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
                    _predefinedType = (IfcServiceLifeFactorTypeEnum) System.Enum.Parse(typeof (IfcServiceLifeFactorTypeEnum), value.EnumVal, true);
					return;
				case 5: 
					_upperValue = (IfcMeasureValue)(value.EntityVal);
					return;
				case 6: 
					_mostUsedValue = (IfcMeasureValue)(value.EntityVal);
					return;
				case 7: 
					_lowerValue = (IfcMeasureValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcServiceLifeFactor other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}