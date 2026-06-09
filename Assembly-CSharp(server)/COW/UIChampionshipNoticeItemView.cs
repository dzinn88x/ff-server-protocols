using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002135 RID: 8501
	[Token(Token = "0x2002135")]
	public class UIChampionshipNoticeItemView : UIBaseView
	{
		// Token: 0x0600BD7A RID: 48506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD7A")]
		[Address(RVA = "0x1EC8320", Offset = "0x1EC8320", VA = "0x7BBC6C8320", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD7B RID: 48507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD7B")]
		[Address(RVA = "0x1EC8410", Offset = "0x1EC8410", VA = "0x7BBC6C8410")]
		public UIChampionshipNoticeItemView()
		{
		}

		// Token: 0x0400C3A3 RID: 50083
		[Token(Token = "0x400C3A3")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnNoticeItem;

		// Token: 0x0400C3A4 RID: 50084
		[Token(Token = "0x400C3A4")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture CDNTexture;
	}
}
