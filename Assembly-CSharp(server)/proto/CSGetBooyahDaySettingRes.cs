using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000970 RID: 2416
	[Token(Token = "0x2000970")]
	[ProtoContract]
	public class CSGetBooyahDaySettingRes
	{
		// Token: 0x0600267E RID: 9854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267E")]
		[Address(RVA = "0x21B2800", Offset = "0x21B2800", VA = "0x7BBC9B2800")]
		public CSGetBooyahDaySettingRes()
		{
		}

		// Token: 0x04002C06 RID: 11270
		[Token(Token = "0x4002C06")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119834", Offset = "0x1119834")]
		public BooyahDaySettingDesc setting;

		// Token: 0x04002C07 RID: 11271
		[Token(Token = "0x4002C07")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119848", Offset = "0x1119848")]
		public List<BigEventTokenTipsDesc> exchange_token_tips;

		// Token: 0x04002C08 RID: 11272
		[Token(Token = "0x4002C08")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111985C", Offset = "0x111985C")]
		public List<BigEventTokenTipsDesc> sugar_token_tips;

		// Token: 0x04002C09 RID: 11273
		[Token(Token = "0x4002C09")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119870", Offset = "0x1119870")]
		public List<BooyahDayProcessRewardDesc> process_reward_info;

		// Token: 0x04002C0A RID: 11274
		[Token(Token = "0x4002C0A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119884", Offset = "0x1119884")]
		public List<BigEventProcessSettingDesc> process_setting;

		// Token: 0x04002C0B RID: 11275
		[Token(Token = "0x4002C0B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119898", Offset = "0x1119898")]
		public List<BooyahDaySignInDesc> sign_in;
	}
}
