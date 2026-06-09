using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000607 RID: 1543
	[Token(Token = "0x2000607")]
	[ProtoContract]
	public class BasicEPInfo
	{
		// Token: 0x06002383 RID: 9091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002383")]
		[Address(RVA = "0x21AF734", Offset = "0x21AF734", VA = "0x7BBC9AF734")]
		public BasicEPInfo()
		{
		}

		// Token: 0x04001EC6 RID: 7878
		[Token(Token = "0x4001EC6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107134", Offset = "0x1107134")]
		public uint ep_event_id;

		// Token: 0x04001EC7 RID: 7879
		[Token(Token = "0x4001EC7")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107148", Offset = "0x1107148")]
		public bool owned_pass;

		// Token: 0x04001EC8 RID: 7880
		[Token(Token = "0x4001EC8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110715C", Offset = "0x110715C")]
		public uint ep_badge;

		// Token: 0x04001EC9 RID: 7881
		[Token(Token = "0x4001EC9")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107170", Offset = "0x1107170")]
		public uint badge_cnt;
	}
}
