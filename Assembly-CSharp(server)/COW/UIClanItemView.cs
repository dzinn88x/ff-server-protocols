using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002169 RID: 8553
	[Token(Token = "0x2002169")]
	public class UIClanItemView : UIBaseView
	{
		// Token: 0x0600BDE2 RID: 48610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE2")]
		[Address(RVA = "0x1CFB430", Offset = "0x1CFB430", VA = "0x7BBC4FB430", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDE3 RID: 48611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE3")]
		[Address(RVA = "0x1CFB7B4", Offset = "0x1CFB7B4", VA = "0x7BBC4FB7B4")]
		public UIClanItemView()
		{
		}

		// Token: 0x0400C5F6 RID: 50678
		[Token(Token = "0x400C5F6")]
		[FieldOffset(Offset = "0x20")]
		public UISprite SelectLine;

		// Token: 0x0400C5F7 RID: 50679
		[Token(Token = "0x400C5F7")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ClanItemInfoContainer;

		// Token: 0x0400C5F8 RID: 50680
		[Token(Token = "0x400C5F8")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ClanPosition;

		// Token: 0x0400C5F9 RID: 50681
		[Token(Token = "0x400C5F9")]
		[FieldOffset(Offset = "0x38")]
		public UILabel HonorPointLabel;

		// Token: 0x0400C5FA RID: 50682
		[Token(Token = "0x400C5FA")]
		[FieldOffset(Offset = "0x40")]
		public UILabel AccountState_Online;

		// Token: 0x0400C5FB RID: 50683
		[Token(Token = "0x400C5FB")]
		[FieldOffset(Offset = "0x48")]
		public UILabel AccountState_Offline;

		// Token: 0x0400C5FC RID: 50684
		[Token(Token = "0x400C5FC")]
		[FieldOffset(Offset = "0x50")]
		public UILabel AccountState_InGame;

		// Token: 0x0400C5FD RID: 50685
		[Token(Token = "0x400C5FD")]
		[FieldOffset(Offset = "0x58")]
		public Transform AccountInfoContainer;

		// Token: 0x0400C5FE RID: 50686
		[Token(Token = "0x400C5FE")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnShowDetail;

		// Token: 0x0400C5FF RID: 50687
		[Token(Token = "0x400C5FF")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ApplyBtnGroup;

		// Token: 0x0400C600 RID: 50688
		[Token(Token = "0x400C600")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnComfirm;

		// Token: 0x0400C601 RID: 50689
		[Token(Token = "0x400C601")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnRefuse;

		// Token: 0x0400C602 RID: 50690
		[Token(Token = "0x400C602")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnDrag;
	}
}
