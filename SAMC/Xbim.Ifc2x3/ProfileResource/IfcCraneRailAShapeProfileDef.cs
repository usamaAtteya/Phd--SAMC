// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProfileResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCraneRailAShapeProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCraneRailAShapeProfileDef : IIfcParameterizedProfileDef
	{
		IfcPositiveLengthMeasure @OverallHeight { get;  set; }
		IfcPositiveLengthMeasure @BaseWidth2 { get;  set; }
		IfcPositiveLengthMeasure? @Radius { get;  set; }
		IfcPositiveLengthMeasure @HeadWidth { get;  set; }
		IfcPositiveLengthMeasure @HeadDepth2 { get;  set; }
		IfcPositiveLengthMeasure @HeadDepth3 { get;  set; }
		IfcPositiveLengthMeasure @WebThickness { get;  set; }
		IfcPositiveLengthMeasure @BaseWidth4 { get;  set; }
		IfcPositiveLengthMeasure @BaseDepth1 { get;  set; }
		IfcPositiveLengthMeasure @BaseDepth2 { get;  set; }
		IfcPositiveLengthMeasure @BaseDepth3 { get;  set; }
		IfcPositiveLengthMeasure? @CentreOfGravityInY { get;  set; }
	
	}
}

namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IfcCraneRailAShapeProfileDef", 257)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCraneRailAShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IIfcCraneRailAShapeProfileDef, IContainsEntityReferences, IEquatable<@IfcCraneRailAShapeProfileDef>
	{
		#region IIfcCraneRailAShapeProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.OverallHeight { 
 
			get { return @OverallHeight; } 
			set { OverallHeight = value;}
		}	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.BaseWidth2 { 
 
			get { return @BaseWidth2; } 
			set { BaseWidth2 = value;}
		}	
		IfcPositiveLengthMeasure? IIfcCraneRailAShapeProfileDef.Radius { 
 
			get { return @Radius; } 
			set { Radius = value;}
		}	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.HeadWidth { 
 
			get { return @HeadWidth; } 
			set { HeadWidth = value;}
		}	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.HeadDepth2 { 
 
			get { return @HeadDepth2; } 
			set { HeadDepth2 = value;}
		}	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.HeadDepth3 { 
 
			get { return @HeadDepth3; } 
			set { HeadDepth3 = value;}
		}	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.WebThickness { 
 
			get { return @WebThickness; } 
			set { WebThickness = value;}
		}	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.BaseWidth4 { 
 
			get { return @BaseWidth4; } 
			set { BaseWidth4 = value;}
		}	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.BaseDepth1 { 
 
			get { return @BaseDepth1; } 
			set { BaseDepth1 = value;}
		}	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.BaseDepth2 { 
 
			get { return @BaseDepth2; } 
			set { BaseDepth2 = value;}
		}	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.BaseDepth3 { 
 
			get { return @BaseDepth3; } 
			set { BaseDepth3 = value;}
		}	
		IfcPositiveLengthMeasure? IIfcCraneRailAShapeProfileDef.CentreOfGravityInY { 
 
			get { return @CentreOfGravityInY; } 
			set { CentreOfGravityInY = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCraneRailAShapeProfileDef(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _overallHeight;
		private IfcPositiveLengthMeasure _baseWidth2;
		private IfcPositiveLengthMeasure? _radius;
		private IfcPositiveLengthMeasure _headWidth;
		private IfcPositiveLengthMeasure _headDepth2;
		private IfcPositiveLengthMeasure _headDepth3;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _baseWidth4;
		private IfcPositiveLengthMeasure _baseDepth1;
		private IfcPositiveLengthMeasure _baseDepth2;
		private IfcPositiveLengthMeasure _baseDepth3;
		private IfcPositiveLengthMeasure? _centreOfGravityInY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 4)]
		public IfcPositiveLengthMeasure @OverallHeight 
		{ 
			get 
			{
				if(_activated) return _overallHeight;
				Activate();
				return _overallHeight;
			} 
			set
			{
				SetValue( v =>  _overallHeight = v, _overallHeight, value,  "OverallHeight", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 5)]
		public IfcPositiveLengthMeasure @BaseWidth2 
		{ 
			get 
			{
				if(_activated) return _baseWidth2;
				Activate();
				return _baseWidth2;
			} 
			set
			{
				SetValue( v =>  _baseWidth2 = v, _baseWidth2, value,  "BaseWidth2", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public IfcPositiveLengthMeasure? @Radius 
		{ 
			get 
			{
				if(_activated) return _radius;
				Activate();
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcPositiveLengthMeasure @HeadWidth 
		{ 
			get 
			{
				if(_activated) return _headWidth;
				Activate();
				return _headWidth;
			} 
			set
			{
				SetValue( v =>  _headWidth = v, _headWidth, value,  "HeadWidth", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 8)]
		public IfcPositiveLengthMeasure @HeadDepth2 
		{ 
			get 
			{
				if(_activated) return _headDepth2;
				Activate();
				return _headDepth2;
			} 
			set
			{
				SetValue( v =>  _headDepth2 = v, _headDepth2, value,  "HeadDepth2", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 9)]
		public IfcPositiveLengthMeasure @HeadDepth3 
		{ 
			get 
			{
				if(_activated) return _headDepth3;
				Activate();
				return _headDepth3;
			} 
			set
			{
				SetValue( v =>  _headDepth3 = v, _headDepth3, value,  "HeadDepth3", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public IfcPositiveLengthMeasure @WebThickness 
		{ 
			get 
			{
				if(_activated) return _webThickness;
				Activate();
				return _webThickness;
			} 
			set
			{
				SetValue( v =>  _webThickness = v, _webThickness, value,  "WebThickness", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 11)]
		public IfcPositiveLengthMeasure @BaseWidth4 
		{ 
			get 
			{
				if(_activated) return _baseWidth4;
				Activate();
				return _baseWidth4;
			} 
			set
			{
				SetValue( v =>  _baseWidth4 = v, _baseWidth4, value,  "BaseWidth4", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 12)]
		public IfcPositiveLengthMeasure @BaseDepth1 
		{ 
			get 
			{
				if(_activated) return _baseDepth1;
				Activate();
				return _baseDepth1;
			} 
			set
			{
				SetValue( v =>  _baseDepth1 = v, _baseDepth1, value,  "BaseDepth1", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 13)]
		public IfcPositiveLengthMeasure @BaseDepth2 
		{ 
			get 
			{
				if(_activated) return _baseDepth2;
				Activate();
				return _baseDepth2;
			} 
			set
			{
				SetValue( v =>  _baseDepth2 = v, _baseDepth2, value,  "BaseDepth2", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 14)]
		public IfcPositiveLengthMeasure @BaseDepth3 
		{ 
			get 
			{
				if(_activated) return _baseDepth3;
				Activate();
				return _baseDepth3;
			} 
			set
			{
				SetValue( v =>  _baseDepth3 = v, _baseDepth3, value,  "BaseDepth3", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 15)]
		public IfcPositiveLengthMeasure? @CentreOfGravityInY 
		{ 
			get 
			{
				if(_activated) return _centreOfGravityInY;
				Activate();
				return _centreOfGravityInY;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInY = v, _centreOfGravityInY, value,  "CentreOfGravityInY", 15);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_overallHeight = value.RealVal;
					return;
				case 4: 
					_baseWidth2 = value.RealVal;
					return;
				case 5: 
					_radius = value.RealVal;
					return;
				case 6: 
					_headWidth = value.RealVal;
					return;
				case 7: 
					_headDepth2 = value.RealVal;
					return;
				case 8: 
					_headDepth3 = value.RealVal;
					return;
				case 9: 
					_webThickness = value.RealVal;
					return;
				case 10: 
					_baseWidth4 = value.RealVal;
					return;
				case 11: 
					_baseDepth1 = value.RealVal;
					return;
				case 12: 
					_baseDepth2 = value.RealVal;
					return;
				case 13: 
					_baseDepth3 = value.RealVal;
					return;
				case 14: 
					_centreOfGravityInY = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCraneRailAShapeProfileDef other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}