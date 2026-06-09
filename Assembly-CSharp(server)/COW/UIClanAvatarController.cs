using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001717 RID: 5911
	[Token(Token = "0x2001717")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1734", Offset = "0x10F1734")]
	public class UIClanAvatarController : UIPopupWindowController, IEasyList
	{
		// Token: 0x06006E39 RID: 28217 RVA: 0x0001F0B0 File Offset: 0x0001D2B0
		[Token(Token = "0x6006E39")]
		[Address(RVA = "0x1BF9D80", Offset = "0x1BF9D80", VA = "0x7BBC3F9D80")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006E3A RID: 28218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E3A")]
		[Address(RVA = "0x1BF9DD0", Offset = "0x1BF9DD0", VA = "0x7BBC3F9DD0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E3B RID: 28219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E3B")]
		[Address(RVA = "0x1BF9FA0", Offset = "0x1BF9FA0", VA = "0x7BBC3F9FA0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006E3C RID: 28220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E3C")]
		[Address(RVA = "0x1BFA06C", Offset = "0x1BFA06C", VA = "0x7BBC3FA06C")]
		public void SetColliderMaskAlpha()
		{
		}

		// Token: 0x06006E3D RID: 28221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E3D")]
		[Address(RVA = "0x1BFA0A8", Offset = "0x1BFA0A8", VA = "0x7BBC3FA0A8", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006E3E RID: 28222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E3E")]
		[Address(RVA = "0x1BFA13C", Offset = "0x1BFA13C", VA = "0x7BBC3FA13C", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006E3F RID: 28223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E3F")]
		[Address(RVA = "0x1BFA16C", Offset = "0x1BFA16C", VA = "0x7BBC3FA16C")]
		public void AvatarSelectHandler(object[] args)
		{
		}

		// Token: 0x06006E40 RID: 28224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E40")]
		[Address(RVA = "0x1BFA174", Offset = "0x1BFA174", VA = "0x7BBC3FA174")]
		public UIClanAvatarController()
		{
		}

		// Token: 0x040088EE RID: 35054
		[Token(Token = "0x40088EE")]
		[FieldOffset(Offset = "0x98")]
		private UIClanAvatarView m_View;
	}
}
