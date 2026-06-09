using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005F7 RID: 1527
	[Token(Token = "0x20005F7")]
	[ProtoContract]
	public class SupercarHelpPlayer
	{
		// Token: 0x06002377 RID: 9079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002377")]
		[Address(RVA = "0x24A0B10", Offset = "0x24A0B10", VA = "0x7BBCCA0B10")]
		public SupercarHelpPlayer()
		{
		}

		// Token: 0x04001E7E RID: 7806
		[Token(Token = "0x4001E7E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106D24", Offset = "0x1106D24")]
		public ulong account_id;

		// Token: 0x04001E7F RID: 7807
		[Token(Token = "0x4001E7F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106D38", Offset = "0x1106D38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1106D38", Offset = "0x1106D38")]
		public string nickname;

		// Token: 0x04001E80 RID: 7808
		[Token(Token = "0x4001E80")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106D88", Offset = "0x1106D88")]
		public bool is_speed;

		// Token: 0x04001E81 RID: 7809
		[Token(Token = "0x4001E81")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106D9C", Offset = "0x1106D9C")]
		public uint car_id;
	}
}
