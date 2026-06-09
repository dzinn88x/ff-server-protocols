using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001186 RID: 4486
	[Token(Token = "0x2001186")]
	public class ServerSettingsData : CSVBaseData
	{
		// Token: 0x060045CA RID: 17866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045CA")]
		[Address(RVA = "0x1B3418C", Offset = "0x1B3418C", VA = "0x7BBC33418C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CB")]
		[Address(RVA = "0x1B34198", Offset = "0x1B34198", VA = "0x7BBC334198", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CC")]
		[Address(RVA = "0x1B34310", Offset = "0x1B34310", VA = "0x7BBC334310")]
		public ServerSettingsData()
		{
		}

		// Token: 0x040056DA RID: 22234
		[Token(Token = "0x40056DA")]
		public const string SBT_SERVER = "1";

		// Token: 0x040056DB RID: 22235
		[Token(Token = "0x40056DB")]
		public const string LIVE_SERVER = "2";

		// Token: 0x040056DC RID: 22236
		[Token(Token = "0x40056DC")]
		public const string IOS_SERVER = "3";

		// Token: 0x040056DD RID: 22237
		[Token(Token = "0x40056DD")]
		public const string RCT_SERVER = "4";

		// Token: 0x040056DE RID: 22238
		[Token(Token = "0x40056DE")]
		public const string PREVIEW_SERVER = "5";

		// Token: 0x040056DF RID: 22239
		[Token(Token = "0x40056DF")]
		public const string BETA_SERVER = "6";

		// Token: 0x040056E0 RID: 22240
		[Token(Token = "0x40056E0")]
		public const string EXP_SERVER = "7";

		// Token: 0x040056E1 RID: 22241
		[Token(Token = "0x40056E1")]
		public const string ART_SERVER = "8";

		// Token: 0x040056E2 RID: 22242
		[Token(Token = "0x40056E2")]
		public const string DESIGN_SERVER = "9";

		// Token: 0x040056E3 RID: 22243
		[Token(Token = "0x40056E3")]
		public const string ACT_SERVER = "10";

		// Token: 0x040056E4 RID: 22244
		[Token(Token = "0x40056E4")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x040056E5 RID: 22245
		[Token(Token = "0x40056E5")]
		[FieldOffset(Offset = "0x18")]
		public string ServerAdd;

		// Token: 0x040056E6 RID: 22246
		[Token(Token = "0x40056E6")]
		[FieldOffset(Offset = "0x20")]
		public string BillboardServerAdd;

		// Token: 0x040056E7 RID: 22247
		[Token(Token = "0x40056E7")]
		[FieldOffset(Offset = "0x28")]
		public bool IsIOSReview;

		// Token: 0x040056E8 RID: 22248
		[Token(Token = "0x40056E8")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x040056E9 RID: 22249
		[Token(Token = "0x40056E9")]
		[FieldOffset(Offset = "0x38")]
		public bool Production;
	}
}
