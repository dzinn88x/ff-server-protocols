using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	[ProtoContract]
	public class ShowEmoteReq
	{
		// Token: 0x06001E6A RID: 7786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0x24A70DC", Offset = "0x24A70DC", VA = "0x7BBCCA70DC")]
		public ShowEmoteReq()
		{
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x0000D020 File Offset: 0x0000B220
		// (set) Token: 0x06001E6C RID: 7788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156754", Offset = "0x1156754")]
		public ulong group_id
		{
			[Token(Token = "0x6001E6B")]
			[Address(RVA = "0x24A70E4", Offset = "0x24A70E4", VA = "0x7BBCCA70E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136D64", Offset = "0x1136D64")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E6C")]
			[Address(RVA = "0x24A70EC", Offset = "0x24A70EC", VA = "0x7BBCCA70EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136D74", Offset = "0x1136D74")]
			set
			{
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x0000D038 File Offset: 0x0000B238
		// (set) Token: 0x06001E6E RID: 7790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156768", Offset = "0x1156768")]
		public uint emote_id
		{
			[Token(Token = "0x6001E6D")]
			[Address(RVA = "0x24A70F4", Offset = "0x24A70F4", VA = "0x7BBCCA70F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136D84", Offset = "0x1136D84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E6E")]
			[Address(RVA = "0x24A70FC", Offset = "0x24A70FC", VA = "0x7BBCCA70FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136D94", Offset = "0x1136D94")]
			set
			{
			}
		}

		// Token: 0x04001671 RID: 5745
		[Token(Token = "0x4001671")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102C74", Offset = "0x1102C74")]
		private ulong <group_id>k__BackingField;

		// Token: 0x04001672 RID: 5746
		[Token(Token = "0x4001672")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102C84", Offset = "0x1102C84")]
		private uint <emote_id>k__BackingField;
	}
}
