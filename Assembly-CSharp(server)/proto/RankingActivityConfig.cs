using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A5A RID: 2650
	[Token(Token = "0x2000A5A")]
	[ProtoContract]
	public class RankingActivityConfig
	{
		// Token: 0x06002764 RID: 10084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002764")]
		[Address(RVA = "0x249FA10", Offset = "0x249FA10", VA = "0x7BBCC9FA10")]
		public RankingActivityConfig()
		{
		}

		// Token: 0x04003074 RID: 12404
		[Token(Token = "0x4003074")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11210FC", Offset = "0x11210FC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11210FC", Offset = "0x11210FC")]
		public string region;

		// Token: 0x04003075 RID: 12405
		[Token(Token = "0x4003075")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112114C", Offset = "0x112114C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112114C", Offset = "0x112114C")]
		public string start_time;

		// Token: 0x04003076 RID: 12406
		[Token(Token = "0x4003076")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112119C", Offset = "0x112119C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112119C", Offset = "0x112119C")]
		public string end_time;

		// Token: 0x04003077 RID: 12407
		[Token(Token = "0x4003077")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11211EC", Offset = "0x11211EC")]
		public ERanking.ActivityType activity_type;

		// Token: 0x04003078 RID: 12408
		[Token(Token = "0x4003078")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121200", Offset = "0x1121200")]
		public uint start_timestamp;

		// Token: 0x04003079 RID: 12409
		[Token(Token = "0x4003079")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121214", Offset = "0x1121214")]
		public uint end_timestamp;
	}
}
