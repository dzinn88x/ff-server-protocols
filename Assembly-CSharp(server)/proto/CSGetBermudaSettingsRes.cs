using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200097C RID: 2428
	[Token(Token = "0x200097C")]
	[ProtoContract]
	public class CSGetBermudaSettingsRes
	{
		// Token: 0x0600268A RID: 9866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268A")]
		[Address(RVA = "0x21B2524", Offset = "0x21B2524", VA = "0x7BBC9B2524")]
		public CSGetBermudaSettingsRes()
		{
		}

		// Token: 0x04002C1E RID: 11294
		[Token(Token = "0x4002C1E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119A3C", Offset = "0x1119A3C")]
		public BermudaSettingsDesc bermuda_settings_desc;

		// Token: 0x04002C1F RID: 11295
		[Token(Token = "0x4002C1F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119A50", Offset = "0x1119A50")]
		public List<BermudaAwardDesc> bermuda_awards;

		// Token: 0x04002C20 RID: 11296
		[Token(Token = "0x4002C20")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119A64", Offset = "0x1119A64")]
		public List<BermudaIntroDesc> bermuda_intro_desc;
	}
}
