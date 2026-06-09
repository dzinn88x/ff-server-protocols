using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200043D RID: 1085
	[Token(Token = "0x200043D")]
	[ProtoContract]
	public class ItemTCP
	{
		// Token: 0x06001BEF RID: 7151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0x24A4508", Offset = "0x24A4508", VA = "0x7BBCCA4508")]
		public ItemTCP()
		{
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000335")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11544B8", Offset = "0x11544B8")]
		public uint id
		{
			[Token(Token = "0x6001BF0")]
			[Address(RVA = "0x24A4510", Offset = "0x24A4510", VA = "0x7BBCCA4510")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134A84", Offset = "0x1134A84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001BF1")]
			[Address(RVA = "0x24A4518", Offset = "0x24A4518", VA = "0x7BBCCA4518")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134A94", Offset = "0x1134A94")]
			set
			{
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000336")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11544CC", Offset = "0x11544CC")]
		public uint cnt
		{
			[Token(Token = "0x6001BF2")]
			[Address(RVA = "0x24A4520", Offset = "0x24A4520", VA = "0x7BBCCA4520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134AA4", Offset = "0x1134AA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001BF3")]
			[Address(RVA = "0x24A4528", Offset = "0x24A4528", VA = "0x7BBCCA4528")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134AB4", Offset = "0x1134AB4")]
			set
			{
			}
		}

		// Token: 0x04001454 RID: 5204
		[Token(Token = "0x4001454")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101B04", Offset = "0x1101B04")]
		private uint <id>k__BackingField;

		// Token: 0x04001455 RID: 5205
		[Token(Token = "0x4001455")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101B14", Offset = "0x1101B14")]
		private uint <cnt>k__BackingField;
	}
}
