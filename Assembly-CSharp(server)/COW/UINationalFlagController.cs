using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A7F RID: 6783
	[Token(Token = "0x2001A7F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8524", Offset = "0x10F8524")]
	public class UINationalFlagController : UIPopupWindowController, IEasyList
	{
		// Token: 0x06008EE8 RID: 36584 RVA: 0x000261A8 File Offset: 0x000243A8
		[Token(Token = "0x6008EE8")]
		[Address(RVA = "0x14D7258", Offset = "0x14D7258", VA = "0x7BBBCD7258")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008EE9 RID: 36585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EE9")]
		[Address(RVA = "0x14D72A8", Offset = "0x14D72A8", VA = "0x7BBBCD72A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008EEA RID: 36586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EEA")]
		[Address(RVA = "0x14D74D4", Offset = "0x14D74D4", VA = "0x7BBBCD74D4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008EEB RID: 36587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EEB")]
		[Address(RVA = "0x14D75A0", Offset = "0x14D75A0", VA = "0x7BBBCD75A0")]
		public void SetColliderMaskAlpha()
		{
		}

		// Token: 0x06008EEC RID: 36588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008EEC")]
		[Address(RVA = "0x14D75DC", Offset = "0x14D75DC", VA = "0x7BBBCD75DC", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06008EED RID: 36589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EED")]
		[Address(RVA = "0x14D7670", Offset = "0x14D7670", VA = "0x7BBBCD7670", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06008EEE RID: 36590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EEE")]
		[Address(RVA = "0x14D76A0", Offset = "0x14D76A0", VA = "0x7BBBCD76A0")]
		public void FlagSelectHandler(object[] args)
		{
		}

		// Token: 0x06008EEF RID: 36591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EEF")]
		[Address(RVA = "0x14D76A8", Offset = "0x14D76A8", VA = "0x7BBBCD76A8")]
		public UINationalFlagController()
		{
		}

		// Token: 0x04009A6E RID: 39534
		[Token(Token = "0x4009A6E")]
		[FieldOffset(Offset = "0x98")]
		private UINationalFlagView m_View;
	}
}
