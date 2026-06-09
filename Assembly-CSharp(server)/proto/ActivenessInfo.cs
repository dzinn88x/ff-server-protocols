using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200092B RID: 2347
	[Token(Token = "0x200092B")]
	[ProtoContract]
	public class ActivenessInfo
	{
		// Token: 0x06002639 RID: 9785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002639")]
		[Address(RVA = "0x21AE924", Offset = "0x21AE924", VA = "0x7BBC9AE924")]
		public ActivenessInfo()
		{
		}

		// Token: 0x04002B79 RID: 11129
		[Token(Token = "0x4002B79")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118AD8", Offset = "0x1118AD8")]
		public uint group_id;

		// Token: 0x04002B7A RID: 11130
		[Token(Token = "0x4002B7A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118AEC", Offset = "0x1118AEC")]
		public uint daily_activeness;

		// Token: 0x04002B7B RID: 11131
		[Token(Token = "0x4002B7B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118B00", Offset = "0x1118B00")]
		public uint weekly_activeness;
	}
}
