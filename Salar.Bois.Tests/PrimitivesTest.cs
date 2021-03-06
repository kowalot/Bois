﻿using System;
using System.Collections.Generic;
using System.IO;
using ReflectionMagic;
using Salar.Bois;
using SharpTestsEx;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Salar.Bois.Tests
{
	[TestClass]
	public class PrimitivesTest
	{
		private BoisSerializer _boisSerializer;
		private dynamic bion;
		private MemoryStream bionStream;
		private BinaryReader bionReader;
		private BinaryWriter bionWriter;

		[TestInitialize]
		public void Initialize()
		{
			_boisSerializer = new BoisSerializer();
			bion = _boisSerializer.AsDynamic();
			bionStream = new MemoryStream();
			bionReader = new BinaryReader(bionStream);
			bionWriter = new BinaryWriter(bionStream);
		}

		void ResetStream()
		{
			bionStream.Seek(0, SeekOrigin.Begin);
		}

		[TestMethod]
		public void Numbers_Int_Normal()
		{
			ResetStream();
			int init = 250;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (int)bion.ReadMember(bionReader, typeof(int));

			final.Should().Be.EqualTo(init);
		}
		[TestMethod]
		public void Numbers_Int_Normal_2()
		{
			ResetStream();
			int init = 11;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (int)bion.ReadMember(bionReader, typeof(int));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Int_Nullable()
		{
			ResetStream();
			int? init = null;
			bion.WriteValue(bionWriter, init, typeof(int?));
			ResetStream();

			var final = (int?)bion.ReadMember(bionReader, typeof(int?));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_UInt_Normal()
		{
			ResetStream();
			uint init = 250;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (uint)bion.ReadMember(bionReader, typeof(uint));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_UInt_Normal_2()
		{
			ResetStream();
			uint init = 6;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (uint)bion.ReadMember(bionReader, typeof(uint));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_UInt_Nullable()
		{
			ResetStream();
			uint? init = null;
			bion.WriteValue(bionWriter, init, typeof(uint?));
			ResetStream();

			var final = (uint?)bion.ReadMember(bionReader, typeof(uint?));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Short_Normal()
		{
			ResetStream();
			short init = 250;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (short)bion.ReadMember(bionReader, typeof(short));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Short_Normal_2()
		{
			ResetStream();
			short init = 23;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (short)bion.ReadMember(bionReader, typeof(short));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Short_Nullable()
		{
			ResetStream();
			short? init = null;
			bion.WriteValue(bionWriter, init, typeof(short?));
			ResetStream();

			var final = (short?)bion.ReadMember(bionReader, typeof(short?));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_UShort_Normal()
		{
			ResetStream();
			ushort init = 250;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (ushort)bion.ReadMember(bionReader, typeof(ushort));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_UShort_Normal_2()
		{
			ResetStream();
			ushort init = 24;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (ushort)bion.ReadMember(bionReader, typeof(ushort));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_UShort_Nullable()
		{
			ResetStream();
			ushort? init = null;
			bion.WriteValue(bionWriter, init, typeof(ushort?));
			ResetStream();

			var final = (ushort?)bion.ReadMember(bionReader, typeof(ushort?));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Byte_Normal()
		{
			ResetStream();
			byte init = 250;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (byte)bion.ReadMember(bionReader, typeof(byte));

			final.Should().Be.EqualTo(init);
		}


		[TestMethod]
		public void Numbers_Byte_Nullable()
		{
			ResetStream();
			byte? init = null;
			bion.WriteValue(bionWriter, init, typeof(byte?));
			ResetStream();

			var final = (byte?)bion.ReadMember(bionReader, typeof(byte?));

			final.Should().Be.EqualTo(init);
		}
		[TestMethod]
		public void Numbers_SByte_Normal()
		{
			ResetStream();
			sbyte init = 122;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (sbyte)bion.ReadMember(bionReader, typeof(sbyte));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_SByte_Nullable()
		{
			ResetStream();
			sbyte? init = null;
			bion.WriteValue(bionWriter, init, typeof(sbyte?));
			ResetStream();

			var final = (sbyte?)bion.ReadMember(bionReader, typeof(sbyte?));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Int64_Normal()
		{
			ResetStream();
			long init = 250;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (long)bion.ReadMember(bionReader, typeof(long));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Int64_Normal_2()
		{
			ResetStream();
			long init = 16;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (long)bion.ReadMember(bionReader, typeof(long));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Int64_Nullable()
		{
			ResetStream();
			long? init = null;
			bion.WriteValue(bionWriter, init, typeof(long?));
			ResetStream();

			var final = (long?)bion.ReadMember(bionReader, typeof(long?));

			final.Should().Be.EqualTo(init);
		}
		[TestMethod]
		public void Numbers_UInt64_Normal()
		{
			ResetStream();
			ulong init = 250;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (ulong)bion.ReadMember(bionReader, typeof(ulong));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_UInt64_Normal_2()
		{
			ResetStream();
			ulong init = 17;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (ulong)bion.ReadMember(bionReader, typeof(ulong));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_UInt64_Nullable()
		{
			ResetStream();
			ulong? init = null;
			bion.WriteValue(bionWriter, init, typeof(ulong?));
			ResetStream();

			var final = (ulong?)bion.ReadMember(bionReader, typeof(ulong?));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Single_Normal()
		{
			ResetStream();
			Single init = 250;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (Single)bion.ReadMember(bionReader, typeof(Single));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Single_Nullable()
		{
			ResetStream();
			Single? init = null;
			bion.WriteValue(bionWriter, init, typeof(Single?));
			ResetStream();

			var final = (Single?)bion.ReadMember(bionReader, typeof(Single?));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Single_Normal_2()
		{
			ResetStream();
			Single init = 250.1199F;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (Single)bion.ReadMember(bionReader, typeof(Single));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Single_Normal_3()
		{
			ResetStream();
			Single init = 0.0009F;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (Single)bion.ReadMember(bionReader, typeof(Single));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Decimal_Normal()
		{
			ResetStream();
			Decimal init = 250;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (Decimal)bion.ReadMember(bionReader, typeof(Decimal));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Decimal_Nullable()
		{
			ResetStream();
			Decimal? init = null;
			bion.WriteValue(bionWriter, init, typeof(Decimal?));
			ResetStream();

			var final = (Decimal?)bion.ReadMember(bionReader, typeof(Decimal?));

			final.Should().Be.EqualTo(init);
		}
		[TestMethod]
		public void Numbers_Decimal_Normal_2()
		{
			ResetStream();
			Decimal init = 250.0091M;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (Decimal)bion.ReadMember(bionReader, typeof(Decimal));

			final.Should().Be.EqualTo(init);
		}
		[TestMethod]
		public void Numbers_Decimal_Normal_3()
		{
			ResetStream();
			Decimal init = 0.0089M;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (Decimal)bion.ReadMember(bionReader, typeof(Decimal));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Double_Normal()
		{
			ResetStream();
			Double init = 250;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (Double)bion.ReadMember(bionReader, typeof(Double));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void Numbers_Double_Nullable()
		{
			ResetStream();
			Decimal? init = null;
			bion.WriteValue(bionWriter, init, typeof(Double?));
			ResetStream();

			var final = (Double?)bion.ReadMember(bionReader, typeof(Double?));

			final.Should().Be.EqualTo(init);
		}
		[TestMethod]
		public void Numbers_Double_Normal_2()
		{
			ResetStream();
			Double init = 250.98765;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (Double)bion.ReadMember(bionReader, typeof(Double));

			final.Should().Be.EqualTo(init);
		}
		[TestMethod]
		public void Numbers_Double_Normal_3()
		{
			ResetStream();
			Double init = 0.000019;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (Double)bion.ReadMember(bionReader, typeof(Double));

			final.Should().Be.EqualTo(init);
		}

		[TestMethod]
		public void DateTimeOffset_Normal()
		{
			ResetStream();
			DateTimeOffset init = DateTimeOffset.Now;
			bion.WriteValue(bionWriter, init);
			ResetStream();

			var final = (DateTimeOffset)bion.ReadMember(bionReader, typeof(DateTimeOffset));

			final.Should().Be.EqualTo(init);
			
		}
	}
}
