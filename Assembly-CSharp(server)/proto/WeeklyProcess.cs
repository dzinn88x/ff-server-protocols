using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200088C RID: 2188
	[Token(Token = "0x200088C")]
	[ProtoContract]
	public class WeeklyProcess
	{
		// Token: 0x0600259A RID: 9626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600259A")]
		[Address(RVA = "0x24A19C4", Offset = "0x24A19C4", VA = "0x7BBCCA19C4")]
		public WeeklyProcess()
		{
		}

		// Token: 0x040028C9 RID: 10441
		[Token(Token = "0x40028C9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11139FC", Offset = "0x11139FC")]
		public uint week_id;

		// Token: 0x040028CA RID: 10442
		[Token(Token = "0x40028CA")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113A10", Offset = "0x1113A10")]
		public uint challenge_num;

		// Token: 0x040028CB RID: 10443
		[Token(Token = "0x40028CB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113A24", Offset = "0x1113A24")]
		public List<WeeklyProcessStatus> weekly_process_status;
	}
}
