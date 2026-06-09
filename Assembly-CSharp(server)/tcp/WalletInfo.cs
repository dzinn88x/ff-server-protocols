using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000543 RID: 1347
	[Token(Token = "0x2000543")]
	[ProtoContract]
	public class WalletInfo
	{
		// Token: 0x060021C8 RID: 8648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x24A7464", Offset = "0x24A7464", VA = "0x7BBCCA7464")]
		public WalletInfo()
		{
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159044", Offset = "0x1159044")]
		public uint coins
		{
			[Token(Token = "0x60021C9")]
			[Address(RVA = "0x24A746C", Offset = "0x24A746C", VA = "0x7BBCCA746C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139CA4", Offset = "0x1139CA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60021CA")]
			[Address(RVA = "0x24A7474", Offset = "0x24A7474", VA = "0x7BBCCA7474")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139CB4", Offset = "0x1139CB4")]
			set
			{
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1159058", Offset = "0x1159058")]
		public int gems
		{
			[Token(Token = "0x60021CB")]
			[Address(RVA = "0x24A747C", Offset = "0x24A747C", VA = "0x7BBCCA747C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139CC4", Offset = "0x1139CC4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60021CC")]
			[Address(RVA = "0x24A7484", Offset = "0x24A7484", VA = "0x7BBCCA7484")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139CD4", Offset = "0x1139CD4")]
			set
			{
			}
		}

		// Token: 0x0400194B RID: 6475
		[Token(Token = "0x400194B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104414", Offset = "0x1104414")]
		private uint <coins>k__BackingField;

		// Token: 0x0400194C RID: 6476
		[Token(Token = "0x400194C")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104424", Offset = "0x1104424")]
		private int <gems>k__BackingField;
	}
}
