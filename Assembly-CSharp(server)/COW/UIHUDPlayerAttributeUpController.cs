using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200192E RID: 6446
	[Token(Token = "0x200192E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5B5C", Offset = "0x10F5B5C")]
	internal class UIHUDPlayerAttributeUpController : UIBaseController
	{
		// Token: 0x06008264 RID: 33380 RVA: 0x000237A8 File Offset: 0x000219A8
		[Token(Token = "0x6008264")]
		[Address(RVA = "0x16BCCBC", Offset = "0x16BCCBC", VA = "0x7BBBEBCCBC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008265 RID: 33381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008265")]
		[Address(RVA = "0x16BCD0C", Offset = "0x16BCD0C", VA = "0x7BBBEBCD0C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008266 RID: 33382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008266")]
		[Address(RVA = "0x16BCE04", Offset = "0x16BCE04", VA = "0x7BBBEBCE04")]
		public void ShowMessage(string msg)
		{
		}

		// Token: 0x06008267 RID: 33383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008267")]
		[Address(RVA = "0x16BCE9C", Offset = "0x16BCE9C", VA = "0x7BBBEBCE9C")]
		public UIHUDPlayerAttributeUpItem DequeueItem()
		{
			return null;
		}

		// Token: 0x06008268 RID: 33384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008268")]
		[Address(RVA = "0x16BD0A0", Offset = "0x16BD0A0", VA = "0x7BBBEBD0A0")]
		public void Reposition()
		{
		}

		// Token: 0x06008269 RID: 33385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008269")]
		[Address(RVA = "0x16BD25C", Offset = "0x16BD25C", VA = "0x7BBBEBD25C")]
		public UIHUDPlayerAttributeUpController()
		{
		}

		// Token: 0x040093A8 RID: 37800
		[Token(Token = "0x40093A8")]
		private const int MAX_ITEM_COUNT = 4;

		// Token: 0x040093A9 RID: 37801
		[Token(Token = "0x40093A9")]
		[FieldOffset(Offset = "0x58")]
		private float m_ItemDeltaY;

		// Token: 0x040093AA RID: 37802
		[Token(Token = "0x40093AA")]
		[FieldOffset(Offset = "0x60")]
		private UIHUDPlayerAttributeUpItem m_ItemTemplate;

		// Token: 0x040093AB RID: 37803
		[Token(Token = "0x40093AB")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_TemlateLocPos;

		// Token: 0x040093AC RID: 37804
		[Token(Token = "0x40093AC")]
		[FieldOffset(Offset = "0x78")]
		private Queue<UIHUDPlayerAttributeUpItem> m_ItemQ;
	}
}
