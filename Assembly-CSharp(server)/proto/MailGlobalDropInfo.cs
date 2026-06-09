using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005EC RID: 1516
	[Token(Token = "0x20005EC")]
	[ProtoContract]
	public class MailGlobalDropInfo
	{
		// Token: 0x0600236C RID: 9068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236C")]
		[Address(RVA = "0x21BC228", Offset = "0x21BC228", VA = "0x7BBC9BC228")]
		public MailGlobalDropInfo()
		{
		}

		// Token: 0x04001E45 RID: 7749
		[Token(Token = "0x4001E45")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106568", Offset = "0x1106568")]
		public uint item_id;

		// Token: 0x04001E46 RID: 7750
		[Token(Token = "0x4001E46")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110657C", Offset = "0x110657C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110657C", Offset = "0x110657C")]
		public string url;

		// Token: 0x04001E47 RID: 7751
		[Token(Token = "0x4001E47")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11065CC", Offset = "0x11065CC")]
		public uint award_time;
	}
}
