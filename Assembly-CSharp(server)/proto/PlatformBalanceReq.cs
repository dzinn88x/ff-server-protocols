using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000618 RID: 1560
	[Token(Token = "0x2000618")]
	[ProtoContract]
	public class PlatformBalanceReq
	{
		// Token: 0x06002393 RID: 9107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002393")]
		[Address(RVA = "0x249F38C", Offset = "0x249F38C", VA = "0x7BBCC9F38C")]
		public PlatformBalanceReq()
		{
		}

		// Token: 0x04001F14 RID: 7956
		[Token(Token = "0x4001F14")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107BD4", Offset = "0x1107BD4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107BD4", Offset = "0x1107BD4")]
		public string token;

		// Token: 0x04001F15 RID: 7957
		[Token(Token = "0x4001F15")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1107C24", Offset = "0x1107C24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107C24", Offset = "0x1107C24")]
		public string external_id;

		// Token: 0x04001F16 RID: 7958
		[Token(Token = "0x4001F16")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107C74", Offset = "0x1107C74")]
		public uint client_type;

		// Token: 0x04001F17 RID: 7959
		[Token(Token = "0x4001F17")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107C88", Offset = "0x1107C88")]
		public uint platform_sdk_id;
	}
}
