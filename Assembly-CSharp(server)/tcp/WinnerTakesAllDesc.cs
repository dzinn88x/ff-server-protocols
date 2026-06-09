using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000547 RID: 1351
	[Token(Token = "0x2000547")]
	[ProtoContract]
	public class WinnerTakesAllDesc
	{
		// Token: 0x060021E8 RID: 8680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E8")]
		[Address(RVA = "0x3496BEC", Offset = "0x3496BEC", VA = "0x7BBDC96BEC")]
		public WinnerTakesAllDesc()
		{
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060021E9 RID: 8681 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		// (set) Token: 0x060021EA RID: 8682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11591C0", Offset = "0x11591C0")]
		public uint chip_cost
		{
			[Token(Token = "0x60021E9")]
			[Address(RVA = "0x3496BF4", Offset = "0x3496BF4", VA = "0x7BBDC96BF4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139E64", Offset = "0x1139E64")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021EA")]
			[Address(RVA = "0x3496BFC", Offset = "0x3496BFC", VA = "0x7BBDC96BFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139E74", Offset = "0x1139E74")]
			set
			{
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x060021EB RID: 8683 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		// (set) Token: 0x060021EC RID: 8684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11591D4", Offset = "0x11591D4")]
		public uint diamond_cost
		{
			[Token(Token = "0x60021EB")]
			[Address(RVA = "0x3496C04", Offset = "0x3496C04", VA = "0x7BBDC96C04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139E84", Offset = "0x1139E84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021EC")]
			[Address(RVA = "0x3496C0C", Offset = "0x3496C0C", VA = "0x7BBDC96C0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139E94", Offset = "0x1139E94")]
			set
			{
			}
		}

		// Token: 0x04001959 RID: 6489
		[Token(Token = "0x4001959")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11044F4", Offset = "0x11044F4")]
		private uint <chip_cost>k__BackingField;

		// Token: 0x0400195A RID: 6490
		[Token(Token = "0x400195A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104504", Offset = "0x1104504")]
		private uint <diamond_cost>k__BackingField;
	}
}
