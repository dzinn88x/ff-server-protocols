using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200073C RID: 1852
	[Token(Token = "0x200073C")]
	[ProtoContract]
	public class CSGetCupConfigRes
	{
		// Token: 0x06002449 RID: 9289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002449")]
		[Address(RVA = "0x21B2DF4", Offset = "0x21B2DF4", VA = "0x7BBC9B2DF4")]
		public CSGetCupConfigRes()
		{
		}

		// Token: 0x040024A1 RID: 9377
		[Token(Token = "0x40024A1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C9CC", Offset = "0x110C9CC")]
		public CupOpenInfoDesc open_info;

		// Token: 0x040024A2 RID: 9378
		[Token(Token = "0x40024A2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C9E0", Offset = "0x110C9E0")]
		public CupSettingDesc cup_setting;

		// Token: 0x040024A3 RID: 9379
		[Token(Token = "0x40024A3")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C9F4", Offset = "0x110C9F4")]
		public List<CupTierDesc> tiers;

		// Token: 0x040024A4 RID: 9380
		[Token(Token = "0x40024A4")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CA08", Offset = "0x110CA08")]
		public CupCDNSettingDesc cdn_setting;

		// Token: 0x040024A5 RID: 9381
		[Token(Token = "0x40024A5")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CA1C", Offset = "0x110CA1C")]
		public List<CupNameOverwriteDesc> name_overwrite;

		// Token: 0x040024A6 RID: 9382
		[Token(Token = "0x40024A6")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CA30", Offset = "0x110CA30")]
		public List<CupChestDesc> chests;

		// Token: 0x040024A7 RID: 9383
		[Token(Token = "0x40024A7")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CA44", Offset = "0x110CA44")]
		public bool is_in_blocklist;
	}
}
