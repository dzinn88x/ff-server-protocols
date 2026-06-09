using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200082B RID: 2091
	[Token(Token = "0x200082B")]
	[ProtoContract]
	public class CSGetPlatformFriendListReq
	{
		// Token: 0x0600253C RID: 9532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600253C")]
		[Address(RVA = "0x21B532C", Offset = "0x21B532C", VA = "0x7BBC9B532C")]
		public CSGetPlatformFriendListReq()
		{
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x0000F618 File Offset: 0x0000D818
		[Token(Token = "0x600253D")]
		[Address(RVA = "0x21B5388", Offset = "0x21B5388", VA = "0x7BBC9B5388", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x0000F630 File Offset: 0x0000D830
		[Token(Token = "0x600253E")]
		[Address(RVA = "0x21B5548", Offset = "0x21B5548", VA = "0x7BBC9B5548", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04002745 RID: 10053
		[Token(Token = "0x4002745")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111210", Offset = "0x1111210")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111210", Offset = "0x1111210")]
		public string token;

		// Token: 0x04002746 RID: 10054
		[Token(Token = "0x4002746")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111260", Offset = "0x1111260")]
		public uint platform_sdk_id;

		// Token: 0x04002747 RID: 10055
		[Token(Token = "0x4002747")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111274", Offset = "0x1111274")]
		public uint platform_type;

		// Token: 0x04002748 RID: 10056
		[Token(Token = "0x4002748")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111288", Offset = "0x1111288")]
		public bool need_presence;

		// Token: 0x04002749 RID: 10057
		[Token(Token = "0x4002749")]
		[FieldOffset(Offset = "0x21")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111129C", Offset = "0x111129C")]
		public bool need_stats;

		// Token: 0x0400274A RID: 10058
		[Token(Token = "0x400274A")]
		[FieldOffset(Offset = "0x22")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11112B0", Offset = "0x11112B0")]
		public bool need_ranking_stats;

		// Token: 0x0400274B RID: 10059
		[Token(Token = "0x400274B")]
		[FieldOffset(Offset = "0x23")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11112C4", Offset = "0x11112C4")]
		public bool need_casual_stats;

		// Token: 0x0400274C RID: 10060
		[Token(Token = "0x400274C")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11112D8", Offset = "0x11112D8")]
		public bool need_cs_ranking_stats;
	}
}
