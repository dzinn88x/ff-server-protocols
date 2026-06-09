using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001601 RID: 5633
	[Token(Token = "0x2001601")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF884", Offset = "0x10EF884")]
	public class UIMapBaseController : UIBaseController
	{
		// Token: 0x0600647D RID: 25725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647D")]
		[Address(RVA = "0x18EBDA4", Offset = "0x18EBDA4", VA = "0x7BBC0EBDA4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647E")]
		[Address(RVA = "0x18EBDAC", Offset = "0x18EBDAC", VA = "0x7BBC0EBDAC")]
		protected void InitMapContent(Transform tr, UIMapUtil.EMapType mapType = UIMapUtil.EMapType.Minimap)
		{
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600647F")]
		[Address(RVA = "0x18EC164", Offset = "0x18EC164", VA = "0x7BBC0EC164", Slot = "28")]
		protected virtual void RegisterEvents()
		{
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006480")]
		[Address(RVA = "0x18EC2D0", Offset = "0x18EC2D0", VA = "0x7BBC0EC2D0", Slot = "29")]
		protected virtual void UnRegisterEvents()
		{
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006481")]
		[Address(RVA = "0x18EC43C", Offset = "0x18EC43C", VA = "0x7BBC0EC43C", Slot = "30")]
		protected virtual void OnObservePlayer(params object[] data)
		{
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006482")]
		[Address(RVA = "0x18EC440", Offset = "0x18EC440", VA = "0x7BBC0EC440", Slot = "31")]
		protected virtual void OnObserverTargetChange(params object[] data)
		{
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006483")]
		[Address(RVA = "0x18EC5BC", Offset = "0x18EC5BC", VA = "0x7BBC0EC5BC", Slot = "32")]
		protected virtual void OnPlayerHPChanged(params object[] data)
		{
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006484")]
		[Address(RVA = "0x18EC5C0", Offset = "0x18EC5C0", VA = "0x7BBC0EC5C0")]
		public UIMapBaseController()
		{
		}

		// Token: 0x040082F3 RID: 33523
		[Token(Token = "0x40082F3")]
		[FieldOffset(Offset = "0x58")]
		protected UIMapContentController m_MapContentCtrl;
	}
}
