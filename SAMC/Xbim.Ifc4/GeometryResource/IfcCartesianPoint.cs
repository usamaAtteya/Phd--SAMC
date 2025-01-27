// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCartesianPoint
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCartesianPoint : IIfcPoint, IfcTrimmingSelect
	{
		IItemSet<IfcLengthMeasure> @Coordinates { get; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcCartesianPoint", 410)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianPoint : IfcPoint, IInstantiableEntity, IIfcCartesianPoint, IEquatable<@IfcCartesianPoint>
	{
		#region IIfcCartesianPoint explicit implementation
		IItemSet<IfcLengthMeasure> IIfcCartesianPoint.Coordinates { 
			get { return @Coordinates; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianPoint(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_coordinates = new ItemSet<IfcLengthMeasure>( this, 3,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcLengthMeasure> _coordinates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 1, 3, 3)]
		public IItemSet<IfcLengthMeasure> @Coordinates 
		{ 
			get 
			{
				if(_activated) return _coordinates;
				Activate();
				return _coordinates;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
                return Coordinates.Count;
				//##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_coordinates.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianPoint other)
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