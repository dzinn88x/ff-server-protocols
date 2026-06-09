using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000967 RID: 2407
	[Token(Token = "0x2000967")]
	[ProtoContract]
	public class CSGetMoneyHeistInfoRes
	{
		// Token: 0x06002675 RID: 9845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002675")]
		[Address(RVA = "0x21B4C38", Offset = "0x21B4C38", VA = "0x7BBC9B4C38")]
		public CSGetMoneyHeistInfoRes()
		{
		}

		// Token: 0x04002BEF RID: 11247
		[Token(Token = "0x4002BEF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11195B4", Offset = "0x11195B4")]
		public uint speed_from_friend;

		// Token: 0x04002BF0 RID: 11248
		[Token(Token = "0x4002BF0")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11195C8", Offset = "0x11195C8")]
		public uint speed_from_task;

		// Token: 0x04002BF1 RID: 11249
		[Token(Token = "0x4002BF1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11195DC", Offset = "0x11195DC")]
		public uint speed_from_tokens;

		// Token: 0x04002BF2 RID: 11250
		[Token(Token = "0x4002BF2")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11195F0", Offset = "0x11195F0")]
		public uint[] rewarded;

		// Token: 0x04002BF3 RID: 11251
		[Token(Token = "0x4002BF3")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111962C", Offset = "0x111962C")]
		public ulong[] help_other;

		// Token: 0x04002BF4 RID: 11252
		[Token(Token = "0x4002BF4")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119668", Offset = "0x1119668")]
		public List<HelpPlayer> be_helped;

		// Token: 0x04002BF5 RID: 11253
		[Token(Token = "0x4002BF5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111967C", Offset = "0x111967C")]
		public uint deposit;

		// Token: 0x04002BF6 RID: 11254
		[Token(Token = "0x4002BF6")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119690", Offset = "0x1119690")]
		public uint speed_change_time;

		// Token: 0x04002BF7 RID: 11255
		[Token(Token = "0x4002BF7")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11196A4", Offset = "0x11196A4")]
		public long reset_time;
	}
}
