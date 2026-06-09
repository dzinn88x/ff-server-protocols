using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011A6 RID: 4518
	[Token(Token = "0x20011A6")]
	public class WeaponSkinUpgradeInfoData : CSVBaseData
	{
		// Token: 0x06004649 RID: 17993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004649")]
		[Address(RVA = "0x17A07B8", Offset = "0x17A07B8", VA = "0x7BBBFA07B8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464A")]
		[Address(RVA = "0x17A07E4", Offset = "0x17A07E4", VA = "0x7BBBFA07E4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464B")]
		[Address(RVA = "0x17A090C", Offset = "0x17A090C", VA = "0x7BBBFA090C")]
		public WeaponSkinUpgradeInfoData()
		{
		}

		// Token: 0x04005796 RID: 22422
		[Token(Token = "0x4005796")]
		[FieldOffset(Offset = "0x10")]
		public WeaponSkinFeature FeatureInThisLevel;

		// Token: 0x04005797 RID: 22423
		[Token(Token = "0x4005797")]
		[FieldOffset(Offset = "0x14")]
		public ResourceID Icon;

		// Token: 0x04005798 RID: 22424
		[Token(Token = "0x4005798")]
		[FieldOffset(Offset = "0x18")]
		public string TitleKey;
	}
}
