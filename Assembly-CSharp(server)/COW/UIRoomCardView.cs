using System;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C78 RID: 7288
	[Token(Token = "0x2001C78")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB88C", Offset = "0x10FB88C")]
	public class UIRoomCardView : MonoBehaviour
	{
		// Token: 0x06009EF9 RID: 40697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EF9")]
		[Address(RVA = "0x1E220A8", Offset = "0x1E220A8", VA = "0x7BBC6220A8")]
		public void SetActive(bool active)
		{
		}

		// Token: 0x06009EFA RID: 40698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EFA")]
		[Address(RVA = "0x1E220E4", Offset = "0x1E220E4", VA = "0x7BBC6220E4")]
		public void Init(EInventory.ItemSubType type)
		{
		}

		// Token: 0x06009EFB RID: 40699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EFB")]
		[Address(RVA = "0x1E22678", Offset = "0x1E22678", VA = "0x7BBC622678")]
		private void OnBtnClick()
		{
		}

		// Token: 0x06009EFC RID: 40700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EFC")]
		[Address(RVA = "0x1E222C4", Offset = "0x1E222C4", VA = "0x7BBC6222C4")]
		public void RefreshLabel(EInventory.ItemSubType type, bool showTime)
		{
		}

		// Token: 0x06009EFD RID: 40701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EFD")]
		[Address(RVA = "0x1E227DC", Offset = "0x1E227DC", VA = "0x7BBC6227DC")]
		public UIRoomCardView()
		{
		}

		// Token: 0x0400A5E9 RID: 42473
		[Token(Token = "0x400A5E9")]
		[FieldOffset(Offset = "0x18")]
		public UIButton Button;

		// Token: 0x0400A5EA RID: 42474
		[Token(Token = "0x400A5EA")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Label;

		// Token: 0x0400A5EB RID: 42475
		[Token(Token = "0x400A5EB")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Sprite;

		// Token: 0x0400A5EC RID: 42476
		[Token(Token = "0x400A5EC")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget Widget;

		// Token: 0x0400A5ED RID: 42477
		[Token(Token = "0x400A5ED")]
		[FieldOffset(Offset = "0x38")]
		private CSSharedItemData ItemData;

		// Token: 0x0400A5EE RID: 42478
		[Token(Token = "0x400A5EE")]
		[FieldOffset(Offset = "0x40")]
		private UICountDownLabel m_CountDownLabel;
	}
}
