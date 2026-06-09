using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001107 RID: 4359
	[Token(Token = "0x2001107")]
	public class GameModeCategoryData : CSVBaseData
	{
		// Token: 0x06004418 RID: 17432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004418")]
		[Address(RVA = "0x187E504", Offset = "0x187E504", VA = "0x7BBC07E504", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004419")]
		[Address(RVA = "0x187E5A4", Offset = "0x187E5A4", VA = "0x7BBC07E5A4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600441A RID: 17434 RVA: 0x00014E38 File Offset: 0x00013038
		[Token(Token = "0x600441A")]
		[Address(RVA = "0x187E704", Offset = "0x187E704", VA = "0x7BBC07E704")]
		public bool ContainInCategory(uint gamemodeid)
		{
			return default(bool);
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x00014E50 File Offset: 0x00013050
		[Token(Token = "0x600441B")]
		[Address(RVA = "0x187E7EC", Offset = "0x187E7EC", VA = "0x7BBC07E7EC")]
		public static ResourceID GetLadderIconByGameMode(uint gamemodeid, uint rank)
		{
			return default(ResourceID);
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x00014E68 File Offset: 0x00013068
		[Token(Token = "0x600441C")]
		[Address(RVA = "0x187E9AC", Offset = "0x187E9AC", VA = "0x7BBC07E9AC")]
		public static EGameModeCategory GetGameModeCategory(uint gamemodeid)
		{
			return EGameModeCategory.None;
		}

		// Token: 0x0600441D RID: 17437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600441D")]
		[Address(RVA = "0x187EB08", Offset = "0x187EB08", VA = "0x7BBC07EB08")]
		public GameModeCategoryData()
		{
		}

		// Token: 0x04005421 RID: 21537
		[Token(Token = "0x4005421")]
		[FieldOffset(Offset = "0x10")]
		public EGameModeCategory m_Category;

		// Token: 0x04005422 RID: 21538
		[Token(Token = "0x4005422")]
		[FieldOffset(Offset = "0x18")]
		public List<uint> m_GameModes;
	}
}
