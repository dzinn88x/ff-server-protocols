using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001D28 RID: 7464
	[Token(Token = "0x2001D28")]
	public class UIManualMapDebrisData : UIManualDataBase
	{
		// Token: 0x0600A295 RID: 41621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A295")]
		[Address(RVA = "0x1E02FD0", Offset = "0x1E02FD0", VA = "0x7BBC602FD0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A296")]
		[Address(RVA = "0x1E033D8", Offset = "0x1E033D8", VA = "0x7BBC6033D8")]
		private void LoadManualMapRewardCSV()
		{
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A297")]
		[Address(RVA = "0x1E02FFC", Offset = "0x1E02FFC", VA = "0x7BBC602FFC")]
		private void CalUnlockMapData()
		{
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A298")]
		[Address(RVA = "0x1DFD310", Offset = "0x1DFD310", VA = "0x7BBC5FD310")]
		public UIManualMapDebrisData()
		{
		}

		// Token: 0x0400A8D5 RID: 43221
		[Token(Token = "0x400A8D5")]
		[FieldOffset(Offset = "0x60")]
		public List<ManualMapReward> m_MapRewardDataList;

		// Token: 0x0400A8D6 RID: 43222
		[Token(Token = "0x400A8D6")]
		[FieldOffset(Offset = "0x68")]
		public List<ManualMapData> m_UnlockMapDataList;

		// Token: 0x02001D29 RID: 7465
		[Token(Token = "0x2001D29")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBB54", Offset = "0x10FBB54")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A29A RID: 41626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A29A")]
			[Address(RVA = "0x1E035A8", Offset = "0x1E035A8", VA = "0x7BBC6035A8")]
			public <>c()
			{
			}

			// Token: 0x0600A29B RID: 41627 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A29B")]
			[Address(RVA = "0x1E035B0", Offset = "0x1E035B0", VA = "0x7BBC6035B0")]
			internal ManualMapReward <LoadManualMapRewardCSV>b__3_0(CSVBaseData temp)
			{
				return null;
			}

			// Token: 0x0600A29C RID: 41628 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A29C")]
			[Address(RVA = "0x1E03630", Offset = "0x1E03630", VA = "0x7BBC603630")]
			internal ManualMapData <CalUnlockMapData>b__4_0(CSVBaseData temp)
			{
				return null;
			}

			// Token: 0x0400A8D7 RID: 43223
			[Token(Token = "0x400A8D7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIManualMapDebrisData.<>c <>9;

			// Token: 0x0400A8D8 RID: 43224
			[Token(Token = "0x400A8D8")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<CSVBaseData, ManualMapReward> <>9__3_0;

			// Token: 0x0400A8D9 RID: 43225
			[Token(Token = "0x400A8D9")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<CSVBaseData, ManualMapData> <>9__4_0;
		}

		// Token: 0x02001D2A RID: 7466
		[Token(Token = "0x2001D2A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBB64", Offset = "0x10FBB64")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x0600A29D RID: 41629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A29D")]
			[Address(RVA = "0x1E0353C", Offset = "0x1E0353C", VA = "0x7BBC60353C")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x0600A29E RID: 41630 RVA: 0x0002AA80 File Offset: 0x00028C80
			[Token(Token = "0x600A29E")]
			[Address(RVA = "0x1E036B0", Offset = "0x1E036B0", VA = "0x7BBC6036B0")]
			internal bool <CalUnlockMapData>b__1(ManualMapData itm)
			{
				return default(bool);
			}

			// Token: 0x0400A8DA RID: 43226
			[Token(Token = "0x400A8DA")]
			[FieldOffset(Offset = "0x10")]
			public uint it;
		}
	}
}
