// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.11.1
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Sample.Contracts
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Avro;
	using global::Avro.Specific;
	
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("avrogen", "1.11.1")]
	public partial class Product : global::Avro.Specific.ISpecificRecord
	{
		public static global::Avro.Schema _SCHEMA = global::Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Product\",\"namespace\":\"Sample.Contracts\",\"fields\":[{\"name" +
				"\":\"Sku\",\"type\":\"string\",\"displayName\":\"Sku\",\"maxLength\":100},{\"name\":\"SerialNumb" +
				"er\",\"type\":\"string\",\"displayName\":\"SerialNumber\",\"maxLength\":100}],\"displayName\"" +
				":\"Product\"}");
		private string _Sku;
		private string _SerialNumber;
		public virtual global::Avro.Schema Schema
		{
			get
			{
				return Product._SCHEMA;
			}
		}
		public string Sku
		{
			get
			{
				return this._Sku;
			}
			set
			{
				this._Sku = value;
			}
		}
		public string SerialNumber
		{
			get
			{
				return this._SerialNumber;
			}
			set
			{
				this._SerialNumber = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.Sku;
			case 1: return this.SerialNumber;
			default: throw new global::Avro.AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.Sku = (System.String)fieldValue; break;
			case 1: this.SerialNumber = (System.String)fieldValue; break;
			default: throw new global::Avro.AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
