using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000541 RID: 1345
	[Token(Token = "0x2000541")]
	[ProtoContract]
	public class ChipInfo
	{
		// Token: 0x060021BA RID: 8634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BA")]
		[Address(RVA = "0x24A2AA8", Offset = "0x24A2AA8", VA = "0x7BBCCA2AA8")]
		public ChipInfo()
		{
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x0000EA30 File Offset: 0x0000CC30
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158FCC", Offset = "0x1158FCC")]
		public uint id
		{
			[Token(Token = "0x60021BB")]
			[Address(RVA = "0x24A2AB0", Offset = "0x24A2AB0", VA = "0x7BBCCA2AB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139BE4", Offset = "0x1139BE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021BC")]
			[Address(RVA = "0x24A2AB8", Offset = "0x24A2AB8", VA = "0x7BBCCA2AB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139BF4", Offset = "0x1139BF4")]
			set
			{
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x0000EA48 File Offset: 0x0000CC48
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158FE0", Offset = "0x1158FE0")]
		public uint cnt
		{
			[Token(Token = "0x60021BD")]
			[Address(RVA = "0x24A2AC0", Offset = "0x24A2AC0", VA = "0x7BBCCA2AC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139C04", Offset = "0x1139C04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021BE")]
			[Address(RVA = "0x24A2AC8", Offset = "0x24A2AC8", VA = "0x7BBCCA2AC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139C14", Offset = "0x1139C14")]
			set
			{
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x0000EA60 File Offset: 0x0000CC60
		// (set) Token: 0x060021C0 RID: 8640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158FF4", Offset = "0x1158FF4")]
		public uint expire_time
		{
			[Token(Token = "0x60021BF")]
			[Address(RVA = "0x24A2AD0", Offset = "0x24A2AD0", VA = "0x7BBCCA2AD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139C24", Offset = "0x1139C24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021C0")]
			[Address(RVA = "0x24A2AD8", Offset = "0x24A2AD8", VA = "0x7BBCCA2AD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139C34", Offset = "0x1139C34")]
			set
			{
			}
		}

		// Token: 0x04001945 RID: 6469
		[Token(Token = "0x4001945")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11043B4", Offset = "0x11043B4")]
		private uint <id>k__BackingField;

		// Token: 0x04001946 RID: 6470
		[Token(Token = "0x4001946")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11043C4", Offset = "0x11043C4")]
		private uint <cnt>k__BackingField;

		// Token: 0x04001947 RID: 6471
		[Token(Token = "0x4001947")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11043D4", Offset = "0x11043D4")]
		private uint <expire_time>k__BackingField;
	}
}
