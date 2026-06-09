using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000539 RID: 1337
	[Token(Token = "0x2000539")]
	[ProtoContract]
	public class ProtoReq
	{
		// Token: 0x0600218C RID: 8588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218C")]
		[Address(RVA = "0x24A5A0C", Offset = "0x24A5A0C", VA = "0x7BBCCA5A0C")]
		public ProtoReq()
		{
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600218D RID: 8589 RVA: 0x0000E880 File Offset: 0x0000CA80
		// (set) Token: 0x0600218E RID: 8590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AD")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158E50", Offset = "0x1158E50")]
		public uint cmd
		{
			[Token(Token = "0x600218D")]
			[Address(RVA = "0x24A5A14", Offset = "0x24A5A14", VA = "0x7BBCCA5A14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139984", Offset = "0x1139984")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600218E")]
			[Address(RVA = "0x24A5A1C", Offset = "0x24A5A1C", VA = "0x7BBCCA5A1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139994", Offset = "0x1139994")]
			set
			{
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600218F RID: 8591 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002190 RID: 8592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158E64", Offset = "0x1158E64")]
		public byte[] data
		{
			[Token(Token = "0x600218F")]
			[Address(RVA = "0x24A5A24", Offset = "0x24A5A24", VA = "0x7BBCCA5A24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11399A4", Offset = "0x11399A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002190")]
			[Address(RVA = "0x24A5A2C", Offset = "0x24A5A2C", VA = "0x7BBCCA5A2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11399B4", Offset = "0x11399B4")]
			set
			{
			}
		}

		// Token: 0x04001932 RID: 6450
		[Token(Token = "0x4001932")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104284", Offset = "0x1104284")]
		private uint <cmd>k__BackingField;

		// Token: 0x04001933 RID: 6451
		[Token(Token = "0x4001933")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104294", Offset = "0x1104294")]
		private byte[] <data>k__BackingField;
	}
}
