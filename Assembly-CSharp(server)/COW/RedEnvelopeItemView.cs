using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025A9 RID: 9641
	[Token(Token = "0x20025A9")]
	internal class RedEnvelopeItemView : MonoBehaviour
	{
		// Token: 0x0600C665 RID: 50789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C665")]
		[Address(RVA = "0x17529B8", Offset = "0x17529B8", VA = "0x7BBBF529B8")]
		private void Start()
		{
		}

		// Token: 0x0600C666 RID: 50790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C666")]
		[Address(RVA = "0x1752AB4", Offset = "0x1752AB4", VA = "0x7BBBF52AB4")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C667 RID: 50791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C667")]
		[Address(RVA = "0x1752BB0", Offset = "0x1752BB0", VA = "0x7BBBF52BB0")]
		public void SetItemData(nQJxQBO itemInfo)
		{
		}

		// Token: 0x0600C668 RID: 50792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C668")]
		[Address(RVA = "0x1752D24", Offset = "0x1752D24", VA = "0x7BBBF52D24")]
		public void OnRedPackageBtnClick()
		{
		}

		// Token: 0x0600C669 RID: 50793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C669")]
		[Address(RVA = "0x1752E28", Offset = "0x1752E28", VA = "0x7BBBF52E28")]
		public RedEnvelopeItemView()
		{
		}

		// Token: 0x0400F8F8 RID: 63736
		[Token(Token = "0x400F8F8")]
		[FieldOffset(Offset = "0x18")]
		public UISprite m_ItemIcon;

		// Token: 0x0400F8F9 RID: 63737
		[Token(Token = "0x400F8F9")]
		[FieldOffset(Offset = "0x20")]
		public UIButton m_ItemBtn;

		// Token: 0x0400F8FA RID: 63738
		[Token(Token = "0x400F8FA")]
		[FieldOffset(Offset = "0x28")]
		public UILabel m_ItemCount;

		// Token: 0x0400F8FB RID: 63739
		[Token(Token = "0x400F8FB")]
		[FieldOffset(Offset = "0x30")]
		private nQJxQBO m_RedEnvelopeItem;
	}
}
