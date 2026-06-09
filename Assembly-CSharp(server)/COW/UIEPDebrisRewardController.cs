using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014F7 RID: 5367
	[Token(Token = "0x20014F7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDE24", Offset = "0x10EDE24")]
	public class UIEPDebrisRewardController : UIPopupWindowController
	{
		// Token: 0x06005C07 RID: 23559 RVA: 0x0001AD60 File Offset: 0x00018F60
		[Token(Token = "0x6005C07")]
		[Address(RVA = "0x2214BFC", Offset = "0x2214BFC", VA = "0x7BBCA14BFC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C08")]
		[Address(RVA = "0x2214C4C", Offset = "0x2214C4C", VA = "0x7BBCA14C4C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005C09 RID: 23561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C09")]
		[Address(RVA = "0x2214EA4", Offset = "0x2214EA4", VA = "0x7BBCA14EA4")]
		private void Update()
		{
		}

		// Token: 0x06005C0A RID: 23562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0A")]
		[Address(RVA = "0x22152CC", Offset = "0x22152CC", VA = "0x7BBCA152CC")]
		public void InitSlider(uint oldBadgeCnt, uint curBadgeCnt, uint oldDebrisCnt, uint curDebrisCnt)
		{
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x0001AD78 File Offset: 0x00018F78
		[Token(Token = "0x6005C0B")]
		[Address(RVA = "0x2214EF0", Offset = "0x2214EF0", VA = "0x7BBCA14EF0")]
		private bool DoUpdateBarVal(float time)
		{
			return default(bool);
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0C")]
		[Address(RVA = "0x22152C4", Offset = "0x22152C4", VA = "0x7BBCA152C4")]
		private void EndBarProcess()
		{
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0x22157A8", Offset = "0x22157A8", VA = "0x7BBCA157A8")]
		private void ProcessBarDone()
		{
		}

		// Token: 0x06005C0E RID: 23566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0E")]
		[Address(RVA = "0x22159C4", Offset = "0x22159C4", VA = "0x7BBCA159C4")]
		private void OnSkipClick()
		{
		}

		// Token: 0x06005C0F RID: 23567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0x22159DC", Offset = "0x22159DC", VA = "0x7BBCA159DC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06005C10 RID: 23568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C10")]
		[Address(RVA = "0x22159E4", Offset = "0x22159E4", VA = "0x7BBCA159E4")]
		public UIEPDebrisRewardController()
		{
		}

		// Token: 0x04007E4A RID: 32330
		[Token(Token = "0x4007E4A")]
		[FieldOffset(Offset = "0x98")]
		private UIEPDebrisRewardView m_View;

		// Token: 0x04007E4B RID: 32331
		[Token(Token = "0x4007E4B")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelElitePass m_Model;

		// Token: 0x04007E4C RID: 32332
		[Token(Token = "0x4007E4C")]
		[FieldOffset(Offset = "0xA8")]
		private int DebrisRate;

		// Token: 0x04007E4D RID: 32333
		[Token(Token = "0x4007E4D")]
		[FieldOffset(Offset = "0xB0")]
		private Queue<UIEPDebrisRewardController.ProgressInfo> progressQueue;

		// Token: 0x04007E4E RID: 32334
		[Token(Token = "0x4007E4E")]
		[FieldOffset(Offset = "0xB8")]
		private UIEPDebrisRewardController.ProgressInfo currentProgressInfo;

		// Token: 0x04007E4F RID: 32335
		[Token(Token = "0x4007E4F")]
		[FieldOffset(Offset = "0xC8")]
		private bool DoneCurProgress;

		// Token: 0x04007E50 RID: 32336
		[Token(Token = "0x4007E50")]
		[FieldOffset(Offset = "0xCC")]
		private int mBeginVal;

		// Token: 0x04007E51 RID: 32337
		[Token(Token = "0x4007E51")]
		[FieldOffset(Offset = "0xD0")]
		private int mIncreaseVal;

		// Token: 0x04007E52 RID: 32338
		[Token(Token = "0x4007E52")]
		[FieldOffset(Offset = "0xD4")]
		private int sliderSpeed;

		// Token: 0x04007E53 RID: 32339
		[Token(Token = "0x4007E53")]
		[FieldOffset(Offset = "0xD8")]
		private int mOldBadgeCnt;

		// Token: 0x04007E54 RID: 32340
		[Token(Token = "0x4007E54")]
		[FieldOffset(Offset = "0xDC")]
		private int mCurBadgeCnt;

		// Token: 0x04007E55 RID: 32341
		[Token(Token = "0x4007E55")]
		[FieldOffset(Offset = "0xE0")]
		private bool canShow;

		// Token: 0x04007E56 RID: 32342
		[Token(Token = "0x4007E56")]
		[FieldOffset(Offset = "0xE1")]
		private bool isShowing;

		// Token: 0x020014F8 RID: 5368
		[Token(Token = "0x20014F8")]
		private struct ProgressInfo
		{
			// Token: 0x04007E57 RID: 32343
			[Token(Token = "0x4007E57")]
			[FieldOffset(Offset = "0x0")]
			public float CurPercent;

			// Token: 0x04007E58 RID: 32344
			[Token(Token = "0x4007E58")]
			[FieldOffset(Offset = "0x4")]
			public float BeginProgressVal;

			// Token: 0x04007E59 RID: 32345
			[Token(Token = "0x4007E59")]
			[FieldOffset(Offset = "0x8")]
			public float EndProgressVal;

			// Token: 0x04007E5A RID: 32346
			[Token(Token = "0x4007E5A")]
			[FieldOffset(Offset = "0xC")]
			public float Speed;
		}
	}
}
