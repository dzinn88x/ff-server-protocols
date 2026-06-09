using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000939 RID: 2361
	[Token(Token = "0x2000939")]
	[ProtoContract]
	public class CSGetProcessRewardsRes
	{
		// Token: 0x06002647 RID: 9799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002647")]
		[Address(RVA = "0x21B56B0", Offset = "0x21B56B0", VA = "0x7BBC9B56B0")]
		public CSGetProcessRewardsRes()
		{
		}

		// Token: 0x04002B9A RID: 11162
		[Token(Token = "0x4002B9A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118DD0", Offset = "0x1118DD0")]
		public AwardData awards;

		// Token: 0x04002B9B RID: 11163
		[Token(Token = "0x4002B9B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118DE4", Offset = "0x1118DE4")]
		public uint process_id;

		// Token: 0x04002B9C RID: 11164
		[Token(Token = "0x4002B9C")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118DF8", Offset = "0x1118DF8")]
		public bool is_button_open;
	}
}
