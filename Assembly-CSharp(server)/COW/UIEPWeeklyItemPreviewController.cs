using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001506 RID: 5382
	[Token(Token = "0x2001506")]
	public class UIEPWeeklyItemPreviewController : MonoBehaviour
	{
		// Token: 0x06005C59 RID: 23641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C59")]
		[Address(RVA = "0x1AD1454", Offset = "0x1AD1454", VA = "0x7BBC2D1454")]
		public void Awake()
		{
		}

		// Token: 0x06005C5A RID: 23642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5A")]
		[Address(RVA = "0x1AD1508", Offset = "0x1AD1508", VA = "0x7BBC2D1508")]
		private void OnClick()
		{
		}

		// Token: 0x06005C5B RID: 23643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5B")]
		[Address(RVA = "0x1AD1630", Offset = "0x1AD1630", VA = "0x7BBC2D1630")]
		public void SetData(int idx, EPWeeklyQuestGroupData data)
		{
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5C")]
		[Address(RVA = "0x1AD1884", Offset = "0x1AD1884", VA = "0x7BBC2D1884")]
		private void SetCDN(string url)
		{
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5D")]
		[Address(RVA = "0x1AD163C", Offset = "0x1AD163C", VA = "0x7BBC2D163C")]
		private void RefreshUI()
		{
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5E")]
		[Address(RVA = "0x1AD1A78", Offset = "0x1AD1A78", VA = "0x7BBC2D1A78")]
		private void RefreshProcess()
		{
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C5F")]
		[Address(RVA = "0x1AD194C", Offset = "0x1AD194C", VA = "0x7BBC2D194C")]
		private string GetOpenDay(DateTime sTime)
		{
			return null;
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C60")]
		[Address(RVA = "0x1AD1E00", Offset = "0x1AD1E00", VA = "0x7BBC2D1E00")]
		public UIEPWeeklyItemPreviewController()
		{
		}

		// Token: 0x04007E87 RID: 32391
		[Token(Token = "0x4007E87")]
		[FieldOffset(Offset = "0x18")]
		public GameObject LockGo;

		// Token: 0x04007E88 RID: 32392
		[Token(Token = "0x4007E88")]
		[FieldOffset(Offset = "0x20")]
		public UIProgressBar ProgressBar;

		// Token: 0x04007E89 RID: 32393
		[Token(Token = "0x4007E89")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ProgressCnt;

		// Token: 0x04007E8A RID: 32394
		[Token(Token = "0x4007E8A")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Desc;

		// Token: 0x04007E8B RID: 32395
		[Token(Token = "0x4007E8B")]
		[FieldOffset(Offset = "0x38")]
		public UIButton Btn;

		// Token: 0x04007E8C RID: 32396
		[Token(Token = "0x4007E8C")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTexture CDNBG;

		// Token: 0x04007E8D RID: 32397
		[Token(Token = "0x4007E8D")]
		[FieldOffset(Offset = "0x48")]
		private EPWeeklyQuestGroupData m_Data;

		// Token: 0x04007E8E RID: 32398
		[Token(Token = "0x4007E8E")]
		[FieldOffset(Offset = "0x50")]
		private int index;

		// Token: 0x04007E8F RID: 32399
		[Token(Token = "0x4007E8F")]
		[FieldOffset(Offset = "0x58")]
		public UILabel OpenDay;
	}
}
