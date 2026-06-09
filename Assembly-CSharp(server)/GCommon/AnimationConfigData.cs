using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EEA RID: 3818
	[Token(Token = "0x2000EEA")]
	public class AnimationConfigData : CSVBaseData
	{
		// Token: 0x06003537 RID: 13623 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		[Token(Token = "0x6003537")]
		[Address(RVA = "0x25D89C8", Offset = "0x25D89C8", VA = "0x7BBCDD89C8")]
		private static int GetNextID(int layerIndex)
		{
			return 0;
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003538")]
		[Address(RVA = "0x25D8AC8", Offset = "0x25D8AC8", VA = "0x7BBCDD8AC8")]
		public static void OnCleanup()
		{
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003539")]
		[Address(RVA = "0x25D8B54", Offset = "0x25D8B54", VA = "0x7BBCDD8B54")]
		public static AnimationConfigData GetFinishConfigData(int hash)
		{
			return null;
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600353A")]
		[Address(RVA = "0x25D8BF8", Offset = "0x25D8BF8", VA = "0x7BBCDD8BF8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x00010008 File Offset: 0x0000E208
		[Token(Token = "0x600353B")]
		[Address(RVA = "0x25D8C00", Offset = "0x25D8C00", VA = "0x7BBCDD8C00")]
		private AnimationID GetAnimationID(string from, int layer)
		{
			return default(AnimationID);
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353C")]
		[Address(RVA = "0x25D8ED4", Offset = "0x25D8ED4", VA = "0x7BBCDD8ED4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600353D")]
		[Address(RVA = "0x25D933C", Offset = "0x25D933C", VA = "0x7BBCDD933C")]
		public AnimationConfigData()
		{
		}

		// Token: 0x0400489D RID: 18589
		[Token(Token = "0x400489D")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, int> sGenID;

		// Token: 0x0400489E RID: 18590
		[Token(Token = "0x400489E")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, AnimationConfigData> hashToData;

		// Token: 0x0400489F RID: 18591
		[Token(Token = "0x400489F")]
		[FieldOffset(Offset = "0x10")]
		public AnimationID AnimID;

		// Token: 0x040048A0 RID: 18592
		[Token(Token = "0x40048A0")]
		[FieldOffset(Offset = "0x18")]
		public string AnimIDName;

		// Token: 0x040048A1 RID: 18593
		[Token(Token = "0x40048A1")]
		[FieldOffset(Offset = "0x20")]
		public string TargetStateName;

		// Token: 0x040048A2 RID: 18594
		[Token(Token = "0x40048A2")]
		[FieldOffset(Offset = "0x28")]
		public float TransitionDuration;

		// Token: 0x040048A3 RID: 18595
		[Token(Token = "0x40048A3")]
		[FieldOffset(Offset = "0x2C")]
		public bool NeedWaitForFinished;

		// Token: 0x040048A4 RID: 18596
		[Token(Token = "0x40048A4")]
		[FieldOffset(Offset = "0x30")]
		public float EndCutTime;

		// Token: 0x040048A5 RID: 18597
		[Token(Token = "0x40048A5")]
		[FieldOffset(Offset = "0x34")]
		public bool ToDefault;

		// Token: 0x040048A6 RID: 18598
		[Token(Token = "0x40048A6")]
		[FieldOffset(Offset = "0x38")]
		public AnimationID FinishedID;
	}
}
