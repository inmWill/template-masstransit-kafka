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
	public partial class WarehouseEvent : global::Avro.Specific.ISpecificRecord
	{
		public static global::Avro.Schema _SCHEMA = global::Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"WarehouseEvent\",\"namespace\":\"Sample.Contracts\",\"fields\":" +
				"[{\"name\":\"SourceSystemId\",\"type\":\"string\",\"displayName\":\"Source System Id\",\"maxL" +
				"ength\":100},{\"name\":\"EventId\",\"type\":\"string\",\"displayName\":\"Event Id\",\"maxLengt" +
				"h\":100},{\"name\":\"Timestamp\",\"type\":\"string\",\"displayName\":\"Timestamp\",\"maxLength" +
				"\":50},{\"name\":\"Event\",\"type\":[{\"type\":\"record\",\"name\":\"ProductReceived\",\"namespa" +
				"ce\":\"Sample.Contracts\",\"fields\":[{\"name\":\"PurchaseOrderNumber\",\"type\":\"string\",\"" +
				"displayName\":\"Purchase Order Number\",\"maxLength\":100},{\"name\":\"Sku\",\"type\":\"stri" +
				"ng\",\"displayName\":\"Sku\",\"maxLength\":100},{\"name\":\"SerialNumber\",\"type\":\"string\"," +
				"\"displayName\":\"SerialNumber\",\"maxLength\":100}],\"displayName\":\"Product Received\"}" +
				",{\"type\":\"record\",\"name\":\"ProductPicked\",\"namespace\":\"Sample.Contracts\",\"fields\"" +
				":[{\"name\":\"OrderNumber\",\"type\":\"string\",\"displayName\":\"Order Number\",\"maxLength\"" +
				":100},{\"name\":\"OrderLine\",\"type\":\"long\",\"displayName\":\"OrderLine\"},{\"name\":\"Sku\"" +
				",\"type\":\"string\",\"displayName\":\"Sku\",\"maxLength\":100},{\"name\":\"SerialNumber\",\"ty" +
				"pe\":\"string\",\"displayName\":\"SerialNumber\",\"maxLength\":100},{\"name\":\"LicensePlate" +
				"Number\",\"type\":\"string\",\"displayName\":\"LicensePlateNumber\",\"maxLength\":100}],\"di" +
				"splayName\":\"Product Picked\"},{\"type\":\"record\",\"name\":\"ContainerShipped\",\"namespa" +
				"ce\":\"Sample.Contracts\",\"fields\":[{\"name\":\"OrderNumber\",\"type\":\"string\",\"displayN" +
				"ame\":\"Order Number\",\"maxLength\":100},{\"name\":\"LicensePlateNumber\",\"type\":\"string" +
				"\",\"displayName\":\"LicensePlateNumber\",\"maxLength\":100},{\"name\":\"Carrier\",\"type\":\"" +
				"string\",\"displayName\":\"Carrier\",\"maxLength\":50},{\"name\":\"TrackingNumber\",\"type\":" +
				"\"string\",\"displayName\":\"Tracking Number\",\"maxLength\":100}],\"displayName\":\"Contai" +
				"ner Shipped\"}],\"displayName\":\"Event\"}]}");
		private string _SourceSystemId;
		private string _EventId;
		private string _Timestamp;
		private object _Event;
		public virtual global::Avro.Schema Schema
		{
			get
			{
				return WarehouseEvent._SCHEMA;
			}
		}
		public string SourceSystemId
		{
			get
			{
				return this._SourceSystemId;
			}
			set
			{
				this._SourceSystemId = value;
			}
		}
		public string EventId
		{
			get
			{
				return this._EventId;
			}
			set
			{
				this._EventId = value;
			}
		}
		public string Timestamp
		{
			get
			{
				return this._Timestamp;
			}
			set
			{
				this._Timestamp = value;
			}
		}
		public object Event
		{
			get
			{
				return this._Event;
			}
			set
			{
				this._Event = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.SourceSystemId;
			case 1: return this.EventId;
			case 2: return this.Timestamp;
			case 3: return this.Event;
			default: throw new global::Avro.AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.SourceSystemId = (System.String)fieldValue; break;
			case 1: this.EventId = (System.String)fieldValue; break;
			case 2: this.Timestamp = (System.String)fieldValue; break;
			case 3: this.Event = (System.Object)fieldValue; break;
			default: throw new global::Avro.AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
