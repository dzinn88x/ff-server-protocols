using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020013C6 RID: 5062
	[Token(Token = "0x20013C6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBE88", Offset = "0x10EBE88")]
	public class UISuperFighterAwardPreviewWndController : UIPopupWindowController, IEasyList
	{
		// Token: 0x060052C3 RID: 21187 RVA: 0x00018D20 File Offset: 0x00016F20
		[Token(Token = "0x60052C3")]
		[Address(RVA = "0x1F435B8", Offset = "0x1F435B8", VA = "0x7BBC7435B8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C4")]
		[Address(RVA = "0x1F43608", Offset = "0x1F43608", VA = "0x7BBC743608", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C5")]
		[Address(RVA = "0x1F437D0", Offset = "0x1F437D0", VA = "0x7BBC7437D0", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C6")]
		[Address(RVA = "0x1F43938", Offset = "0x1F43938", VA = "0x7BBC743938", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C7")]
		[Address(RVA = "0x1F43940", Offset = "0x1F43940", VA = "0x7BBC743940", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C8")]
		[Address(RVA = "0x1F439FC", Offset = "0x1F439FC", VA = "0x7BBC7439FC", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C9")]
		[Address(RVA = "0x1F43828", Offset = "0x1F43828", VA = "0x7BBC743828")]
		private void SetView()
		{
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CA")]
		[Address(RVA = "0x1F43A2C", Offset = "0x1F43A2C", VA = "0x7BBC743A2C")]
		private void SetSmallAwardView()
		{
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CB")]
		[Address(RVA = "0x1F43AD4", Offset = "0x1F43AD4", VA = "0x7BBC743AD4")]
		private void SetBigAwardView()
		{
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CC")]
		[Address(RVA = "0x1F43BD4", Offset = "0x1F43BD4", VA = "0x7BBC743BD4")]
		private void OnTabSmallAwardClick()
		{
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CD")]
		[Address(RVA = "0x1F43BE0", Offset = "0x1F43BE0", VA = "0x7BBC743BE0")]
		private void OnTabBigAwardClick()
		{
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CE")]
		[Address(RVA = "0x1F43BEC", Offset = "0x1F43BEC", VA = "0x7BBC743BEC")]
		public UISuperFighterAwardPreviewWndController()
		{
		}

		// Token: 0x04007891 RID: 30865
		[Token(Token = "0x4007891")]
		[FieldOffset(Offset = "0x98")]
		private UISuperFighterAwardPreviewWndView m_View;

		// Token: 0x04007892 RID: 30866
		[Token(Token = "0x4007892")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelSuperFighter m_ModelSuperFighter;

		// Token: 0x04007893 RID: 30867
		[Token(Token = "0x4007893")]
		[FieldOffset(Offset = "0xA8")]
		private UISuperFighterAwardPreviewWndController.EPageType m_CurPage;

		// Token: 0x020013C7 RID: 5063
		[Token(Token = "0x20013C7")]
		private enum EPageType
		{
			// Token: 0x04007895 RID: 30869
			[Token(Token = "0x4007895")]
			SmallAward = 1,
			// Token: 0x04007896 RID: 30870
			[Token(Token = "0x4007896")]
			BigAward
		}
	}
}
