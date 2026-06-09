using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020CA RID: 8394
	[Token(Token = "0x20020CA")]
	public class MatchResultRewardItemView : MonoBehaviour
	{
		// Token: 0x0600BCA5 RID: 48293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA5")]
		[Address(RVA = "0x1A5CB50", Offset = "0x1A5CB50", VA = "0x7BBC25CB50")]
		public void SetItemData(BaseItemInfo rewardInfo)
		{
		}

		// Token: 0x0600BCA6 RID: 48294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA6")]
		[Address(RVA = "0x1A5CC64", Offset = "0x1A5CC64", VA = "0x7BBC25CC64")]
		public MatchResultRewardItemView()
		{
		}

		// Token: 0x0400BE1F RID: 48671
		[Token(Token = "0x400BE1F")]
		[FieldOffset(Offset = "0x18")]
		public UILabel m_ItemNameLabel;

		// Token: 0x0400BE20 RID: 48672
		[Token(Token = "0x400BE20")]
		[FieldOffset(Offset = "0x20")]
		public UILabel m_ItemCountLabel;
	}
}
