using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008DA RID: 2266
	[Token(Token = "0x20008DA")]
	[ProtoContract]
	public class CSGetPersonalVideoZoneRes
	{
		// Token: 0x060025E8 RID: 9704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x21B51BC", Offset = "0x21B51BC", VA = "0x7BBC9B51BC")]
		public CSGetPersonalVideoZoneRes()
		{
		}

		// Token: 0x04002A6C RID: 10860
		[Token(Token = "0x4002A6C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116F44", Offset = "0x1116F44")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1116F44", Offset = "0x1116F44")]
		public string nickname;

		// Token: 0x04002A6D RID: 10861
		[Token(Token = "0x4002A6D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116F94", Offset = "0x1116F94")]
		public EInventory.GenderType sex;

		// Token: 0x04002A6E RID: 10862
		[Token(Token = "0x4002A6E")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116FA8", Offset = "0x1116FA8")]
		public uint fan_count;

		// Token: 0x04002A6F RID: 10863
		[Token(Token = "0x4002A6F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116FBC", Offset = "0x1116FBC")]
		public uint head_pic;

		// Token: 0x04002A70 RID: 10864
		[Token(Token = "0x4002A70")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116FD0", Offset = "0x1116FD0")]
		public ELive.FollowerType follower_type;

		// Token: 0x04002A71 RID: 10865
		[Token(Token = "0x4002A71")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116FE4", Offset = "0x1116FE4")]
		public List<VideoDetail> video_list;
	}
}
