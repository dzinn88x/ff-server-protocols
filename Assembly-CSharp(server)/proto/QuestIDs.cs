using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000648 RID: 1608
	[Token(Token = "0x2000648")]
	[ProtoContract]
	public class QuestIDs
	{
		// Token: 0x060023B2 RID: 9138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B2")]
		[Address(RVA = "0x249F7C0", Offset = "0x249F7C0", VA = "0x7BBCC9F7C0")]
		public QuestIDs()
		{
		}

		// Token: 0x04001FC4 RID: 8132
		[Token(Token = "0x4001FC4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11084F8", Offset = "0x11084F8")]
		public uint[] questIDs;

		// Token: 0x04001FC5 RID: 8133
		[Token(Token = "0x4001FC5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108534", Offset = "0x1108534")]
		public uint[] dailyQuestIDs;

		// Token: 0x04001FC6 RID: 8134
		[Token(Token = "0x4001FC6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108570", Offset = "0x1108570")]
		public uint daily_quest_completed_cnt;

		// Token: 0x04001FC7 RID: 8135
		[Token(Token = "0x4001FC7")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108584", Offset = "0x1108584")]
		public uint daily_quest_today_cnt;

		// Token: 0x04001FC8 RID: 8136
		[Token(Token = "0x4001FC8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108598", Offset = "0x1108598")]
		public uint quest_completed_cnt;
	}
}
