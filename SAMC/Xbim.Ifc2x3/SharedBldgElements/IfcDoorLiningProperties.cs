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
using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDoorLiningProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDoorLiningProperties : IIfcPropertySetDefinition
	{
		IfcPositiveLengthMeasure? @LiningDepth { get;  set; }
		IfcPositiveLengthMeasure? @LiningThickness { get;  set; }
		IfcPositiveLengthMeasure? @ThresholdDepth { get;  set; }
		IfcPositiveLengthMeasure? @ThresholdThickness { get;  set; }
		IfcPositiveLengthMeasure? @TransomThickness { get;  set; }
		IfcLengthMeasure? @TransomOffset { get;  set; }
		IfcLengthMeasure? @LiningOffset { get;  set; }
		IfcLengthMeasure? @ThresholdOffset { get;  set; }
		IfcPositiveLengthMeasure? @CasingThickness { get;  set; }
		IfcPositiveLengthMeasure? @CasingDepth { get;  set; }
		IIfcShapeAspect @ShapeAspectStyle { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[ExpressType("IfcDoorLiningProperties", 493)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDoorLiningProperties : IfcPropertySetDefinition, IInstantiableEntity, IIfcDoorLiningProperties, IContainsEntityReferences, IEquatable<@IfcDoorLiningProperties>
	{
		#region IIfcDoorLiningProperties explicit implementation
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.LiningDepth { 
 
			get { return @LiningDepth; } 
			set { LiningDepth = value;}
		}	
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.LiningThickness { 
 
			get { return @LiningThickness; } 
			set { LiningThickness = value;}
		}	
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.ThresholdDepth { 
 
			get { return @ThresholdDepth; } 
			set { ThresholdDepth = value;}
		}	
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.ThresholdThickness { 
 
			get { return @ThresholdThickness; } 
			set { ThresholdThickness = value;}
		}	
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.TransomThickness { 
 
			get { return @TransomThickness; } 
			set { TransomThickness = value;}
		}	
		IfcLengthMeasure? IIfcDoorLiningProperties.TransomOffset { 
 
			get { return @TransomOffset; } 
			set { TransomOffset = value;}
		}	
		IfcLengthMeasure? IIfcDoorLiningProperties.LiningOffset { 
 
			get { return @LiningOffset; } 
			set { LiningOffset = value;}
		}	
		IfcLengthMeasure? IIfcDoorLiningProperties.ThresholdOffset { 
 
			get { return @ThresholdOffset; } 
			set { ThresholdOffset = value;}
		}	
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.CasingThickness { 
 
			get { return @CasingThickness; } 
			set { CasingThickness = value;}
		}	
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.CasingDepth { 
 
			get { return @CasingDepth; } 
			set { CasingDepth = value;}
		}	
		IIfcShapeAspect IIfcDoorLiningProperties.ShapeAspectStyle { 
 
 
			get { return @ShapeAspectStyle; } 
			set { ShapeAspectStyle = value as IfcShapeAspect;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDoorLiningProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _liningDepth;
		private IfcPositiveLengthMeasure? _liningThickness;
		private IfcPositiveLengthMeasure? _thresholdDepth;
		private IfcPositiveLengthMeasure? _thresholdThickness;
		private IfcPositiveLengthMeasure? _transomThickness;
		private IfcLengthMeasure? _transomOffset;
		private IfcLengthMeasure? _liningOffset;
		private IfcLengthMeasure? _thresholdOffset;
		private IfcPositiveLengthMeasure? _casingThickness;
		private IfcPositiveLengthMeasure? _casingDepth;
		private IfcShapeAspect _shapeAspectStyle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcPositiveLengthMeasure? @LiningDepth 
		{ 
			get 
			{
				if(_activated) return _liningDepth;
				Activate();
				return _liningDepth;
			} 
			set
			{
				SetValue( v =>  _liningDepth = v, _liningDepth, value,  "LiningDepth", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcPositiveLengthMeasure? @LiningThickness 
		{ 
			get 
			{
				if(_activated) return _liningThickness;
				Activate();
				return _liningThickness;
			} 
			set
			{
				SetValue( v =>  _liningThickness = v, _liningThickness, value,  "LiningThickness", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public IfcPositiveLengthMeasure? @ThresholdDepth 
		{ 
			get 
			{
				if(_activated) return _thresholdDepth;
				Activate();
				return _thresholdDepth;
			} 
			set
			{
				SetValue( v =>  _thresholdDepth = v, _thresholdDepth, value,  "ThresholdDepth", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public IfcPositiveLengthMeasure? @ThresholdThickness 
		{ 
			get 
			{
				if(_activated) return _thresholdThickness;
				Activate();
				return _thresholdThickness;
			} 
			set
			{
				SetValue( v =>  _thresholdThickness = v, _thresholdThickness, value,  "ThresholdThickness", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcPositiveLengthMeasure? @TransomThickness 
		{ 
			get 
			{
				if(_activated) return _transomThickness;
				Activate();
				return _transomThickness;
			} 
			set
			{
				SetValue( v =>  _transomThickness = v, _transomThickness, value,  "TransomThickness", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public IfcLengthMeasure? @TransomOffset 
		{ 
			get 
			{
				if(_activated) return _transomOffset;
				Activate();
				return _transomOffset;
			} 
			set
			{
				SetValue( v =>  _transomOffset = v, _transomOffset, value,  "TransomOffset", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 14)]
		public IfcLengthMeasure? @LiningOffset 
		{ 
			get 
			{
				if(_activated) return _liningOffset;
				Activate();
				return _liningOffset;
			} 
			set
			{
				SetValue( v =>  _liningOffset = v, _liningOffset, value,  "LiningOffset", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 15)]
		public IfcLengthMeasure? @ThresholdOffset 
		{ 
			get 
			{
				if(_activated) return _thresholdOffset;
				Activate();
				return _thresholdOffset;
			} 
			set
			{
				SetValue( v =>  _thresholdOffset = v, _thresholdOffset, value,  "ThresholdOffset", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 16)]
		public IfcPositiveLengthMeasure? @CasingThickness 
		{ 
			get 
			{
				if(_activated) return _casingThickness;
				Activate();
				return _casingThickness;
			} 
			set
			{
				SetValue( v =>  _casingThickness = v, _casingThickness, value,  "CasingThickness", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 17)]
		public IfcPositiveLengthMeasure? @CasingDepth 
		{ 
			get 
			{
				if(_activated) return _casingDepth;
				Activate();
				return _casingDepth;
			} 
			set
			{
				SetValue( v =>  _casingDepth = v, _casingDepth, value,  "CasingDepth", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 18)]
		public IfcShapeAspect @ShapeAspectStyle 
		{ 
			get 
			{
				if(_activated) return _shapeAspectStyle;
				Activate();
				return _shapeAspectStyle;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _shapeAspectStyle = v, _shapeAspectStyle, value,  "ShapeAspectStyle", 15);
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
					_liningDepth = value.RealVal;
					return;
				case 5: 
					_liningThickness = value.RealVal;
					return;
				case 6: 
					_thresholdDepth = value.RealVal;
					return;
				case 7: 
					_thresholdThickness = value.RealVal;
					return;
				case 8: 
					_transomThickness = value.RealVal;
					return;
				case 9: 
					_transomOffset = value.RealVal;
					return;
				case 10: 
					_liningOffset = value.RealVal;
					return;
				case 11: 
					_thresholdOffset = value.RealVal;
					return;
				case 12: 
					_casingThickness = value.RealVal;
					return;
				case 13: 
					_casingDepth = value.RealVal;
					return;
				case 14: 
					_shapeAspectStyle = (IfcShapeAspect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDoorLiningProperties other)
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
				if (@ShapeAspectStyle != null)
					yield return @ShapeAspectStyle;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}