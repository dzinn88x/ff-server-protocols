using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004AF RID: 1199
	[Token(Token = "0x20004AF")]
	[ProtoContract]
	public class ShowEmoteNtf
	{
		// Token: 0x06001E6F RID: 7791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0x24A70B4", Offset = "0x24A70B4", VA = "0x7BBCCA70B4")]
		public ShowEmoteNtf()
		{
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x0000D050 File Offset: 0x0000B250
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115677C", Offset = "0x115677C")]
		public ulong account_id
		{
			[Token(Token = "0x6001E70")]
			[Address(RVA = "0x24A70BC", Offset = "0x24A70BC", VA = "0x7BBCCA70BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136DA4", Offset = "0x1136DA4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E71")]
			[Address(RVA = "0x24A70C4", Offset = "0x24A70C4", VA = "0x7BBCCA70C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136DB4", Offset = "0x1136DB4")]
			set
			{
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x0000D068 File Offset: 0x0000B268
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156790", Offset = "0x1156790")]
		public uint emote_id
		{
			[Token(Token = "0x6001E72")]
			[Address(RVA = "0x24A70CC", Offset = "0x24A70CC", VA = "0x7BBCCA70CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136DC4", Offset = "0x1136DC4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E73")]
			[Address(RVA = "0x24A70D4", Offset = "0x24A70D4", VA = "0x7BBCCA70D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136DD4", Offset = "0x1136DD4")]
			set
			{
			}
		}

		// Token: 0x04001673 RID: 5747
		[Token(Token = "0x4001673")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102C94", Offset = "0x1102C94")]
		private ulong <account_id>k__BackingField;

		// Token: 0x04001674 RID: 5748
		[Token(Token = "0x4001674")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102CA4", Offset = "0x1102CA4")]
		private uint <emote_id>k__BackingField;
	}
}
