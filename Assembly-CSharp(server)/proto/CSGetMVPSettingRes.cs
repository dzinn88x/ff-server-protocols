using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009B2 RID: 2482
	[Token(Token = "0x20009B2")]
	[ProtoContract]
	public class CSGetMVPSettingRes
	{
		// Token: 0x060026C0 RID: 9920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x21B4888", Offset = "0x21B4888", VA = "0x7BBC9B4888")]
		public CSGetMVPSettingRes()
		{
		}

		// Token: 0x04002CAA RID: 11434
		[Token(Token = "0x4002CAA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A720", Offset = "0x111A720")]
		public MVPSettingDesc setting;

		// Token: 0x04002CAB RID: 11435
		[Token(Token = "0x4002CAB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A734", Offset = "0x111A734")]
		public List<MVPProcessRewardDesc> process_reward_info;
	}
}
