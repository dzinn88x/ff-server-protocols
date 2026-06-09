using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000909 RID: 2313
	[Token(Token = "0x2000909")]
	[ProtoContract]
	public class CSChampionshipBasicInfoRes
	{
		// Token: 0x06002617 RID: 9751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x21B04FC", Offset = "0x21B04FC", VA = "0x7BBC9B04FC")]
		public CSChampionshipBasicInfoRes()
		{
		}

		// Token: 0x04002ADC RID: 10972
		[Token(Token = "0x4002ADC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117D18", Offset = "0x1117D18")]
		public List<ChampionshipOpenInfoDesc> open_infos;

		// Token: 0x04002ADD RID: 10973
		[Token(Token = "0x4002ADD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117D2C", Offset = "0x1117D2C")]
		public uint limited_level;

		// Token: 0x04002ADE RID: 10974
		[Token(Token = "0x4002ADE")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117D40", Offset = "0x1117D40")]
		public uint limited_rank;

		// Token: 0x04002ADF RID: 10975
		[Token(Token = "0x4002ADF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117D54", Offset = "0x1117D54")]
		public List<ChampionshipScoreRewardDesc> reward_infos;

		// Token: 0x04002AE0 RID: 10976
		[Token(Token = "0x4002AE0")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117D68", Offset = "0x1117D68")]
		public List<ChampionshipSettingDesc> setting_infos;

		// Token: 0x04002AE1 RID: 10977
		[Token(Token = "0x4002AE1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117D7C", Offset = "0x1117D7C")]
		public List<ChampionshipScoreBaseDesc> score_bases;

		// Token: 0x04002AE2 RID: 10978
		[Token(Token = "0x4002AE2")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117D90", Offset = "0x1117D90")]
		public List<ChampionshipNameOverwriteDesc> name_overwrite_infos;

		// Token: 0x04002AE3 RID: 10979
		[Token(Token = "0x4002AE3")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117DA4", Offset = "0x1117DA4")]
		public List<ChampionshipTeamDesc> team_settings;

		// Token: 0x04002AE4 RID: 10980
		[Token(Token = "0x4002AE4")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117DB8", Offset = "0x1117DB8")]
		public bool isInBlacklist;

		// Token: 0x04002AE5 RID: 10981
		[Token(Token = "0x4002AE5")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117DCC", Offset = "0x1117DCC")]
		public uint upper_limited_level;

		// Token: 0x04002AE6 RID: 10982
		[Token(Token = "0x4002AE6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117DE0", Offset = "0x1117DE0")]
		public uint upper_limited_rank;
	}
}
