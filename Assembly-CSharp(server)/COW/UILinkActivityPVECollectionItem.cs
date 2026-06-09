using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200154B RID: 5451
	[Token(Token = "0x200154B")]
	public class UILinkActivityPVECollectionItem : MonoBehaviour
	{
		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06005E40 RID: 24128 RVA: 0x0001B528 File Offset: 0x00019728
		[Token(Token = "0x170008B2")]
		private bool m_IsOpenGameItem
		{
			[Token(Token = "0x6005E40")]
			[Address(RVA = "0x1CBDE4C", Offset = "0x1CBDE4C", VA = "0x7BBC4BDE4C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005E41 RID: 24129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E41")]
		[Address(RVA = "0x1CBDEC4", Offset = "0x1CBDEC4", VA = "0x7BBC4BDEC4")]
		public void Init(int collectionIndex, UILinkActivityPVECollectionItem.OnItemClick onClick)
		{
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E42")]
		[Address(RVA = "0x1CBE0B0", Offset = "0x1CBE0B0", VA = "0x7BBC4BE0B0")]
		private void OnGiftBtnClick()
		{
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E43")]
		[Address(RVA = "0x1CBE75C", Offset = "0x1CBE75C", VA = "0x7BBC4BE75C")]
		private void OnOpenBtnClick()
		{
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E44")]
		[Address(RVA = "0x1CBE9C8", Offset = "0x1CBE9C8", VA = "0x7BBC4BE9C8")]
		public void UpdateInfo(string count, uint processID, ENUM_CollectionState itemState)
		{
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E45")]
		[Address(RVA = "0x1CBEAA8", Offset = "0x1CBEAA8", VA = "0x7BBC4BEAA8")]
		private void UpdateGiftInfo()
		{
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E46")]
		[Address(RVA = "0x1CBEA38", Offset = "0x1CBEA38", VA = "0x7BBC4BEA38")]
		private void UpdateOpenGameInfo()
		{
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E47")]
		[Address(RVA = "0x1CBEBB0", Offset = "0x1CBEBB0", VA = "0x7BBC4BEBB0")]
		private void UpdateProgressIcon()
		{
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E48")]
		[Address(RVA = "0x1CBEDB8", Offset = "0x1CBEDB8", VA = "0x7BBC4BEDB8")]
		public UILinkActivityPVECollectionItem()
		{
		}

		// Token: 0x04007F96 RID: 32662
		[Token(Token = "0x4007F96")]
		[FieldOffset(Offset = "0x18")]
		public UISprite m_ProgressIcon;

		// Token: 0x04007F97 RID: 32663
		[Token(Token = "0x4007F97")]
		[FieldOffset(Offset = "0x20")]
		public UILabel m_ProgressLabel;

		// Token: 0x04007F98 RID: 32664
		[Token(Token = "0x4007F98")]
		[FieldOffset(Offset = "0x28")]
		public GameObject m_ProgressIconReadyContainer;

		// Token: 0x04007F99 RID: 32665
		[Token(Token = "0x4007F99")]
		[FieldOffset(Offset = "0x30")]
		public GameObject m_GiftContainer;

		// Token: 0x04007F9A RID: 32666
		[Token(Token = "0x4007F9A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject m_GiftNormalContainer;

		// Token: 0x04007F9B RID: 32667
		[Token(Token = "0x4007F9B")]
		[FieldOffset(Offset = "0x40")]
		public GameObject m_GiftReadyContainer;

		// Token: 0x04007F9C RID: 32668
		[Token(Token = "0x4007F9C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject m_GiftFinishContainer;

		// Token: 0x04007F9D RID: 32669
		[Token(Token = "0x4007F9D")]
		[FieldOffset(Offset = "0x50")]
		public UIButton m_GiftBtn;

		// Token: 0x04007F9E RID: 32670
		[Token(Token = "0x4007F9E")]
		[FieldOffset(Offset = "0x58")]
		public GameObject m_OpenGameContainer;

		// Token: 0x04007F9F RID: 32671
		[Token(Token = "0x4007F9F")]
		[FieldOffset(Offset = "0x60")]
		public UIButton m_OpenBtn;

		// Token: 0x04007FA0 RID: 32672
		[Token(Token = "0x4007FA0")]
		[FieldOffset(Offset = "0x68")]
		public GameObject m_OpenReadyContainer;

		// Token: 0x04007FA1 RID: 32673
		[Token(Token = "0x4007FA1")]
		[FieldOffset(Offset = "0x70")]
		private uint m_ProcessID;

		// Token: 0x04007FA2 RID: 32674
		[Token(Token = "0x4007FA2")]
		[FieldOffset(Offset = "0x74")]
		private ENUM_CollectionState m_CurState;

		// Token: 0x04007FA3 RID: 32675
		[Token(Token = "0x4007FA3")]
		[FieldOffset(Offset = "0x78")]
		public UILinkActivityPVECollectionItem.OnItemClick m_OnItemClick;

		// Token: 0x0200154C RID: 5452
		// (Invoke) Token: 0x06005E4A RID: 24138
		[Token(Token = "0x200154C")]
		public delegate void OnItemClick(uint processID);
	}
}
