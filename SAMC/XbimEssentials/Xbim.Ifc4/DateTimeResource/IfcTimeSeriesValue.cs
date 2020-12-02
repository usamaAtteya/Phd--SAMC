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
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.DateTimeResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTimeSeriesValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTimeSeriesValue : IPersistEntity
	{
		IItemSet<IIfcValue> @ListValues { get; }
	
	}
}

namespace Xbim.Ifc4.DateTimeResource
{
	[ExpressType("IfcTimeSeriesValue", 35)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTimeSeriesValue : PersistEntity, IInstantiableEntity, IIfcTimeSeriesValue, IEquatable<@IfcTimeSeriesValue>
	{
		#region IIfcTimeSeriesValue explicit implementation
		IItemSet<IIfcValue> IIfcTimeSeriesValue.ListValues { 
			get { return new Common.Collections.ProxyItemSet<IfcValue, IIfcValue>( @ListValues); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTimeSeriesValue(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_listValues = new ItemSet<IfcValue>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcValue> _listValues;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1, 1)]
		public IItemSet<IfcValue> @ListValues 
		{ 
			get 
			{
				if(_activated) return _listValues;
				Activate();
				return _listValues;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_listValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTimeSeriesValue other)
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