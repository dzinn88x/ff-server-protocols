using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	[ProtoContract]
	public class WarmGameInfo
	{
		// Token: 0x060021ED RID: 8685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021ED")]
		[Address(RVA = "0x24A748C", Offset = "0x24A748C", VA = "0x7BBCCA748C")]
		public WarmGameInfo()
		{
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11591E8", Offset = "0x11591E8")]
		public uint type
		{
			[Token(Token = "0x60021EE")]
			[Address(RVA = "0x24A7494", Offset = "0x24A7494", VA = "0x7BBCCA7494")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139EA4", Offset = "0x1139EA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021EF")]
			[Address(RVA = "0x24A749C", Offset = "0x24A749C", VA = "0x7BBCCA749C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139EB4", Offset = "0x1139EB4")]
			set
			{
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x0000EC10 File Offset: 0x0000CE10
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11591FC", Offset = "0x11591FC")]
		public uint level
		{
			[Token(Token = "0x60021F0")]
			[Address(RVA = "0x24A74A4", Offset = "0x24A74A4", VA = "0x7BBCCA74A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139EC4", Offset = "0x1139EC4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021F1")]
			[Address(RVA = "0x24A74AC", Offset = "0x24A74AC", VA = "0x7BBCCA74AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139ED4", Offset = "0x1139ED4")]
			set
			{
			}
		}

		// Token: 0x0400195B RID: 6491
		[Token(Token = "0x400195B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104514", Offset = "0x1104514")]
		private uint <type>k__BackingField;

		// Token: 0x0400195C RID: 6492
		[Token(Token = "0x400195C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104524", Offset = "0x1104524")]
		private uint <level>k__BackingField;
	}
}
