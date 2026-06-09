using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005FB RID: 1531
	[Token(Token = "0x20005FB")]
	[ProtoContract]
	public class AwakenTask
	{
		// Token: 0x0600237B RID: 9083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237B")]
		[Address(RVA = "0x21AF5C8", Offset = "0x21AF5C8", VA = "0x7BBC9AF5C8")]
		public AwakenTask()
		{
		}

		// Token: 0x04001E8E RID: 7822
		[Token(Token = "0x4001E8E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106EC8", Offset = "0x1106EC8")]
		public ulong account_id;

		// Token: 0x04001E8F RID: 7823
		[Token(Token = "0x4001E8F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106EDC", Offset = "0x1106EDC")]
		public uint avatar_id;

		// Token: 0x04001E90 RID: 7824
		[Token(Token = "0x4001E90")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106EF0", Offset = "0x1106EF0")]
		public uint task_type;

		// Token: 0x04001E91 RID: 7825
		[Token(Token = "0x4001E91")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106F04", Offset = "0x1106F04")]
		public uint data;

		// Token: 0x04001E92 RID: 7826
		[Token(Token = "0x4001E92")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106F18", Offset = "0x1106F18")]
		public EProfile.TaskState state;
	}
}
