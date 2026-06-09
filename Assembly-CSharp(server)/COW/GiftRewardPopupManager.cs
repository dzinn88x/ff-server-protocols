using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200165E RID: 5726
	[Token(Token = "0x200165E")]
	public class GiftRewardPopupManager : SingletonModule<GiftRewardPopupManager>
	{
		// Token: 0x06006769 RID: 26473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006769")]
		[Address(RVA = "0x1D8D940", Offset = "0x1D8D940", VA = "0x7BBC58D940", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600676A RID: 26474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676A")]
		[Address(RVA = "0x1D8D944", Offset = "0x1D8D944", VA = "0x7BBC58D944", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600676B RID: 26475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676B")]
		[Address(RVA = "0x1D8D948", Offset = "0x1D8D948", VA = "0x7BBC58D948")]
		public void ShowAwardList(List<GiftRewardPopupData> data)
		{
		}

		// Token: 0x0600676C RID: 26476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676C")]
		[Address(RVA = "0x1D8D9EC", Offset = "0x1D8D9EC", VA = "0x7BBC58D9EC")]
		public void PopupNextRewards(object[] data)
		{
		}

		// Token: 0x0600676D RID: 26477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676D")]
		[Address(RVA = "0x1D8DB40", Offset = "0x1D8DB40", VA = "0x7BBC58DB40")]
		public GiftRewardPopupManager()
		{
		}

		// Token: 0x040084C6 RID: 33990
		[Token(Token = "0x40084C6")]
		[FieldOffset(Offset = "0x18")]
		private List<GiftRewardPopupData> m_GiftMailList;

		// Token: 0x040084C7 RID: 33991
		[Token(Token = "0x40084C7")]
		[FieldOffset(Offset = "0x20")]
		private int m_CurrentPopupIndex;

		// Token: 0x040084C8 RID: 33992
		[Token(Token = "0x40084C8")]
		[FieldOffset(Offset = "0x24")]
		private int m_GiftMailCount;

		// Token: 0x040084C9 RID: 33993
		[Token(Token = "0x40084C9")]
		[FieldOffset(Offset = "0x28")]
		private bool m_Finished;
	}
}
