using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002176 RID: 8566
	[Token(Token = "0x2002176")]
	public class UICollectionEmoteItemView : UIBaseView
	{
		// Token: 0x0600BDFC RID: 48636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDFC")]
		[Address(RVA = "0x20A7DE8", Offset = "0x20A7DE8", VA = "0x7BBC8A7DE8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDFD RID: 48637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDFD")]
		[Address(RVA = "0x20A8338", Offset = "0x20A8338", VA = "0x7BBC8A8338")]
		public UICollectionEmoteItemView()
		{
		}

		// Token: 0x0400C6F9 RID: 50937
		[Token(Token = "0x400C6F9")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400C6FA RID: 50938
		[Token(Token = "0x400C6FA")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Quality;

		// Token: 0x0400C6FB RID: 50939
		[Token(Token = "0x400C6FB")]
		[FieldOffset(Offset = "0x30")]
		public UISprite QualityBG;

		// Token: 0x0400C6FC RID: 50940
		[Token(Token = "0x400C6FC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject gray;

		// Token: 0x0400C6FD RID: 50941
		[Token(Token = "0x400C6FD")]
		[FieldOffset(Offset = "0x40")]
		public UISprite itemSprite;

		// Token: 0x0400C6FE RID: 50942
		[Token(Token = "0x400C6FE")]
		[FieldOffset(Offset = "0x48")]
		public UISprite defaultEmoteSprite;

		// Token: 0x0400C6FF RID: 50943
		[Token(Token = "0x400C6FF")]
		[FieldOffset(Offset = "0x50")]
		public GameObject TipsGO;

		// Token: 0x0400C700 RID: 50944
		[Token(Token = "0x400C700")]
		[FieldOffset(Offset = "0x58")]
		public UILabel TagLabel;

		// Token: 0x0400C701 RID: 50945
		[Token(Token = "0x400C701")]
		[FieldOffset(Offset = "0x60")]
		public GameObject HL;

		// Token: 0x0400C702 RID: 50946
		[Token(Token = "0x400C702")]
		[FieldOffset(Offset = "0x68")]
		public GameObject WL;

		// Token: 0x0400C703 RID: 50947
		[Token(Token = "0x400C703")]
		[FieldOffset(Offset = "0x70")]
		public UISprite stateSprite;

		// Token: 0x0400C704 RID: 50948
		[Token(Token = "0x400C704")]
		[FieldOffset(Offset = "0x78")]
		public UILabel state;

		// Token: 0x0400C705 RID: 50949
		[Token(Token = "0x400C705")]
		[FieldOffset(Offset = "0x80")]
		public UISprite validSprite;

		// Token: 0x0400C706 RID: 50950
		[Token(Token = "0x400C706")]
		[FieldOffset(Offset = "0x88")]
		public UILabel valid;

		// Token: 0x0400C707 RID: 50951
		[Token(Token = "0x400C707")]
		[FieldOffset(Offset = "0x90")]
		public UISprite descSprite;

		// Token: 0x0400C708 RID: 50952
		[Token(Token = "0x400C708")]
		[FieldOffset(Offset = "0x98")]
		public UILabel description;

		// Token: 0x0400C709 RID: 50953
		[Token(Token = "0x400C709")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite RankIcon;

		// Token: 0x0400C70A RID: 50954
		[Token(Token = "0x400C70A")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject Download;

		// Token: 0x0400C70B RID: 50955
		[Token(Token = "0x400C70B")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject DragItem;

		// Token: 0x0400C70C RID: 50956
		[Token(Token = "0x400C70C")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite DragItemIcon;

		// Token: 0x0400C70D RID: 50957
		[Token(Token = "0x400C70D")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton DownloadState;

		// Token: 0x0400C70E RID: 50958
		[Token(Token = "0x400C70E")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite BooyahSpr;
	}
}
