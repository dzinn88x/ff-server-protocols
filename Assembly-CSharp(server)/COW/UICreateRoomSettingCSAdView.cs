using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200218D RID: 8589
	[Token(Token = "0x200218D")]
	public class UICreateRoomSettingCSAdView : UIBaseView
	{
		// Token: 0x0600BE2A RID: 48682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE2A")]
		[Address(RVA = "0x1BA2ED8", Offset = "0x1BA2ED8", VA = "0x7BBC3A2ED8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE2B RID: 48683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE2B")]
		[Address(RVA = "0x1BA35A8", Offset = "0x1BA35A8", VA = "0x7BBC3A35A8")]
		public UICreateRoomSettingCSAdView()
		{
		}

		// Token: 0x0400C7E2 RID: 51170
		[Token(Token = "0x400C7E2")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UnavailablePanel;

		// Token: 0x0400C7E3 RID: 51171
		[Token(Token = "0x400C7E3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SettingPanel;

		// Token: 0x0400C7E4 RID: 51172
		[Token(Token = "0x400C7E4")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Mask;

		// Token: 0x0400C7E5 RID: 51173
		[Token(Token = "0x400C7E5")]
		[FieldOffset(Offset = "0x38")]
		public UIButton MaskBtn;

		// Token: 0x0400C7E6 RID: 51174
		[Token(Token = "0x400C7E6")]
		[FieldOffset(Offset = "0x40")]
		public UIDragScrollView MaskDrag;

		// Token: 0x0400C7E7 RID: 51175
		[Token(Token = "0x400C7E7")]
		[FieldOffset(Offset = "0x48")]
		public GameObject CSAdSettingBtns;

		// Token: 0x0400C7E8 RID: 51176
		[Token(Token = "0x400C7E8")]
		[FieldOffset(Offset = "0x50")]
		public UIToggleButton CSStoreSettingToggleBtn;

		// Token: 0x0400C7E9 RID: 51177
		[Token(Token = "0x400C7E9")]
		[FieldOffset(Offset = "0x58")]
		public UIToggleButton CSEcoSettingToggleBtn;

		// Token: 0x0400C7EA RID: 51178
		[Token(Token = "0x400C7EA")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ToggleCSAd;

		// Token: 0x0400C7EB RID: 51179
		[Token(Token = "0x400C7EB")]
		[FieldOffset(Offset = "0x68")]
		public UIButton TipsBtn;

		// Token: 0x0400C7EC RID: 51180
		[Token(Token = "0x400C7EC")]
		[FieldOffset(Offset = "0x70")]
		public UIToggle CheckBtn;

		// Token: 0x0400C7ED RID: 51181
		[Token(Token = "0x400C7ED")]
		[FieldOffset(Offset = "0x78")]
		public UISprite OnToggleSprite;

		// Token: 0x0400C7EE RID: 51182
		[Token(Token = "0x400C7EE")]
		[FieldOffset(Offset = "0x80")]
		public GameObject CSStoreSettingPanel;

		// Token: 0x0400C7EF RID: 51183
		[Token(Token = "0x400C7EF")]
		[FieldOffset(Offset = "0x88")]
		public UILabel ItemCnVal;

		// Token: 0x0400C7F0 RID: 51184
		[Token(Token = "0x400C7F0")]
		[FieldOffset(Offset = "0x90")]
		public UIScrollView CSStoreSettingSV;

		// Token: 0x0400C7F1 RID: 51185
		[Token(Token = "0x400C7F1")]
		[FieldOffset(Offset = "0x98")]
		public UITable CSStoreSettingTable;

		// Token: 0x0400C7F2 RID: 51186
		[Token(Token = "0x400C7F2")]
		[FieldOffset(Offset = "0xA0")]
		public UIWidget CSStoreSettingWidget;

		// Token: 0x0400C7F3 RID: 51187
		[Token(Token = "0x400C7F3")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject WeaponDropGo;

		// Token: 0x0400C7F4 RID: 51188
		[Token(Token = "0x400C7F4")]
		[FieldOffset(Offset = "0xB0")]
		public UIGrid WeaponListGrid;

		// Token: 0x0400C7F5 RID: 51189
		[Token(Token = "0x400C7F5")]
		[FieldOffset(Offset = "0xB8")]
		public UIGrid ItemListGrid;

		// Token: 0x0400C7F6 RID: 51190
		[Token(Token = "0x400C7F6")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject CSEcoSettingPanel;

		// Token: 0x0400C7F7 RID: 51191
		[Token(Token = "0x400C7F7")]
		[FieldOffset(Offset = "0xC8")]
		public UIScrollView CSEcoSettingSV;

		// Token: 0x0400C7F8 RID: 51192
		[Token(Token = "0x400C7F8")]
		[FieldOffset(Offset = "0xD0")]
		public UITable CSEcoSettingTable;

		// Token: 0x0400C7F9 RID: 51193
		[Token(Token = "0x400C7F9")]
		[FieldOffset(Offset = "0xD8")]
		public UIWidget CSEcoSettingWidget;

		// Token: 0x0400C7FA RID: 51194
		[Token(Token = "0x400C7FA")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject RoundDropGo;

		// Token: 0x0400C7FB RID: 51195
		[Token(Token = "0x400C7FB")]
		[FieldOffset(Offset = "0xE8")]
		public UIGrid RoundListGrid;

		// Token: 0x0400C7FC RID: 51196
		[Token(Token = "0x400C7FC")]
		[FieldOffset(Offset = "0xF0")]
		public UIGrid OthersListGrid;
	}
}
