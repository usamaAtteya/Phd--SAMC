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
using Xbim.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTriangulatedFaceSet
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTriangulatedFaceSet : IIfcTessellatedFaceSet
	{
		IItemSet<IItemSet<IfcParameterValue>> @Normals { get; }
		IfcBoolean? @Closed { get;  set; }
		IItemSet<IItemSet<IfcPositiveInteger>> @CoordIndex { get; }
		IItemSet<IfcPositiveInteger> @PnIndex { get; }
		IfcInteger @NumberOfTriangles  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometricModelResource
{
	[ExpressType("IfcTriangulatedFaceSet", 1304)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTriangulatedFaceSet : IfcTessellatedFaceSet, IInstantiableEntity, IIfcTriangulatedFaceSet, IContainsEntityReferences, IEquatable<@IfcTriangulatedFaceSet>
	{
		#region IIfcTriangulatedFaceSet explicit implementation
		IItemSet<IItemSet<IfcParameterValue>> IIfcTriangulatedFaceSet.Normals { 
			get { return @Normals; } 
		}	
		IfcBoolean? IIfcTriangulatedFaceSet.Closed { 
 
			get { return @Closed; } 
			set { Closed = value;}
		}	
		IItemSet<IItemSet<IfcPositiveInteger>> IIfcTriangulatedFaceSet.CoordIndex { 
			get { return @CoordIndex; } 
		}	
		IItemSet<IfcPositiveInteger> IIfcTriangulatedFaceSet.PnIndex { 
			get { return @PnIndex; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTriangulatedFaceSet(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_normals = new OptionalItemSet<IItemSet<IfcParameterValue>>( this, 0,  2);
			_coordIndex = new ItemSet<IItemSet<IfcPositiveInteger>>( this, 0,  4);
			_pnIndex = new OptionalItemSet<IfcPositiveInteger>( this, 0,  5);
		}

		#region Explicit attribute fields
		private readonly OptionalItemSet<IItemSet<IfcParameterValue>> _normals;
		private IfcBoolean? _closed;
		private readonly ItemSet<IItemSet<IfcPositiveInteger>> _coordIndex;
		private readonly OptionalItemSet<IfcPositiveInteger> _pnIndex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.List, 3, 3, 6)]
		public IOptionalItemSet<IItemSet<IfcParameterValue>> @Normals 
		{ 
			get 
			{
				if(_activated) return _normals;
				Activate();
				return _normals;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public IfcBoolean? @Closed 
		{ 
			get 
			{
				if(_activated) return _closed;
				Activate();
				return _closed;
			} 
			set
			{
				SetValue( v =>  _closed = v, _closed, value,  "Closed", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, 3, 3, 8)]
		public IItemSet<IItemSet<IfcPositiveInteger>> @CoordIndex 
		{ 
			get 
			{
				if(_activated) return _coordIndex;
				Activate();
				return _coordIndex;
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1, 9)]
		public IOptionalItemSet<IfcPositiveInteger> @PnIndex 
		{ 
			get 
			{
				if(_activated) return _pnIndex;
				Activate();
				return _pnIndex;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public IfcInteger @NumberOfTriangles 
		{
			get 
			{
				//## Getter for NumberOfTriangles
			    return CoordIndex.Count;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					((ItemSet<IfcParameterValue>)_normals
						.InternalGetAt(nestedIndex[0]) )
						.InternalAdd((IfcParameterValue)(value.RealVal));
					return;
				case 2: 
					_closed = value.BooleanVal;
					return;
				case 3: 
					((ItemSet<IfcPositiveInteger>)_coordIndex
						.InternalGetAt(nestedIndex[0]) )
						.InternalAdd((IfcPositiveInteger)(value.IntegerVal));
					return;
				case 4: 
					_pnIndex.InternalAdd(value.IntegerVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTriangulatedFaceSet other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Coordinates != null)
					yield return @Coordinates;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}