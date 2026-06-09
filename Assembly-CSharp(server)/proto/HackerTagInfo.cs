using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000582 RID: 1410
	[Token(Token = "0x2000582")]
	[ProtoContract]
	public class HackerTagInfo
	{
		// Token: 0x06002341 RID: 9025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002341")]
		[Address(RVA = "0x21BB23C", Offset = "0x21BB23C", VA = "0x7BBC9BB23C")]
		public HackerTagInfo()
		{
		}

		// Token: 0x04001B88 RID: 7048
		[Token(Token = "0x4001B88")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1104F60", Offset = "0x1104F60")]
		public uint hacker_tag;

		// Token: 0x04001B89 RID: 7049
		[Token(Token = "0x4001B89")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1104F74", Offset = "0x1104F74")]
		public long hackerpool_time;
	}
}
