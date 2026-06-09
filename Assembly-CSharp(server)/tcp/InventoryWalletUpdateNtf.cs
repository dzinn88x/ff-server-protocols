using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004BC RID: 1212
	[Token(Token = "0x20004BC")]
	[ProtoContract]
	public class InventoryWalletUpdateNtf
	{
		// Token: 0x06001E9A RID: 7834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x24A43A4", Offset = "0x24A43A4", VA = "0x7BBCCA43A4")]
		public InventoryWalletUpdateNtf()
		{
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001E9B RID: 7835 RVA: 0x0000D140 File Offset: 0x0000B340
		// (set) Token: 0x06001E9C RID: 7836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11569AC", Offset = "0x11569AC")]
		public uint coins
		{
			[Token(Token = "0x6001E9B")]
			[Address(RVA = "0x24A43AC", Offset = "0x24A43AC", VA = "0x7BBCCA43AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136FA4", Offset = "0x1136FA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E9C")]
			[Address(RVA = "0x24A43B4", Offset = "0x24A43B4", VA = "0x7BBCCA43B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136FB4", Offset = "0x1136FB4")]
			set
			{
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x0000D158 File Offset: 0x0000B358
		// (set) Token: 0x06001E9E RID: 7838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11569C0", Offset = "0x11569C0")]
		public int gems
		{
			[Token(Token = "0x6001E9D")]
			[Address(RVA = "0x24A43BC", Offset = "0x24A43BC", VA = "0x7BBCCA43BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136FC4", Offset = "0x1136FC4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E9E")]
			[Address(RVA = "0x24A43C4", Offset = "0x24A43C4", VA = "0x7BBCCA43C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136FD4", Offset = "0x1136FD4")]
			set
			{
			}
		}

		// Token: 0x04001694 RID: 5780
		[Token(Token = "0x4001694")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102D94", Offset = "0x1102D94")]
		private uint <coins>k__BackingField;

		// Token: 0x04001695 RID: 5781
		[Token(Token = "0x4001695")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102DA4", Offset = "0x1102DA4")]
		private int <gems>k__BackingField;
	}
}
