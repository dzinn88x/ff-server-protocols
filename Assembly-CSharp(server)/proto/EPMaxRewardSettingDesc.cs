using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A8C RID: 2700
	[Token(Token = "0x2000A8C")]
	[ProtoContract]
	public class EPMaxRewardSettingDesc
	{
		// Token: 0x06002796 RID: 10134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002796")]
		[Address(RVA = "0x21B9924", Offset = "0x21B9924", VA = "0x7BBC9B9924")]
		public EPMaxRewardSettingDesc()
		{
		}

		// Token: 0x040031B9 RID: 12729
		[Token(Token = "0x40031B9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112353C", Offset = "0x112353C")]
		public uint badge_num;

		// Token: 0x040031BA RID: 12730
		[Token(Token = "0x40031BA")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123550", Offset = "0x1123550")]
		public uint reward_id;
	}
}
