using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000540 RID: 1344
	[Token(Token = "0x2000540")]
	[ProtoContract]
	public class ReviveTokenInfo
	{
		// Token: 0x060021B3 RID: 8627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B3")]
		[Address(RVA = "0x24A5C84", Offset = "0x24A5C84", VA = "0x7BBCCA5C84")]
		public ReviveTokenInfo()
		{
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BD")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158F90", Offset = "0x1158F90")]
		public uint id
		{
			[Token(Token = "0x60021B4")]
			[Address(RVA = "0x24A5C8C", Offset = "0x24A5C8C", VA = "0x7BBCCA5C8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139B84", Offset = "0x1139B84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021B5")]
			[Address(RVA = "0x24A5C94", Offset = "0x24A5C94", VA = "0x7BBCCA5C94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139B94", Offset = "0x1139B94")]
			set
			{
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x0000EA00 File Offset: 0x0000CC00
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158FA4", Offset = "0x1158FA4")]
		public uint cnt
		{
			[Token(Token = "0x60021B6")]
			[Address(RVA = "0x24A5C9C", Offset = "0x24A5C9C", VA = "0x7BBCCA5C9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139BA4", Offset = "0x1139BA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021B7")]
			[Address(RVA = "0x24A5CA4", Offset = "0x24A5CA4", VA = "0x7BBCCA5CA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139BB4", Offset = "0x1139BB4")]
			set
			{
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x0000EA18 File Offset: 0x0000CC18
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158FB8", Offset = "0x1158FB8")]
		public uint expire_time
		{
			[Token(Token = "0x60021B8")]
			[Address(RVA = "0x24A5CAC", Offset = "0x24A5CAC", VA = "0x7BBCCA5CAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139BC4", Offset = "0x1139BC4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021B9")]
			[Address(RVA = "0x24A5CB4", Offset = "0x24A5CB4", VA = "0x7BBCCA5CB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139BD4", Offset = "0x1139BD4")]
			set
			{
			}
		}

		// Token: 0x04001942 RID: 6466
		[Token(Token = "0x4001942")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104384", Offset = "0x1104384")]
		private uint <id>k__BackingField;

		// Token: 0x04001943 RID: 6467
		[Token(Token = "0x4001943")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104394", Offset = "0x1104394")]
		private uint <cnt>k__BackingField;

		// Token: 0x04001944 RID: 6468
		[Token(Token = "0x4001944")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11043A4", Offset = "0x11043A4")]
		private uint <expire_time>k__BackingField;
	}
}
