using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x02002748 RID: 10056
	[Token(Token = "0x2002748")]
	internal class WDcv\u0082eT : CSVBaseData, IGetId
	{
		// Token: 0x0600D21A RID: 53786 RVA: 0x00038CD0 File Offset: 0x00036ED0
		[Token(Token = "0x600D21A")]
		[Address(RVA = "0x149C57C", Offset = "0x149C57C", VA = "0x7BBBC9C57C", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x0600D21B RID: 53787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D21B")]
		[Address(RVA = "0x149C584", Offset = "0x149C584", VA = "0x7BBBC9C584", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600D21C RID: 53788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D21C")]
		[Address(RVA = "0x149C590", Offset = "0x149C590", VA = "0x7BBBC9C590", Slot = "4")]
		public override void ParseData(long z]|XnJH, int }S\u007Fvb]i, string[] XKssXce, string[] LT|kWDB)
		{
		}

		// Token: 0x0600D21D RID: 53789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D21D")]
		[Address(RVA = "0x149CEA0", Offset = "0x149CEA0", VA = "0x7BBBC9CEA0")]
		public WDcv\u0082eT()
		{
		}

		// Token: 0x04010564 RID: 66916
		[Token(Token = "0x4010564")]
		[FieldOffset(Offset = "0x10")]
		public nS}etYj taWc~\u0080i;

		// Token: 0x04010565 RID: 66917
		[Token(Token = "0x4010565")]
		[FieldOffset(Offset = "0x18")]
		public uint rt[uToO;

		// Token: 0x04010566 RID: 66918
		[Token(Token = "0x4010566")]
		[FieldOffset(Offset = "0x1C")]
		public WDcv\u0082eT.|ufCqpF dYWIuh\u0081;

		// Token: 0x04010567 RID: 66919
		[Token(Token = "0x4010567")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID UDwgMK^;

		// Token: 0x04010568 RID: 66920
		[Token(Token = "0x4010568")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID yOY[vZi;

		// Token: 0x04010569 RID: 66921
		[Token(Token = "0x4010569")]
		[FieldOffset(Offset = "0x28")]
		public bool FxAVPtR;

		// Token: 0x0401056A RID: 66922
		[Token(Token = "0x401056A")]
		[FieldOffset(Offset = "0x2C")]
		public int BdLsKdz;

		// Token: 0x0401056B RID: 66923
		[Token(Token = "0x401056B")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, string> j}]gabU;

		// Token: 0x0401056C RID: 66924
		[Token(Token = "0x401056C")]
		[FieldOffset(Offset = "0x38")]
		public List<string> s}jpax~;

		// Token: 0x02002749 RID: 10057
		[Token(Token = "0x2002749")]
		public enum |ufCqpF
		{
			// Token: 0x0401056E RID: 66926
			[Token(Token = "0x401056E")]
			LoadoutSubType_Campfire,
			// Token: 0x0401056F RID: 66927
			[Token(Token = "0x401056F")]
			LoadoutSubType_Carepackage,
			// Token: 0x04010570 RID: 66928
			[Token(Token = "0x4010570")]
			LoadoutSubType_Treasuremap,
			// Token: 0x04010571 RID: 66929
			[Token(Token = "0x4010571")]
			LoadoutSubType_BountyContract,
			// Token: 0x04010572 RID: 66930
			[Token(Token = "0x4010572")]
			LoadoutSubType_BountyScanner,
			// Token: 0x04010573 RID: 66931
			[Token(Token = "0x4010573")]
			LoadoutSubType_PersonalUAV,
			// Token: 0x04010574 RID: 66932
			[Token(Token = "0x4010574")]
			MAX
		}
	}
}
