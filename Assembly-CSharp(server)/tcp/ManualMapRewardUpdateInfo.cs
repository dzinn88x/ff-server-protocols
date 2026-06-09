using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004D6 RID: 1238
	[Token(Token = "0x20004D6")]
	[ProtoContract]
	public class ManualMapRewardUpdateInfo
	{
		// Token: 0x06001EF6 RID: 7926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0x24A4828", Offset = "0x24A4828", VA = "0x7BBCCA4828")]
		public ManualMapRewardUpdateInfo()
		{
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		// (set) Token: 0x06001EF8 RID: 7928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000483")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156DBC", Offset = "0x1156DBC")]
		public uint map_id
		{
			[Token(Token = "0x6001EF7")]
			[Address(RVA = "0x24A4830", Offset = "0x24A4830", VA = "0x7BBCCA4830")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137444", Offset = "0x1137444")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001EF8")]
			[Address(RVA = "0x24A4838", Offset = "0x24A4838", VA = "0x7BBCCA4838")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137454", Offset = "0x1137454")]
			set
			{
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x0000D410 File Offset: 0x0000B610
		// (set) Token: 0x06001EFA RID: 7930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000484")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156DD0", Offset = "0x1156DD0")]
		public uint state
		{
			[Token(Token = "0x6001EF9")]
			[Address(RVA = "0x24A4840", Offset = "0x24A4840", VA = "0x7BBCCA4840")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137464", Offset = "0x1137464")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001EFA")]
			[Address(RVA = "0x24A4848", Offset = "0x24A4848", VA = "0x7BBCCA4848")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137474", Offset = "0x1137474")]
			set
			{
			}
		}

		// Token: 0x040016D2 RID: 5842
		[Token(Token = "0x40016D2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102FE4", Offset = "0x1102FE4")]
		private uint <map_id>k__BackingField;

		// Token: 0x040016D3 RID: 5843
		[Token(Token = "0x40016D3")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102FF4", Offset = "0x1102FF4")]
		private uint <state>k__BackingField;
	}
}
