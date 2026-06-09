using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A89 RID: 2697
	[Token(Token = "0x2000A89")]
	[ProtoContract]
	public class EPSubscriptionDesc
	{
		// Token: 0x06002793 RID: 10131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002793")]
		[Address(RVA = "0x21B99B0", Offset = "0x21B99B0", VA = "0x7BBC9B99B0")]
		public EPSubscriptionDesc()
		{
		}

		// Token: 0x040031AA RID: 12714
		[Token(Token = "0x40031AA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11232A8", Offset = "0x11232A8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11232A8", Offset = "0x11232A8")]
		public string region;

		// Token: 0x040031AB RID: 12715
		[Token(Token = "0x40031AB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11232F8", Offset = "0x11232F8")]
		public uint rebate_id;

		// Token: 0x040031AC RID: 12716
		[Token(Token = "0x40031AC")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112330C", Offset = "0x112330C")]
		public uint subscription_bonus;

		// Token: 0x040031AD RID: 12717
		[Token(Token = "0x40031AD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123320", Offset = "0x1123320")]
		public uint subscription_extend_secs;

		// Token: 0x040031AE RID: 12718
		[Token(Token = "0x40031AE")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123334", Offset = "0x1123334")]
		public uint subscription_protect_before_secs;

		// Token: 0x040031AF RID: 12719
		[Token(Token = "0x40031AF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123348", Offset = "0x1123348")]
		public uint subscription_protect_after_secs;
	}
}
