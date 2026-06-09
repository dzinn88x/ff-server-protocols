using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001660 RID: 5728
	[Token(Token = "0x2001660")]
	public class RewardPopupManager : SingletonModule<RewardPopupManager>
	{
		// Token: 0x06006774 RID: 26484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006774")]
		[Address(RVA = "0x175DDE8", Offset = "0x175DDE8", VA = "0x7BBBF5DDE8", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06006775 RID: 26485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006775")]
		[Address(RVA = "0x175DEC4", Offset = "0x175DEC4", VA = "0x7BBBF5DEC4", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06006776 RID: 26486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006776")]
		[Address(RVA = "0x175DFA0", Offset = "0x175DFA0", VA = "0x7BBBF5DFA0")]
		private void PopupNextRewards(object[] data)
		{
		}

		// Token: 0x06006777 RID: 26487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006777")]
		[Address(RVA = "0x175E358", Offset = "0x175E358", VA = "0x7BBBF5E358")]
		public RewardPopupManager()
		{
		}

		// Token: 0x040084CF RID: 33999
		[Token(Token = "0x40084CF")]
		private const int MAX_ITEM_SHOWED_PER_POPUP = 5;

		// Token: 0x040084D0 RID: 34000
		[Token(Token = "0x40084D0")]
		[FieldOffset(Offset = "0x18")]
		private List<BaseItemInfo> m_CachedBaseItemInfo;

		// Token: 0x040084D1 RID: 34001
		[Token(Token = "0x40084D1")]
		[FieldOffset(Offset = "0x20")]
		private RewardPopupData m_RewardData;

		// Token: 0x040084D2 RID: 34002
		[Token(Token = "0x40084D2")]
		[FieldOffset(Offset = "0x28")]
		private int m_CurrentPopupIndex;

		// Token: 0x040084D3 RID: 34003
		[Token(Token = "0x40084D3")]
		[FieldOffset(Offset = "0x2C")]
		private int m_RewardItemCount;

		// Token: 0x040084D4 RID: 34004
		[Token(Token = "0x40084D4")]
		[FieldOffset(Offset = "0x30")]
		private bool m_Finished;
	}
}
