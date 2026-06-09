using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012EC RID: 4844
	[Token(Token = "0x20012EC")]
	public class DevSpecWhitelistData : CSVBaseData
	{
		// Token: 0x06004CA3 RID: 19619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA3")]
		[Address(RVA = "0x1604E3C", Offset = "0x1604E3C", VA = "0x7BBBE04E3C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004CA4 RID: 19620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA4")]
		[Address(RVA = "0x1604E48", Offset = "0x1604E48", VA = "0x7BBBE04E48", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004CA5 RID: 19621 RVA: 0x00016F38 File Offset: 0x00015138
		[Token(Token = "0x6004CA5")]
		[Address(RVA = "0x1605224", Offset = "0x1605224", VA = "0x7BBBE05224")]
		private int GetStringCompDistance(string InBase, string InTarget)
		{
			return 0;
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x00016F50 File Offset: 0x00015150
		[Token(Token = "0x6004CA6")]
		[Address(RVA = "0x160530C", Offset = "0x160530C", VA = "0x7BBBE0530C")]
		public bool SetupSortPriority(string InCurDeviceName, string InCurCPU, string InCurGPU, int InCurSysMemSize)
		{
			return default(bool);
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA7")]
		[Address(RVA = "0x160539C", Offset = "0x160539C", VA = "0x7BBBE0539C")]
		private void SetupSortPriorityForItems(string InCurCPU, string InCurGPU, int InCurSysMemSize)
		{
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA8")]
		[Address(RVA = "0x1605478", Offset = "0x1605478", VA = "0x7BBBE05478")]
		public DevSpecWhitelistData()
		{
		}

		// Token: 0x04007431 RID: 29745
		[Token(Token = "0x4007431")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04007432 RID: 29746
		[Token(Token = "0x4007432")]
		[FieldOffset(Offset = "0x18")]
		public string strDeviceName;

		// Token: 0x04007433 RID: 29747
		[Token(Token = "0x4007433")]
		[FieldOffset(Offset = "0x20")]
		public string strOS;

		// Token: 0x04007434 RID: 29748
		[Token(Token = "0x4007434")]
		[FieldOffset(Offset = "0x28")]
		public string strCPU;

		// Token: 0x04007435 RID: 29749
		[Token(Token = "0x4007435")]
		[FieldOffset(Offset = "0x30")]
		public string strGPU;

		// Token: 0x04007436 RID: 29750
		[Token(Token = "0x4007436")]
		[FieldOffset(Offset = "0x38")]
		public uint[] uRAMRange;

		// Token: 0x04007437 RID: 29751
		[Token(Token = "0x4007437")]
		[FieldOffset(Offset = "0x40")]
		public GGfm}Dt eQualityLevel;

		// Token: 0x04007438 RID: 29752
		[Token(Token = "0x4007438")]
		[FieldOffset(Offset = "0x44")]
		public Rqvv|Tq eGraphicLevel;

		// Token: 0x04007439 RID: 29753
		[Token(Token = "0x4007439")]
		[FieldOffset(Offset = "0x48")]
		public Rqvv|Tq eMapDesertGraphicLevel;

		// Token: 0x0400743A RID: 29754
		[Token(Token = "0x400743A")]
		[FieldOffset(Offset = "0x4C")]
		public bool bShowHighFramerateUI;

		// Token: 0x0400743B RID: 29755
		[Token(Token = "0x400743B")]
		[FieldOffset(Offset = "0x4D")]
		public bool bEnableHighFramerateDefault;

		// Token: 0x0400743C RID: 29756
		[Token(Token = "0x400743C")]
		[FieldOffset(Offset = "0x4E")]
		public bool bEnableRTShadow;

		// Token: 0x0400743D RID: 29757
		[Token(Token = "0x400743D")]
		[FieldOffset(Offset = "0x4F")]
		public bool bEnableHDGraphics;

		// Token: 0x0400743E RID: 29758
		[Token(Token = "0x400743E")]
		[FieldOffset(Offset = "0x50")]
		public int iUnloadTime;

		// Token: 0x0400743F RID: 29759
		[Token(Token = "0x400743F")]
		[FieldOffset(Offset = "0x54")]
		public int iUnloadMemory;

		// Token: 0x04007440 RID: 29760
		[Token(Token = "0x4007440")]
		[FieldOffset(Offset = "0x58")]
		public bool bLowMemeoryIOS;

		// Token: 0x04007441 RID: 29761
		[Token(Token = "0x4007441")]
		[FieldOffset(Offset = "0x5C")]
		public int iSortPriority;

		// Token: 0x04007442 RID: 29762
		[Token(Token = "0x4007442")]
		[FieldOffset(Offset = "0x60")]
		public float resolutionReduceRate;

		// Token: 0x04007443 RID: 29763
		[Token(Token = "0x4007443")]
		[FieldOffset(Offset = "0x64")]
		public bool IsBountyForceUseLowResource;

		// Token: 0x04007444 RID: 29764
		[Token(Token = "0x4007444")]
		[FieldOffset(Offset = "0x65")]
		public bool bUnloadEmbeddedSceneObjects;
	}
}
