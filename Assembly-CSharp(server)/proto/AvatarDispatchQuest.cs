using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000604 RID: 1540
	[Token(Token = "0x2000604")]
	[ProtoContract]
	public class AvatarDispatchQuest
	{
		// Token: 0x06002380 RID: 9088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002380")]
		[Address(RVA = "0x21AF498", Offset = "0x21AF498", VA = "0x7BBC9AF498")]
		public AvatarDispatchQuest()
		{
		}

		// Token: 0x04001EB6 RID: 7862
		[Token(Token = "0x4001EB6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106FCC", Offset = "0x1106FCC")]
		public uint quest_line;

		// Token: 0x04001EB7 RID: 7863
		[Token(Token = "0x4001EB7")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106FE0", Offset = "0x1106FE0")]
		public uint quest_id;

		// Token: 0x04001EB8 RID: 7864
		[Token(Token = "0x4001EB8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106FF4", Offset = "0x1106FF4")]
		public EProfile.DispatchQuestState state;

		// Token: 0x04001EB9 RID: 7865
		[Token(Token = "0x4001EB9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107008", Offset = "0x1107008")]
		public long start_time;
	}
}
